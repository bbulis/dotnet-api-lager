using Microsoft.EntityFrameworkCore;
using MySql.EntityFrameworkCore.Extensions;

namespace Lager
{
    public class DatabaseContext : DbContext
    {
        public DbSet<TireBrand> TireBrand {get; set;} = default!;
        public DbSet<Tire> Tire {get; set;} = default!;
        public DbSet<Storage> Storage {get; set;} = default!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=lager;user=root;password=password");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TireBrand>(entity => 
            {
                entity.HasKey(e => e.TireBrandId);
            });
            modelBuilder.Entity<Tire>(entity => 
            {
                entity.HasKey(e => e.TireId);
            });
            modelBuilder.Entity<Storage>(entity => 
            {
                entity.HasKey(e => e.StorageId);
            });
        }
    }
}