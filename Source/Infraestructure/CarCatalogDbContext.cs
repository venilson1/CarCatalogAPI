using CarCatalogAPI.Source.Core.DTOs;
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

            modelBuilder.Entity<CarEntity>().HasData(
                new CarEntity
                {
                    Name = "EX",
                    Brand = "Honda",
                    Model = "City",
                    Price = 1354.99,
                    UrlImage = "https://images.kavak.services/images/207087/EXTERIOR-frontSidePilotNear-1666038248023.jpeg?d=756x434",
                    CreatedAt = DateTime.Now
                },
                new CarEntity
                {
                    Name = "SCE STEPWAY EXPRESSION",
                    Brand = "Sandero",
                    Model = "Renault",
                    Price = 1354.99,
                    UrlImage = "https://images.kavak.services/images/207112/EXTERIOR-frontSidePilotNear-1666216087267.jpeg?d=756x434",
                    CreatedAt = DateTime.Now
                },
                new CarEntity
                {
                    Name = "MI",
                    Brand = "Fox",
                    Model = "Volkswagen",
                    Price = 44354.99,
                    UrlImage = "https://images.kavak.services/images/199784/EXTERIOR-frontSidePilotNear-1660250648875.jpeg?d=756x434",
                    CreatedAt = DateTime.Now
                },
                new CarEntity
                {
                    Name = "T-GDI GLS ECOSHIFT",
                    Brand = "Hyundai",
                    Model = "Tucson",
                    Price = 188954.99,
                    UrlImage = "https://images.kavak.services/images/197145/EXTERIOR-frontSidePilotNear-1659209409416.jpeg?d=756x434",
                    CreatedAt = DateTime.Now
                },
                new CarEntity
                {
                    Name = "EX",
                    Brand = "Honda",
                    Model = "City",
                    Price = 1354058.99,
                    UrlImage = "https://images.kavak.services/images/207087/EXTERIOR-frontSidePilotNear-1666038248023.jpeg?d=756x434",
                    CreatedAt = DateTime.Now
                },
                new CarEntity
                {
                    Name = "SCE STEPWAY EXPRESSION",
                    Brand = "Sandero",
                    Model = "Renault",
                    Price = 135454.99,
                    UrlImage = "https://images.kavak.services/images/207112/EXTERIOR-frontSidePilotNear-1666216087267.jpeg?d=756x434",
                    CreatedAt = DateTime.Now
                },
                new CarEntity
                {
                    Name = "MI",
                    Brand = "Fox",
                    Model = "Volkswagen",
                    Price = 1359844.99,
                    UrlImage = "https://images.kavak.services/images/199784/EXTERIOR-frontSidePilotNear-1660250648875.jpeg?d=756x434",
                    CreatedAt = DateTime.Now
                },
                new CarEntity
                {
                    Name = "T-GDI GLS ECOSHIFT",
                    Brand = "Hyundai",
                    Model = "Tucson",
                    Price = 1359864.99,
                    UrlImage = "https://images.kavak.services/images/197145/EXTERIOR-frontSidePilotNear-1659209409416.jpeg?d=756x434",
                    CreatedAt = DateTime.Now
                },
                new CarEntity
                {
                    Name = "EX",
                    Brand = "Honda",
                    Model = "City",
                    Price = 13984654.99,
                    UrlImage = "https://images.kavak.services/images/207087/EXTERIOR-frontSidePilotNear-1666038248023.jpeg?d=756x434",
                    CreatedAt = DateTime.Now
                },
                new CarEntity
                {
                    Name = "SCE STEPWAY EXPRESSION",
                    Brand = "Sandero",
                    Model = "Renault",
                    Price = 13568464.99,
                    UrlImage = "https://images.kavak.services/images/207112/EXTERIOR-frontSidePilotNear-1666216087267.jpeg?d=756x434",
                    CreatedAt = DateTime.Now
                },
                new CarEntity
                {
                    Name = "MI",
                    Brand = "Fox",
                    Model = "Volkswagen",
                    Price = 13568464.99,
                    UrlImage = "https://images.kavak.services/images/199784/EXTERIOR-frontSidePilotNear-1660250648875.jpeg?d=756x434",
                    CreatedAt = DateTime.Now
                },
                new CarEntity
                {
                    Name = "T-GDI GLS ECOSHIFT",
                    Brand = "Hyundai",
                    Model = "Tucson",
                    Price = 1356854.99,
                    UrlImage = "https://images.kavak.services/images/197145/EXTERIOR-frontSidePilotNear-1659209409416.jpeg?d=756x434",
                    CreatedAt = DateTime.Now
                },
                new CarEntity
                {
                    Name = "EX",
                    Brand = "Honda",
                    Model = "City",
                    Price = 135974.99,
                    UrlImage = "https://images.kavak.services/images/207087/EXTERIOR-frontSidePilotNear-1666038248023.jpeg?d=756x434",
                    CreatedAt = DateTime.Now
                },
                new CarEntity
                {
                    Name = "SCE STEPWAY EXPRESSION",
                    Brand = "Sandero",
                    Model = "Renault",
                    Price = 9991354.99,
                    UrlImage = "https://images.kavak.services/images/207112/EXTERIOR-frontSidePilotNear-1666216087267.jpeg?d=756x434",
                    CreatedAt = DateTime.Now
                },
                new CarEntity
                {
                    Name = "MI",
                    Brand = "Fox",
                    Model = "Volkswagen",
                    Price = 13884654.99,
                    UrlImage = "https://images.kavak.services/images/199784/EXTERIOR-frontSidePilotNear-1660250648875.jpeg?d=756x434",
                    CreatedAt = DateTime.Now
                },
                new CarEntity
                {
                    Name = "T-GDI GLS ECOSHIFT",
                    Brand = "Hyundai",
                    Model = "Tucson",
                    Price = 13588984.99,
                    UrlImage = "https://images.kavak.services/images/197145/EXTERIOR-frontSidePilotNear-1659209409416.jpeg?d=756x434",
                    CreatedAt = DateTime.Now
                },
                 new CarEntity
                 {
                     Name = "EX",
                     Brand = "Honda",
                     Model = "City",
                     Price = 13155454.99,
                     UrlImage = "https://images.kavak.services/images/207087/EXTERIOR-frontSidePilotNear-1666038248023.jpeg?d=756x434",
                     CreatedAt = DateTime.Now
                 },
                new CarEntity
                {
                    Name = "SCE STEPWAY EXPRESSION",
                    Brand = "Sandero",
                    Model = "Renault",
                    Price = 13683554.99,
                    UrlImage = "https://images.kavak.services/images/207112/EXTERIOR-frontSidePilotNear-1666216087267.jpeg?d=756x434",
                    CreatedAt = DateTime.Now
                },
                new CarEntity
                {
                    Name = "MI",
                    Brand = "Fox",
                    Model = "Volkswagen",
                    Price = 1386554.99,
                    UrlImage = "https://images.kavak.services/images/199784/EXTERIOR-frontSidePilotNear-1660250648875.jpeg?d=756x434",
                    CreatedAt = DateTime.Now
                },
                new CarEntity
                {
                    Name = "T-GDI GLS ECOSHIFT",
                    Brand = "Hyundai",
                    Model = "Tucson",
                    Price = 169846354.99,
                    UrlImage = "https://images.kavak.services/images/197145/EXTERIOR-frontSidePilotNear-1659209409416.jpeg?d=756x434",
                    CreatedAt = DateTime.Now
                },
                 new CarEntity
                 {
                     Name = "EX",
                     Brand = "Honda",
                     Model = "City",
                     Price = 1354.99,
                     UrlImage = "https://images.kavak.services/images/207087/EXTERIOR-frontSidePilotNear-1666038248023.jpeg?d=756x434",
                     CreatedAt = DateTime.Now
                 },
                new CarEntity
                {
                    Name = "SCE STEPWAY EXPRESSION",
                    Brand = "Sandero",
                    Model = "Renault",
                    Price = 13684654.99,
                    UrlImage = "https://images.kavak.services/images/207112/EXTERIOR-frontSidePilotNear-1666216087267.jpeg?d=756x434",
                    CreatedAt = DateTime.Now
                },
                new CarEntity
                {
                    Name = "MI",
                    Brand = "Fox",
                    Model = "Volkswagen",
                    Price = 13584654.99,
                    UrlImage = "https://images.kavak.services/images/199784/EXTERIOR-frontSidePilotNear-1660250648875.jpeg?d=756x434",
                    CreatedAt = DateTime.Now
                },
                new CarEntity
                {
                    Name = "T-GDI GLS ECOSHIFT",
                    Brand = "Hyundai",
                    Model = "Tucson",
                    Price = 13546546.99,
                    UrlImage = "https://images.kavak.services/images/197145/EXTERIOR-frontSidePilotNear-1659209409416.jpeg?d=756x434",
                    CreatedAt = DateTime.Now
                }
            );
        }
    }
}
 