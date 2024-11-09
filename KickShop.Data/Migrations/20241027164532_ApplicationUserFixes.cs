using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KickShop.Migrations
{
    /// <inheritdoc />
    public partial class ApplicationUserFixes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("8b5f1273-55b1-40af-a2c7-78f557b880de"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("9b6e954b-1657-4cc8-9cf4-6c7a4bb32c93"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d338cd76-2c8a-42c3-82ae-764f28944567"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f69aed43-394d-474f-b133-26ce8ed80bb7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("fa093b23-4406-47ed-ab80-6647c3e7fa96"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("0c92e8ce-9a02-4cae-b114-04491b15cb37"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("91361c91-345e-4427-a233-0b1d9db5e901"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("ef307b2f-bac3-4848-b440-62496f45839e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("6eae2a9f-a3aa-4b17-b043-5cdcc20577ff"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("aea04a01-71c5-484d-869b-c34fce4af5c0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f976a522-ac82-4409-9e76-427cf03c530a"));

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandId", "Country", "Name" },
                values: new object[,]
                {
                    { new Guid("2f29a8bb-a06b-4def-9cdd-9d464ddfcad1"), "USA", "Everlast" },
                    { new Guid("4949008e-7ba0-48df-9347-aae4867936c7"), "Germany", "Adidas" },
                    { new Guid("dfa3ca54-32fa-4c45-aa35-e6863e9ca76c"), "France", "Venum" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { new Guid("3f8f66a7-5c6d-4983-ad74-8dcc75945f27"), "/images/apparel-category.jpg", "Apparel" },
                    { new Guid("6001f938-c6c1-4def-ad9c-a3e45281bbdb"), "/images/protective-gear-category.jpg", "Protective Gear" },
                    { new Guid("6e2fbefe-bf81-4da3-98c7-9628016dfd61"), "/images/gloves-category.jpg", "Gloves" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "BrandId", "CategoryId", "Description", "ImageUrl", "Name", "Price", "Sizes", "StockQuantity" },
                values: new object[,]
                {
                    { new Guid("04cfdfcb-9790-456c-abb4-7aaf6e037573"), new Guid("4949008e-7ba0-48df-9347-aae4867936c7"), new Guid("6001f938-c6c1-4def-ad9c-a3e45281bbdb"), "Protective headgear for safety during training.", "/images/headgear.jpg", "Headgear", 59.99m, "[0,1,2,3]", 2 },
                    { new Guid("2533d885-0647-40e7-924a-5ceec911716c"), new Guid("dfa3ca54-32fa-4c45-aa35-e6863e9ca76c"), new Guid("6001f938-c6c1-4def-ad9c-a3e45281bbdb"), "Essential mouth guard for protecting your teeth.", "/images/mouth-guard.jpg", "Mouth Guard", 12.99m, "[0,1,2,3]", 6 },
                    { new Guid("301733be-a3ca-4137-9477-b5b95884b2b1"), new Guid("2f29a8bb-a06b-4def-9cdd-9d464ddfcad1"), new Guid("3f8f66a7-5c6d-4983-ad74-8dcc75945f27"), "Comfortable shorts designed for kickboxing training.", "/images/shorts.jpg", "Kickboxing Shorts", 29.99m, "[0,1,2,3]", 4 },
                    { new Guid("c58ca0a1-e18c-4c7f-a99c-769188c37264"), new Guid("2f29a8bb-a06b-4def-9cdd-9d464ddfcad1"), new Guid("6e2fbefe-bf81-4da3-98c7-9628016dfd61"), "High-quality kickboxing gloves for training and competition.", "/images/gloves.jpg", "Kickboxing Gloves", 49.99m, "[0,1,2,3]", 5 },
                    { new Guid("d476c971-89ac-4509-b07e-d5422818dc0b"), new Guid("dfa3ca54-32fa-4c45-aa35-e6863e9ca76c"), new Guid("6e2fbefe-bf81-4da3-98c7-9628016dfd61"), "Durable shin guards for protection during sparring.", "/images/shin-guards.jpg", "Shin Guards", 35.99m, "[0,1,2,3]", 6 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("04cfdfcb-9790-456c-abb4-7aaf6e037573"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("2533d885-0647-40e7-924a-5ceec911716c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("301733be-a3ca-4137-9477-b5b95884b2b1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c58ca0a1-e18c-4c7f-a99c-769188c37264"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d476c971-89ac-4509-b07e-d5422818dc0b"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("2f29a8bb-a06b-4def-9cdd-9d464ddfcad1"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("4949008e-7ba0-48df-9347-aae4867936c7"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("dfa3ca54-32fa-4c45-aa35-e6863e9ca76c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("3f8f66a7-5c6d-4983-ad74-8dcc75945f27"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("6001f938-c6c1-4def-ad9c-a3e45281bbdb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("6e2fbefe-bf81-4da3-98c7-9628016dfd61"));

            migrationBuilder.DropColumn(
                name: "Image",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandId", "Country", "Name" },
                values: new object[,]
                {
                    { new Guid("0c92e8ce-9a02-4cae-b114-04491b15cb37"), "USA", "Everlast" },
                    { new Guid("91361c91-345e-4427-a233-0b1d9db5e901"), "Germany", "Adidas" },
                    { new Guid("ef307b2f-bac3-4848-b440-62496f45839e"), "France", "Venum" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { new Guid("6eae2a9f-a3aa-4b17-b043-5cdcc20577ff"), "/images/gloves-category.jpg", "Gloves" },
                    { new Guid("aea04a01-71c5-484d-869b-c34fce4af5c0"), "/images/apparel-category.jpg", "Apparel" },
                    { new Guid("f976a522-ac82-4409-9e76-427cf03c530a"), "/images/protective-gear-category.jpg", "Protective Gear" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "BrandId", "CategoryId", "Description", "ImageUrl", "Name", "Price", "Sizes", "StockQuantity" },
                values: new object[,]
                {
                    { new Guid("8b5f1273-55b1-40af-a2c7-78f557b880de"), new Guid("ef307b2f-bac3-4848-b440-62496f45839e"), new Guid("f976a522-ac82-4409-9e76-427cf03c530a"), "Essential mouth guard for protecting your teeth.", "/images/mouth-guard.jpg", "Mouth Guard", 12.99m, "[0,1,2,3]", 6 },
                    { new Guid("9b6e954b-1657-4cc8-9cf4-6c7a4bb32c93"), new Guid("ef307b2f-bac3-4848-b440-62496f45839e"), new Guid("6eae2a9f-a3aa-4b17-b043-5cdcc20577ff"), "Durable shin guards for protection during sparring.", "/images/shin-guards.jpg", "Shin Guards", 35.99m, "[0,1,2,3]", 6 },
                    { new Guid("d338cd76-2c8a-42c3-82ae-764f28944567"), new Guid("0c92e8ce-9a02-4cae-b114-04491b15cb37"), new Guid("aea04a01-71c5-484d-869b-c34fce4af5c0"), "Comfortable shorts designed for kickboxing training.", "/images/shorts.jpg", "Kickboxing Shorts", 29.99m, "[0,1,2,3]", 4 },
                    { new Guid("f69aed43-394d-474f-b133-26ce8ed80bb7"), new Guid("0c92e8ce-9a02-4cae-b114-04491b15cb37"), new Guid("6eae2a9f-a3aa-4b17-b043-5cdcc20577ff"), "High-quality kickboxing gloves for training and competition.", "/images/gloves.jpg", "Kickboxing Gloves", 49.99m, "[0,1,2,3]", 5 },
                    { new Guid("fa093b23-4406-47ed-ab80-6647c3e7fa96"), new Guid("91361c91-345e-4427-a233-0b1d9db5e901"), new Guid("f976a522-ac82-4409-9e76-427cf03c530a"), "Protective headgear for safety during training.", "/images/headgear.jpg", "Headgear", 59.99m, "[0,1,2,3]", 2 }
                });
        }
    }
}
