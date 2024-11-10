using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KickShop.Migrations
{
    /// <inheritdoc />
    public partial class AddedSoftDeleteToProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "Soft Delete Property");

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandId", "Country", "Name" },
                values: new object[,]
                {
                    { new Guid("290f0574-7b2a-4d21-bcfc-e438a52556ea"), "USA", "Everlast" },
                    { new Guid("b9c88443-9a16-474b-b986-26d085e408af"), "France", "Venum" },
                    { new Guid("e311e947-9041-4518-826f-636fbb5ad8f1"), "Germany", "Adidas" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { new Guid("a925f449-c1a2-46f0-b24e-318b5d10f4ce"), "/images/protective-gear-category.jpg", "Protective Gear" },
                    { new Guid("ed739c29-d90e-4ec0-9a17-be3a2ea76fc3"), "/images/gloves-category.jpg", "Gloves" },
                    { new Guid("fb46f256-0cb6-43c3-92c4-117cae0dcd06"), "/images/apparel-category.jpg", "Apparel" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "BrandId", "CategoryId", "Description", "ImageUrl", "IsDeleted", "Name", "Price", "Sizes", "StockQuantity" },
                values: new object[,]
                {
                    { new Guid("21bd88aa-8908-4039-9986-c81b1153f000"), new Guid("290f0574-7b2a-4d21-bcfc-e438a52556ea"), new Guid("fb46f256-0cb6-43c3-92c4-117cae0dcd06"), "Comfortable shorts designed for kickboxing training.", "/images/shorts.jpg", false, "Kickboxing Shorts", 29.99m, "[0,1,2,3]", 4 },
                    { new Guid("3b0c1a1b-62eb-4333-8560-e16b536ba9ed"), new Guid("b9c88443-9a16-474b-b986-26d085e408af"), new Guid("a925f449-c1a2-46f0-b24e-318b5d10f4ce"), "Essential mouth guard for protecting your teeth.", "/images/mouth-guard.jpg", false, "Mouth Guard", 12.99m, "[0,1,2,3]", 6 },
                    { new Guid("893b0a39-9a9a-4b7a-9bee-099ec8a8914e"), new Guid("290f0574-7b2a-4d21-bcfc-e438a52556ea"), new Guid("ed739c29-d90e-4ec0-9a17-be3a2ea76fc3"), "High-quality kickboxing gloves for training and competition.", "/images/gloves.jpg", false, "Kickboxing Gloves", 49.99m, "[0,1,2,3]", 5 },
                    { new Guid("98bf588d-929a-4a39-b69c-cf40b3b1a26c"), new Guid("b9c88443-9a16-474b-b986-26d085e408af"), new Guid("ed739c29-d90e-4ec0-9a17-be3a2ea76fc3"), "Durable shin guards for protection during sparring.", "/images/shin-guards.jpg", false, "Shin Guards", 35.99m, "[0,1,2,3]", 6 },
                    { new Guid("cf66fd8c-2f3d-47f1-ac0c-f04e02cbf06e"), new Guid("e311e947-9041-4518-826f-636fbb5ad8f1"), new Guid("a925f449-c1a2-46f0-b24e-318b5d10f4ce"), "Protective headgear for safety during training.", "/images/headgear.jpg", false, "Headgear", 59.99m, "[0,1,2,3]", 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("21bd88aa-8908-4039-9986-c81b1153f000"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("3b0c1a1b-62eb-4333-8560-e16b536ba9ed"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("893b0a39-9a9a-4b7a-9bee-099ec8a8914e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("98bf588d-929a-4a39-b69c-cf40b3b1a26c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("cf66fd8c-2f3d-47f1-ac0c-f04e02cbf06e"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("290f0574-7b2a-4d21-bcfc-e438a52556ea"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("b9c88443-9a16-474b-b986-26d085e408af"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("e311e947-9041-4518-826f-636fbb5ad8f1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("a925f449-c1a2-46f0-b24e-318b5d10f4ce"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ed739c29-d90e-4ec0-9a17-be3a2ea76fc3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("fb46f256-0cb6-43c3-92c4-117cae0dcd06"));

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Products");

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
    }
}
