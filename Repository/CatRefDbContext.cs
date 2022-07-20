using System.ComponentModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Model.CatRef;

namespace Repository
{
    public partial class CatRefDbContext : ExtendedDbContext
    {
        public CatRefDbContext()
        {
        }

        public CatRefDbContext(DbContextOptions<CatRefDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Catalyst> Catalysts { get; set; } = null!;
        public virtual DbSet<CatalystOfPlant> CatalystsOfPlants { get; set; } = null!;
        public virtual DbSet<EmpiricalCoefficient> EmpiricalCoefficients { get; set; } = null!;
        public virtual DbSet<MaterialParameter> MaterialParameters { get; set; } = null!;
        public virtual DbSet<CatalystParameter> CatalystParameters { get; set; } = null!;
        public virtual DbSet<ReactorParameter> ReactorParameters { get; set; } = null!;
        public virtual DbSet<Material> Materials { get; set; } = null!;
        public virtual DbSet<MaterialOfPlant> MaterialsOfPlants { get; set; } = null!;
        public virtual DbSet<MatlabFunc> MatlabFuncs { get; set; } = null!;
        public virtual DbSet<MatlabMathModel> MatlabMathModels { get; set; } = null!;
        public virtual DbSet<MatlabOptimizationMethod> MatlabOptimizationMethods { get; set; } = null!;
        public virtual DbSet<MeasureUnit> MeasureUnits { get; set; } = null!;
        public virtual DbSet<ModelOfPlant> ModelsOfPlants { get; set; } = null!;
        public virtual DbSet<OptimizationParameter> OptimizationParameters { get; set; } = null!;
        public virtual DbSet<ParameterOfOptimizationMethod> ParametersOfOptimizationMethods { get; set; } = null!;
        public virtual DbSet<Plant> Plants { get; set; } = null!;
        public virtual DbSet<Reactor> Reactors { get; set; } = null!;
        public virtual DbSet<SupportableFunc> SupportableFuncs { get; set; } = null!;
        public virtual DbSet<VariableParameter> VariableParameters { get; set; } = null!;

        public override IEnumerable<IBindingList> GetBindingLists()
        {
            Catalysts.Load();
            CatalystsOfPlants.Load();
            EmpiricalCoefficients.Load();
            CatalystParameters.Load();
            MaterialParameters.Load();
            ReactorParameters.Load();
            Materials.Load();
            MaterialsOfPlants.Load();
            MatlabFuncs.Load();
            MatlabMathModels.Load();
            MatlabOptimizationMethods.Load();
            MeasureUnits.Load();
            ModelsOfPlants.Load();
            OptimizationParameters.Load();
            ParametersOfOptimizationMethods.Load();
            Plants.Load();
            Reactors.Load();
            SupportableFuncs.Load();
            VariableParameters.Load();

            return new IBindingList[]
            {
                Catalysts.Local.ToBindingList(),
                CatalystsOfPlants.Local.ToBindingList(),
                EmpiricalCoefficients.Local.ToBindingList(),
                MaterialParameters.Local.ToBindingList(),
                CatalystParameters.Local.ToBindingList(),
                ReactorParameters.Local.ToBindingList(),
                Materials.Local.ToBindingList(),
                MaterialsOfPlants.Local.ToBindingList(),
                MatlabFuncs.Local.ToBindingList(),
                MatlabMathModels.Local.ToBindingList(),
                MatlabOptimizationMethods.Local.ToBindingList(),
                MeasureUnits.Local.ToBindingList(),
                ModelsOfPlants.Local.ToBindingList(),
                OptimizationParameters.Local.ToBindingList(),
                ParametersOfOptimizationMethods.Local.ToBindingList(),
                Plants.Local.ToBindingList(),
                Reactors.Local.ToBindingList(),
                SupportableFuncs.Local.ToBindingList(),
                VariableParameters.Local.ToBindingList()
            };
        }

        public IEnumerable<IBindingList> GetProcessCharacteristicsDb()
        {
            Materials.Load();
            yield return Materials.Local.ToBindingList();
            Catalysts.Load();
            yield return Catalysts.Local.ToBindingList();
            Reactors.Load();
            yield return Reactors.Local.ToBindingList();
            MaterialsOfPlants.Load();
            yield return MaterialsOfPlants.Local.ToBindingList();
            CatalystsOfPlants.Load();
            yield return CatalystsOfPlants.Local.ToBindingList();
            Plants.Load();
            yield return Plants.Local.ToBindingList();
            ModelsOfPlants.Load();
            yield return ModelsOfPlants.Local.ToBindingList();
            VariableParameters.Load();
            yield return VariableParameters.Local.ToBindingList();
            MaterialParameters.Load();
            yield return MaterialParameters.Local.ToBindingList();
            CatalystParameters.Load();
            yield return CatalystParameters.Local.ToBindingList();
            ReactorParameters.Load();
            yield return ReactorParameters.Local.ToBindingList();
            MeasureUnits.Load();
            yield return MeasureUnits.Local.ToBindingList();
        }

        public IEnumerable<IBindingList> GetMathModelsLib()
        {
            MatlabFuncs.Load();
            yield return MatlabFuncs.Local.ToBindingList();
            MatlabMathModels.Load();
            yield return MatlabMathModels.Local.ToBindingList();
            EmpiricalCoefficients.Load();
            yield return EmpiricalCoefficients.Local.ToBindingList();
            MeasureUnits.Load();
            yield return MeasureUnits.Local.ToBindingList();
        }

        public IEnumerable<IBindingList> GetOptimMethodsLib()
        {
            MatlabOptimizationMethods.Load();
            yield return MatlabOptimizationMethods.Local.ToBindingList();
            SupportableFuncs.Load();
            yield return SupportableFuncs.Local.ToBindingList();
            OptimizationParameters.Load();
            yield return OptimizationParameters.Local.ToBindingList();
            ParametersOfOptimizationMethods.Load();
            yield return ParametersOfOptimizationMethods.Local.ToBindingList();
            MeasureUnits.Load();
            yield return MeasureUnits.Local.ToBindingList();
        }

        private static string GetConnectionString()
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();
            return configuration.GetConnectionString("CatRefDb");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(GetConnectionString()).UseLazyLoadingProxies();
            }
        }

        public override string? Validate(object value, IBindingList dataSource)
        {
            if (value is VariableParameter variableParameter)
            {
                if (variableParameter.LowerBound >= variableParameter.UpperBound)
                    return "Нижняя граница не может быть больше или равна верхней";
            }

            return null;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Catalyst>(entity =>
            {
                entity.ToTable("Catalyst");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CatalystOfPlant>(entity =>
            {
                entity.HasKey(e => new { e.PlantId, e.CatalystId });

                entity.ToTable("CatalystOfPlant");

                entity.HasOne(d => d.Catalyst)
                    .WithMany(p => p.CatalystsOfPlants)
                    .HasForeignKey(d => d.CatalystId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CatalystOfPlant_Catalyst");

                entity.HasOne(d => d.Plant)
                    .WithMany(p => p.CatalystsOfPlants)
                    .HasForeignKey(d => d.PlantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CatalystOfPlant_Plant");
            });

            modelBuilder.Entity<EmpiricalCoefficient>(entity =>
            {
                entity.ToTable("EmpiricalCoefficient");

                entity.Property(e => e.Designation)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.Func)
                    .WithMany(p => p.EmpiricalCoefficients)
                    .HasForeignKey(d => d.FuncId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmpiricalCoefficient_MatlabFunc");
            });

            modelBuilder.Entity<Material>(entity =>
            {
                entity.ToTable("Material");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MaterialParameter>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("MaterialParameter");

                entity.Property(e => e.Designation)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.Material)
                    .WithMany(p => p.MaterialParameters)
                    .HasForeignKey(d => d.MaterialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MaterialParameter_Material");

                entity.HasOne(d => d.MathModel)
                    .WithMany(p => p.MaterialParameters)
                    .HasForeignKey(d => d.MathModelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InputParameter_MatlabMathModel");

                entity.HasOne(d => d.MeasureUnit)
                    .WithMany(p => p.MaterialsParameters)
                    .HasForeignKey(d => d.MeasureUnitId)
                    .HasConstraintName("FK_MaterialParameter_MeasureUnit");
            });

            modelBuilder.Entity<CatalystParameter>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("CatalystParameter");

                entity.Property(e => e.Designation)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.Catalyst)
                    .WithMany(p => p.CatalystParameters)
                    .HasForeignKey(d => d.CatalystId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CatalystParameter_Catalyst");

                entity.HasOne(d => d.MathModel)
                    .WithMany(p => p.CatalystParameters)
                    .HasForeignKey(d => d.MathModelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CatalystParameter_MatlabMathModel");

                entity.HasOne(d => d.MeasureUnit)
                    .WithMany(p => p.CatalystsParameters)
                    .HasForeignKey(d => d.MeasureUnitId)
                    .HasConstraintName("FK_CatalystParameter_MeasureUnit");
            });

            modelBuilder.Entity<ReactorParameter>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("ReactorParameter");

                entity.Property(e => e.Designation)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.MathModel)
                    .WithMany(p => p.ReactorParameters)
                    .HasForeignKey(d => d.MathModelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReactorParameter_MatlabMathModel");

                entity.HasOne(d => d.Reactor)
                    .WithMany(p => p.ReactorParameters)
                    .HasForeignKey(d => d.ReactorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReactorParameter_Reactor");

                entity.HasOne(d => d.MeasureUnit)
                    .WithMany(p => p.ReactorsParameters)
                    .HasForeignKey(d => d.MeasureUnitId)
                    .HasConstraintName("FK_ReactorParameter_MeasureUnit");
            });

            modelBuilder.Entity<MaterialOfPlant>(entity =>
            {
                entity.HasKey(e => new { e.PlantId, e.MaterialId });

                entity.ToTable("MaterialOfPlant");

                entity.HasOne(d => d.Material)
                    .WithMany(p => p.MaterialsOfPlants)
                    .HasForeignKey(d => d.MaterialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MaterialOfPlant_Material");

                entity.HasOne(d => d.Plant)
                    .WithMany(p => p.MaterialsOfPlants)
                    .HasForeignKey(d => d.PlantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MaterialOfPlant_Plant");
            });

            modelBuilder.Entity<MatlabFunc>(entity =>
            {
                entity.ToTable("MatlabFunc");

                entity.Property(e => e.MatlabFuncText).IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.MeasureUnit)
                    .WithMany(p => p.MatlabFuncs)
                    .HasForeignKey(d => d.MeasureUnitIdOfOutput)
                    .HasConstraintName("FK_MatlabFunc_MeasureUnit");
            });

            modelBuilder.Entity<MatlabMathModel>(entity =>
            {
                entity.ToTable("MatlabMathModel");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.OctaneNumberFunc)
                    .WithMany(p => p.MatlabMathModelOctaneNumberFuncs)
                    .HasForeignKey(d => d.OctaneNumberFuncId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MatlabMathModel_MatlabFunc");

                entity.HasOne(d => d.SelectionFunc)
                    .WithMany(p => p.MatlabMathModelSelectionFuncs)
                    .HasForeignKey(d => d.SelectionFuncId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MatlabMathModel_MatlabFunc1");
            });

            modelBuilder.Entity<MatlabOptimizationMethod>(entity =>
            {
                entity.ToTable("MatlabOptimizationMethod");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.MatlabText).IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MeasureUnit>(entity =>
            {
                entity.ToTable("MeasureUnit");

                entity.Property(e => e.Designation)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ModelOfPlant>(entity =>
            {
                entity.HasKey(e => new { e.MathModelId, e.PlantId })
                    .HasName("PK_ModelPlant");

                entity.ToTable("ModelOfPlant");

                entity.HasOne(d => d.MathModel)
                    .WithMany(p => p.ModelsOfPlants)
                    .HasForeignKey(d => d.MathModelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ModelPlant_MatlabMathModel");

                entity.HasOne(d => d.Plant)
                    .WithMany(p => p.ModelsOfPlants)
                    .HasForeignKey(d => d.PlantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ModelPlant_Plant");
            });

            modelBuilder.Entity<OptimizationParameter>(entity =>
            {
                entity.ToTable("OptimizationParameter");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.MeasureUnit)
                    .WithMany(p => p.OptimizationParameters)
                    .HasForeignKey(d => d.MeasureUnitId)
                    .HasConstraintName("FK_OptimizationParameter_MeasureUnit");
            });

            modelBuilder.Entity<ParameterOfOptimizationMethod>(entity =>
            {
                entity.HasKey(e => new { e.ParameterId, e.OptimizationMethodId })
                    .HasName("PK_ParameterOfOptimizationMethod_1");

                entity.ToTable("ParameterOfOptimizationMethod");

                entity.HasIndex(e => new { e.OptimizationMethodId, e.Designation }, "AK_ParameterDesignation")
                    .IsUnique();

                entity.Property(e => e.Designation)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.OptimizationMethod)
                    .WithMany(p => p.ParameterOfOptimizationMethods)
                    .HasForeignKey(d => d.OptimizationMethodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OptimizationParameter_MatlabOptimizationMethod");

                entity.HasOne(d => d.ParameterInfo)
                    .WithMany(p => p.ParametersOfOptimizationMethods)
                    .HasForeignKey(d => d.ParameterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ParameterOfOptimizationMethod_OptimizationParameter");
            });

            modelBuilder.Entity<Plant>(entity =>
            {
                entity.ToTable("Plant");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Reactor>(entity =>
            {
                entity.ToTable("Reactor");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Plant)
                    .WithMany(p => p.Reactors)
                    .HasForeignKey(d => d.PlantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reactor_Plant");
            });

            modelBuilder.Entity<SupportableFunc>(entity =>
            {
                entity.HasKey(e => new { e.FuncId, e.OptimizationMethodId });

                entity.ToTable("SupportableFunc");

                entity.HasOne(d => d.Func)
                    .WithMany(p => p.SupportableFuncs)
                    .HasForeignKey(d => d.FuncId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SupportableFunc_MatlabFunc");

                entity.HasOne(d => d.OptimizationMethod)
                    .WithMany(p => p.SupportableFuncs)
                    .HasForeignKey(d => d.OptimizationMethodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SupportableFunc_MatlabOptimizationMethod");
            });

            modelBuilder.Entity<VariableParameter>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("VariableParameter");

                entity.Property(e => e.Designation)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.MathModel)
                    .WithMany(p => p.VariableParameters)
                    .HasForeignKey(d => d.MathModelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VariableParameter_MatlabMathModel");

                entity.HasOne(d => d.Plant)
                    .WithMany(p => p.VariableParameters)
                    .HasForeignKey(d => d.PlantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VariableParameter_Plant");

                entity.HasOne(d => d.MeasureUnit)
                    .WithMany(p => p.VariableParameters)
                    .HasForeignKey(d => d.MeasureUnitId)
                    .HasConstraintName("FK_ReactorParameter_MeasureUnit");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        public override string ToString()
        {
            return "База данных характеристик каталитического риформинга, библиотеки математических моделей, методов оптимизации";
        }

        public override ExtendedDbContext CreateNew()
        {
            return new CatRefDbContext();
        }
    }
}
