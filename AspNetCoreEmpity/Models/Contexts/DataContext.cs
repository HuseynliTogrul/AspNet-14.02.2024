using AspNetCoreEmpity.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreEmpity.Models.Contexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options)
            :base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var currentAssembly = typeof(DataContext).Assembly;

            modelBuilder.ApplyConfigurationsFromAssembly(currentAssembly);
        }

        public DbSet<Size> Sizes { get; set; }
        public DbSet<Color> Colors { get; set; }
    }
}
