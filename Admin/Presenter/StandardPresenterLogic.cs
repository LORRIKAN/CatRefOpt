using Admin.Shared;
using Admin.View;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Repository;
using System.ComponentModel;

namespace Admin.Presenter
{
    public class StandardPresenterLogic<T> where T : Form, IFormWithTableEditor
    {
        public IBindingList? DataSource { get; private set; }

        public EntityInfo TableEntity { get; }

        public ExtendedDbContext DbContext { get; set; }

        public T Form { get; }

        public StandardPresenterLogic(ExtendedDbContext dbContext, EntityInfo tableEntity, T form)
        {
            Form = form;
            Form.TableEditor.BindDataGridView += Form_BindDataGridView;
            Form.TableEditor.ValidateValue += Form_ValidateValue;
            Form.TableEditor.AnyChangesForTable += Form_AnyChangesForTable;
            Form.TableEditor.TryAddRow += Form_TryAddRow;
            Form.TableEditor.TryDeleteRow += Form_TryDeleteRow;
            Form.TableEditor.TrySaveChanges += Form_TrySaveChanges;

            DbContext = dbContext;
            TableEntity = tableEntity;
        }

        private string? Form_TrySaveChanges()
        {
            try
            {
                DbContext.SaveChanges();
                return null;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        private string? Form_TryDeleteRow(int rowIndex)
        {
            try
            {
                DataSource!.RemoveAt(rowIndex);
                return null;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        private string? Form_TryAddRow()
        {
            try
            {
                DataSource!.AddNew();
                return null;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        private bool Form_AnyChangesForTable()
        {
            return FindChangingEntityEntries().Any();
        }

        private IEnumerable<EntityEntry> FindChangingEntityEntries()
        {
            return DbContext.ChangeTracker.Entries()
                .Where(e => e.Entity.GetType().IsAssignableTo(TableEntity.DataType)
                && e.State is not (EntityState.Detached or EntityState.Unchanged));
        }

        private string? Form_ValidateValue(object value)
        {
            return DbContext.Validate(value, DataSource!);
        }

        private void Form_BindDataGridView(DataGridView dataGridView)
        {
            dataGridView.Bind(DataSource!, DbContext);
        }

        public void Run(IBindingList dataSource)
        {
            DataSource = dataSource;
            Form.Text = TableEntity.Name ?? "Форма редактирования таблицы";
            Form.ShowDialog();
        }
    }
}
