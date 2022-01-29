using Microsoft.EntityFrameworkCore;
using MySql.EntityFrameworkCore.Extensions;

namespace Lager.DbController
{
    public class DatabaseContext : DbContext
    {
        public DbSet<TireBrand> TireBrand {get; set;} = default!;
        public DbSet<Tire> Tire {get; set;} = default!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=buchhaltung;user=root;password=password");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}