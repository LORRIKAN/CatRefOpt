using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.Shared.DbEntities
{
    public class MathModelsLibDbEntity : IDbEntity
    {
        public MathModelsLibDbEntity(CatRefDbContext catRefDbContext)
        {
            CatRefDbContext = catRefDbContext;
            Name = "Библиотека математических моделей";
        }
        public string Name { get; }
        public EntityInfo[] EntitiesInfo => CatRefDbContext.GetMathModelsLib()
                .Select(bl => new EntityInfo
                {
                    Name = bl.GetName(),
                    DataType = bl.GetDataType()
                }).ToArray();
        public ExtendedDbContext DbContext { get => CatRefDbContext; set => CatRefDbContext = (CatRefDbContext)value; }

        private CatRefDbContext CatRefDbContext { get; set; }
    }
}
