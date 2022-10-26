using CarCatalogAPI.Source.Entities;
using CarCatalogAPI.Source.Infraestructure.Map;
using Microsoft.EntityFrameworkCore;

namespace CarCatalogAPI.Source.Infraestructure
{
    public class CarCatalogDbContext : DbContext
    {
        public CarCatalogDbContext(DbContextOptions<CarCatalogDbContext> options) : base(options) { }

        public DbSet<CarEntity> Cars { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CarMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
 