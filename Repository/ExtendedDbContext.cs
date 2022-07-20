using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Repository
{
    public abstract class ExtendedDbContext : DbContext
    {
        public ExtendedDbContext()
        {

        }

        public ExtendedDbContext(DbContextOptions options) : base(options)
        {

        }

        public abstract ExtendedDbContext CreateNew();

        public abstract string? Validate(object value, IBindingList dataSource);

        public abstract IEnumerable<IBindingList> GetBindingLists();
    }
}