// <auto-generated />
using System;
using CarCatalogAPI.Source.Infraestructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarCatalogAPI.Migrations
{
    [DbContext(typeof(CarCatalogDbContext))]
    [Migration("20221029004443_addFieldPriceEntityCar")]
    partial class addFieldPriceEntityCar
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CarCatalogAPI.Source.Entities.CarEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("UrlImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4c465de4-9711-4077-a02a-067e7c14c329"),
                            Brand = "Honda",
                            CreatedAt = new DateTime(2022, 10, 28, 21, 44, 43, 756, DateTimeKind.Local).AddTicks(7066),
                            Model = "City",
                            Name = "EX",
                            Price = 1354.99,
                            UrlImage = "https://images.kavak.services/images/207087/EXTERIOR-frontSidePilotNear-1666038248023.jpeg?d=756x434"
                        },
                        new
                        {
                            Id = new Guid("82eef636-eca7-4565-aeb5-e333e78bfa16"),
                            Brand = "Sandero",
                            CreatedAt = new DateTime(2022, 10, 28, 21, 44, 43, 756, DateTimeKind.Local).AddTicks(7077),
                            Model = "Renault",
                            Name = "SCE STEPWAY EXPRESSION",
                            Price = 1354.99,
                            UrlImage = "https://images.kavak.services/images/207112/EXTERIOR-frontSidePilotNear-1666216087267.jpeg?d=756x434"
                        },
                        new
                        {
                            Id = new Guid("5dbff9c7-f08e-4a43-9ac2-3c1f4f1b9584"),
                            Brand = "Fox",
                            CreatedAt = new DateTime(2022, 10, 28, 21, 44, 43, 756, DateTimeKind.Local).AddTicks(7078),
                            Model = "Volkswagen",
                            Name = "MI",
                            Price = 1354.99,
                            UrlImage = "https://images.kavak.services/images/199784/EXTERIOR-frontSidePilotNear-1660250648875.jpeg?d=756x434"
                        },
                        new
                        {
                            Id = new Guid("15eb04a2-4feb-49ec-a171-b26c00a9b64f"),
                            Brand = "Hyundai",
                            CreatedAt = new DateTime(2022, 10, 28, 21, 44, 43, 756, DateTimeKind.Local).AddTicks(7080),
                            Model = "Tucson",
                            Name = "T-GDI GLS ECOSHIFT",
                            Price = 1354.99,
                            UrlImage = "https://images.kavak.services/images/197145/EXTERIOR-frontSidePilotNear-1659209409416.jpeg?d=756x434"
                        },
                        new
                        {
                            Id = new Guid("278a9d7b-af4c-458f-8828-6c4efeff3d4d"),
                            Brand = "Honda",
                            CreatedAt = new DateTime(2022, 10, 28, 21, 44, 43, 756, DateTimeKind.Local).AddTicks(7081),
                            Model = "City",
                            Name = "EX",
                            Price = 1354.99,
                            UrlImage = "https://images.kavak.services/images/207087/EXTERIOR-frontSidePilotNear-1666038248023.jpeg?d=756x434"
                        },
                        new
                        {
                            Id = new Guid("2c08bd3e-bc74-4449-a750-d2d790e9fbaa"),
                            Brand = "Sandero",
                            CreatedAt = new DateTime(2022, 10, 28, 21, 44, 43, 756, DateTimeKind.Local).AddTicks(7083),
                            Model = "Renault",
                            Name = "SCE STEPWAY EXPRESSION",
                            Price = 1354.99,
                            UrlImage = "https://images.kavak.services/images/207112/EXTERIOR-frontSidePilotNear-1666216087267.jpeg?d=756x434"
                        },
                        new
                        {
                            Id = new Guid("485dbe67-a62f-4ea6-a07e-a9f848da6474"),
                            Brand = "Fox",
                            CreatedAt = new DateTime(2022, 10, 28, 21, 44, 43, 756, DateTimeKind.Local).AddTicks(7084),
                            Model = "Volkswagen",
                            Name = "MI",
                            Price = 1354.99,
                            UrlImage = "https://images.kavak.services/images/199784/EXTERIOR-frontSidePilotNear-1660250648875.jpeg?d=756x434"
                        },
                        new
                        {
                            Id = new Guid("cb278d25-0d2d-48dc-b802-4fa45c5cf2c5"),
                            Brand = "Hyundai",
                            CreatedAt = new DateTime(2022, 10, 28, 21, 44, 43, 756, DateTimeKind.Local).AddTicks(7085),
                            Model = "Tucson",
                            Name = "T-GDI GLS ECOSHIFT",
                            Price = 1354.99,
                            UrlImage = "https://images.kavak.services/images/197145/EXTERIOR-frontSidePilotNear-1659209409416.jpeg?d=756x434"
                        },
                        new
                        {
                            Id = new Guid("0e91d281-1533-461f-ab1a-41f9ef9fcb3d"),
                            Brand = "Honda",
                            CreatedAt = new DateTime(2022, 10, 28, 21, 44, 43, 756, DateTimeKind.Local).AddTicks(7089),
                            Model = "City",
                            Name = "EX",
                            Price = 1354.99,
                            UrlImage = "https://images.kavak.services/images/207087/EXTERIOR-frontSidePilotNear-1666038248023.jpeg?d=756x434"
                        },
                        new
                        {
                            Id = new Guid("6baeb43a-ff3f-4b99-b422-beead5ed5d93"),
                            Brand = "Sandero",
                            CreatedAt = new DateTime(2022, 10, 28, 21, 44, 43, 756, DateTimeKind.Local).AddTicks(7091),
                            Model = "Renault",
                            Name = "SCE STEPWAY EXPRESSION",
                            Price = 1354.99,
                            UrlImage = "https://images.kavak.services/images/207112/EXTERIOR-frontSidePilotNear-1666216087267.jpeg?d=756x434"
                        },
                        new
                        {
                            Id = new Guid("3b699324-b499-4952-b6ee-81306b7a0941"),
                            Brand = "Fox",
                            CreatedAt = new DateTime(2022, 10, 28, 21, 44, 43, 756, DateTimeKind.Local).AddTicks(7092),
                            Model = "Volkswagen",
                            Name = "MI",
                            Price = 1354.99,
                            UrlImage = "https://images.kavak.services/images/199784/EXTERIOR-frontSidePilotNear-1660250648875.jpeg?d=756x434"
                        },
                        new
                        {
                            Id = new Guid("7644d1a8-39dc-4da7-ba81-8439d92c2292"),
                            Brand = "Hyundai",
                            CreatedAt = new DateTime(2022, 10, 28, 21, 44, 43, 756, DateTimeKind.Local).AddTicks(7093),
                            Model = "Tucson",
                            Name = "T-GDI GLS ECOSHIFT",
                            Price = 1354.99,
                            UrlImage = "https://images.kavak.services/images/197145/EXTERIOR-frontSidePilotNear-1659209409416.jpeg?d=756x434"
                        },
                        new
                        {
                            Id = new Guid("76cd1c8e-8407-47a6-8341-e53ffc1fafd6"),
                            Brand = "Honda",
                            CreatedAt = new DateTime(2022, 10, 28, 21, 44, 43, 756, DateTimeKind.Local).AddTicks(7094),
                            Model = "City",
                            Name = "EX",
                            Price = 1354.99,
                            UrlImage = "https://images.kavak.services/images/207087/EXTERIOR-frontSidePilotNear-1666038248023.jpeg?d=756x434"
                        },
                        new
                        {
                            Id = new Guid("81f71ec7-7408-4eda-b4fa-d2ff41eedc0d"),
                            Brand = "Sandero",
                            CreatedAt = new DateTime(2022, 10, 28, 21, 44, 43, 756, DateTimeKind.Local).AddTicks(7096),
                            Model = "Renault",
                            Name = "SCE STEPWAY EXPRESSION",
                            Price = 1354.99,
                            UrlImage = "https://images.kavak.services/images/207112/EXTERIOR-frontSidePilotNear-1666216087267.jpeg?d=756x434"
                        },
                        new
                        {
                            Id = new Guid("f68ea4cc-cde2-43fc-bee1-7750d0435030"),
                            Brand = "Fox",
                            CreatedAt = new DateTime(2022, 10, 28, 21, 44, 43, 756, DateTimeKind.Local).AddTicks(7097),
                            Model = "Volkswagen",
                            Name = "MI",
                            Price = 1354.99,
                            UrlImage = "https://images.kavak.services/images/199784/EXTERIOR-frontSidePilotNear-1660250648875.jpeg?d=756x434"
                        },
                        new
                        {
                            Id = new Guid("0e3de54e-17a4-429a-8ff5-ebba4ca4880e"),
                            Brand = "Hyundai",
                            CreatedAt = new DateTime(2022, 10, 28, 21, 44, 43, 756, DateTimeKind.Local).AddTicks(7098),
                            Model = "Tucson",
                            Name = "T-GDI GLS ECOSHIFT",
                            Price = 1354.99,
                            UrlImage = "https://images.kavak.services/images/197145/EXTERIOR-frontSidePilotNear-1659209409416.jpeg?d=756x434"
                        },
                        new
                        {
                            Id = new Guid("c03e0d90-dfbf-4b2d-aeba-83a166a48365"),
                            Brand = "Honda",
                            CreatedAt = new DateTime(2022, 10, 28, 21, 44, 43, 756, DateTimeKind.Local).AddTicks(7102),
                            Model = "City",
                            Name = "EX",
                            Price = 1354.99,
                            UrlImage = "https://images.kavak.services/images/207087/EXTERIOR-frontSidePilotNear-1666038248023.jpeg?d=756x434"
                        },
                        new
                        {
                            Id = new Guid("129f7af3-b7cd-4ba1-9c96-4ca56dd139e4"),
                            Brand = "Sandero",
                            CreatedAt = new DateTime(2022, 10, 28, 21, 44, 43, 756, DateTimeKind.Local).AddTicks(7103),
                            Model = "Renault",
                            Name = "SCE STEPWAY EXPRESSION",
                            Price = 1354.99,
                            UrlImage = "https://images.kavak.services/images/207112/EXTERIOR-frontSidePilotNear-1666216087267.jpeg?d=756x434"
                        },
                        new
                        {
                            Id = new Guid("e26f224b-51c0-4852-b8f8-3ac3986233ad"),
                            Brand = "Fox",
                            CreatedAt = new DateTime(2022, 10, 28, 21, 44, 43, 756, DateTimeKind.Local).AddTicks(7104),
                            Model = "Volkswagen",
                            Name = "MI",
                            Price = 1354.99,
                            UrlImage = "https://images.kavak.services/images/199784/EXTERIOR-frontSidePilotNear-1660250648875.jpeg?d=756x434"
                        },
                        new
                        {
                            Id = new Guid("eaaa9e47-67d2-4a21-b2eb-34ce1edea315"),
                            Brand = "Hyundai",
                            CreatedAt = new DateTime(2022, 10, 28, 21, 44, 43, 756, DateTimeKind.Local).AddTicks(7106),
                            Model = "Tucson",
                            Name = "T-GDI GLS ECOSHIFT",
                            Price = 1354.99,
                            UrlImage = "https://images.kavak.services/images/197145/EXTERIOR-frontSidePilotNear-1659209409416.jpeg?d=756x434"
                        },
                        new
                        {
                            Id = new Guid("f9394146-3937-4c16-972f-40f5a2bb1802"),
                            Brand = "Honda",
                            CreatedAt = new DateTime(2022, 10, 28, 21, 44, 43, 756, DateTimeKind.Local).AddTicks(7107),
                            Model = "City",
                            Name = "EX",
                            Price = 1354.99,
                            UrlImage = "https://images.kavak.services/images/207087/EXTERIOR-frontSidePilotNear-1666038248023.jpeg?d=756x434"
                        },
                        new
                        {
                            Id = new Guid("2ddbabe2-94f6-42b3-8a0f-5f692404d4e7"),
                            Brand = "Sandero",
                            CreatedAt = new DateTime(2022, 10, 28, 21, 44, 43, 756, DateTimeKind.Local).AddTicks(7108),
                            Model = "Renault",
                            Name = "SCE STEPWAY EXPRESSION",
                            Price = 1354.99,
                            UrlImage = "https://images.kavak.services/images/207112/EXTERIOR-frontSidePilotNear-1666216087267.jpeg?d=756x434"
                        },
                        new
                        {
                            Id = new Guid("cf76beed-be0c-49ee-86cf-816fced70835"),
                            Brand = "Fox",
                            CreatedAt = new DateTime(2022, 10, 28, 21, 44, 43, 756, DateTimeKind.Local).AddTicks(7110),
                            Model = "Volkswagen",
                            Name = "MI",
                            Price = 1354.99,
                            UrlImage = "https://images.kavak.services/images/199784/EXTERIOR-frontSidePilotNear-1660250648875.jpeg?d=756x434"
                        },
                        new
                        {
                            Id = new Guid("e7452952-1aa4-4102-835e-57875099c5e1"),
                            Brand = "Hyundai",
                            CreatedAt = new DateTime(2022, 10, 28, 21, 44, 43, 756, DateTimeKind.Local).AddTicks(7111),
                            Model = "Tucson",
                            Name = "T-GDI GLS ECOSHIFT",
                            Price = 1354.99,
                            UrlImage = "https://images.kavak.services/images/197145/EXTERIOR-frontSidePilotNear-1659209409416.jpeg?d=756x434"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
