using Admin.Shared;
using WinFormsShared;
using MVP;
using Repository;

namespace Admin.View
{
    public partial class MainForm : Form, IView
    {
        public event Func<IList<IDbEntity>>? GetContexts;

        public event Action<IDbEntity, EntityInfo>? SelectedEntityChanged;

        public event Action? HelpRequired;

        public bool ReloginRequired { get; private set; }

        public MainForm()
        {
            InitializeComponent();

            this.Shown += LoadContexts;

            exitButt.Click += (_, _) => Close();
            reloginButt.Click += (_, _) =>
            {
                ReloginRequired = true;
                Close();
            };
        }

        private void LoadContexts(object? sender, EventArgs e)
        {
            if (GetContexts is null)
            {
                MessageDialog.ShowMessage(MessageType.Error, this, "Ошибка", "Ошибка в программном коде",
                    "Ошибка при загрузке баз данных. Проблема в программном коде.");
                return;
            }

            dbChooseComboBox.DisplayMember = "Name";
            dbChooseComboBox.DataSource = GetContexts();
        }

        private void DbChooseComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            tableChooseComboBox.DisplayMember = "Name";
            tableChooseComboBox.DataSource = CurrContext.EntitiesInfo;
        }

        public IDbEntity CurrContext => (IDbEntity)dbChooseComboBox.SelectedValue;

        public EntityInfo CurrEntity => (EntityInfo)tableChooseComboBox.SelectedValue;

        private void aboutButt_Click(object sender, EventArgs e)
        {
            if (HelpRequired is null)
            {
                MessageDialog.ShowMessage(MessageType.Error, this, "Ошибка", "Ошибка в программном коде",
                    "Ошибка при попытке открытия справки. Проблема в программном коде.");
                return;
            }
            HelpRequired();
        }

        private void openTableButt_Click(object sender, EventArgs e)
        {
            if (SelectedEntityChanged is null)
            {
                MessageDialog.ShowMessage(MessageType.Error, this, "Ошибка", "Ошибка в программном коде",
                    "Ошибка при загрузке таблиц. Проблема в программном коде.");
                return;
            }
            SelectedEntityChanged(CurrContext, CurrEntity);
        }
    }
}