using CarCatalogAPI.Source.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarCatalogAPI.Source.Infraestructure
{
    public class CarCatalogDbContext : DbContext
    {
        public CarCatalogDbContext(DbContextOptions<CarCatalogDbContext> options) : base(options) { }

        public DbSet<CarEntity> Cars { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
