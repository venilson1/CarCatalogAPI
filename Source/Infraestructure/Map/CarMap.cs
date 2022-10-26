using CarCatalogAPI.Source.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarCatalogAPI.Source.Infraestructure.Map
{
    public class CarMap : IEntityTypeConfiguration<CarEntity>
    {
        public void Configure(EntityTypeBuilder<CarEntity> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Brand).IsRequired();
            builder.Property(x => x.Model).IsRequired();
            builder.Property(x => x.UrlImage);
        }
    }
}
