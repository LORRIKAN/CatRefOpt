using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Model.Users;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Repository
{
    public partial class CatRefUsersDbContext : ExtendedDbContext
    {
        public CatRefUsersDbContext()
        {
        }

        public CatRefUsersDbContext(DbContextOptions<CatRefUsersDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        private static string GetConnectionString()
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();
            return configuration.GetConnectionString("CatRefUsersDb");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(GetConnectionString()).UseLazyLoadingProxies();
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.HasIndex(e => e.RoleId, "IX_UserHasRole");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("UserHasRole");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        public override string ToString()
        {
            return "База данных пользователей";
        }

        public override string? Validate(object value, IBindingList dataSource)
        {
            return null;
        }

        public override IEnumerable<IBindingList> GetBindingLists()
        {
            Roles.Load();
            yield return Roles.Local.ToBindingList();
            Users.Load();
            yield return Users.Local.ToBindingList();
        }

        public override ExtendedDbContext CreateNew()
        {
            return new CatRefUsersDbContext();
        }
    }
}
