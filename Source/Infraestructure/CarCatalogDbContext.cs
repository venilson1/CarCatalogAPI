using CarCatalogAPI.Source.Core.DTOs;
using CarCatalogAPI.Source.Entities;
using CarCatalogAPI.Source.Infraestructure.Map;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;

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

            modelBuilder.Entity<CarEntity>().HasData(
                new CarEntity
                {
                    Name = "EX",
                    Brand = "Honda",
                    Model = "City",
                    UrlImage = "https://images.kavak.services/images/207087/EXTERIOR-frontSidePilotNear-1666038248023.jpeg?d=756x434",
                    CreatedAt = DateTime.Now
                },
                new CarEntity
                {
                    Name = "SCE STEPWAY EXPRESSION",
                    Brand = "Sandero",
                    Model = "Renault",
                    UrlImage = "https://images.kavak.services/images/207112/EXTERIOR-frontSidePilotNear-1666216087267.jpeg?d=756x434",
                    CreatedAt = DateTime.Now
                },
                new CarEntity
                {
                    Name = "MI",
                    Brand = "Fox",
                    Model = "Volkswagen",
                    UrlImage = "https://images.kavak.services/images/199784/EXTERIOR-frontSidePilotNear-1660250648875.jpeg?d=756x434",
                    CreatedAt = DateTime.Now
                },
                new CarEntity
                {
                    Name = "T-GDI GLS ECOSHIFT",
                    Brand = "Hyundai",
                    Model = "Tucson",
                    UrlImage = "https://images.kavak.services/images/197145/EXTERIOR-frontSidePilotNear-1659209409416.jpeg?d=756x434",
                    CreatedAt = DateTime.Now
                }
            );
        }
    }
}
 