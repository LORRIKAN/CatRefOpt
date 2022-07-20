using Admin.Presenter.CustomPresenters;
using Admin.Shared;
using Admin.View;
using Model.Users;
using MVP;
using Repository;
using System.ComponentModel;
using System.Diagnostics;
using WinFormsShared;

namespace Admin.Presenter
{
    public class MainPresenter : RoleBasedPresenterBase<MainForm>
    {
        public MainPresenter(MainForm form, Role role,
            IEnumerable<IDbEntity> dbContexts,
            IEnumerable<ICustomPresenter> customPresenters) : base(role, form)
        {
            DbContexts = dbContexts;
            CustomPresenters = customPresenters;

            Form.GetContexts += AdministratorForm_GetContexts;
            Form.SelectedEntityChanged += Form_SelectedEntityChanged;
            Form.HelpRequired += Form_HelpRequired;
        }

        private void Form_SelectedEntityChanged(IDbEntity context, EntityInfo entity)
        {
            ICustomPresenter? customPresenter = CustomPresenters
                .FirstOrDefault(cp => cp.EntityInfo.DataType == entity.DataType);

            if (customPresenter is not null)
                customPresenter.Run(context.DbContext);
            else
            {
                IBindingList? dataSource = context.DbContext.GetBindingLists()
                    .FirstOrDefault(bl => bl.GetDataType() == entity.DataType);

                if (dataSource is null)
                {
                    MessageDialog.ShowMessage(MessageType.Error, Form, entity.Name,
                        $"Таблица {entity.Name}", $"Таблицу {entity.Name} открыть не удалось, " +
                        $"она не предусмотрена в коде программы.");
                    return;
                }
                var standardPresenter = new StandardPresenter(context.DbContext, entity);

                standardPresenter.Run(dataSource);
            }

            foreach (var item in DbContexts.Where(c => c.DbContext == context.DbContext))
                item.DbContext = item.DbContext.CreateNew();
        }

        private IList<IDbEntity> AdministratorForm_GetContexts()
        {
            return DbContexts.ToList();
        }

        private void Form_HelpRequired()
        {
            string directory = Path.Combine(Environment.CurrentDirectory, "helpAdmin");

            string filePath = Path.Combine(directory, "index.htm");

            Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
        }

        private IEnumerable<IDbEntity> DbContexts { get; set; }

        private IEnumerable<ICustomPresenter> CustomPresenters { get; }
    }
}