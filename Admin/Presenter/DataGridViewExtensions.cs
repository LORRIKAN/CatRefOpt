using Microsoft.EntityFrameworkCore;
using Repository;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Admin.Presenter
{

    internal static class DataGridViewExtensions
    {
        public static DataGridView Bind(this DataGridView grid, IBindingList data, ExtendedDbContext dbContext)
        {
            grid.DataSource = null;
            grid.AutoGenerateColumns = false;
            var dataType = data.GetDataType();

            var properties = TypeDescriptor.GetProperties(dataType);

            var dependentItems = dbContext.Model.FindEntityType(dataType)!.GetNavigations()
                .Where(n => n.IsOnDependent)
                .Select(n =>
                {
                    IBindingList? bindingList = dbContext.GetBindingLists()
                        .FirstOrDefault(d => d.GetDataType() == n.ClrType);

                    return (
                        FromPropName: n.ForeignKey.Properties[0].Name,
                        ToPropName: n.ForeignKey.PrincipalKey.Properties[0].Name,
                        DataSource: bindingList
                    );
                });

            BindGridInternal(grid, properties, dependentItems);

            var bindingSource = new BindingSource
            {
                DataSource = data
            };
            grid.DataSource = bindingSource;

            //grid.DataSource = data;

            return grid;
        }

        private static void BindGridInternal(DataGridView grid, PropertyDescriptorCollection properties,
            IEnumerable<(string FromPropName, string ToPropName, IBindingList? DataSource)> dependentItems)
        {
            var metedata = properties.Cast<PropertyDescriptor>()
            .Where(p => p.IsBrowsable && p.Name is not ("DisplayName" or "Id"))
            .Select(p =>
            {
                var dependment = dependentItems?.FirstOrDefault(di => di.FromPropName == p.Name);

                return new
                {
                    p.Name,
                    HeaderText = p.Attributes.OfType<DisplayAttribute>()
                    .FirstOrDefault()?.Name ?? p.DisplayName,
                    ReadOnly = p.IsReadOnly,
                    Type = p.PropertyType,
                    Dependency = dependment
                };
            });

            var columns = metedata.Select(m =>
            {
                DataGridViewColumn c;

                if (m.Type == typeof(bool))
                    c = new DataGridViewCheckBoxColumn();
                else
                    c = m.Dependency?.DataSource switch
                    {
                        not null => new DataGridViewComboBoxColumn
                        {
                            DataSource = m.Dependency.Value.DataSource,
                            DisplayMember = "DisplayName",
                            ValueMember = m.Dependency.Value.ToPropName,
                            DataPropertyName = m.Dependency.Value.ToPropName,
                        },
                        _ => new DataGridViewTextBoxColumn()
                    };

                c.DataPropertyName = m.Name;
                c.Resizable = DataGridViewTriState.True;
                c.Name = m.Name;
                c.HeaderText = m.HeaderText;
                c.ReadOnly = m.ReadOnly;
                if (m.ReadOnly)
                    c.DefaultCellStyle = new DataGridViewCellStyle { BackColor = Color.DarkGray };
                c.ValueType = m.Type;
                //c.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                c.SortMode = DataGridViewColumnSortMode.NotSortable;
                c.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                return c;
            });

            grid.Columns.Clear();
            grid.Columns.AddRange(columns.ToArray());
        }
    }
}