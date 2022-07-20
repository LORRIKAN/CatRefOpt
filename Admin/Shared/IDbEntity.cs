using Repository;

namespace Admin.Shared
{
    public interface IDbEntity
    {
        string Name { get; }

        EntityInfo[] EntitiesInfo { get; }

        ExtendedDbContext DbContext { get; set; }
    }
}
