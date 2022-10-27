using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarCatalogAPI.Migrations
{
    public partial class UpdatePopulateDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Brand", "CreatedAt", "Model", "Name", "UrlImage" },
                values: new object[,]
                {
                    { new Guid("03909860-5262-4b65-9f20-aa17d3fc92ea"), "Hyundai", new DateTime(2022, 10, 27, 10, 38, 21, 770, DateTimeKind.Local).AddTicks(6106), "Tucson", "T-GDI GLS ECOSHIFT", "https://images.kavak.services/images/197145/EXTERIOR-frontSidePilotNear-1659209409416.jpeg?d=756x434" },
                    { new Guid("0e6ce2d9-92a8-4bc3-994c-5159753972ee"), "Sandero", new DateTime(2022, 10, 27, 10, 38, 21, 770, DateTimeKind.Local).AddTicks(6128), "Renault", "SCE STEPWAY EXPRESSION", "https://images.kavak.services/images/207112/EXTERIOR-frontSidePilotNear-1666216087267.jpeg?d=756x434" },
                    { new Guid("1819f30a-3b36-49dd-ac46-8e03ca7f1195"), "Honda", new DateTime(2022, 10, 27, 10, 38, 21, 770, DateTimeKind.Local).AddTicks(6115), "City", "EX", "https://images.kavak.services/images/207087/EXTERIOR-frontSidePilotNear-1666038248023.jpeg?d=756x434" },
                    { new Guid("1a9605a5-6f3e-4f3f-a0d8-1d594c2c4e3d"), "Sandero", new DateTime(2022, 10, 27, 10, 38, 21, 770, DateTimeKind.Local).AddTicks(6086), "Renault", "SCE STEPWAY EXPRESSION", "https://images.kavak.services/images/207112/EXTERIOR-frontSidePilotNear-1666216087267.jpeg?d=756x434" },
                    { new Guid("23d7b05b-fef0-4366-abf1-57cb062a22f2"), "Fox", new DateTime(2022, 10, 27, 10, 38, 21, 770, DateTimeKind.Local).AddTicks(6105), "Volkswagen", "MI", "https://images.kavak.services/images/199784/EXTERIOR-frontSidePilotNear-1660250648875.jpeg?d=756x434" },
                    { new Guid("2e713daa-b76f-425a-852e-583ac25f60b9"), "Honda", new DateTime(2022, 10, 27, 10, 38, 21, 770, DateTimeKind.Local).AddTicks(6120), "City", "EX", "https://images.kavak.services/images/207087/EXTERIOR-frontSidePilotNear-1666038248023.jpeg?d=756x434" },
                    { new Guid("3f893291-9a4a-4776-a5f1-477f863af66c"), "Hyundai", new DateTime(2022, 10, 27, 10, 38, 21, 770, DateTimeKind.Local).AddTicks(6126), "Tucson", "T-GDI GLS ECOSHIFT", "https://images.kavak.services/images/197145/EXTERIOR-frontSidePilotNear-1659209409416.jpeg?d=756x434" },
                    { new Guid("463599ba-ae70-4880-9a11-dc2a72768996"), "Sandero", new DateTime(2022, 10, 27, 10, 38, 21, 770, DateTimeKind.Local).AddTicks(6116), "Renault", "SCE STEPWAY EXPRESSION", "https://images.kavak.services/images/207112/EXTERIOR-frontSidePilotNear-1666216087267.jpeg?d=756x434" },
                    { new Guid("507ee7aa-5005-424d-956e-fe892d61be7e"), "Sandero", new DateTime(2022, 10, 27, 10, 38, 21, 770, DateTimeKind.Local).AddTicks(6121), "Renault", "SCE STEPWAY EXPRESSION", "https://images.kavak.services/images/207112/EXTERIOR-frontSidePilotNear-1666216087267.jpeg?d=756x434" },
                    { new Guid("5a400604-747c-4e03-ace8-015e26415b6d"), "Sandero", new DateTime(2022, 10, 27, 10, 38, 21, 770, DateTimeKind.Local).AddTicks(6109), "Renault", "SCE STEPWAY EXPRESSION", "https://images.kavak.services/images/207112/EXTERIOR-frontSidePilotNear-1666216087267.jpeg?d=756x434" },
                    { new Guid("5e5ecbeb-7198-4dd0-909c-dc9dd2d1ef5e"), "Fox", new DateTime(2022, 10, 27, 10, 38, 21, 770, DateTimeKind.Local).AddTicks(6110), "Volkswagen", "MI", "https://images.kavak.services/images/199784/EXTERIOR-frontSidePilotNear-1660250648875.jpeg?d=756x434" },
                    { new Guid("6d3748d7-dc10-4867-863e-7af50b6ee0f1"), "Hyundai", new DateTime(2022, 10, 27, 10, 38, 21, 770, DateTimeKind.Local).AddTicks(6119), "Tucson", "T-GDI GLS ECOSHIFT", "https://images.kavak.services/images/197145/EXTERIOR-frontSidePilotNear-1659209409416.jpeg?d=756x434" },
                    { new Guid("71230b56-5003-4784-ba46-eef4ec59757d"), "Fox", new DateTime(2022, 10, 27, 10, 38, 21, 770, DateTimeKind.Local).AddTicks(6088), "Volkswagen", "MI", "https://images.kavak.services/images/199784/EXTERIOR-frontSidePilotNear-1660250648875.jpeg?d=756x434" },
                    { new Guid("8835edc1-ede8-402a-974c-fc2aadecad78"), "Hyundai", new DateTime(2022, 10, 27, 10, 38, 21, 770, DateTimeKind.Local).AddTicks(6131), "Tucson", "T-GDI GLS ECOSHIFT", "https://images.kavak.services/images/197145/EXTERIOR-frontSidePilotNear-1659209409416.jpeg?d=756x434" },
                    { new Guid("8f2a84f8-85a0-4e47-9b68-27ee65d5b2c1"), "Sandero", new DateTime(2022, 10, 27, 10, 38, 21, 770, DateTimeKind.Local).AddTicks(6103), "Renault", "SCE STEPWAY EXPRESSION", "https://images.kavak.services/images/207112/EXTERIOR-frontSidePilotNear-1666216087267.jpeg?d=756x434" },
                    { new Guid("92756d61-90f9-4cc9-a6a8-a8944fb8b205"), "Fox", new DateTime(2022, 10, 27, 10, 38, 21, 770, DateTimeKind.Local).AddTicks(6122), "Volkswagen", "MI", "https://images.kavak.services/images/199784/EXTERIOR-frontSidePilotNear-1660250648875.jpeg?d=756x434" },
                    { new Guid("9d4e6be7-b6ef-4578-b545-cdaa8bb6abed"), "Honda", new DateTime(2022, 10, 27, 10, 38, 21, 770, DateTimeKind.Local).AddTicks(6127), "City", "EX", "https://images.kavak.services/images/207087/EXTERIOR-frontSidePilotNear-1666038248023.jpeg?d=756x434" },
                    { new Guid("a0ecc806-3eaa-4e8c-8be3-cacd8a4dac11"), "Honda", new DateTime(2022, 10, 27, 10, 38, 21, 770, DateTimeKind.Local).AddTicks(6075), "City", "EX", "https://images.kavak.services/images/207087/EXTERIOR-frontSidePilotNear-1666038248023.jpeg?d=756x434" },
                    { new Guid("a54d308f-d0ea-4c4f-8af2-447e4c659cd9"), "Honda", new DateTime(2022, 10, 27, 10, 38, 21, 770, DateTimeKind.Local).AddTicks(6102), "City", "EX", "https://images.kavak.services/images/207087/EXTERIOR-frontSidePilotNear-1666038248023.jpeg?d=756x434" },
                    { new Guid("b95054d8-cf7b-427a-88a6-40b2c6bbaddc"), "Hyundai", new DateTime(2022, 10, 27, 10, 38, 21, 770, DateTimeKind.Local).AddTicks(6114), "Tucson", "T-GDI GLS ECOSHIFT", "https://images.kavak.services/images/197145/EXTERIOR-frontSidePilotNear-1659209409416.jpeg?d=756x434" },
                    { new Guid("c1ac211c-50d3-4375-86e0-abbe71c46714"), "Hyundai", new DateTime(2022, 10, 27, 10, 38, 21, 770, DateTimeKind.Local).AddTicks(6100), "Tucson", "T-GDI GLS ECOSHIFT", "https://images.kavak.services/images/197145/EXTERIOR-frontSidePilotNear-1659209409416.jpeg?d=756x434" },
                    { new Guid("c930b5fe-0979-484d-9bd5-fa4ce3759b1f"), "Fox", new DateTime(2022, 10, 27, 10, 38, 21, 770, DateTimeKind.Local).AddTicks(6118), "Volkswagen", "MI", "https://images.kavak.services/images/199784/EXTERIOR-frontSidePilotNear-1660250648875.jpeg?d=756x434" },
                    { new Guid("da1ec7a8-bbd3-4bb8-8937-8cbf2bc75a1d"), "Honda", new DateTime(2022, 10, 27, 10, 38, 21, 770, DateTimeKind.Local).AddTicks(6107), "City", "EX", "https://images.kavak.services/images/207087/EXTERIOR-frontSidePilotNear-1666038248023.jpeg?d=756x434" },
                    { new Guid("f7d22a28-cb79-44b8-ae97-194fd3db2fa9"), "Fox", new DateTime(2022, 10, 27, 10, 38, 21, 770, DateTimeKind.Local).AddTicks(6129), "Volkswagen", "MI", "https://images.kavak.services/images/199784/EXTERIOR-frontSidePilotNear-1660250648875.jpeg?d=756x434" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("03909860-5262-4b65-9f20-aa17d3fc92ea"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("0e6ce2d9-92a8-4bc3-994c-5159753972ee"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("1819f30a-3b36-49dd-ac46-8e03ca7f1195"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("1a9605a5-6f3e-4f3f-a0d8-1d594c2c4e3d"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("23d7b05b-fef0-4366-abf1-57cb062a22f2"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("2e713daa-b76f-425a-852e-583ac25f60b9"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("3f893291-9a4a-4776-a5f1-477f863af66c"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("463599ba-ae70-4880-9a11-dc2a72768996"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("507ee7aa-5005-424d-956e-fe892d61be7e"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("5a400604-747c-4e03-ace8-015e26415b6d"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("5e5ecbeb-7198-4dd0-909c-dc9dd2d1ef5e"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("6d3748d7-dc10-4867-863e-7af50b6ee0f1"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("71230b56-5003-4784-ba46-eef4ec59757d"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("8835edc1-ede8-402a-974c-fc2aadecad78"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("8f2a84f8-85a0-4e47-9b68-27ee65d5b2c1"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("92756d61-90f9-4cc9-a6a8-a8944fb8b205"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("9d4e6be7-b6ef-4578-b545-cdaa8bb6abed"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("a0ecc806-3eaa-4e8c-8be3-cacd8a4dac11"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("a54d308f-d0ea-4c4f-8af2-447e4c659cd9"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("b95054d8-cf7b-427a-88a6-40b2c6bbaddc"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("c1ac211c-50d3-4375-86e0-abbe71c46714"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("c930b5fe-0979-484d-9bd5-fa4ce3759b1f"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("da1ec7a8-bbd3-4bb8-8937-8cbf2bc75a1d"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("f7d22a28-cb79-44b8-ae97-194fd3db2fa9"));

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
    }
}
