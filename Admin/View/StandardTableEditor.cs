using Model;
using WinFormsShared;

namespace Admin.View
{
    public partial class StandardTableEditor : UserControl
    {
        public event Action<DataGridView>? BindDataGridView;

        public event Func<object, string?>? ValidateValue;

        public event Func<bool>? AnyChangesForTable;

        public event Func<string?>? TryAddRow;

        public event Func<int, string?>? TryDeleteRow;

        public event Func<string?>? TrySaveChanges;

        private List<DataGridViewRow> Errors { get; } = new();

        public StandardTableEditor()
        {
            InitializeComponent();
            Load += StandardTableEditor_Load;
        }

        private void StandardTableEditor_Load(object? sender, EventArgs e)
        {
            void BindData() => BindDataGridView?.Invoke(dataGridView);
            ExecuteEditAction(BindData);
            Form = this.GetParentControlOfType<Form>();
            if (Form is not null)
                Form.FormClosing += FormClosing;
        }

        public void FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (sender is Form form && !CanClose(form))
                e.Cancel = true;
        }

        public bool CanClose(Form form)
        {
            bool anyChanges = AnyChangesForTable?.Invoke() ?? false;
            bool anyErrors = Errors.Any();

            if (anyChanges)
            {
                TaskDialogButton taskDialogResult;
                if (anyErrors)
                {
                    taskDialogResult = MessageDialog.ShowMessage(MessageType.YesNo, form,
                        "Сохранение изменений", "Вы хотите отменить внесённые изменения и выйти?",
                        "У вас есть несохранённые изменения, однако, сохранить их невозможно. " +
                        "Вы действительно хотите выйти, не сохраняя их?",
                        aboveAll: true);
                    if (taskDialogResult != TaskDialogButton.Yes)
                        return false;
                }
                else
                {
                    taskDialogResult = MessageDialog.ShowMessage(MessageType.YesNoCancel, form,
                        "Сохранение изменений", "Вы хотите сохранить внесённые изменения?",
                        "У вас есть несохранённые изменения. Вы хотите их сохранить перед выходом?",
                        aboveAll: true);

                    if (taskDialogResult == TaskDialogButton.Yes)
                    {
                        string? errorMsg = TrySaveChanges is null ? 
                            "Проблема в программном коде" : TrySaveChanges();

                        if (!string.IsNullOrEmpty(errorMsg))
                        {
                            taskDialogResult = MessageDialog.ShowMessage(MessageType.YesNo,
                                form, "Сохранение изменений", "Сохранить изменения не удалось",
                                errorMsg + $"{Environment.NewLine}Хотите выйти без сохранения изменений?");

                            if (taskDialogResult != TaskDialogButton.Yes)
                                return false;
                        }
                    }
                    else if (taskDialogResult != TaskDialogButton.No)
                        return false;
                }
            }

            return true;
        }

        public void DeleteButt_Click(object sender, EventArgs e)
        {
            ExecuteEditAction(() =>
            {
                if (MessageDialog.ShowMessage(MessageType.YesNo, Form,
                    "Удаление строк", "Вы действительно хотите удалить выбранные строки?", 
                    aboveAll: true) != TaskDialogButton.Yes)
                    return;

                foreach (DataGridViewRow row in dataGridView.SelectedRows)
                {
                    int rowIndex = row.Index;
                    Errors.Remove(dataGridView.Rows[rowIndex]);

                    string? errorMessage = TryDeleteRow is null ? "Проблема в программном коде" 
                        : TryDeleteRow(rowIndex);

                    if (!string.IsNullOrEmpty(errorMessage))
                    {
                        MessageDialog.ShowMessage(MessageType.Error, Form, "Удаление строк",
                            $"Удалить строку {rowIndex + 1} не удалось", errorMessage);
                    }
                }
            });
        }

        public void AddButt_Click(object sender, EventArgs e)
        {
            ExecuteEditAction(() =>
            {
                string? errorMessage = TryAddRow is null ? "Проблема в программном коде"
                        : TryAddRow();

                if (!string.IsNullOrEmpty(errorMessage))
                    MessageDialog.ShowMessage(MessageType.Error, Form, "Добавление строки", "Добавить " +
                        "строку не удалось", errorMessage);
            });
        }

        public void SaveButt_Click(object sender, EventArgs e)
        {
            ExecuteEditAction(() =>
            {
                string? errorMessage = TrySaveChanges is null ? "Проблема в программном коде"
                        : TrySaveChanges();

                if (string.IsNullOrEmpty(errorMessage))
                {
                    MessageDialog.ShowMessage(MessageType.Success, Form, "Сохранение изменений",
                        "Сохранение изменений прошло успешно", string.Empty);
                }
                else
                    MessageDialog.ShowMessage(MessageType.Error, Form, "Сохранение изменений",
                        "Сохранить изменения не удалось", errorMessage);
            });
        }

        public void ExecuteEditAction(Action editAction)
        {
            saveButt.Enabled = false;
            deleteButt.Enabled = false;
            addButt.Enabled = false;

            editAction();

            saveButt.Enabled = (AnyChangesForTable?.Invoke() ?? false) && !Errors.Any();
            deleteButt.Enabled = dataGridView.Rows.Count is not 0;
            addButt.Enabled = true;
        }

        public void ValidateRow(DataGridViewRow row)
        {
            dataGridView.BindingContext[dataGridView.DataSource].EndCurrentEdit();
            string? validationResult;

            try
            {
                validationResult = (row.DataBoundItem as Validatable)?.Error;
                validationResult ??= ValidateValue?.Invoke((dataGridView.DataSource as BindingSource)!.Current);
            }
            catch
            {
                validationResult = $"В этой записи данную ячейку изменить невозможно";
            }

            row.ErrorText = validationResult;

            if (!string.IsNullOrEmpty(validationResult))
            {
                saveButt.Enabled = false;
                if (!Errors.Contains(row))
                    Errors.Add(row);
            }
            else
            {
                Errors.Remove(row);
                saveButt.Enabled = (AnyChangesForTable?.Invoke() ?? false) && !Errors.Any();
            }
        }

        public void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            ValidateRow(dataGridView.Rows[e.RowIndex]);
        }

        public void dataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            ValidateRow(dataGridView.Rows[e.RowIndex]);
        }

        public void dataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private Form? Form { get; set; }
    }
}