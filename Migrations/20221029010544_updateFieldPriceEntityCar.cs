using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarCatalogAPI.Migrations
{
    public partial class updateFieldPriceEntityCar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Brand", "CreatedAt", "Model", "Name", "Price", "UrlImage" },
                values: new object[,]
                {
                    { new Guid("20726a46-02c3-4bce-9583-178ffa108db7"), "Hyundai", new DateTime(2022, 10, 28, 22, 5, 44, 575, DateTimeKind.Local).AddTicks(4099), "Tucson", "T-GDI GLS ECOSHIFT", 1359864.99, "https://images.kavak.services/images/197145/EXTERIOR-frontSidePilotNear-1659209409416.jpeg?d=756x434" },
                    { new Guid("238fc273-b58a-4b53-a403-7956dcfd5f96"), "Honda", new DateTime(2022, 10, 28, 22, 5, 44, 575, DateTimeKind.Local).AddTicks(4166), "City", "EX", 13155454.99, "https://images.kavak.services/images/207087/EXTERIOR-frontSidePilotNear-1666038248023.jpeg?d=756x434" },
                    { new Guid("254ebadd-ca36-495c-a239-f35080ad6b28"), "Hyundai", new DateTime(2022, 10, 28, 22, 5, 44, 575, DateTimeKind.Local).AddTicks(4164), "Tucson", "T-GDI GLS ECOSHIFT", 13588984.99, "https://images.kavak.services/images/197145/EXTERIOR-frontSidePilotNear-1659209409416.jpeg?d=756x434" },
                    { new Guid("2d2f973f-7aaf-4d9d-b952-fbe54949c280"), "Sandero", new DateTime(2022, 10, 28, 22, 5, 44, 575, DateTimeKind.Local).AddTicks(4174), "Renault", "SCE STEPWAY EXPRESSION", 13684654.99, "https://images.kavak.services/images/207112/EXTERIOR-frontSidePilotNear-1666216087267.jpeg?d=756x434" },
                    { new Guid("4102d309-e790-4c9a-8d1f-be452943bde8"), "Honda", new DateTime(2022, 10, 28, 22, 5, 44, 575, DateTimeKind.Local).AddTicks(4160), "City", "EX", 135974.98999999999, "https://images.kavak.services/images/207087/EXTERIOR-frontSidePilotNear-1666038248023.jpeg?d=756x434" },
                    { new Guid("44ababab-7e4e-4cf1-9cef-5961ac86863c"), "Sandero", new DateTime(2022, 10, 28, 22, 5, 44, 575, DateTimeKind.Local).AddTicks(4167), "Renault", "SCE STEPWAY EXPRESSION", 13683554.99, "https://images.kavak.services/images/207112/EXTERIOR-frontSidePilotNear-1666216087267.jpeg?d=756x434" },
                    { new Guid("573c24bb-3ffb-4e7e-adb2-5e442e255650"), "Fox", new DateTime(2022, 10, 28, 22, 5, 44, 575, DateTimeKind.Local).AddTicks(4168), "Volkswagen", "MI", 1386554.99, "https://images.kavak.services/images/199784/EXTERIOR-frontSidePilotNear-1660250648875.jpeg?d=756x434" },
                    { new Guid("5bee15c4-b1af-461b-b58b-38f1fbf836c6"), "Honda", new DateTime(2022, 10, 28, 22, 5, 44, 575, DateTimeKind.Local).AddTicks(4173), "City", "EX", 1354.99, "https://images.kavak.services/images/207087/EXTERIOR-frontSidePilotNear-1666038248023.jpeg?d=756x434" },
                    { new Guid("6a4306e2-274f-4c68-b743-780473a5683d"), "Fox", new DateTime(2022, 10, 28, 22, 5, 44, 575, DateTimeKind.Local).AddTicks(4154), "Volkswagen", "MI", 13568464.99, "https://images.kavak.services/images/199784/EXTERIOR-frontSidePilotNear-1660250648875.jpeg?d=756x434" },
                    { new Guid("6a92a22b-58a0-4097-9dc9-960616ee9bdc"), "Honda", new DateTime(2022, 10, 28, 22, 5, 44, 575, DateTimeKind.Local).AddTicks(4069), "City", "EX", 1354.99, "https://images.kavak.services/images/207087/EXTERIOR-frontSidePilotNear-1666038248023.jpeg?d=756x434" },
                    { new Guid("76126647-32ea-4639-9ec5-86ded748a341"), "Fox", new DateTime(2022, 10, 28, 22, 5, 44, 575, DateTimeKind.Local).AddTicks(4080), "Volkswagen", "MI", 44354.989999999998, "https://images.kavak.services/images/199784/EXTERIOR-frontSidePilotNear-1660250648875.jpeg?d=756x434" },
                    { new Guid("7d11c1db-2f91-4523-a9fc-69ff973574d5"), "Honda", new DateTime(2022, 10, 28, 22, 5, 44, 575, DateTimeKind.Local).AddTicks(4101), "City", "EX", 13984654.99, "https://images.kavak.services/images/207087/EXTERIOR-frontSidePilotNear-1666038248023.jpeg?d=756x434" },
                    { new Guid("7d23a96f-f6b4-4838-a4db-c117affdc1c1"), "Fox", new DateTime(2022, 10, 28, 22, 5, 44, 575, DateTimeKind.Local).AddTicks(4176), "Volkswagen", "MI", 13584654.99, "https://images.kavak.services/images/199784/EXTERIOR-frontSidePilotNear-1660250648875.jpeg?d=756x434" },
                    { new Guid("7eb937fe-11c2-41d3-8064-dc50f7fb387c"), "Sandero", new DateTime(2022, 10, 28, 22, 5, 44, 575, DateTimeKind.Local).AddTicks(4079), "Renault", "SCE STEPWAY EXPRESSION", 1354.99, "https://images.kavak.services/images/207112/EXTERIOR-frontSidePilotNear-1666216087267.jpeg?d=756x434" },
                    { new Guid("84138e79-7342-449b-9cfd-d2fb75504556"), "Honda", new DateTime(2022, 10, 28, 22, 5, 44, 575, DateTimeKind.Local).AddTicks(4095), "City", "EX", 1354058.99, "https://images.kavak.services/images/207087/EXTERIOR-frontSidePilotNear-1666038248023.jpeg?d=756x434" },
                    { new Guid("85a2b187-d568-4237-8e10-12b6864425f8"), "Sandero", new DateTime(2022, 10, 28, 22, 5, 44, 575, DateTimeKind.Local).AddTicks(4096), "Renault", "SCE STEPWAY EXPRESSION", 135454.98999999999, "https://images.kavak.services/images/207112/EXTERIOR-frontSidePilotNear-1666216087267.jpeg?d=756x434" },
                    { new Guid("87547095-45f3-4d9b-917c-329cf596c013"), "Fox", new DateTime(2022, 10, 28, 22, 5, 44, 575, DateTimeKind.Local).AddTicks(4098), "Volkswagen", "MI", 1359844.99, "https://images.kavak.services/images/199784/EXTERIOR-frontSidePilotNear-1660250648875.jpeg?d=756x434" },
                    { new Guid("91ed367b-c849-4181-8f13-83cea557a9c9"), "Hyundai", new DateTime(2022, 10, 28, 22, 5, 44, 575, DateTimeKind.Local).AddTicks(4082), "Tucson", "T-GDI GLS ECOSHIFT", 188954.98999999999, "https://images.kavak.services/images/197145/EXTERIOR-frontSidePilotNear-1659209409416.jpeg?d=756x434" },
                    { new Guid("95d48961-9ede-4476-b75e-1be304bb6362"), "Hyundai", new DateTime(2022, 10, 28, 22, 5, 44, 575, DateTimeKind.Local).AddTicks(4156), "Tucson", "T-GDI GLS ECOSHIFT", 1356854.99, "https://images.kavak.services/images/197145/EXTERIOR-frontSidePilotNear-1659209409416.jpeg?d=756x434" },
                    { new Guid("bc79fa9e-b2a8-4fcf-b68f-ebac87a0ad58"), "Fox", new DateTime(2022, 10, 28, 22, 5, 44, 575, DateTimeKind.Local).AddTicks(4163), "Volkswagen", "MI", 13884654.99, "https://images.kavak.services/images/199784/EXTERIOR-frontSidePilotNear-1660250648875.jpeg?d=756x434" },
                    { new Guid("c5d3d152-4b36-469d-9447-765ff45dc108"), "Sandero", new DateTime(2022, 10, 28, 22, 5, 44, 575, DateTimeKind.Local).AddTicks(4161), "Renault", "SCE STEPWAY EXPRESSION", 9991354.9900000002, "https://images.kavak.services/images/207112/EXTERIOR-frontSidePilotNear-1666216087267.jpeg?d=756x434" },
                    { new Guid("d78530bc-d791-49ef-9e7e-0ab1d4dfe975"), "Sandero", new DateTime(2022, 10, 28, 22, 5, 44, 575, DateTimeKind.Local).AddTicks(4102), "Renault", "SCE STEPWAY EXPRESSION", 13568464.99, "https://images.kavak.services/images/207112/EXTERIOR-frontSidePilotNear-1666216087267.jpeg?d=756x434" },
                    { new Guid("d91ff562-6f81-4856-85ef-93f9f8e53d68"), "Hyundai", new DateTime(2022, 10, 28, 22, 5, 44, 575, DateTimeKind.Local).AddTicks(4177), "Tucson", "T-GDI GLS ECOSHIFT", 13546546.99, "https://images.kavak.services/images/197145/EXTERIOR-frontSidePilotNear-1659209409416.jpeg?d=756x434" },
                    { new Guid("daa41667-1fb4-4e5f-921f-ad2239dc38fe"), "Hyundai", new DateTime(2022, 10, 28, 22, 5, 44, 575, DateTimeKind.Local).AddTicks(4170), "Tucson", "T-GDI GLS ECOSHIFT", 169846354.99000001, "https://images.kavak.services/images/197145/EXTERIOR-frontSidePilotNear-1659209409416.jpeg?d=756x434" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("20726a46-02c3-4bce-9583-178ffa108db7"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("238fc273-b58a-4b53-a403-7956dcfd5f96"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("254ebadd-ca36-495c-a239-f35080ad6b28"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("2d2f973f-7aaf-4d9d-b952-fbe54949c280"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("4102d309-e790-4c9a-8d1f-be452943bde8"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("44ababab-7e4e-4cf1-9cef-5961ac86863c"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("573c24bb-3ffb-4e7e-adb2-5e442e255650"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("5bee15c4-b1af-461b-b58b-38f1fbf836c6"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("6a4306e2-274f-4c68-b743-780473a5683d"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("6a92a22b-58a0-4097-9dc9-960616ee9bdc"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("76126647-32ea-4639-9ec5-86ded748a341"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("7d11c1db-2f91-4523-a9fc-69ff973574d5"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("7d23a96f-f6b4-4838-a4db-c117affdc1c1"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("7eb937fe-11c2-41d3-8064-dc50f7fb387c"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("84138e79-7342-449b-9cfd-d2fb75504556"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("85a2b187-d568-4237-8e10-12b6864425f8"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("87547095-45f3-4d9b-917c-329cf596c013"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("91ed367b-c849-4181-8f13-83cea557a9c9"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("95d48961-9ede-4476-b75e-1be304bb6362"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("bc79fa9e-b2a8-4fcf-b68f-ebac87a0ad58"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("c5d3d152-4b36-469d-9447-765ff45dc108"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("d78530bc-d791-49ef-9e7e-0ab1d4dfe975"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("d91ff562-6f81-4856-85ef-93f9f8e53d68"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("daa41667-1fb4-4e5f-921f-ad2239dc38fe"));

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
    }
}
