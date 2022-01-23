using Microsoft.EntityFrameworkCore;
using MySql.EntityFrameworkCore.Extensions;

namespace Lager.DbController
{
    public class DatabaseContext : DbContext
    {
        public DbSet<TireBrand> TireBrand {get; set;}
        public DbSet<Tire> Tire {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=buchhaltung;user=root;password=password");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TireBrand>(entity => {
                entity.HasKey(e => e.TireBrandId);
                entity.Property(e => e.TireBrandName).IsRequired();
            });

            modelBuilder.Entity<Tire>(entity => {
                entity.HasKey(e => e.TireId);
                entity.Property(e => e.Brand).IsRequired();
                entity.Property(e => e.Width).IsRequired();
                entity.Property(e => e.Height).IsRequired();
                entity.Property(e => e.RimSize).IsRequired();
                entity.Property(e => e.LoadIndex).IsRequired();
                entity.Property(e => e.SpeedIndex).IsRequired();
                entity.Property(e => e.Description).IsRequired();
            });
        }
    }
}