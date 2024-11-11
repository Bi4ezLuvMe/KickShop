using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KickShop.Migrations
{
    /// <inheritdoc />
    public partial class AddedIsDeletedPropertyToBrandAndCategoryAndAddedImagesToBrandAndCategoryModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Products",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                comment: "URL To The Product Image",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldComment: "URL To The Product Image");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Categories",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                comment: "Image For The Category",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldComment: "Image For The Category");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Categories",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "Soft Delete Property");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Brands",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                comment: "The Address Of The Brand");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Brands",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                comment: "The Image Of The Brand");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Brands",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "Soft Delete Property");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Brands",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                comment: "The Phone Number Of The Brand");

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandId", "Address", "Country", "ImageUrl", "IsDeleted", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("0aeb1752-e356-4934-a55b-f2e279b68bab"), "Las Vegas,Nevada", "France", "Venum-Logo.png", false, "Venum", "1-888-200-5032" },
                    { new Guid("8da67b86-e855-40f0-846f-bc7bd1a57b35"), "Everlast Canada c/o ACI Brands Inc. 2616 Sheridan Garden Drive Oakville, ON L6J 7Z2", "USA", "Everlast-Logo.png", false, "Everlast", "1-800-668-5593" },
                    { new Guid("c25077e7-3cd4-4491-a9b4-19d23802026a"), "Adi-Dassler-Strasse 1 91074 Herzogenaurach, Germany", "Germany", "Adidas-Logo.png", false, "Adidas", "+49 9132 84 0" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "ImageUrl", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { new Guid("25843867-fead-46ef-bb13-1b15d2fc7393"), "/images/protective-gear-category.jpg", false, "Protective Gear" },
                    { new Guid("43c9094e-c5b0-4d28-90e8-ef959556803e"), "/images/apparel-category.jpg", false, "Apparel" },
                    { new Guid("50eca588-3281-4991-acbc-447ed3492c52"), "/images/gloves-category.jpg", false, "Gloves" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "BrandId", "CategoryId", "Description", "ImageUrl", "IsDeleted", "Name", "Price", "Sizes", "StockQuantity" },
                values: new object[,]
                {
                    { new Guid("4ae180ab-e5ab-4b3e-b105-d6fc984612af"), new Guid("0aeb1752-e356-4934-a55b-f2e279b68bab"), new Guid("25843867-fead-46ef-bb13-1b15d2fc7393"), "Essential mouth guard for protecting your teeth.", "/images/mouth-guard.jpg", false, "Mouth Guard", 12.99m, "[0,1,2,3]", 6 },
                    { new Guid("64c2a68a-7071-4bdc-8a2e-91c5d8df1424"), new Guid("8da67b86-e855-40f0-846f-bc7bd1a57b35"), new Guid("50eca588-3281-4991-acbc-447ed3492c52"), "High-quality kickboxing gloves for training and competition.", "/images/gloves.jpg", false, "Kickboxing Gloves", 49.99m, "[0,1,2,3]", 5 },
                    { new Guid("80904993-56d5-4324-acbe-3753ce1cb0f6"), new Guid("0aeb1752-e356-4934-a55b-f2e279b68bab"), new Guid("50eca588-3281-4991-acbc-447ed3492c52"), "Durable shin guards for protection during sparring.", "/images/shin-guards.jpg", false, "Shin Guards", 35.99m, "[0,1,2,3]", 6 },
                    { new Guid("999888a3-89a0-46fa-b2cd-a9d8645fda77"), new Guid("c25077e7-3cd4-4491-a9b4-19d23802026a"), new Guid("25843867-fead-46ef-bb13-1b15d2fc7393"), "Protective headgear for safety during training.", "/images/headgear.jpg", false, "Headgear", 59.99m, "[0,1,2,3]", 2 },
                    { new Guid("bb2722c4-0258-48c3-8f14-4d954ce153d3"), new Guid("8da67b86-e855-40f0-846f-bc7bd1a57b35"), new Guid("43c9094e-c5b0-4d28-90e8-ef959556803e"), "Comfortable shorts designed for kickboxing training.", "/images/shorts.jpg", false, "Kickboxing Shorts", 29.99m, "[0,1,2,3]", 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4ae180ab-e5ab-4b3e-b105-d6fc984612af"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("64c2a68a-7071-4bdc-8a2e-91c5d8df1424"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("80904993-56d5-4324-acbe-3753ce1cb0f6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("999888a3-89a0-46fa-b2cd-a9d8645fda77"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("bb2722c4-0258-48c3-8f14-4d954ce153d3"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("0aeb1752-e356-4934-a55b-f2e279b68bab"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("8da67b86-e855-40f0-846f-bc7bd1a57b35"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("c25077e7-3cd4-4491-a9b4-19d23802026a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("25843867-fead-46ef-bb13-1b15d2fc7393"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("43c9094e-c5b0-4d28-90e8-ef959556803e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("50eca588-3281-4991-acbc-447ed3492c52"));

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Brands");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Brands");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Brands");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Brands");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                comment: "URL To The Product Image",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true,
                oldComment: "URL To The Product Image");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true,
                comment: "Image For The Category",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true,
                oldComment: "Image For The Category");

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
    }
}
