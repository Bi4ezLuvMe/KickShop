using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KickShop.Migrations
{
    /// <inheritdoc />
    public partial class ApplicationUserImageUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("3a75ab89-c959-4cad-8485-dcfc9a044a01"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("435f522b-7750-44f0-8dda-d74629427649"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("72675002-8534-4774-9ee6-8e5f729aece5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a6e7e1ff-75ca-4a25-83db-5fa08d6e064c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("bf005e8b-217d-4213-bd9c-497fbbc66d7b"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("10fc2f80-c63b-4c0c-bfc7-472b4f4af4e8"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("6e5dd27c-e9a8-4cfd-9e7d-ad63b8215f60"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("f875996a-d95b-4539-a0af-843b85d50ac3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("9374212f-7d1d-4be1-b05d-9b2de9c43f49"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("9c37c417-9dd6-44d0-a2cf-aa76762e3161"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("dc2f95f0-793c-45b7-95f5-cfc2ebbfb418"));

            migrationBuilder.DropColumn(
                name: "ImageUrl",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "ImageUrl",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandId", "Country", "Name" },
                values: new object[,]
                {
                    { new Guid("10fc2f80-c63b-4c0c-bfc7-472b4f4af4e8"), "USA", "Everlast" },
                    { new Guid("6e5dd27c-e9a8-4cfd-9e7d-ad63b8215f60"), "Germany", "Adidas" },
                    { new Guid("f875996a-d95b-4539-a0af-843b85d50ac3"), "France", "Venum" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { new Guid("9374212f-7d1d-4be1-b05d-9b2de9c43f49"), "/images/protective-gear-category.jpg", "Protective Gear" },
                    { new Guid("9c37c417-9dd6-44d0-a2cf-aa76762e3161"), "/images/apparel-category.jpg", "Apparel" },
                    { new Guid("dc2f95f0-793c-45b7-95f5-cfc2ebbfb418"), "/images/gloves-category.jpg", "Gloves" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "BrandId", "CategoryId", "Description", "ImageUrl", "Name", "Price", "Sizes", "StockQuantity" },
                values: new object[,]
                {
                    { new Guid("3a75ab89-c959-4cad-8485-dcfc9a044a01"), new Guid("f875996a-d95b-4539-a0af-843b85d50ac3"), new Guid("dc2f95f0-793c-45b7-95f5-cfc2ebbfb418"), "Durable shin guards for protection during sparring.", "/images/shin-guards.jpg", "Shin Guards", 35.99m, "[0,1,2,3]", 6 },
                    { new Guid("435f522b-7750-44f0-8dda-d74629427649"), new Guid("10fc2f80-c63b-4c0c-bfc7-472b4f4af4e8"), new Guid("dc2f95f0-793c-45b7-95f5-cfc2ebbfb418"), "High-quality kickboxing gloves for training and competition.", "/images/gloves.jpg", "Kickboxing Gloves", 49.99m, "[0,1,2,3]", 5 },
                    { new Guid("72675002-8534-4774-9ee6-8e5f729aece5"), new Guid("f875996a-d95b-4539-a0af-843b85d50ac3"), new Guid("9374212f-7d1d-4be1-b05d-9b2de9c43f49"), "Essential mouth guard for protecting your teeth.", "/images/mouth-guard.jpg", "Mouth Guard", 12.99m, "[0,1,2,3]", 6 },
                    { new Guid("a6e7e1ff-75ca-4a25-83db-5fa08d6e064c"), new Guid("6e5dd27c-e9a8-4cfd-9e7d-ad63b8215f60"), new Guid("9374212f-7d1d-4be1-b05d-9b2de9c43f49"), "Protective headgear for safety during training.", "/images/headgear.jpg", "Headgear", 59.99m, "[0,1,2,3]", 2 },
                    { new Guid("bf005e8b-217d-4213-bd9c-497fbbc66d7b"), new Guid("10fc2f80-c63b-4c0c-bfc7-472b4f4af4e8"), new Guid("9c37c417-9dd6-44d0-a2cf-aa76762e3161"), "Comfortable shorts designed for kickboxing training.", "/images/shorts.jpg", "Kickboxing Shorts", 29.99m, "[0,1,2,3]", 4 }
                });
        }
    }
}
