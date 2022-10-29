using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarCatalogAPI.Migrations
{
    public partial class addFieldPriceEntityCar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Cars",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Brand", "CreatedAt", "Model", "Name", "Price", "UrlImage" },
                values: new object[,]
                {
                    { new Guid("0e3de54e-17a4-429a-8ff5-ebba4ca4880e"), "Hyundai", new DateTime(2022, 10, 28, 21, 44, 43, 756, DateTimeKind.Local).AddTicks(7098), "Tucson", "T-GDI GLS ECOSHIFT", 1354.99, "https://images.kavak.services/images/197145/EXTERIOR-frontSidePilotNear-1659209409416.jpeg?d=756x434" },
                    { new Guid("0e91d281-1533-461f-ab1a-41f9ef9fcb3d"), "Honda", new DateTime(2022, 10, 28, 21, 44, 43, 756, DateTimeKind.Local).AddTicks(7089), "City", "EX", 1354.99, "https://images.kavak.services/images/207087/EXTERIOR-frontSidePilotNear-1666038248023.jpeg?d=756x434" },
                    { new Guid("129f7af3-b7cd-4ba1-9c96-4ca56dd139e4"), "Sandero", new DateTime(2022, 10, 28, 21, 44, 43, 756, DateTimeKind.Local).AddTicks(7103), "Renault", "SCE STEPWAY EXPRESSION", 1354.99, "https://images.kavak.services/images/207112/EXTERIOR-frontSidePilotNear-1666216087267.jpeg?d=756x434" },
                    { new Guid("15eb04a2-4feb-49ec-a171-b26c00a9b64f"), "Hyundai", new DateTime(2022, 10, 28, 21, 44, 43, 756, DateTimeKind.Local).AddTicks(7080), "Tucson", "T-GDI GLS ECOSHIFT", 1354.99, "https://images.kavak.services/images/197145/EXTERIOR-frontSidePilotNear-1659209409416.jpeg?d=756x434" },
                    { new Guid("278a9d7b-af4c-458f-8828-6c4efeff3d4d"), "Honda", new DateTime(2022, 10, 28, 21, 44, 43, 756, DateTimeKind.Local).AddTicks(7081), "City", "EX", 1354.99, "https://images.kavak.services/images/207087/EXTERIOR-frontSidePilotNear-1666038248023.jpeg?d=756x434" },
                    { new Guid("2c08bd3e-bc74-4449-a750-d2d790e9fbaa"), "Sandero", new DateTime(2022, 10, 28, 21, 44, 43, 756, DateTimeKind.Local).AddTicks(7083), "Renault", "SCE STEPWAY EXPRESSION", 1354.99, "https://images.kavak.services/images/207112/EXTERIOR-frontSidePilotNear-1666216087267.jpeg?d=756x434" },
                    { new Guid("2ddbabe2-94f6-42b3-8a0f-5f692404d4e7"), "Sandero", new DateTime(2022, 10, 28, 21, 44, 43, 756, DateTimeKind.Local).AddTicks(7108), "Renault", "SCE STEPWAY EXPRESSION", 1354.99, "https://images.kavak.services/images/207112/EXTERIOR-frontSidePilotNear-1666216087267.jpeg?d=756x434" },
                    { new Guid("3b699324-b499-4952-b6ee-81306b7a0941"), "Fox", new DateTime(2022, 10, 28, 21, 44, 43, 756, DateTimeKind.Local).AddTicks(7092), "Volkswagen", "MI", 1354.99, "https://images.kavak.services/images/199784/EXTERIOR-frontSidePilotNear-1660250648875.jpeg?d=756x434" },
                    { new Guid("485dbe67-a62f-4ea6-a07e-a9f848da6474"), "Fox", new DateTime(2022, 10, 28, 21, 44, 43, 756, DateTimeKind.Local).AddTicks(7084), "Volkswagen", "MI", 1354.99, "https://images.kavak.services/images/199784/EXTERIOR-frontSidePilotNear-1660250648875.jpeg?d=756x434" },
                    { new Guid("4c465de4-9711-4077-a02a-067e7c14c329"), "Honda", new DateTime(2022, 10, 28, 21, 44, 43, 756, DateTimeKind.Local).AddTicks(7066), "City", "EX", 1354.99, "https://images.kavak.services/images/207087/EXTERIOR-frontSidePilotNear-1666038248023.jpeg?d=756x434" },
                    { new Guid("5dbff9c7-f08e-4a43-9ac2-3c1f4f1b9584"), "Fox", new DateTime(2022, 10, 28, 21, 44, 43, 756, DateTimeKind.Local).AddTicks(7078), "Volkswagen", "MI", 1354.99, "https://images.kavak.services/images/199784/EXTERIOR-frontSidePilotNear-1660250648875.jpeg?d=756x434" },
                    { new Guid("6baeb43a-ff3f-4b99-b422-beead5ed5d93"), "Sandero", new DateTime(2022, 10, 28, 21, 44, 43, 756, DateTimeKind.Local).AddTicks(7091), "Renault", "SCE STEPWAY EXPRESSION", 1354.99, "https://images.kavak.services/images/207112/EXTERIOR-frontSidePilotNear-1666216087267.jpeg?d=756x434" },
                    { new Guid("7644d1a8-39dc-4da7-ba81-8439d92c2292"), "Hyundai", new DateTime(2022, 10, 28, 21, 44, 43, 756, DateTimeKind.Local).AddTicks(7093), "Tucson", "T-GDI GLS ECOSHIFT", 1354.99, "https://images.kavak.services/images/197145/EXTERIOR-frontSidePilotNear-1659209409416.jpeg?d=756x434" },
                    { new Guid("76cd1c8e-8407-47a6-8341-e53ffc1fafd6"), "Honda", new DateTime(2022, 10, 28, 21, 44, 43, 756, DateTimeKind.Local).AddTicks(7094), "City", "EX", 1354.99, "https://images.kavak.services/images/207087/EXTERIOR-frontSidePilotNear-1666038248023.jpeg?d=756x434" },
                    { new Guid("81f71ec7-7408-4eda-b4fa-d2ff41eedc0d"), "Sandero", new DateTime(2022, 10, 28, 21, 44, 43, 756, DateTimeKind.Local).AddTicks(7096), "Renault", "SCE STEPWAY EXPRESSION", 1354.99, "https://images.kavak.services/images/207112/EXTERIOR-frontSidePilotNear-1666216087267.jpeg?d=756x434" },
                    { new Guid("82eef636-eca7-4565-aeb5-e333e78bfa16"), "Sandero", new DateTime(2022, 10, 28, 21, 44, 43, 756, DateTimeKind.Local).AddTicks(7077), "Renault", "SCE STEPWAY EXPRESSION", 1354.99, "https://images.kavak.services/images/207112/EXTERIOR-frontSidePilotNear-1666216087267.jpeg?d=756x434" },
                    { new Guid("c03e0d90-dfbf-4b2d-aeba-83a166a48365"), "Honda", new DateTime(2022, 10, 28, 21, 44, 43, 756, DateTimeKind.Local).AddTicks(7102), "City", "EX", 1354.99, "https://images.kavak.services/images/207087/EXTERIOR-frontSidePilotNear-1666038248023.jpeg?d=756x434" },
                    { new Guid("cb278d25-0d2d-48dc-b802-4fa45c5cf2c5"), "Hyundai", new DateTime(2022, 10, 28, 21, 44, 43, 756, DateTimeKind.Local).AddTicks(7085), "Tucson", "T-GDI GLS ECOSHIFT", 1354.99, "https://images.kavak.services/images/197145/EXTERIOR-frontSidePilotNear-1659209409416.jpeg?d=756x434" },
                    { new Guid("cf76beed-be0c-49ee-86cf-816fced70835"), "Fox", new DateTime(2022, 10, 28, 21, 44, 43, 756, DateTimeKind.Local).AddTicks(7110), "Volkswagen", "MI", 1354.99, "https://images.kavak.services/images/199784/EXTERIOR-frontSidePilotNear-1660250648875.jpeg?d=756x434" },
                    { new Guid("e26f224b-51c0-4852-b8f8-3ac3986233ad"), "Fox", new DateTime(2022, 10, 28, 21, 44, 43, 756, DateTimeKind.Local).AddTicks(7104), "Volkswagen", "MI", 1354.99, "https://images.kavak.services/images/199784/EXTERIOR-frontSidePilotNear-1660250648875.jpeg?d=756x434" },
                    { new Guid("e7452952-1aa4-4102-835e-57875099c5e1"), "Hyundai", new DateTime(2022, 10, 28, 21, 44, 43, 756, DateTimeKind.Local).AddTicks(7111), "Tucson", "T-GDI GLS ECOSHIFT", 1354.99, "https://images.kavak.services/images/197145/EXTERIOR-frontSidePilotNear-1659209409416.jpeg?d=756x434" },
                    { new Guid("eaaa9e47-67d2-4a21-b2eb-34ce1edea315"), "Hyundai", new DateTime(2022, 10, 28, 21, 44, 43, 756, DateTimeKind.Local).AddTicks(7106), "Tucson", "T-GDI GLS ECOSHIFT", 1354.99, "https://images.kavak.services/images/197145/EXTERIOR-frontSidePilotNear-1659209409416.jpeg?d=756x434" },
                    { new Guid("f68ea4cc-cde2-43fc-bee1-7750d0435030"), "Fox", new DateTime(2022, 10, 28, 21, 44, 43, 756, DateTimeKind.Local).AddTicks(7097), "Volkswagen", "MI", 1354.99, "https://images.kavak.services/images/199784/EXTERIOR-frontSidePilotNear-1660250648875.jpeg?d=756x434" },
                    { new Guid("f9394146-3937-4c16-972f-40f5a2bb1802"), "Honda", new DateTime(2022, 10, 28, 21, 44, 43, 756, DateTimeKind.Local).AddTicks(7107), "City", "EX", 1354.99, "https://images.kavak.services/images/207087/EXTERIOR-frontSidePilotNear-1666038248023.jpeg?d=756x434" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("0e3de54e-17a4-429a-8ff5-ebba4ca4880e"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("0e91d281-1533-461f-ab1a-41f9ef9fcb3d"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("129f7af3-b7cd-4ba1-9c96-4ca56dd139e4"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("15eb04a2-4feb-49ec-a171-b26c00a9b64f"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("278a9d7b-af4c-458f-8828-6c4efeff3d4d"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("2c08bd3e-bc74-4449-a750-d2d790e9fbaa"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("2ddbabe2-94f6-42b3-8a0f-5f692404d4e7"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("3b699324-b499-4952-b6ee-81306b7a0941"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("485dbe67-a62f-4ea6-a07e-a9f848da6474"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("4c465de4-9711-4077-a02a-067e7c14c329"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("5dbff9c7-f08e-4a43-9ac2-3c1f4f1b9584"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("6baeb43a-ff3f-4b99-b422-beead5ed5d93"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("7644d1a8-39dc-4da7-ba81-8439d92c2292"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("76cd1c8e-8407-47a6-8341-e53ffc1fafd6"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("81f71ec7-7408-4eda-b4fa-d2ff41eedc0d"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("82eef636-eca7-4565-aeb5-e333e78bfa16"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("c03e0d90-dfbf-4b2d-aeba-83a166a48365"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("cb278d25-0d2d-48dc-b802-4fa45c5cf2c5"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("cf76beed-be0c-49ee-86cf-816fced70835"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("e26f224b-51c0-4852-b8f8-3ac3986233ad"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("e7452952-1aa4-4102-835e-57875099c5e1"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("eaaa9e47-67d2-4a21-b2eb-34ce1edea315"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("f68ea4cc-cde2-43fc-bee1-7750d0435030"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("f9394146-3937-4c16-972f-40f5a2bb1802"));

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Cars");

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
    }
}
