using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.Shared.DbEntities
{
    public class UsersDbEntity : IDbEntity
    {
        public UsersDbEntity(CatRefUsersDbContext catRefUsersDbContext)
        {
            UsersDbContext = catRefUsersDbContext;
            Name = "База данных пользователей";
        }
        public string Name { get; }
        public EntityInfo[] EntitiesInfo => UsersDbContext.GetBindingLists()
                .Select(bl => new EntityInfo
                {
                    Name = bl.GetName(),
                    DataType = bl.GetDataType()
                }).ToArray();
        public ExtendedDbContext DbContext { get => UsersDbContext; set => UsersDbContext = (CatRefUsersDbContext)value; }

        private CatRefUsersDbContext UsersDbContext { get; set; }
    }
}
