using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarCatalogAPI.Migrations
{
    public partial class SeedDataCar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Brand", "CreatedAt", "Model", "Name", "UrlImage" },
                values: new object[,]
                {
                    { new Guid("004ee614-a662-44b1-b2c0-8b255c341006"), "Fox", new DateTime(2022, 10, 26, 10, 16, 57, 650, DateTimeKind.Local).AddTicks(3238), "Volkswagen", "MI", "https://images.kavak.services/images/199784/EXTERIOR-frontSidePilotNear-1660250648875.jpeg?d=756x434" },
                    { new Guid("60bcb243-65c6-4741-a6d9-3a44f11c79d1"), "Honda", new DateTime(2022, 10, 26, 10, 16, 57, 650, DateTimeKind.Local).AddTicks(3225), "City", "EX", "https://images.kavak.services/images/207087/EXTERIOR-frontSidePilotNear-1666038248023.jpeg?d=756x434" },
                    { new Guid("6ea4d159-db2c-4484-8557-9f365e52bb37"), "Sandero", new DateTime(2022, 10, 26, 10, 16, 57, 650, DateTimeKind.Local).AddTicks(3236), "Renault", "SCE STEPWAY EXPRESSION", "https://images.kavak.services/images/207112/EXTERIOR-frontSidePilotNear-1666216087267.jpeg?d=756x434" },
                    { new Guid("9b7532e7-ad06-4205-8bc7-05838ac3f93b"), "Hyundai", new DateTime(2022, 10, 26, 10, 16, 57, 650, DateTimeKind.Local).AddTicks(3239), "Tucson", "T-GDI GLS ECOSHIFT", "https://images.kavak.services/images/197145/EXTERIOR-frontSidePilotNear-1659209409416.jpeg?d=756x434" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("004ee614-a662-44b1-b2c0-8b255c341006"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("60bcb243-65c6-4741-a6d9-3a44f11c79d1"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("6ea4d159-db2c-4484-8557-9f365e52bb37"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("9b7532e7-ad06-4205-8bc7-05838ac3f93b"));
        }
    }
}
