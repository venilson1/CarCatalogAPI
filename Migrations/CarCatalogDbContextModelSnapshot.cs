﻿// <auto-generated />
using System;
using CarCatalogAPI.Source.Infraestructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarCatalogAPI.Migrations
{
    [DbContext(typeof(CarCatalogDbContext))]
    partial class CarCatalogDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            Id = new Guid("6a92a22b-58a0-4097-9dc9-960616ee9bdc"),
                            Brand = "Honda",
                            CreatedAt = new DateTime(2022, 10, 28, 22, 5, 44, 575, DateTimeKind.Local).AddTicks(4069),
                            Model = "City",
                            Name = "EX",
                            Price = 1354.99,
                            UrlImage = "https://images.kavak.services/images/207087/EXTERIOR-frontSidePilotNear-1666038248023.jpeg?d=756x434"
                        },
                        new
                        {
                            Id = new Guid("7eb937fe-11c2-41d3-8064-dc50f7fb387c"),
                            Brand = "Sandero",
                            CreatedAt = new DateTime(2022, 10, 28, 22, 5, 44, 575, DateTimeKind.Local).AddTicks(4079),
                            Model = "Renault",
                            Name = "SCE STEPWAY EXPRESSION",
                            Price = 1354.99,
                            UrlImage = "https://images.kavak.services/images/207112/EXTERIOR-frontSidePilotNear-1666216087267.jpeg?d=756x434"
                        },
                        new
                        {
                            Id = new Guid("76126647-32ea-4639-9ec5-86ded748a341"),
                            Brand = "Fox",
                            CreatedAt = new DateTime(2022, 10, 28, 22, 5, 44, 575, DateTimeKind.Local).AddTicks(4080),
                            Model = "Volkswagen",
                            Name = "MI",
                            Price = 44354.989999999998,
                            UrlImage = "https://images.kavak.services/images/199784/EXTERIOR-frontSidePilotNear-1660250648875.jpeg?d=756x434"
                        },
                        new
                        {
                            Id = new Guid("91ed367b-c849-4181-8f13-83cea557a9c9"),
                            Brand = "Hyundai",
                            CreatedAt = new DateTime(2022, 10, 28, 22, 5, 44, 575, DateTimeKind.Local).AddTicks(4082),
                            Model = "Tucson",
                            Name = "T-GDI GLS ECOSHIFT",
                            Price = 188954.98999999999,
                            UrlImage = "https://images.kavak.services/images/197145/EXTERIOR-frontSidePilotNear-1659209409416.jpeg?d=756x434"
                        },
                        new
                        {
                            Id = new Guid("84138e79-7342-449b-9cfd-d2fb75504556"),
                            Brand = "Honda",
                            CreatedAt = new DateTime(2022, 10, 28, 22, 5, 44, 575, DateTimeKind.Local).AddTicks(4095),
                            Model = "City",
                            Name = "EX",
                            Price = 1354058.99,
                            UrlImage = "https://images.kavak.services/images/207087/EXTERIOR-frontSidePilotNear-1666038248023.jpeg?d=756x434"
                        },
                        new
                        {
                            Id = new Guid("85a2b187-d568-4237-8e10-12b6864425f8"),
                            Brand = "Sandero",
                            CreatedAt = new DateTime(2022, 10, 28, 22, 5, 44, 575, DateTimeKind.Local).AddTicks(4096),
                            Model = "Renault",
                            Name = "SCE STEPWAY EXPRESSION",
                            Price = 135454.98999999999,
                            UrlImage = "https://images.kavak.services/images/207112/EXTERIOR-frontSidePilotNear-1666216087267.jpeg?d=756x434"
                        },
                        new
                        {
                            Id = new Guid("87547095-45f3-4d9b-917c-329cf596c013"),
                            Brand = "Fox",
                            CreatedAt = new DateTime(2022, 10, 28, 22, 5, 44, 575, DateTimeKind.Local).AddTicks(4098),
                            Model = "Volkswagen",
                            Name = "MI",
                            Price = 1359844.99,
                            UrlImage = "https://images.kavak.services/images/199784/EXTERIOR-frontSidePilotNear-1660250648875.jpeg?d=756x434"
                        },
                        new
                        {
                            Id = new Guid("20726a46-02c3-4bce-9583-178ffa108db7"),
                            Brand = "Hyundai",
                            CreatedAt = new DateTime(2022, 10, 28, 22, 5, 44, 575, DateTimeKind.Local).AddTicks(4099),
                            Model = "Tucson",
                            Name = "T-GDI GLS ECOSHIFT",
                            Price = 1359864.99,
                            UrlImage = "https://images.kavak.services/images/197145/EXTERIOR-frontSidePilotNear-1659209409416.jpeg?d=756x434"
                        },
                        new
                        {
                            Id = new Guid("7d11c1db-2f91-4523-a9fc-69ff973574d5"),
                            Brand = "Honda",
                            CreatedAt = new DateTime(2022, 10, 28, 22, 5, 44, 575, DateTimeKind.Local).AddTicks(4101),
                            Model = "City",
                            Name = "EX",
                            Price = 13984654.99,
                            UrlImage = "https://images.kavak.services/images/207087/EXTERIOR-frontSidePilotNear-1666038248023.jpeg?d=756x434"
                        },
                        new
                        {
                            Id = new Guid("d78530bc-d791-49ef-9e7e-0ab1d4dfe975"),
                            Brand = "Sandero",
                            CreatedAt = new DateTime(2022, 10, 28, 22, 5, 44, 575, DateTimeKind.Local).AddTicks(4102),
                            Model = "Renault",
                            Name = "SCE STEPWAY EXPRESSION",
                            Price = 13568464.99,
                            UrlImage = "https://images.kavak.services/images/207112/EXTERIOR-frontSidePilotNear-1666216087267.jpeg?d=756x434"
                        },
                        new
                        {
                            Id = new Guid("6a4306e2-274f-4c68-b743-780473a5683d"),
                            Brand = "Fox",
                            CreatedAt = new DateTime(2022, 10, 28, 22, 5, 44, 575, DateTimeKind.Local).AddTicks(4154),
                            Model = "Volkswagen",
                            Name = "MI",
                            Price = 13568464.99,
                            UrlImage = "https://images.kavak.services/images/199784/EXTERIOR-frontSidePilotNear-1660250648875.jpeg?d=756x434"
                        },
                        new
                        {
                            Id = new Guid("95d48961-9ede-4476-b75e-1be304bb6362"),
                            Brand = "Hyundai",
                            CreatedAt = new DateTime(2022, 10, 28, 22, 5, 44, 575, DateTimeKind.Local).AddTicks(4156),
                            Model = "Tucson",
                            Name = "T-GDI GLS ECOSHIFT",
                            Price = 1356854.99,
                            UrlImage = "https://images.kavak.services/images/197145/EXTERIOR-frontSidePilotNear-1659209409416.jpeg?d=756x434"
                        },
                        new
                        {
                            Id = new Guid("4102d309-e790-4c9a-8d1f-be452943bde8"),
                            Brand = "Honda",
                            CreatedAt = new DateTime(2022, 10, 28, 22, 5, 44, 575, DateTimeKind.Local).AddTicks(4160),
                            Model = "City",
                            Name = "EX",
                            Price = 135974.98999999999,
                            UrlImage = "https://images.kavak.services/images/207087/EXTERIOR-frontSidePilotNear-1666038248023.jpeg?d=756x434"
                        },
                        new
                        {
                            Id = new Guid("c5d3d152-4b36-469d-9447-765ff45dc108"),
                            Brand = "Sandero",
                            CreatedAt = new DateTime(2022, 10, 28, 22, 5, 44, 575, DateTimeKind.Local).AddTicks(4161),
                            Model = "Renault",
                            Name = "SCE STEPWAY EXPRESSION",
                            Price = 9991354.9900000002,
                            UrlImage = "https://images.kavak.services/images/207112/EXTERIOR-frontSidePilotNear-1666216087267.jpeg?d=756x434"
                        },
                        new
                        {
                            Id = new Guid("bc79fa9e-b2a8-4fcf-b68f-ebac87a0ad58"),
                            Brand = "Fox",
                            CreatedAt = new DateTime(2022, 10, 28, 22, 5, 44, 575, DateTimeKind.Local).AddTicks(4163),
                            Model = "Volkswagen",
                            Name = "MI",
                            Price = 13884654.99,
                            UrlImage = "https://images.kavak.services/images/199784/EXTERIOR-frontSidePilotNear-1660250648875.jpeg?d=756x434"
                        },
                        new
                        {
                            Id = new Guid("254ebadd-ca36-495c-a239-f35080ad6b28"),
                            Brand = "Hyundai",
                            CreatedAt = new DateTime(2022, 10, 28, 22, 5, 44, 575, DateTimeKind.Local).AddTicks(4164),
                            Model = "Tucson",
                            Name = "T-GDI GLS ECOSHIFT",
                            Price = 13588984.99,
                            UrlImage = "https://images.kavak.services/images/197145/EXTERIOR-frontSidePilotNear-1659209409416.jpeg?d=756x434"
                        },
                        new
                        {
                            Id = new Guid("238fc273-b58a-4b53-a403-7956dcfd5f96"),
                            Brand = "Honda",
                            CreatedAt = new DateTime(2022, 10, 28, 22, 5, 44, 575, DateTimeKind.Local).AddTicks(4166),
                            Model = "City",
                            Name = "EX",
                            Price = 13155454.99,
                            UrlImage = "https://images.kavak.services/images/207087/EXTERIOR-frontSidePilotNear-1666038248023.jpeg?d=756x434"
                        },
                        new
                        {
                            Id = new Guid("44ababab-7e4e-4cf1-9cef-5961ac86863c"),
                            Brand = "Sandero",
                            CreatedAt = new DateTime(2022, 10, 28, 22, 5, 44, 575, DateTimeKind.Local).AddTicks(4167),
                            Model = "Renault",
                            Name = "SCE STEPWAY EXPRESSION",
                            Price = 13683554.99,
                            UrlImage = "https://images.kavak.services/images/207112/EXTERIOR-frontSidePilotNear-1666216087267.jpeg?d=756x434"
                        },
                        new
                        {
                            Id = new Guid("573c24bb-3ffb-4e7e-adb2-5e442e255650"),
                            Brand = "Fox",
                            CreatedAt = new DateTime(2022, 10, 28, 22, 5, 44, 575, DateTimeKind.Local).AddTicks(4168),
                            Model = "Volkswagen",
                            Name = "MI",
                            Price = 1386554.99,
                            UrlImage = "https://images.kavak.services/images/199784/EXTERIOR-frontSidePilotNear-1660250648875.jpeg?d=756x434"
                        },
                        new
                        {
                            Id = new Guid("daa41667-1fb4-4e5f-921f-ad2239dc38fe"),
                            Brand = "Hyundai",
                            CreatedAt = new DateTime(2022, 10, 28, 22, 5, 44, 575, DateTimeKind.Local).AddTicks(4170),
                            Model = "Tucson",
                            Name = "T-GDI GLS ECOSHIFT",
                            Price = 169846354.99000001,
                            UrlImage = "https://images.kavak.services/images/197145/EXTERIOR-frontSidePilotNear-1659209409416.jpeg?d=756x434"
                        },
                        new
                        {
                            Id = new Guid("5bee15c4-b1af-461b-b58b-38f1fbf836c6"),
                            Brand = "Honda",
                            CreatedAt = new DateTime(2022, 10, 28, 22, 5, 44, 575, DateTimeKind.Local).AddTicks(4173),
                            Model = "City",
                            Name = "EX",
                            Price = 1354.99,
                            UrlImage = "https://images.kavak.services/images/207087/EXTERIOR-frontSidePilotNear-1666038248023.jpeg?d=756x434"
                        },
                        new
                        {
                            Id = new Guid("2d2f973f-7aaf-4d9d-b952-fbe54949c280"),
                            Brand = "Sandero",
                            CreatedAt = new DateTime(2022, 10, 28, 22, 5, 44, 575, DateTimeKind.Local).AddTicks(4174),
                            Model = "Renault",
                            Name = "SCE STEPWAY EXPRESSION",
                            Price = 13684654.99,
                            UrlImage = "https://images.kavak.services/images/207112/EXTERIOR-frontSidePilotNear-1666216087267.jpeg?d=756x434"
                        },
                        new
                        {
                            Id = new Guid("7d23a96f-f6b4-4838-a4db-c117affdc1c1"),
                            Brand = "Fox",
                            CreatedAt = new DateTime(2022, 10, 28, 22, 5, 44, 575, DateTimeKind.Local).AddTicks(4176),
                            Model = "Volkswagen",
                            Name = "MI",
                            Price = 13584654.99,
                            UrlImage = "https://images.kavak.services/images/199784/EXTERIOR-frontSidePilotNear-1660250648875.jpeg?d=756x434"
                        },
                        new
                        {
                            Id = new Guid("d91ff562-6f81-4856-85ef-93f9f8e53d68"),
                            Brand = "Hyundai",
                            CreatedAt = new DateTime(2022, 10, 28, 22, 5, 44, 575, DateTimeKind.Local).AddTicks(4177),
                            Model = "Tucson",
                            Name = "T-GDI GLS ECOSHIFT",
                            Price = 13546546.99,
                            UrlImage = "https://images.kavak.services/images/197145/EXTERIOR-frontSidePilotNear-1659209409416.jpeg?d=756x434"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
