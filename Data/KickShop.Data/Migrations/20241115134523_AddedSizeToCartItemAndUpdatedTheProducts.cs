using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KickShop.Migrations
{
    /// <inheritdoc />
    public partial class AddedSizeToCartItemAndUpdatedTheProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("1556377c-8e7c-4337-b870-fa6cd2b21b32"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("7ff89137-6779-4c22-8a68-d69c5f529b7a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("eee343f0-2c8a-4163-9335-9bbed69fdcad"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("088a4b0d-6a88-4378-92c2-3799887fdb09"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("0ca0672c-be4c-4e8f-b9cc-8b51e4c3b200"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("0e220100-bc71-470b-8b80-6be442d518d0"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("0f3f6662-09ec-425b-bca2-7bbc4562d131"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("1281123e-e425-4686-956b-1eeb26f815a9"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("14a3ba2b-7bfc-474d-bc2b-11b6478778bd"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("15e95d65-46c6-475a-bab5-b0c2f4587a45"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("17f30d46-d164-47db-887e-e7b157928061"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("194d1019-7c46-4a63-a961-0a08906cda1f"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("1e8f783f-2877-4245-9215-61506bdda7a6"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("254bc3ad-f700-494f-a062-dc06041ff0ad"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("2c862a35-9c73-45e9-9316-4263b15956db"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("31f24caa-f9c6-4c98-a601-9ff67c832ace"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("37d505b8-22e7-4506-af7e-06adcc83f58d"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("3d6e5856-e270-4d34-b4be-be0efd14d1f8"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("42b0f4c9-edb9-49da-81a8-c17b2f53a7e3"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("44f9bf57-d728-4f1f-84e3-2c8bc4c4614b"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("4e9b058d-79e7-485c-8d9c-d0fdf4196b9c"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("59556a56-ba2e-44b2-bc58-20b787efe5ad"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("59e60392-a265-4ab5-9df6-fef6a8734ee7"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("5f931152-abfb-4e05-9bd0-56314f731f5c"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("6b852767-0636-43a6-a4e8-586e85b4ba23"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("6bac080b-bdab-4bf6-877d-e27adb854a10"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("77b1e173-bb46-4936-a37a-6fb2eed50c84"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("7a12680b-6e74-46f2-ac10-62c949753e07"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("7f57fdfb-8bde-4b19-8752-214979f9a8b9"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("82377d30-b96e-4130-a4d2-682e71762b86"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("86e33e7f-5782-4b0f-a974-a0963efe0841"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("9287156e-c511-421c-9f3e-a598dd92d918"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("a342313a-7205-4b50-b47d-6e8c309bde4d"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("ae86a083-48a6-4aea-a20f-6d5c70ae12a9"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("afdc9067-4219-49d4-bf7d-9eab23cf6189"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("b925ad56-afb7-4059-a0b0-3333a5bcc02b"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("c2ae6044-f5fc-4956-92bc-b2bc21593a60"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("c7322b7c-6add-4c0c-9682-1be0b037e3ce"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("cda371a5-b543-4be3-b30d-5754ba1a4097"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("d87196c1-138b-4049-8964-f906daa4c68a"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("dfd4cc07-cab0-4394-ae26-92815cfff4b0"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("e11e7d93-c45f-4b38-ab51-87404e7917fe"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("e46f3572-5659-47f7-848a-b782c663e7db"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("ec1a0e8f-6fe9-4930-8fe3-7d250fff581a"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("f02e5a59-9eaa-44d8-9235-26bc5a082932"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("209af4ae-89e8-40b0-9129-17ca94e00fb2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("22fb6af2-5840-4689-aa43-23932434bf22"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4cf73507-e2bc-4129-95d7-8fe1c851fb74"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("60718779-33aa-4e88-8ec9-709e259563db"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("796abb42-932e-4cd2-a455-29fd74172027"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("7981f302-b3e9-42b9-a942-92d5b7c1fced"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("8bfd6821-2671-4c46-b618-2835b1c1166c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("8e7282a8-2332-4573-bfbc-b140994616ef"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b5697e77-6dcd-41be-b2cc-5c33e64b3d68"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b60923e1-2179-4852-87d8-d6d8f35db990"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c16354cd-8b60-44c9-b9b9-f2ad3038d5a4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d83e1861-9146-4dbb-8e08-0e3d7efae4c6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d8b53ea0-1545-4d04-aec7-bdad8881281e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e6124fde-e8d5-4d73-81c6-56326afcb917"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("00320467-1903-4d4d-b9b6-7b47a6fa9dff"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("12866d4e-ce72-481b-b150-84930935dd94"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("1e15c503-fbb5-4d61-9919-ad5f86df8a82"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("445fe8f9-aa8c-4bf0-8a22-8c9096621dff"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("47967126-feb3-4661-9803-940fae62b166"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("70cc5518-7e0f-4cba-a4ad-a5b4868ec881"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("71c8003f-0971-41a7-b716-22b0e3d00487"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("a7fddf9c-74ac-4b8c-bd1e-2a4c77ad1dc2"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("cfd27ff1-c8fc-4325-a29f-ea0ac77fb164"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("d0f5a15d-f342-4092-91e1-4c5835e5a58e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("248ab499-276d-4fd6-964a-0f337f410cf9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("2b37ed62-977b-4140-853d-b0943b7ca34b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("55ba0e71-f616-4387-b214-fd73f035d066"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("7983a000-af57-4d17-bcad-0ee6aa729c02"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("8bb74788-0ac7-4534-9f04-08625c8baa6f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("b250c4fd-003c-418a-a172-4e6e3060b14f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("cfe03cde-9795-4f22-907d-8e17ba926870"));

            migrationBuilder.AlterColumn<int>(
                name: "Quantity",
                table: "CartsItems",
                type: "int",
                nullable: false,
                comment: "The Quantity Of The Product",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Size",
                table: "CartsItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                comment: "The Selected Size Of The Product");

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandId", "Address", "Country", "ImageUrl", "IsDeleted", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("1a12e445-1bf3-4fca-9791-944f50123442"), "456 Ring Rd, Chicago, IL", "USA", "/images/Brands/ringside-logo.png", false, "Ringside", "234-567-8901" },
                    { new Guid("2e6a6e60-1e01-414c-8269-2ea87f3080de"), "789 Kick Rd, Phuket, TH", "Thailand", "/images/Brands/twins-special-logo.png", false, "Twins Special", "567-890-1234" },
                    { new Guid("35bafac4-404d-46e4-9af7-d8fd7f39fc5d"), "789 Fight St, Toronto, ON", "Canada", "/images/Brands/hayabusa-logo.png", false, "Hayabusa", "789-012-3456" },
                    { new Guid("8cbc1919-4c2c-4e9a-81a4-56709c6a9d3a"), "234 Fighter Rd, Bangkok, TH", "Thailand", "/images/Brands/fairtex-logo.png", false, "Fairtex", "876-543-2109" },
                    { new Guid("9d4c3abd-182c-4f87-8002-ca33e0db970c"), "101 Martial Arts Way, Paris, FR", "France", "/images/Brands/venum-logo.png", false, "Venum", "321-654-0987" },
                    { new Guid("a7ec4ec3-4cfb-4d87-b84d-19447a6135b1"), "123 Boxing Blvd, New York, NY", "USA", "/images/Brands/everlast-logo.png", false, "Everlast", "123-456-7890" },
                    { new Guid("b35fa41d-c4b2-4155-9902-7eb37748586f"), "345 Punch Ln, Los Angeles, CA", "USA", "/images/Brands/title-boxing-logo.png", false, "Title Boxing", "987-654-3210" },
                    { new Guid("d2da5cd7-466a-4b99-903d-e72e54c3de3d"), "456 Sports Ave, London, UK", "UK", "/images/Brands/rdx-logo.png", false, "RDX", "456-789-0123" },
                    { new Guid("e2c91574-fcab-455c-b49b-631a568140d4"), "678 Fighter Ave, Miami, FL", "USA", "/images/Brands/sanabul-logo.png", false, "Sanabul", "456-789-0123" },
                    { new Guid("fb7c51b9-171e-4d15-9acd-7b38b5b738e6"), "567 Martial Arts Blvd, Oklahoma City, OK", "USA", "/images/Brands/century-logo.png", false, "Century", "345-678-9012" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "ImageUrl", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { new Guid("01117694-2336-4f1b-9ce8-de33d302db47"), "/images/Categories/mouth-guard.png", false, "Mouthguards" },
                    { new Guid("33f3e250-d7f7-4084-9417-5f41f12f0c6d"), "/images/Categories/protective-equipment.jfif", false, "Protective Gear" },
                    { new Guid("37217175-8641-4195-bf21-e6be1da10904"), "/images/Categegories/boxing-gloves.jfif", false, "Gloves" },
                    { new Guid("75ad6db9-0dcc-4d72-b42c-998fccb558f0"), "/images/Categories/hand-wraps.png", false, "Hand Wraps" },
                    { new Guid("7910c192-08b7-40e1-bb3b-42e78f5a00b2"), "/images/Categories/punching-bag.png", false, "Punching Bags" },
                    { new Guid("8cfb3c2e-d9b5-4cee-9b97-90a4d8040f13"), "/images/Categories/clothing.png", false, "Clothing" },
                    { new Guid("8d161e3d-49a8-40d6-a534-ee01c4f2acbc"), "/images/Categories/boxing-shoes.png", false, "Shoes" },
                    { new Guid("a7feb726-fa14-4cf2-90f3-16ae52d2311e"), "/images/Categories/shin-guards.png", false, "Shinguards" },
                    { new Guid("b9a25e9d-6252-4865-bf62-080a4b4c8d93"), "/images/Categories/head-gear.png", false, "Headgear" },
                    { new Guid("da69fa40-d344-4c02-ae80-5bad0a60569b"), "/images/Categories/training-equipment.png", false, "Training Equipment" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "BrandId", "CategoryId", "Description", "IsDeleted", "MainImageUrl", "Name", "Price", "Sizes", "StockQuantity" },
                values: new object[,]
                {
                    { new Guid("2e68149e-5e3f-438c-8123-9a0d1e788660"), new Guid("2e6a6e60-1e01-414c-8269-2ea87f3080de"), new Guid("b9a25e9d-6252-4865-bf62-080a4b4c8d93"), "Full-face protection with Twins quality.", false, "/images/Products/twins-special-headgear/twins-special-headgear-1.png", "Twins Special Headgear", 89.99m, "[1,2,3]", 60 },
                    { new Guid("3d304dc7-02bc-471f-aca0-327562dbebc7"), new Guid("e2c91574-fcab-455c-b49b-631a568140d4"), new Guid("a7feb726-fa14-4cf2-90f3-16ae52d2311e"), "High-quality shin guards for protection and mobility.", false, "/images/Products/sanabul-shin-guards/sanabul-shin-guards-1.png", "Sanabul Essential Shin Guards", 105.99m, "[2,3,4]", 90 },
                    { new Guid("5c8517c9-e056-48d4-a6c1-26b8d38248c9"), new Guid("fb7c51b9-171e-4d15-9acd-7b38b5b738e6"), new Guid("8cfb3c2e-d9b5-4cee-9b97-90a4d8040f13"), "Comfortable shorts designed for kickboxing.", false, "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-1.png", "Century Martial Arts Kickboxing Shorts", 79.99m, "[2,3,4]", 75 },
                    { new Guid("7068aca7-4008-4c28-9495-479ce2114b3b"), new Guid("9d4c3abd-182c-4f87-8002-ca33e0db970c"), new Guid("a7feb726-fa14-4cf2-90f3-16ae52d2311e"), "High-durability shin guards ideal for intense training.", false, "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-1.png", "Venum Challenger Shin Guards", 105.99m, "[1,2,3]", 95 },
                    { new Guid("9a8f5bd7-69cc-4e65-bc89-f47f35f0ccde"), new Guid("1a12e445-1bf3-4fca-9791-944f50123442"), new Guid("7910c192-08b7-40e1-bb3b-42e78f5a00b2"), "Heavy-duty bag for all levels of training.", false, "/images/Products/ringside-punching-bag/ringside-punching-bag-1.png", "Ringside Punching Bag", 219.99m, "[3]", 40 },
                    { new Guid("9aae063f-38f3-452e-9d04-183adef544a2"), new Guid("8cbc1919-4c2c-4e9a-81a4-56709c6a9d3a"), new Guid("8cfb3c2e-d9b5-4cee-9b97-90a4d8040f13"), "Premium Muay Thai shorts with authentic design.", false, "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-1.png", "Fairtex Muay Thai Shorts", 84.99m, "[2,3,4]", 90 },
                    { new Guid("c3cb695f-8672-426d-a839-fddf8eafa32f"), new Guid("d2da5cd7-466a-4b99-903d-e72e54c3de3d"), new Guid("8d161e3d-49a8-40d6-a534-ee01c4f2acbc"), "Lightweight and supportive for agility in the ring.", false, "/images/Products/rdx-boxing-shoes/rdx-boxing-shoes-1.png", "RDX Pro Boxing Shoes", 109.99m, "[2,3,4]", 65 },
                    { new Guid("c6f2436e-e7ba-41a7-8572-18475cf77f35"), new Guid("35bafac4-404d-46e4-9af7-d8fd7f39fc5d"), new Guid("37217175-8641-4195-bf21-e6be1da10904"), "Top-notch gloves with exceptional durability.", false, "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-1.png", "Hayabusa T3 Boxing Gloves", 189.99m, "[2,3,4]", 50 },
                    { new Guid("cb912c0e-927b-44af-a7be-1196edd82aed"), new Guid("9d4c3abd-182c-4f87-8002-ca33e0db970c"), new Guid("37217175-8641-4195-bf21-e6be1da10904"), "Lightweight and designed for all skill levels.", false, "/images/Products/venum-challenger-gloves/venum-challenger-gloves-2.png", "Venum Challenger Gloves", 89.99m, "[1,2,3]", 120 },
                    { new Guid("dbc7ee19-78f0-425e-b656-96c6dd4a43f6"), new Guid("b35fa41d-c4b2-4155-9902-7eb37748586f"), new Guid("37217175-8641-4195-bf21-e6be1da10904"), "Durable leather gloves for heavy bag workouts.", false, "/images/Products/title-boxing-bag/title-boxing-bag-1.png", "Title Boxing Leather Bag Gloves", 79.99m, "[2,3]", 80 },
                    { new Guid("dd11e94a-5a3c-4a37-9717-94270c18540d"), new Guid("b35fa41d-c4b2-4155-9902-7eb37748586f"), new Guid("7910c192-08b7-40e1-bb3b-42e78f5a00b2"), "Perfect for accuracy and reflex training.", false, "/images/Products/title-boxing-gloves/title-boxing-gloves-1.png", "Title Boxing Double End Bag", 99.99m, "[3]", 70 },
                    { new Guid("e4976020-b55f-4b56-ac8d-e364c04853e0"), new Guid("d2da5cd7-466a-4b99-903d-e72e54c3de3d"), new Guid("37217175-8641-4195-bf21-e6be1da10904"), "High-quality leather gloves for all training levels.", false, "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-3.png", "RDX Boxing Gloves", 109.99m, "[1,2,3]", 100 },
                    { new Guid("f020749e-aa83-46b8-8dcd-d69147d60b60"), new Guid("a7ec4ec3-4cfb-4d87-b84d-19447a6135b1"), new Guid("b9a25e9d-6252-4865-bf62-080a4b4c8d93"), "Full-protection headgear with durable padding.", false, "/images/Products/everlast-pro-headgear/everlast-headgear-1.png", "Everlast Pro Headgear", 89.99m, "[2,3]", 50 },
                    { new Guid("fb64da22-9f41-4f37-adb8-f487ed95db0b"), new Guid("a7ec4ec3-4cfb-4d87-b84d-19447a6135b1"), new Guid("75ad6db9-0dcc-4d72-b42c-998fccb558f0"), "Classic wraps for wrist and knuckle protection.", false, "/images/Products/everlast-hand-wraps/everlast-hand-wraps-3.png", "Everlast Hand Wraps", 9.99m, "[2,3]", 200 }
                });

            migrationBuilder.InsertData(
                table: "ProductsImages",
                columns: new[] { "ImageId", "ImageUrl", "ProductId" },
                values: new object[,]
                {
                    { new Guid("011efb89-123d-484f-8708-0196ba52575e"), "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-3.png", new Guid("7068aca7-4008-4c28-9495-479ce2114b3b") },
                    { new Guid("035113c2-3dcd-4175-aaed-d8d8026c8ccb"), "/images/Products/rdx-boxing-shoes/rdx-boxing-shoes-1.png", new Guid("c3cb695f-8672-426d-a839-fddf8eafa32f") },
                    { new Guid("08ccd12e-d4ec-4717-aa6e-f91e84cbf18d"), "/images/Products/venum-challenger-gloves/venum-challenger-gloves-2.png", new Guid("cb912c0e-927b-44af-a7be-1196edd82aed") },
                    { new Guid("0dac16b8-773d-4cd5-a11d-af9b3af92d65"), "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-2.png", new Guid("9aae063f-38f3-452e-9d04-183adef544a2") },
                    { new Guid("17fc2d4b-ab63-4d0e-be8f-c582acca43cc"), "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-1.png", new Guid("5c8517c9-e056-48d4-a6c1-26b8d38248c9") },
                    { new Guid("29a03e15-33cd-4987-a0e4-4c8d976b314b"), "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-2.png", new Guid("e4976020-b55f-4b56-ac8d-e364c04853e0") },
                    { new Guid("2b3c66b6-955b-48a6-ad44-a923556d53cf"), "/images/Products/ringside-punching-bag/ringside-punching-bag-2.png", new Guid("9a8f5bd7-69cc-4e65-bc89-f47f35f0ccde") },
                    { new Guid("2faf1ddc-0018-46f1-9e8e-05eb974023ef"), "/images/Products/title-boxing-bag/title-boxing-bag-3.png", new Guid("dbc7ee19-78f0-425e-b656-96c6dd4a43f6") },
                    { new Guid("33afcd26-6f37-456e-9bca-3c90acbb899e"), "/images/Products/everlast-hand-wraps/everlast-hand-wraps-2.png", new Guid("fb64da22-9f41-4f37-adb8-f487ed95db0b") },
                    { new Guid("43a45525-7a9f-43bf-af5b-4b39cb9d35e4"), "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-3.png", new Guid("9aae063f-38f3-452e-9d04-183adef544a2") },
                    { new Guid("44aa363a-ab5d-4771-ad97-0dae30ac39c0"), "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-1.png", new Guid("c6f2436e-e7ba-41a7-8572-18475cf77f35") },
                    { new Guid("51fb7c50-8e85-4c8e-ad66-61cdcead95b2"), "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-3.png", new Guid("c6f2436e-e7ba-41a7-8572-18475cf77f35") },
                    { new Guid("51fbdd95-4e04-4e75-90a2-4433f5d31d45"), "/images/Products/everlast-hand-wraps/everlast-hand-wraps-3.png", new Guid("fb64da22-9f41-4f37-adb8-f487ed95db0b") },
                    { new Guid("52a6f4cf-1c2b-4a2e-a683-4587916a5057"), "/images/Products/title-boxing-gloves/title-boxing-gloves-2.png", new Guid("dd11e94a-5a3c-4a37-9717-94270c18540d") },
                    { new Guid("5a858856-66a3-45f4-bcc0-dc26dfe6a98a"), "/images/Products/twins-special-headgear/twins-shin-headgear-3.png", new Guid("2e68149e-5e3f-438c-8123-9a0d1e788660") },
                    { new Guid("62dde1f4-e8fe-452e-9d8d-2944c1d51718"), "/images/Products/twins-special-headgear/twins-special-headgear-1.png", new Guid("2e68149e-5e3f-438c-8123-9a0d1e788660") },
                    { new Guid("6b10028c-4ec2-4894-b678-6dabcaf02fca"), "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-2.png", new Guid("5c8517c9-e056-48d4-a6c1-26b8d38248c9") },
                    { new Guid("7760bc40-29b7-4d11-b4b5-c12cd13ad429"), "/images/Products/sanabul-shin-guards/sanabul-shin-guards-3.png", new Guid("3d304dc7-02bc-471f-aca0-327562dbebc7") },
                    { new Guid("7852b782-f5fa-447d-a63e-7cfc9cc73ed9"), "/images/Products/title-boxing-bag/title-boxing-bag-1.png", new Guid("dbc7ee19-78f0-425e-b656-96c6dd4a43f6") },
                    { new Guid("7f8db1f4-29a1-42df-8722-84cd8047769e"), "/images/Products/venum-challenger-gloves/venum-challenger-gloves-3.png", new Guid("cb912c0e-927b-44af-a7be-1196edd82aed") },
                    { new Guid("848467b3-e00a-4618-84ce-715c9ca0e776"), "/images/Products/everlasr-pro-headgear/everlast-headgear-1.png", new Guid("f020749e-aa83-46b8-8dcd-d69147d60b60") },
                    { new Guid("8ae1b473-56ab-4281-81c9-6c606a891bb6"), "/images/Products/sanabul-shin-guards/sanabul-shin-guards-1.png", new Guid("3d304dc7-02bc-471f-aca0-327562dbebc7") },
                    { new Guid("8d50857e-0cde-4542-8e03-46410d6b8d6d"), "/images/Products/sanabul-shin-guards/sanabul-shin-guards-2.png", new Guid("3d304dc7-02bc-471f-aca0-327562dbebc7") },
                    { new Guid("8d9f5115-8c3b-4e77-bc3f-68a496e46926"), "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-1.png", new Guid("9aae063f-38f3-452e-9d04-183adef544a2") },
                    { new Guid("9c937a4e-1ef3-40b7-a1ce-8e0191147683"), "/images/Products/ringside-punching-bag/ringside-punching-bag-1.png", new Guid("9a8f5bd7-69cc-4e65-bc89-f47f35f0ccde") },
                    { new Guid("9d4093ce-eb47-475b-bbc0-d98d96df5531"), "/images/Products/everlast-hand-wraps/everlast-hand-wraps-1.png", new Guid("fb64da22-9f41-4f37-adb8-f487ed95db0b") },
                    { new Guid("a7532de4-884b-48ca-ae3e-92d1a90d439d"), "/images/Products/title-boxing-gloves/title-boxing-gloves-3.png", new Guid("dd11e94a-5a3c-4a37-9717-94270c18540d") },
                    { new Guid("abacd0d4-0038-441d-bc15-7bd68ce6f072"), "/images/Products/twins-special-headgear/twins-special-headgear-2.png", new Guid("2e68149e-5e3f-438c-8123-9a0d1e788660") },
                    { new Guid("afd2b2a5-50c0-477d-91ec-cd1fc7aed008"), "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-3.png", new Guid("e4976020-b55f-4b56-ac8d-e364c04853e0") },
                    { new Guid("b2ad7434-7f0c-4641-8032-af15a62669be"), "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-1.png", new Guid("e4976020-b55f-4b56-ac8d-e364c04853e0") },
                    { new Guid("b93fd0cf-b27f-49cb-9fd1-ed8c7ae0517c"), "/images/Products/ringside-punching-bag/ringside-punching-bag-3.png", new Guid("9a8f5bd7-69cc-4e65-bc89-f47f35f0ccde") },
                    { new Guid("bc73b90d-e31f-48b7-81a8-ffc66d8dcad3"), "/images/Products/venum-challenger-gloves/venum-challenger-gloves-1.png", new Guid("cb912c0e-927b-44af-a7be-1196edd82aed") },
                    { new Guid("befbb641-ac71-4cf3-a9b0-61c2d35d2e9f"), "/images/Products/rdx-boxing-shoes/rdx-boxing-shoes-2.png", new Guid("c3cb695f-8672-426d-a839-fddf8eafa32f") },
                    { new Guid("c0127216-d1d3-47e8-9334-36da0218e043"), "/images/Products/rdx-boxing-shoes/rdx-boxing-shoes-3.png", new Guid("c3cb695f-8672-426d-a839-fddf8eafa32f") },
                    { new Guid("c82e77a8-53ab-48c8-84a7-d9ad3cd78712"), "/images/Products/title-boxing-bag/title-boxing-bag-2.png", new Guid("dbc7ee19-78f0-425e-b656-96c6dd4a43f6") },
                    { new Guid("cc4e4cef-9f39-48cd-83c9-88d9e1c64a35"), "/images/Products/everlasr-pro-headgear/everlast-headgear-3.png", new Guid("f020749e-aa83-46b8-8dcd-d69147d60b60") },
                    { new Guid("d4e4df75-b730-4a6d-98d9-283bdbf2a26d"), "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-3.png", new Guid("5c8517c9-e056-48d4-a6c1-26b8d38248c9") },
                    { new Guid("dcf50c2a-b8ad-463c-a2f1-0529b197882d"), "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-2.png", new Guid("7068aca7-4008-4c28-9495-479ce2114b3b") },
                    { new Guid("e6cbb4ee-8b29-4a65-bb75-7d4d6e94c135"), "/images/Products/everlasr-pro-headgear/everlast-headgear-2.png", new Guid("f020749e-aa83-46b8-8dcd-d69147d60b60") },
                    { new Guid("f3ab8b97-a954-4c25-81d8-9cbf49761f33"), "/images/Products/title-boxing-gloves/title-boxing-gloves-1.png", new Guid("dd11e94a-5a3c-4a37-9717-94270c18540d") },
                    { new Guid("fa28b7ff-e4e5-497f-b7d1-9daa07b6f294"), "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-1.png", new Guid("7068aca7-4008-4c28-9495-479ce2114b3b") },
                    { new Guid("ff6a5279-3cd0-4d45-b2dc-c6d6b534515e"), "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-2.png", new Guid("c6f2436e-e7ba-41a7-8572-18475cf77f35") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("01117694-2336-4f1b-9ce8-de33d302db47"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("33f3e250-d7f7-4084-9417-5f41f12f0c6d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("da69fa40-d344-4c02-ae80-5bad0a60569b"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("011efb89-123d-484f-8708-0196ba52575e"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("035113c2-3dcd-4175-aaed-d8d8026c8ccb"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("08ccd12e-d4ec-4717-aa6e-f91e84cbf18d"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("0dac16b8-773d-4cd5-a11d-af9b3af92d65"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("17fc2d4b-ab63-4d0e-be8f-c582acca43cc"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("29a03e15-33cd-4987-a0e4-4c8d976b314b"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("2b3c66b6-955b-48a6-ad44-a923556d53cf"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("2faf1ddc-0018-46f1-9e8e-05eb974023ef"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("33afcd26-6f37-456e-9bca-3c90acbb899e"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("43a45525-7a9f-43bf-af5b-4b39cb9d35e4"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("44aa363a-ab5d-4771-ad97-0dae30ac39c0"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("51fb7c50-8e85-4c8e-ad66-61cdcead95b2"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("51fbdd95-4e04-4e75-90a2-4433f5d31d45"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("52a6f4cf-1c2b-4a2e-a683-4587916a5057"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("5a858856-66a3-45f4-bcc0-dc26dfe6a98a"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("62dde1f4-e8fe-452e-9d8d-2944c1d51718"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("6b10028c-4ec2-4894-b678-6dabcaf02fca"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("7760bc40-29b7-4d11-b4b5-c12cd13ad429"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("7852b782-f5fa-447d-a63e-7cfc9cc73ed9"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("7f8db1f4-29a1-42df-8722-84cd8047769e"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("848467b3-e00a-4618-84ce-715c9ca0e776"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("8ae1b473-56ab-4281-81c9-6c606a891bb6"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("8d50857e-0cde-4542-8e03-46410d6b8d6d"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("8d9f5115-8c3b-4e77-bc3f-68a496e46926"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("9c937a4e-1ef3-40b7-a1ce-8e0191147683"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("9d4093ce-eb47-475b-bbc0-d98d96df5531"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("a7532de4-884b-48ca-ae3e-92d1a90d439d"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("abacd0d4-0038-441d-bc15-7bd68ce6f072"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("afd2b2a5-50c0-477d-91ec-cd1fc7aed008"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("b2ad7434-7f0c-4641-8032-af15a62669be"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("b93fd0cf-b27f-49cb-9fd1-ed8c7ae0517c"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("bc73b90d-e31f-48b7-81a8-ffc66d8dcad3"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("befbb641-ac71-4cf3-a9b0-61c2d35d2e9f"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("c0127216-d1d3-47e8-9334-36da0218e043"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("c82e77a8-53ab-48c8-84a7-d9ad3cd78712"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("cc4e4cef-9f39-48cd-83c9-88d9e1c64a35"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("d4e4df75-b730-4a6d-98d9-283bdbf2a26d"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("dcf50c2a-b8ad-463c-a2f1-0529b197882d"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("e6cbb4ee-8b29-4a65-bb75-7d4d6e94c135"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("f3ab8b97-a954-4c25-81d8-9cbf49761f33"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("fa28b7ff-e4e5-497f-b7d1-9daa07b6f294"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("ff6a5279-3cd0-4d45-b2dc-c6d6b534515e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("2e68149e-5e3f-438c-8123-9a0d1e788660"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("3d304dc7-02bc-471f-aca0-327562dbebc7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("5c8517c9-e056-48d4-a6c1-26b8d38248c9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("7068aca7-4008-4c28-9495-479ce2114b3b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("9a8f5bd7-69cc-4e65-bc89-f47f35f0ccde"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("9aae063f-38f3-452e-9d04-183adef544a2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c3cb695f-8672-426d-a839-fddf8eafa32f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c6f2436e-e7ba-41a7-8572-18475cf77f35"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("cb912c0e-927b-44af-a7be-1196edd82aed"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("dbc7ee19-78f0-425e-b656-96c6dd4a43f6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("dd11e94a-5a3c-4a37-9717-94270c18540d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e4976020-b55f-4b56-ac8d-e364c04853e0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f020749e-aa83-46b8-8dcd-d69147d60b60"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("fb64da22-9f41-4f37-adb8-f487ed95db0b"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("1a12e445-1bf3-4fca-9791-944f50123442"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("2e6a6e60-1e01-414c-8269-2ea87f3080de"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("35bafac4-404d-46e4-9af7-d8fd7f39fc5d"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("8cbc1919-4c2c-4e9a-81a4-56709c6a9d3a"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("9d4c3abd-182c-4f87-8002-ca33e0db970c"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("a7ec4ec3-4cfb-4d87-b84d-19447a6135b1"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("b35fa41d-c4b2-4155-9902-7eb37748586f"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("d2da5cd7-466a-4b99-903d-e72e54c3de3d"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("e2c91574-fcab-455c-b49b-631a568140d4"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("fb7c51b9-171e-4d15-9acd-7b38b5b738e6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("37217175-8641-4195-bf21-e6be1da10904"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("75ad6db9-0dcc-4d72-b42c-998fccb558f0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("7910c192-08b7-40e1-bb3b-42e78f5a00b2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("8cfb3c2e-d9b5-4cee-9b97-90a4d8040f13"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("8d161e3d-49a8-40d6-a534-ee01c4f2acbc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("a7feb726-fa14-4cf2-90f3-16ae52d2311e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("b9a25e9d-6252-4865-bf62-080a4b4c8d93"));

            migrationBuilder.DropColumn(
                name: "Size",
                table: "CartsItems");

            migrationBuilder.AlterColumn<int>(
                name: "Quantity",
                table: "CartsItems",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "The Quantity Of The Product");

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandId", "Address", "Country", "ImageUrl", "IsDeleted", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("00320467-1903-4d4d-b9b6-7b47a6fa9dff"), "456 Sports Ave, London, UK", "UK", "/images/Brands/rdx-logo.png", false, "RDX", "456-789-0123" },
                    { new Guid("12866d4e-ce72-481b-b150-84930935dd94"), "678 Fighter Ave, Miami, FL", "USA", "/images/Brands/sanabul-logo.png", false, "Sanabul", "456-789-0123" },
                    { new Guid("1e15c503-fbb5-4d61-9919-ad5f86df8a82"), "789 Kick Rd, Phuket, TH", "Thailand", "/images/Brands/twins-special-logo.png", false, "Twins Special", "567-890-1234" },
                    { new Guid("445fe8f9-aa8c-4bf0-8a22-8c9096621dff"), "567 Martial Arts Blvd, Oklahoma City, OK", "USA", "/images/Brands/century-logo.png", false, "Century", "345-678-9012" },
                    { new Guid("47967126-feb3-4661-9803-940fae62b166"), "789 Fight St, Toronto, ON", "Canada", "/images/Brands/hayabusa-logo.png", false, "Hayabusa", "789-012-3456" },
                    { new Guid("70cc5518-7e0f-4cba-a4ad-a5b4868ec881"), "345 Punch Ln, Los Angeles, CA", "USA", "/images/Brands/title-boxing-logo.png", false, "Title Boxing", "987-654-3210" },
                    { new Guid("71c8003f-0971-41a7-b716-22b0e3d00487"), "123 Boxing Blvd, New York, NY", "USA", "/images/Brands/everlast-logo.png", false, "Everlast", "123-456-7890" },
                    { new Guid("a7fddf9c-74ac-4b8c-bd1e-2a4c77ad1dc2"), "456 Ring Rd, Chicago, IL", "USA", "/images/Brands/ringside-logo.png", false, "Ringside", "234-567-8901" },
                    { new Guid("cfd27ff1-c8fc-4325-a29f-ea0ac77fb164"), "234 Fighter Rd, Bangkok, TH", "Thailand", "/images/Brands/fairtex-logo.png", false, "Fairtex", "876-543-2109" },
                    { new Guid("d0f5a15d-f342-4092-91e1-4c5835e5a58e"), "101 Martial Arts Way, Paris, FR", "France", "/images/Brands/venum-logo.png", false, "Venum", "321-654-0987" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "ImageUrl", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { new Guid("1556377c-8e7c-4337-b870-fa6cd2b21b32"), "/images/Categories/training-equipment.png", false, "Training Equipment" },
                    { new Guid("248ab499-276d-4fd6-964a-0f337f410cf9"), "/images/Categories/shin-guards.png", false, "Shinguards" },
                    { new Guid("2b37ed62-977b-4140-853d-b0943b7ca34b"), "/images/Categegories/boxing-gloves.png", false, "Gloves" },
                    { new Guid("55ba0e71-f616-4387-b214-fd73f035d066"), "/images/Categories/punching-bag.png", false, "Punching Bags" },
                    { new Guid("7983a000-af57-4d17-bcad-0ee6aa729c02"), "/images/Categories/boxing-shoes.png", false, "Shoes" },
                    { new Guid("7ff89137-6779-4c22-8a68-d69c5f529b7a"), "/images/Categories/mouth-guard.png", false, "Mouthguards" },
                    { new Guid("8bb74788-0ac7-4534-9f04-08625c8baa6f"), "/images/Categories/head-gear.png", false, "Headgear" },
                    { new Guid("b250c4fd-003c-418a-a172-4e6e3060b14f"), "/images/Categories/hand-wraps.png", false, "Hand Wraps" },
                    { new Guid("cfe03cde-9795-4f22-907d-8e17ba926870"), "/images/Categories/clothing.png", false, "Clothing" },
                    { new Guid("eee343f0-2c8a-4163-9335-9bbed69fdcad"), "/images/Categories/protective-equipment.png", false, "Protective Gear" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "BrandId", "CategoryId", "Description", "IsDeleted", "MainImageUrl", "Name", "Price", "Sizes", "StockQuantity" },
                values: new object[,]
                {
                    { new Guid("209af4ae-89e8-40b0-9129-17ca94e00fb2"), new Guid("00320467-1903-4d4d-b9b6-7b47a6fa9dff"), new Guid("2b37ed62-977b-4140-853d-b0943b7ca34b"), "High-quality leather gloves for all training levels.", false, "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-3.png", "RDX Boxing Gloves", 49.99m, "[1,2,3]", 100 },
                    { new Guid("22fb6af2-5840-4689-aa43-23932434bf22"), new Guid("d0f5a15d-f342-4092-91e1-4c5835e5a58e"), new Guid("2b37ed62-977b-4140-853d-b0943b7ca34b"), "Lightweight and designed for all skill levels.", false, "/images/Products/venum-challenger-gloves/venum-challenger-gloves-2.png", "Venum Challenger Gloves", 39.99m, "[1,2,3]", 120 },
                    { new Guid("4cf73507-e2bc-4129-95d7-8fe1c851fb74"), new Guid("00320467-1903-4d4d-b9b6-7b47a6fa9dff"), new Guid("7983a000-af57-4d17-bcad-0ee6aa729c02"), "Lightweight and supportive for agility in the ring.", false, "/images/Products/rdx-boxing-shoes/rdx-boxing-shoes-1.png", "RDX Pro Boxing Shoes", 69.99m, "[2,3,4]", 65 },
                    { new Guid("60718779-33aa-4e88-8ec9-709e259563db"), new Guid("47967126-feb3-4661-9803-940fae62b166"), new Guid("2b37ed62-977b-4140-853d-b0943b7ca34b"), "Top-notch gloves with exceptional durability.", false, "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-1.png", "Hayabusa T3 Boxing Gloves", 89.99m, "[2,3,4]", 50 },
                    { new Guid("796abb42-932e-4cd2-a455-29fd74172027"), new Guid("445fe8f9-aa8c-4bf0-8a22-8c9096621dff"), new Guid("cfe03cde-9795-4f22-907d-8e17ba926870"), "Comfortable shorts designed for kickboxing.", false, "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-1.png", "Century Martial Arts Kickboxing Shorts", 29.99m, "[2,3,4]", 75 },
                    { new Guid("7981f302-b3e9-42b9-a942-92d5b7c1fced"), new Guid("70cc5518-7e0f-4cba-a4ad-a5b4868ec881"), new Guid("2b37ed62-977b-4140-853d-b0943b7ca34b"), "Durable leather gloves for heavy bag workouts.", false, "/images/Products/title-boxing-bag/title-boxing-bag-1.png", "Title Boxing Leather Bag Gloves", 59.99m, "[2,3]", 80 },
                    { new Guid("8bfd6821-2671-4c46-b618-2835b1c1166c"), new Guid("71c8003f-0971-41a7-b716-22b0e3d00487"), new Guid("b250c4fd-003c-418a-a172-4e6e3060b14f"), "Classic wraps for wrist and knuckle protection.", false, "/images/Products/everlast-hand-wraps/everlast-hand-wraps-3.png", "Everlast Hand Wraps", 9.99m, "[2,3]", 200 },
                    { new Guid("8e7282a8-2332-4573-bfbc-b140994616ef"), new Guid("d0f5a15d-f342-4092-91e1-4c5835e5a58e"), new Guid("248ab499-276d-4fd6-964a-0f337f410cf9"), "High-durability shin guards ideal for intense training.", false, "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-1.png", "Venum Challenger Shin Guards", 45.99m, "[1,2,3]", 95 },
                    { new Guid("b5697e77-6dcd-41be-b2cc-5c33e64b3d68"), new Guid("12866d4e-ce72-481b-b150-84930935dd94"), new Guid("248ab499-276d-4fd6-964a-0f337f410cf9"), "High-quality shin guards for protection and mobility.", false, "/images/Products/sanabul-shin-guards/sanabul-shin-guards-1.png", "Sanabul Essential Shin Guards", 35.99m, "[2,3,4]", 90 },
                    { new Guid("b60923e1-2179-4852-87d8-d6d8f35db990"), new Guid("71c8003f-0971-41a7-b716-22b0e3d00487"), new Guid("8bb74788-0ac7-4534-9f04-08625c8baa6f"), "Full-protection headgear with durable padding.", false, "/images/Products/everlast-pro-headgear/everlast-headgear-1.png", "Everlast Pro Headgear", 69.99m, "[2,3]", 50 },
                    { new Guid("c16354cd-8b60-44c9-b9b9-f2ad3038d5a4"), new Guid("cfd27ff1-c8fc-4325-a29f-ea0ac77fb164"), new Guid("cfe03cde-9795-4f22-907d-8e17ba926870"), "Premium Muay Thai shorts with authentic design.", false, "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-1.png", "Fairtex Muay Thai Shorts", 34.99m, "[2,3,4]", 90 },
                    { new Guid("d83e1861-9146-4dbb-8e08-0e3d7efae4c6"), new Guid("70cc5518-7e0f-4cba-a4ad-a5b4868ec881"), new Guid("55ba0e71-f616-4387-b214-fd73f035d066"), "Perfect for accuracy and reflex training.", false, "/images/Products/title-boxing-gloves/title-boxing-gloves-1.png", "Title Boxing Double End Bag", 44.99m, "[3]", 70 },
                    { new Guid("d8b53ea0-1545-4d04-aec7-bdad8881281e"), new Guid("a7fddf9c-74ac-4b8c-bd1e-2a4c77ad1dc2"), new Guid("55ba0e71-f616-4387-b214-fd73f035d066"), "Heavy-duty bag for all levels of training.", false, "/images/Products/ringside-punching-bag/ringside-punching-bag-1.png", "Ringside Punching Bag", 119.99m, "[3]", 40 },
                    { new Guid("e6124fde-e8d5-4d73-81c6-56326afcb917"), new Guid("1e15c503-fbb5-4d61-9919-ad5f86df8a82"), new Guid("8bb74788-0ac7-4534-9f04-08625c8baa6f"), "Full-face protection with Twins quality.", false, "/images/Products/twins-special-headgear/twins-special-headgear-1.png", "Twins Special Headgear", 89.99m, "[1,2,3]", 60 }
                });

            migrationBuilder.InsertData(
                table: "ProductsImages",
                columns: new[] { "ImageId", "ImageUrl", "ProductId" },
                values: new object[,]
                {
                    { new Guid("088a4b0d-6a88-4378-92c2-3799887fdb09"), "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-1.png", new Guid("c16354cd-8b60-44c9-b9b9-f2ad3038d5a4") },
                    { new Guid("0ca0672c-be4c-4e8f-b9cc-8b51e4c3b200"), "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-3.png", new Guid("c16354cd-8b60-44c9-b9b9-f2ad3038d5a4") },
                    { new Guid("0e220100-bc71-470b-8b80-6be442d518d0"), "/images/Products/venum-challenger-gloves/venum-challenger-gloves-1.png", new Guid("22fb6af2-5840-4689-aa43-23932434bf22") },
                    { new Guid("0f3f6662-09ec-425b-bca2-7bbc4562d131"), "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-1.png", new Guid("60718779-33aa-4e88-8ec9-709e259563db") },
                    { new Guid("1281123e-e425-4686-956b-1eeb26f815a9"), "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-2.png", new Guid("796abb42-932e-4cd2-a455-29fd74172027") },
                    { new Guid("14a3ba2b-7bfc-474d-bc2b-11b6478778bd"), "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-1.png", new Guid("209af4ae-89e8-40b0-9129-17ca94e00fb2") },
                    { new Guid("15e95d65-46c6-475a-bab5-b0c2f4587a45"), "/images/Products/venum-challenger-gloves/venum-challenger-gloves-2.png", new Guid("22fb6af2-5840-4689-aa43-23932434bf22") },
                    { new Guid("17f30d46-d164-47db-887e-e7b157928061"), "/images/Products/twins-special-headgear/twins-special-headgear-1.png", new Guid("e6124fde-e8d5-4d73-81c6-56326afcb917") },
                    { new Guid("194d1019-7c46-4a63-a961-0a08906cda1f"), "/images/Products/title-boxing-bag/title-boxing-bag-2.png", new Guid("7981f302-b3e9-42b9-a942-92d5b7c1fced") },
                    { new Guid("1e8f783f-2877-4245-9215-61506bdda7a6"), "/images/Products/sanabul-shin-guards/sanabul-shin-guards-3.png", new Guid("b5697e77-6dcd-41be-b2cc-5c33e64b3d68") },
                    { new Guid("254bc3ad-f700-494f-a062-dc06041ff0ad"), "/images/Products/everlast-hand-wraps/everlast-hand-wraps-1.png", new Guid("8bfd6821-2671-4c46-b618-2835b1c1166c") },
                    { new Guid("2c862a35-9c73-45e9-9316-4263b15956db"), "/images/Products/title-boxing-gloves/title-boxing-gloves-3.png", new Guid("d83e1861-9146-4dbb-8e08-0e3d7efae4c6") },
                    { new Guid("31f24caa-f9c6-4c98-a601-9ff67c832ace"), "/images/Products/title-boxing-gloves/title-boxing-gloves-1.png", new Guid("d83e1861-9146-4dbb-8e08-0e3d7efae4c6") },
                    { new Guid("37d505b8-22e7-4506-af7e-06adcc83f58d"), "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-3.png", new Guid("209af4ae-89e8-40b0-9129-17ca94e00fb2") },
                    { new Guid("3d6e5856-e270-4d34-b4be-be0efd14d1f8"), "/images/Products/everlasr-pro-headgear/everlast-headgear-1.png", new Guid("b60923e1-2179-4852-87d8-d6d8f35db990") },
                    { new Guid("42b0f4c9-edb9-49da-81a8-c17b2f53a7e3"), "/images/Products/title-boxing-bag/title-boxing-bag-3.png", new Guid("7981f302-b3e9-42b9-a942-92d5b7c1fced") },
                    { new Guid("44f9bf57-d728-4f1f-84e3-2c8bc4c4614b"), "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-2.png", new Guid("60718779-33aa-4e88-8ec9-709e259563db") },
                    { new Guid("4e9b058d-79e7-485c-8d9c-d0fdf4196b9c"), "/images/Products/ringside-punching-bag/ringside-punching-bag-3.png", new Guid("d8b53ea0-1545-4d04-aec7-bdad8881281e") },
                    { new Guid("59556a56-ba2e-44b2-bc58-20b787efe5ad"), "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-1.png", new Guid("796abb42-932e-4cd2-a455-29fd74172027") },
                    { new Guid("59e60392-a265-4ab5-9df6-fef6a8734ee7"), "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-3.png", new Guid("796abb42-932e-4cd2-a455-29fd74172027") },
                    { new Guid("5f931152-abfb-4e05-9bd0-56314f731f5c"), "/images/Products/everlast-hand-wraps/everlast-hand-wraps-3.png", new Guid("8bfd6821-2671-4c46-b618-2835b1c1166c") },
                    { new Guid("6b852767-0636-43a6-a4e8-586e85b4ba23"), "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-2.png", new Guid("209af4ae-89e8-40b0-9129-17ca94e00fb2") },
                    { new Guid("6bac080b-bdab-4bf6-877d-e27adb854a10"), "/images/Products/title-boxing-gloves/title-boxing-gloves-2.png", new Guid("d83e1861-9146-4dbb-8e08-0e3d7efae4c6") },
                    { new Guid("77b1e173-bb46-4936-a37a-6fb2eed50c84"), "/images/Products/twins-special-headgear/twins-shin-headgear-3.png", new Guid("e6124fde-e8d5-4d73-81c6-56326afcb917") },
                    { new Guid("7a12680b-6e74-46f2-ac10-62c949753e07"), "/images/Products/everlasr-pro-headgear/everlast-headgear-2.png", new Guid("b60923e1-2179-4852-87d8-d6d8f35db990") },
                    { new Guid("7f57fdfb-8bde-4b19-8752-214979f9a8b9"), "/images/Products/rdx-boxing-shoes/rdx-boxing-shoes-2.png", new Guid("4cf73507-e2bc-4129-95d7-8fe1c851fb74") },
                    { new Guid("82377d30-b96e-4130-a4d2-682e71762b86"), "/images/Products/sanabul-shin-guards/sanabul-shin-guards-1.png", new Guid("b5697e77-6dcd-41be-b2cc-5c33e64b3d68") },
                    { new Guid("86e33e7f-5782-4b0f-a974-a0963efe0841"), "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-2.png", new Guid("8e7282a8-2332-4573-bfbc-b140994616ef") },
                    { new Guid("9287156e-c511-421c-9f3e-a598dd92d918"), "/images/Products/ringside-punching-bag/ringside-punching-bag-1.png", new Guid("d8b53ea0-1545-4d04-aec7-bdad8881281e") },
                    { new Guid("a342313a-7205-4b50-b47d-6e8c309bde4d"), "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-2.png", new Guid("c16354cd-8b60-44c9-b9b9-f2ad3038d5a4") },
                    { new Guid("ae86a083-48a6-4aea-a20f-6d5c70ae12a9"), "/images/Products/twins-special-headgear/twins-special-headgear-2.png", new Guid("e6124fde-e8d5-4d73-81c6-56326afcb917") },
                    { new Guid("afdc9067-4219-49d4-bf7d-9eab23cf6189"), "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-3.png", new Guid("8e7282a8-2332-4573-bfbc-b140994616ef") },
                    { new Guid("b925ad56-afb7-4059-a0b0-3333a5bcc02b"), "/images/Products/venum-challenger-gloves/venum-challenger-gloves-3.png", new Guid("22fb6af2-5840-4689-aa43-23932434bf22") },
                    { new Guid("c2ae6044-f5fc-4956-92bc-b2bc21593a60"), "/images/Products/everlasr-pro-headgear/everlast-headgear-3.png", new Guid("b60923e1-2179-4852-87d8-d6d8f35db990") },
                    { new Guid("c7322b7c-6add-4c0c-9682-1be0b037e3ce"), "/images/Products/title-boxing-bag/title-boxing-bag-1.png", new Guid("7981f302-b3e9-42b9-a942-92d5b7c1fced") },
                    { new Guid("cda371a5-b543-4be3-b30d-5754ba1a4097"), "/images/Products/ringside-punching-bag/ringside-punching-bag-2.png", new Guid("d8b53ea0-1545-4d04-aec7-bdad8881281e") },
                    { new Guid("d87196c1-138b-4049-8964-f906daa4c68a"), "/images/Products/sanabul-shin-guards/sanabul-shin-guards-2.png", new Guid("b5697e77-6dcd-41be-b2cc-5c33e64b3d68") },
                    { new Guid("dfd4cc07-cab0-4394-ae26-92815cfff4b0"), "/images/Products/rdx-boxing-shoes/rdx-boxing-shoes-1.png", new Guid("4cf73507-e2bc-4129-95d7-8fe1c851fb74") },
                    { new Guid("e11e7d93-c45f-4b38-ab51-87404e7917fe"), "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-3.png", new Guid("60718779-33aa-4e88-8ec9-709e259563db") },
                    { new Guid("e46f3572-5659-47f7-848a-b782c663e7db"), "/images/Products/everlast-hand-wraps/everlast-hand-wraps-2.png", new Guid("8bfd6821-2671-4c46-b618-2835b1c1166c") },
                    { new Guid("ec1a0e8f-6fe9-4930-8fe3-7d250fff581a"), "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-1.png", new Guid("8e7282a8-2332-4573-bfbc-b140994616ef") },
                    { new Guid("f02e5a59-9eaa-44d8-9235-26bc5a082932"), "/images/Products/rdx-boxing-shoes/rdx-boxing-shoes-3.png", new Guid("4cf73507-e2bc-4129-95d7-8fe1c851fb74") }
                });
        }
    }
}
