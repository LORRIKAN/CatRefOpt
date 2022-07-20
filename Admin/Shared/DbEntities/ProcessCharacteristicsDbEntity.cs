using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.Shared.DbEntities
{
    public class ProcessCharacteristicsDbEntity : IDbEntity
    {
        public ProcessCharacteristicsDbEntity(CatRefDbContext catRefDbContext)
        {
            CatRefDbContext = catRefDbContext;
            Name = "База данных характеристик процесса";
        }
        public string Name { get; }
        public EntityInfo[] EntitiesInfo => CatRefDbContext.GetProcessCharacteristicsDb()
                .Select(bl => new EntityInfo
                {
                    Name = bl.GetName(),
                    DataType = bl.GetDataType()
                }).ToArray();
        public ExtendedDbContext DbContext { get => CatRefDbContext; set => CatRefDbContext = (CatRefDbContext)value; }

        private CatRefDbContext CatRefDbContext { get; set; }
    }
}
