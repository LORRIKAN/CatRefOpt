using Admin.Shared;
using Model.CatRef;
using WinFormsShared;

namespace Admin.View.CustomForms
{
    public partial class MatlabFuncForm : Form, IFormWithTableEditor
    {
        public StandardTableEditor TableEditor => standardTableEditor;

        public event Func<MatlabFunc, string, CancellationToken, Task> ExportFile = null!;

        public event Func<MatlabFunc, string, Task<string?>> ImportFile = null!;

        public MatlabFuncForm()
        {
            InitializeComponent();

            importButt.Click += ImportButt_Click;
            exportButt.Click += ExportButt_Click;
            standardTableEditor.dataGridView.SelectionChanged += (_, _) => CollectionChanged();
        }

        private void ExportButt_Click(object? sender, EventArgs e)
        {
            if (CurrFunc is not MatlabFunc matlabFunc)
            {
                MessageDialog.ShowMessage(MessageType.Error, this, text: "Сначала выберите функцию");
                return;
            }

            if (saveFileDialog.ShowDialog() is not DialogResult.OK)
                return;

            CancellationTokenSource cancellationTokenSource = new();
            Task exportTask = ExportFile(matlabFunc, saveFileDialog.FileName, cancellationTokenSource.Token);

            async IAsyncEnumerable<(string msg, bool error, bool cancelable)> ProgressFunc()
            {
                yield return ("Экспорт файла MATLAB...", false, true);
                await exportTask;
                if (exportTask.Exception is not null)
                    yield return ("Ошибка при экспорте", true, false);
                yield break;
            }

            TaskDialogButton butt = MessageDialog
                .ShowMarqueeAwaitDialog(ProgressFunc, this, heading: "Экспорт файла Matlab...", aboveAll: true);

            if (butt == TaskDialogButton.Cancel)
                cancellationTokenSource.Cancel();
            else if (butt == TaskDialogButton.OK)
                MessageDialog.ShowMessage(MessageType.Success, this, "Экспорт",
                    "Экспорт файла MATLAB", "Экспорт файла Matlab успешно завершён");
        }

        private void ImportButt_Click(object? sender, EventArgs e)
        {
            async void editAction()
            {
                if (CurrFunc is not MatlabFunc matlabFunc)
                {
                    MessageDialog.ShowMessage(MessageType.Error, this, text: "Сначала выберите функцию");
                    return;
                }

                if (matlabFunc is null)
                {
                    MessageDialog.ShowMessage(MessageType.Error, this, "Ошибка",
                        "Сначала выберите запись");
                    return;
                }

                if (openFileDialog.ShowDialog() is not DialogResult.OK)
                    return;

                Task<string?> importTask = ImportFile(matlabFunc, openFileDialog.FileName);

                async IAsyncEnumerable<(string msg, bool error, bool cancelable)> ProgressFunc()
                {
                    yield return ("Импорт файла MATLAB...", false, false);
                    string? errorMsg = await importTask;
                    if (!string.IsNullOrEmpty(errorMsg))
                        yield return ($"Ошибка при импорте, {errorMsg}", true, false);
                }

                MessageDialog
                    .ShowMarqueeAwaitDialog(ProgressFunc, this, heading: "Импорт файла Matlab...", aboveAll: true);

                string? error = await importTask;

                if (string.IsNullOrEmpty(error))
                    MessageDialog.ShowMessage(MessageType.Success, this, "Импорт",
                        "Импорт файла MATLAB", "Импорт файла Matlab успешно завершён");
                else
                {
                    DataGridViewRow currentRow = standardTableEditor.dataGridView.CurrentRow;
                    currentRow.ErrorText = error;
                }
            }

            standardTableEditor.ExecuteEditAction(editAction);
        }

        public void CollectionChanged()
        {
            if (CurrFunc is not MatlabFunc matlabFunc)
            {
                MessageDialog.ShowMessage(MessageType.Error, this, text: "Сначала выберите функцию");
                return;
            }

            if (string.IsNullOrEmpty(matlabFunc.MatlabFuncText))
                exportButt.Enabled = false;
            else
                exportButt.Enabled = true;
        }

        private MatlabFunc? CurrFunc => (standardTableEditor.dataGridView.DataSource as BindingSource)?.Current as MatlabFunc;
    }
}
