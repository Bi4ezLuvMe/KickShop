using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KickShop.Migrations
{
    /// <inheritdoc />
    public partial class FkTheseImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("389d3d54-2adf-40ea-8fd2-e31e34b425a8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("3fb6b1db-4c50-4766-9351-2ea61ac2141d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("df9db806-5fe8-4df2-ac1f-583676676b2c"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("04a38bde-aa32-4348-a47d-8f04eec2657d"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("0702b6bc-7ef5-486c-801c-52862dd1efac"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("08c7cd44-50fb-437f-ac9f-529514bc8e66"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("1029cb26-b008-4de1-a2fd-989c363c5a64"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("1573ece9-a1c9-40b9-a591-bd8999fdd55e"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("17704f0d-3c7e-47c4-b09e-8e758c943b4a"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("1cd3088d-b0b1-4f41-9bc9-5acef6174ef0"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("1f52c194-f6c1-49fc-a4b6-2c01a3cff1e1"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("275ef00f-72d3-4689-8de6-df819382c2d1"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("2b958cd8-5d41-4220-8cc5-04d6e43ec584"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("3b8ad847-893b-478c-ab32-820fda4a7d29"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("3c94bb6b-983a-471e-ba36-352398c3f95a"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("3d47bf64-4e42-4d71-b89c-74a4dfd87a34"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("536a3625-89f5-4f19-a072-868bcc8101bb"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("5456036e-fcaa-46b7-aa43-7fc09558711f"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("54d802d9-bd67-4c61-96b1-abfea62ec151"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("6497246c-4a8c-4172-912e-9e3b84a9c36c"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("6b667aa0-bccc-4306-9dbc-5eed401e8cec"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("6c24ad8b-5b4a-4690-8606-5176fd2ed6bf"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("767dfc64-97c7-4407-bdb7-67005be60b6b"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("79730908-719f-4d19-a0c1-ed3c853fb1a4"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("89fcae0c-0d2e-4731-afd4-674d8a9d7c25"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("9661924e-2d8b-4230-993d-c71b48a877b2"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("9f5052da-930f-4091-b285-6b4d1ff62dfc"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("a9be592f-75fe-4d5b-a3f3-7574cbd73322"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("aaf5e4e8-9273-4173-a6bb-0a3d14386083"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("ad2a0d3a-cd7c-4090-847f-aa206cfd641c"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("b8ea749b-15b9-4d29-90af-6cb16dfd1f39"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("bd31fa45-1ade-4b2b-875d-80900bb892f8"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("bd8777ef-eef2-4635-9457-c4541eade513"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("d5689ad2-d830-4c36-b488-53a636d1484d"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("da1a479e-c4fa-430f-9fc8-0c28fb1fcdfe"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("dd61a442-c713-4292-aa40-a322c5cfe4df"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("e4b633c8-4a38-4e4e-a955-1710ae74d37b"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("e529e035-2007-4551-af72-6698a39f52fa"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("eac17d4f-f9a0-4c6f-9c7f-6e138bc08080"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("ebded454-e6c6-4957-bab1-40c310ace072"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("f0e1c685-9925-42c7-b861-cd72ddb6af98"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("f126a9f8-fd10-486c-b464-765c74d09b19"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("fa39762c-e98b-4ada-93b3-3b4a53c9f74d"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("fc29f9b2-ab3d-4399-9ed9-7ef28f5aad37"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("fc52d09b-5e3b-4b8e-b954-1e390749aa6e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("0a9c1a2f-6fd0-42f2-acce-e1ab006468c4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1c43bf72-a827-49cd-a5c8-ddb098e0f0aa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("2660c650-bc5e-4bd0-b333-bb9280637c57"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("341b8d93-babc-4957-a3f6-912b78301288"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("5a3935ca-e41e-47a2-92da-d8ef3c1c0886"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("87713410-2ef2-4b36-9493-b6dffddb9274"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b124cbc7-cf1e-419c-b17c-6bb08be158a4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b6fdcd98-8acd-4ae2-ba7b-9be6c3ea5697"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("bd31c2fb-2552-476b-baef-52477e7c85b8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c49b9f48-1def-403c-ba2c-82c60a094b8a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("ca429e5b-0028-4692-8efb-5d7a600d6c5d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("ccfd99f6-7f49-49fe-a5c6-3790a627873f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d825e718-d7b4-4275-8d57-d0a63f2107c9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e3f611c7-0d19-4d42-9462-194e583b5bf2"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("115765cd-bf19-4309-8e14-fc7439813bfc"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("1944ef41-090d-4f22-b8a3-20057ae8fc52"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("32ffeaf9-e3c6-47a5-85e8-aaa359a5f465"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("53927afb-8a2e-431f-8709-6f5d130173e7"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("9720bb3c-fcc8-4bc2-8bb2-d313ceb2dcd5"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("a00b5831-0901-4d0e-b35e-f7515ea9ec8b"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("a93fa95f-e66c-4f41-8b4e-67e0d6f7b7cf"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("c498b09a-42d0-4f27-8e59-861ca965d73a"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("d62b5127-f62e-4c27-b508-966bc1341cb4"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("ebbe76d6-c8d1-41e1-bb3b-9107ad5a3dd8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("39d6faef-c0c6-4473-9d0e-2e67182df0c9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("3a036573-b78c-45bc-85be-244c470e6c47"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("3cec27fe-1c9d-42d2-8280-7521129390e7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("4a7a84e4-f630-4421-86f9-cf59029c76e1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("63fcae3b-884b-4288-9c7e-ffe128d27148"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("a86b7af6-95a0-45bd-a2fe-dbd55d5c9143"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ce05fc3f-b257-4cfb-bbfb-02e1a0f0923d"));

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandId", "Address", "Country", "ImageUrl", "IsDeleted", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("353fceea-6d94-48c5-8ca4-93a3f37297ae"), "678 Fighter Ave, Miami, FL", "USA", "/images/Brands/sanabul-logo.png", false, "Sanabul", "456-789-0123" },
                    { new Guid("49c61202-45f0-4153-89eb-db5672288f11"), "234 Fighter Rd, Bangkok, TH", "Thailand", "/images/Brands/fairtex-logo.png", false, "Fairtex", "876-543-2109" },
                    { new Guid("64f1ef10-2eb8-48cb-b706-4cf3313bced1"), "456 Sports Ave, London, UK", "UK", "/images/Brands/rdx-logo.png", false, "RDX", "456-789-0123" },
                    { new Guid("77845f58-628a-4b5b-a533-449a204a53e7"), "101 Martial Arts Way, Paris, FR", "France", "/images/Brands/venum-logo.png", false, "Venum", "321-654-0987" },
                    { new Guid("85642a49-0920-40cc-982f-ca3be1f66f99"), "567 Martial Arts Blvd, Oklahoma City, OK", "USA", "/images/Brands/century-logo.png", false, "Century", "345-678-9012" },
                    { new Guid("ab3f0e9b-a8c0-4b6b-baf0-21a69cc71312"), "456 Ring Rd, Chicago, IL", "USA", "/images/Brands/ringside-logo.png", false, "Ringside", "234-567-8901" },
                    { new Guid("b429009a-0fea-4d36-a38f-05958c4f9497"), "345 Punch Ln, Los Angeles, CA", "USA", "/images/Brands/title-boxing-logo.png", false, "Title Boxing", "987-654-3210" },
                    { new Guid("bb90d7e6-0766-4c38-9038-f1bd9f1156cb"), "123 Boxing Blvd, New York, NY", "USA", "/images/Brands/everlast-logo.png", false, "Everlast", "123-456-7890" },
                    { new Guid("bdef6a32-27f0-4708-9325-2f69e1ea7b6d"), "789 Fight St, Toronto, ON", "Canada", "/images/Brands/hayabusa-logo.png", false, "Hayabusa", "789-012-3456" },
                    { new Guid("dbe0c1c6-9ff3-43da-8f8b-6337519e1bcb"), "789 Kick Rd, Phuket, TH", "Thailand", "/images/Brands/twins-special-logo.png", false, "Twins Special", "567-890-1234" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "ImageUrl", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { new Guid("3a7693ba-e6b8-42e7-8c84-e6a6c3c9a733"), "/images/Categories/head-gear.png", false, "Headgear" },
                    { new Guid("46cd1650-6b10-4236-bcde-52a6ec192cf7"), "/images/Categories/clothing.png", false, "Clothing" },
                    { new Guid("66af80d4-d53f-4d35-89cd-bcadf38a4cd0"), "/images/Categories/boxing-shoes.png", false, "Shoes" },
                    { new Guid("88b722d2-c67a-452a-8f94-8827998bb830"), "/images/Categories/punching-bag.png", false, "Punching Bags" },
                    { new Guid("a0bb11de-5e1c-4802-8ad9-65ad443e549b"), "/images/Categories/shinguards.png", false, "Shinguards" },
                    { new Guid("a2761e6d-b4e1-439c-8ea3-66fa5b5d7cd7"), "/images/Categegories/boxing-gloves.png", false, "Gloves" },
                    { new Guid("b0ca88d6-d8b7-413a-a61c-91fc21097ab6"), "/images/Categories/protective-gear.png", false, "Protective Gear" },
                    { new Guid("b6bd9252-b81f-4f99-ae71-3eaa971b2bc0"), "/images/Categories/mouth-guard.png", false, "Mouthguards" },
                    { new Guid("bc342823-3197-45a1-b6a6-eb492b7cdaa5"), "/images/Categories/hand-wraps.png", false, "Hand Wraps" },
                    { new Guid("fd208e3f-20eb-4c3b-8ec5-8cbac3b57c8f"), "/images/Categories/training-equipment.png", false, "Training Equipment" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "BrandId", "CategoryId", "Description", "IsDeleted", "MainImageUrl", "Name", "Price", "Sizes", "StockQuantity" },
                values: new object[,]
                {
                    { new Guid("15801342-e11c-4de5-a709-c50a10b91bbc"), new Guid("353fceea-6d94-48c5-8ca4-93a3f37297ae"), new Guid("a0bb11de-5e1c-4802-8ad9-65ad443e549b"), "High-quality shin guards for protection and mobility.", false, "/images/Products/sanabul-shin-guards/sanabul-shin-guards-1.png", "Sanabul Essential Shin Guards", 35.99m, "[2,3,4]", 90 },
                    { new Guid("1f91e677-c2f1-4db1-9065-7ef40d88d0c9"), new Guid("b429009a-0fea-4d36-a38f-05958c4f9497"), new Guid("a2761e6d-b4e1-439c-8ea3-66fa5b5d7cd7"), "Durable leather gloves for heavy bag workouts.", false, "/images/Products/title-boxing-bag/title-boxing-bag-1.png", "Title Boxing Leather Bag Gloves", 59.99m, "[2,3]", 80 },
                    { new Guid("393179f2-7965-469c-846d-f13a99ce9781"), new Guid("77845f58-628a-4b5b-a533-449a204a53e7"), new Guid("a0bb11de-5e1c-4802-8ad9-65ad443e549b"), "High-durability shin guards ideal for intense training.", false, "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-2.png", "Venum Challenger Shin Guards", 45.99m, "[1,2,3]", 95 },
                    { new Guid("428e4783-9e38-4780-9fd7-c13b54c19633"), new Guid("bb90d7e6-0766-4c38-9038-f1bd9f1156cb"), new Guid("bc342823-3197-45a1-b6a6-eb492b7cdaa5"), "Classic wraps for wrist and knuckle protection.", false, "/images/Products/everlast-hand-wraps/everlast-hand-wraps-3.png", "Everlast Hand Wraps", 9.99m, "[2,3]", 200 },
                    { new Guid("487b9135-1dbc-4cee-ac05-90a51915d113"), new Guid("b429009a-0fea-4d36-a38f-05958c4f9497"), new Guid("88b722d2-c67a-452a-8f94-8827998bb830"), "Perfect for accuracy and reflex training.", false, "/images/Products/title-boxing-gloves/title-boxing-gloves-1.png", "Title Boxing Double End Bag", 44.99m, "[3]", 70 },
                    { new Guid("69c2f313-4f94-41cc-8dee-957f92f89fe8"), new Guid("49c61202-45f0-4153-89eb-db5672288f11"), new Guid("46cd1650-6b10-4236-bcde-52a6ec192cf7"), "Premium Muay Thai shorts with authentic design.", false, "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-1.png", "Fairtex Muay Thai Shorts", 34.99m, "[2,3,4]", 90 },
                    { new Guid("93ff4cc4-945f-4eaf-8792-353897001257"), new Guid("bdef6a32-27f0-4708-9325-2f69e1ea7b6d"), new Guid("a2761e6d-b4e1-439c-8ea3-66fa5b5d7cd7"), "Top-notch gloves with exceptional durability.", false, "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-1.png", "Hayabusa T3 Boxing Gloves", 89.99m, "[2,3,4]", 50 },
                    { new Guid("a77fb3cb-3cd3-4858-a702-bbf05bd0acc9"), new Guid("77845f58-628a-4b5b-a533-449a204a53e7"), new Guid("a2761e6d-b4e1-439c-8ea3-66fa5b5d7cd7"), "Lightweight and designed for all skill levels.", false, "/images/Products/venum-challenger-gloves/venum-challenger-gloves-2.png", "Venum Challenger Gloves", 39.99m, "[1,2,3]", 120 },
                    { new Guid("c4379984-db1b-4c8b-8ce5-6c1ffaae68f9"), new Guid("64f1ef10-2eb8-48cb-b706-4cf3313bced1"), new Guid("a2761e6d-b4e1-439c-8ea3-66fa5b5d7cd7"), "High-quality leather gloves for all training levels.", false, "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-3.png", "RDX Boxing Gloves", 49.99m, "[1,2,3]", 100 },
                    { new Guid("d49ac25a-40f2-4562-9b3a-ae80b2e8a48f"), new Guid("64f1ef10-2eb8-48cb-b706-4cf3313bced1"), new Guid("66af80d4-d53f-4d35-89cd-bcadf38a4cd0"), "Lightweight and supportive for agility in the ring.", false, "/images/Products/rdx-boxing-shoes/rdx-boxing-shoes-1.png", "RDX Pro Boxing Shoes", 69.99m, "[2,3,4]", 65 },
                    { new Guid("e5bb3096-de6b-4698-aeea-6dbeb3ae571b"), new Guid("bb90d7e6-0766-4c38-9038-f1bd9f1156cb"), new Guid("3a7693ba-e6b8-42e7-8c84-e6a6c3c9a733"), "Full-protection headgear with durable padding.", false, "/images/Products/everlasr-pro-headgear/everlast-headgear-1.png", "Everlast Pro Headgear", 69.99m, "[2,3]", 50 },
                    { new Guid("ebd21c2d-28b5-43f3-b8a3-20d267e5f0d4"), new Guid("85642a49-0920-40cc-982f-ca3be1f66f99"), new Guid("46cd1650-6b10-4236-bcde-52a6ec192cf7"), "Comfortable shorts designed for kickboxing.", false, "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-1.png", "Century Martial Arts Kickboxing Shorts", 29.99m, "[2,3,4]", 75 },
                    { new Guid("f3ea111d-3849-4984-a4be-6b8463e60355"), new Guid("dbe0c1c6-9ff3-43da-8f8b-6337519e1bcb"), new Guid("3a7693ba-e6b8-42e7-8c84-e6a6c3c9a733"), "Full-face protection with Twins quality.", false, "/images/Products/twins-special-headgear/twins-special-headgear-1.png", "Twins Special Headgear", 89.99m, "[1,2,3]", 60 },
                    { new Guid("f8ade953-7f8f-4b0e-a331-195bd4aa2b1d"), new Guid("ab3f0e9b-a8c0-4b6b-baf0-21a69cc71312"), new Guid("88b722d2-c67a-452a-8f94-8827998bb830"), "Heavy-duty bag for all levels of training.", false, "/images/Products/ringside-punching-bag/ringside-punching-bag-1.png", "Ringside Punching Bag", 119.99m, "[3]", 40 }
                });

            migrationBuilder.InsertData(
                table: "ProductsImages",
                columns: new[] { "ImageId", "ImageUrl", "ProductId" },
                values: new object[,]
                {
                    { new Guid("0170ea96-44e0-4a82-ab69-dc98c212a7bf"), "/images/Products/title-boxing-gloves/title-boxing-gloves-1.png", new Guid("487b9135-1dbc-4cee-ac05-90a51915d113") },
                    { new Guid("10f2787c-21a0-4cd5-ab71-77204e3a8a9d"), "/images/Products/rdx-boxing-shoes/rdx-boxing-shoes-3.png", new Guid("d49ac25a-40f2-4562-9b3a-ae80b2e8a48f") },
                    { new Guid("13c5c9bd-2b23-40f7-b19d-3b7bb9131ab3"), "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-3.png", new Guid("c4379984-db1b-4c8b-8ce5-6c1ffaae68f9") },
                    { new Guid("145bcef1-54a0-4019-a283-99856ea6568d"), "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-2.png", new Guid("93ff4cc4-945f-4eaf-8792-353897001257") },
                    { new Guid("1464bfb7-50b0-4a0e-83f3-84f7cf50c3c8"), "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-2.png", new Guid("ebd21c2d-28b5-43f3-b8a3-20d267e5f0d4") },
                    { new Guid("14b105b2-45d3-468c-a3e9-d3c0cec359d1"), "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-2.png", new Guid("c4379984-db1b-4c8b-8ce5-6c1ffaae68f9") },
                    { new Guid("18f98941-e14b-49d9-adf4-394476db8401"), "/images/Products/rdx-boxing-shoes/rdx-boxing-shoes-2.png", new Guid("d49ac25a-40f2-4562-9b3a-ae80b2e8a48f") },
                    { new Guid("1d0929ee-2313-415a-8ae6-b8101a5be749"), "/images/Products/everlasr-pro-headgear/everlast-headgear-2.png", new Guid("e5bb3096-de6b-4698-aeea-6dbeb3ae571b") },
                    { new Guid("2006d502-0b49-4f83-ba27-f15063da8c55"), "/images/Products/everlast-hand-wraps/everlast-hand-wraps-3.png", new Guid("428e4783-9e38-4780-9fd7-c13b54c19633") },
                    { new Guid("2ffac221-8347-4610-8d6a-242d885f60fa"), "/images/Products/title-boxing-bag/title-boxing-bag-2.png", new Guid("1f91e677-c2f1-4db1-9065-7ef40d88d0c9") },
                    { new Guid("36854cc1-5d6a-4a4e-8d51-89b56fc7e32f"), "/images/Products/title-boxing-gloves/title-boxing-gloves-3.png", new Guid("487b9135-1dbc-4cee-ac05-90a51915d113") },
                    { new Guid("3cb99269-4f8c-4654-8f98-ff9e42afa295"), "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-3.png", new Guid("69c2f313-4f94-41cc-8dee-957f92f89fe8") },
                    { new Guid("4f4de59d-447a-4241-9dae-2dc48ffb9d7b"), "/images/Products/title-boxing-gloves/title-boxing-gloves-2.png", new Guid("487b9135-1dbc-4cee-ac05-90a51915d113") },
                    { new Guid("4f9fe42f-d904-481c-8e60-2edaad6d3436"), "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-1.png", new Guid("c4379984-db1b-4c8b-8ce5-6c1ffaae68f9") },
                    { new Guid("5517d653-5885-4863-820a-bb45f9cb4b61"), "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-1.png", new Guid("393179f2-7965-469c-846d-f13a99ce9781") },
                    { new Guid("589fabab-3c75-451a-92c9-f4a6d06ce29e"), "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-3.png", new Guid("393179f2-7965-469c-846d-f13a99ce9781") },
                    { new Guid("6d46812a-6936-4cfb-9a5e-27e80fa4b546"), "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-2.png", new Guid("393179f2-7965-469c-846d-f13a99ce9781") },
                    { new Guid("6ea62df1-6788-427c-9eda-4f850c030385"), "/images/Products/sanabul-shin-guards/sanabul-shin-guards-3.png", new Guid("15801342-e11c-4de5-a709-c50a10b91bbc") },
                    { new Guid("7338f75f-9d30-41c0-9530-2f6af30820b2"), "/images/Products/twins-special-headgear/twins-special-headgear-1.png", new Guid("f3ea111d-3849-4984-a4be-6b8463e60355") },
                    { new Guid("73cb239c-1ca8-43dc-8b00-08fbce909ad3"), "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-2.png", new Guid("69c2f313-4f94-41cc-8dee-957f92f89fe8") },
                    { new Guid("7f0c6e95-eb53-4b6a-bace-f3bdfc11f4f9"), "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-1.png", new Guid("93ff4cc4-945f-4eaf-8792-353897001257") },
                    { new Guid("80a7513a-f743-4469-b686-af8715cf03c3"), "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-1.png", new Guid("ebd21c2d-28b5-43f3-b8a3-20d267e5f0d4") },
                    { new Guid("81c058da-6467-46e9-9d1b-d8b75be4d0fc"), "/images/Products/title-boxing-bag/title-boxing-bag-3.png", new Guid("1f91e677-c2f1-4db1-9065-7ef40d88d0c9") },
                    { new Guid("8edaf6cd-4256-4749-8f97-c9a8ec50ddf7"), "/images/Products/ringside-punching-bag/ringside-punching-bag-2.png", new Guid("f8ade953-7f8f-4b0e-a331-195bd4aa2b1d") },
                    { new Guid("93458cc7-93e6-4e43-ab5a-6de02aeff7e7"), "/images/Products/rdx-boxing-shoes/rdx-boxing-shoes-1.png", new Guid("d49ac25a-40f2-4562-9b3a-ae80b2e8a48f") },
                    { new Guid("953353db-04e7-46c3-b9e3-b0a852bc33b0"), "/images/Products/venum-challenger-gloves/venum-challenger-gloves-2.png", new Guid("a77fb3cb-3cd3-4858-a702-bbf05bd0acc9") },
                    { new Guid("95f127eb-6705-4b88-98e3-87e1fa1b750c"), "/images/Products/sanabul-shin-guards/sanabul-shin-guards-2.png", new Guid("15801342-e11c-4de5-a709-c50a10b91bbc") },
                    { new Guid("a0d1b9e3-8f5b-4a6b-bfbf-c04ef38314f7"), "/images/Products/venum-challenger-gloves/venum-challenger-gloves-1.png", new Guid("a77fb3cb-3cd3-4858-a702-bbf05bd0acc9") },
                    { new Guid("af05b0fd-de30-430b-9ad0-9054151dc67f"), "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-3.png", new Guid("93ff4cc4-945f-4eaf-8792-353897001257") },
                    { new Guid("af8f704a-b31c-4a69-bda3-17a231cbeddf"), "/images/Products/ringside-punching-bag/ringside-punching-bag-3.png", new Guid("f8ade953-7f8f-4b0e-a331-195bd4aa2b1d") },
                    { new Guid("b2e7a681-57e0-448a-a290-027df4d896aa"), "/images/Products/venum-challenger-gloves/venum-challenger-gloves-3.png", new Guid("a77fb3cb-3cd3-4858-a702-bbf05bd0acc9") },
                    { new Guid("b8b691f3-4908-4511-a353-6470941100bf"), "/images/Products/everlast-hand-wraps/everlast-hand-wraps-1.png", new Guid("428e4783-9e38-4780-9fd7-c13b54c19633") },
                    { new Guid("cc62350b-8be6-4c4a-b0c5-f887e4d0a84f"), "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-1.png", new Guid("69c2f313-4f94-41cc-8dee-957f92f89fe8") },
                    { new Guid("d4e00dc3-82b3-4cc4-b2e6-66b2c4bc2eab"), "/images/Products/ringside-punching-bag/ringside-punching-bag-1.png", new Guid("f8ade953-7f8f-4b0e-a331-195bd4aa2b1d") },
                    { new Guid("d8d1d425-021e-4d12-91b4-3f46c62a849b"), "/images/Products/twins-special-headgear/twins-shin-headgear-3.png", new Guid("f3ea111d-3849-4984-a4be-6b8463e60355") },
                    { new Guid("db229572-3949-4792-a61b-6cd634a142e9"), "/images/Products/everlast-hand-wraps/everlast-hand-wraps-2.png", new Guid("428e4783-9e38-4780-9fd7-c13b54c19633") },
                    { new Guid("e23480ec-0394-4c93-bb4c-df8e281be7a1"), "/images/Products/twins-special-headgear/twins-special-headgear-2.png", new Guid("f3ea111d-3849-4984-a4be-6b8463e60355") },
                    { new Guid("ea3185c0-1f31-4847-8bed-dbe1c9009dcd"), "/images/Products/everlasr-pro-headgear/everlast-headgear-1.png", new Guid("e5bb3096-de6b-4698-aeea-6dbeb3ae571b") },
                    { new Guid("ef0b332b-85fd-4f23-b678-a199680d99b0"), "/images/Products/sanabul-shin-guards/sanabul-shin-guards-1.png", new Guid("15801342-e11c-4de5-a709-c50a10b91bbc") },
                    { new Guid("f00ae22e-fcd5-47df-9c42-db80775567d1"), "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-3.png", new Guid("ebd21c2d-28b5-43f3-b8a3-20d267e5f0d4") },
                    { new Guid("f54cd91c-0a8d-49ad-a0c2-e0397adcf242"), "/images/Products/title-boxing-bag/title-boxing-bag-1.png", new Guid("1f91e677-c2f1-4db1-9065-7ef40d88d0c9") },
                    { new Guid("faad1217-d1c4-46ba-9afa-cbff081bc770"), "/images/Products/everlasr-pro-headgear/everlast-headgear-3.png", new Guid("e5bb3096-de6b-4698-aeea-6dbeb3ae571b") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("b0ca88d6-d8b7-413a-a61c-91fc21097ab6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("b6bd9252-b81f-4f99-ae71-3eaa971b2bc0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("fd208e3f-20eb-4c3b-8ec5-8cbac3b57c8f"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("0170ea96-44e0-4a82-ab69-dc98c212a7bf"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("10f2787c-21a0-4cd5-ab71-77204e3a8a9d"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("13c5c9bd-2b23-40f7-b19d-3b7bb9131ab3"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("145bcef1-54a0-4019-a283-99856ea6568d"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("1464bfb7-50b0-4a0e-83f3-84f7cf50c3c8"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("14b105b2-45d3-468c-a3e9-d3c0cec359d1"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("18f98941-e14b-49d9-adf4-394476db8401"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("1d0929ee-2313-415a-8ae6-b8101a5be749"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("2006d502-0b49-4f83-ba27-f15063da8c55"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("2ffac221-8347-4610-8d6a-242d885f60fa"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("36854cc1-5d6a-4a4e-8d51-89b56fc7e32f"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("3cb99269-4f8c-4654-8f98-ff9e42afa295"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("4f4de59d-447a-4241-9dae-2dc48ffb9d7b"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("4f9fe42f-d904-481c-8e60-2edaad6d3436"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("5517d653-5885-4863-820a-bb45f9cb4b61"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("589fabab-3c75-451a-92c9-f4a6d06ce29e"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("6d46812a-6936-4cfb-9a5e-27e80fa4b546"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("6ea62df1-6788-427c-9eda-4f850c030385"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("7338f75f-9d30-41c0-9530-2f6af30820b2"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("73cb239c-1ca8-43dc-8b00-08fbce909ad3"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("7f0c6e95-eb53-4b6a-bace-f3bdfc11f4f9"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("80a7513a-f743-4469-b686-af8715cf03c3"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("81c058da-6467-46e9-9d1b-d8b75be4d0fc"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("8edaf6cd-4256-4749-8f97-c9a8ec50ddf7"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("93458cc7-93e6-4e43-ab5a-6de02aeff7e7"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("953353db-04e7-46c3-b9e3-b0a852bc33b0"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("95f127eb-6705-4b88-98e3-87e1fa1b750c"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("a0d1b9e3-8f5b-4a6b-bfbf-c04ef38314f7"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("af05b0fd-de30-430b-9ad0-9054151dc67f"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("af8f704a-b31c-4a69-bda3-17a231cbeddf"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("b2e7a681-57e0-448a-a290-027df4d896aa"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("b8b691f3-4908-4511-a353-6470941100bf"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("cc62350b-8be6-4c4a-b0c5-f887e4d0a84f"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("d4e00dc3-82b3-4cc4-b2e6-66b2c4bc2eab"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("d8d1d425-021e-4d12-91b4-3f46c62a849b"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("db229572-3949-4792-a61b-6cd634a142e9"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("e23480ec-0394-4c93-bb4c-df8e281be7a1"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("ea3185c0-1f31-4847-8bed-dbe1c9009dcd"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("ef0b332b-85fd-4f23-b678-a199680d99b0"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("f00ae22e-fcd5-47df-9c42-db80775567d1"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("f54cd91c-0a8d-49ad-a0c2-e0397adcf242"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("faad1217-d1c4-46ba-9afa-cbff081bc770"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("15801342-e11c-4de5-a709-c50a10b91bbc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1f91e677-c2f1-4db1-9065-7ef40d88d0c9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("393179f2-7965-469c-846d-f13a99ce9781"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("428e4783-9e38-4780-9fd7-c13b54c19633"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("487b9135-1dbc-4cee-ac05-90a51915d113"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("69c2f313-4f94-41cc-8dee-957f92f89fe8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("93ff4cc4-945f-4eaf-8792-353897001257"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a77fb3cb-3cd3-4858-a702-bbf05bd0acc9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c4379984-db1b-4c8b-8ce5-6c1ffaae68f9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d49ac25a-40f2-4562-9b3a-ae80b2e8a48f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e5bb3096-de6b-4698-aeea-6dbeb3ae571b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("ebd21c2d-28b5-43f3-b8a3-20d267e5f0d4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f3ea111d-3849-4984-a4be-6b8463e60355"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f8ade953-7f8f-4b0e-a331-195bd4aa2b1d"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("353fceea-6d94-48c5-8ca4-93a3f37297ae"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("49c61202-45f0-4153-89eb-db5672288f11"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("64f1ef10-2eb8-48cb-b706-4cf3313bced1"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("77845f58-628a-4b5b-a533-449a204a53e7"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("85642a49-0920-40cc-982f-ca3be1f66f99"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("ab3f0e9b-a8c0-4b6b-baf0-21a69cc71312"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("b429009a-0fea-4d36-a38f-05958c4f9497"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("bb90d7e6-0766-4c38-9038-f1bd9f1156cb"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("bdef6a32-27f0-4708-9325-2f69e1ea7b6d"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("dbe0c1c6-9ff3-43da-8f8b-6337519e1bcb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("3a7693ba-e6b8-42e7-8c84-e6a6c3c9a733"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("46cd1650-6b10-4236-bcde-52a6ec192cf7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("66af80d4-d53f-4d35-89cd-bcadf38a4cd0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("88b722d2-c67a-452a-8f94-8827998bb830"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("a0bb11de-5e1c-4802-8ad9-65ad443e549b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("a2761e6d-b4e1-439c-8ea3-66fa5b5d7cd7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("bc342823-3197-45a1-b6a6-eb492b7cdaa5"));

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandId", "Address", "Country", "ImageUrl", "IsDeleted", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("115765cd-bf19-4309-8e14-fc7439813bfc"), "789 Kick Rd, Phuket, TH", "Thailand", "/images/Brands/twins-special-logo.png", false, "Twins Special", "567-890-1234" },
                    { new Guid("1944ef41-090d-4f22-b8a3-20057ae8fc52"), "456 Sports Ave, London, UK", "UK", "/images/Brands/rdx-logo.png", false, "RDX", "456-789-0123" },
                    { new Guid("32ffeaf9-e3c6-47a5-85e8-aaa359a5f465"), "456 Ring Rd, Chicago, IL", "USA", "/images/Brands/ringside-logo.png", false, "Ringside", "234-567-8901" },
                    { new Guid("53927afb-8a2e-431f-8709-6f5d130173e7"), "101 Martial Arts Way, Paris, FR", "France", "/images/Brands/venum-logo.png", false, "Venum", "321-654-0987" },
                    { new Guid("9720bb3c-fcc8-4bc2-8bb2-d313ceb2dcd5"), "123 Boxing Blvd, New York, NY", "USA", "/images/Brands/everlast-logo.png", false, "Everlast", "123-456-7890" },
                    { new Guid("a00b5831-0901-4d0e-b35e-f7515ea9ec8b"), "345 Punch Ln, Los Angeles, CA", "USA", "/images/Brands/title-boxing-logo.png", false, "Title Boxing", "987-654-3210" },
                    { new Guid("a93fa95f-e66c-4f41-8b4e-67e0d6f7b7cf"), "678 Fighter Ave, Miami, FL", "USA", "/images/Brands/sanabul-logo.png", false, "Sanabul", "456-789-0123" },
                    { new Guid("c498b09a-42d0-4f27-8e59-861ca965d73a"), "234 Fighter Rd, Bangkok, TH", "Thailand", "/images/Brands/fairtex-logo.png", false, "Fairtex", "876-543-2109" },
                    { new Guid("d62b5127-f62e-4c27-b508-966bc1341cb4"), "567 Martial Arts Blvd, Oklahoma City, OK", "USA", "/images/Brands/century-logo.png", false, "Century", "345-678-9012" },
                    { new Guid("ebbe76d6-c8d1-41e1-bb3b-9107ad5a3dd8"), "789 Fight St, Toronto, ON", "Canada", "/images/Brands/hayabusa-logo.png", false, "Hayabusa", "789-012-3456" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "ImageUrl", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { new Guid("389d3d54-2adf-40ea-8fd2-e31e34b425a8"), "/images/Categories/mouth-guard.png", false, "Mouthguards" },
                    { new Guid("39d6faef-c0c6-4473-9d0e-2e67182df0c9"), "/images/Categories/head-gear.png", false, "Headgear" },
                    { new Guid("3a036573-b78c-45bc-85be-244c470e6c47"), "/images/Categories/hand-wraps.png", false, "Hand Wraps" },
                    { new Guid("3cec27fe-1c9d-42d2-8280-7521129390e7"), "/images/Categories/shinguards.png", false, "Shinguards" },
                    { new Guid("3fb6b1db-4c50-4766-9351-2ea61ac2141d"), "/images/Categories/protective-gear.png", false, "Protective Gear" },
                    { new Guid("4a7a84e4-f630-4421-86f9-cf59029c76e1"), "/images/Categories/clothing.png", false, "Clothing" },
                    { new Guid("63fcae3b-884b-4288-9c7e-ffe128d27148"), "/images/Categegories/boxing-gloves.png", false, "Gloves" },
                    { new Guid("a86b7af6-95a0-45bd-a2fe-dbd55d5c9143"), "/images/Categories/boxing-shoes.png", false, "Shoes" },
                    { new Guid("ce05fc3f-b257-4cfb-bbfb-02e1a0f0923d"), "/images/Categories/punching-bag.png", false, "Punching Bags" },
                    { new Guid("df9db806-5fe8-4df2-ac1f-583676676b2c"), "/images/Categories/training-equipment.png", false, "Training Equipment" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "BrandId", "CategoryId", "Description", "IsDeleted", "MainImageUrl", "Name", "Price", "Sizes", "StockQuantity" },
                values: new object[,]
                {
                    { new Guid("0a9c1a2f-6fd0-42f2-acce-e1ab006468c4"), new Guid("115765cd-bf19-4309-8e14-fc7439813bfc"), new Guid("39d6faef-c0c6-4473-9d0e-2e67182df0c9"), "Full-face protection with Twins quality.", false, "/images/Products/twins-special-headgear/twins-special-headgear-1.png", "Twins Special Headgear", 89.99m, "[1,2,3]", 60 },
                    { new Guid("1c43bf72-a827-49cd-a5c8-ddb098e0f0aa"), new Guid("1944ef41-090d-4f22-b8a3-20057ae8fc52"), new Guid("a86b7af6-95a0-45bd-a2fe-dbd55d5c9143"), "Lightweight and supportive for agility in the ring.", false, "/images/Products/rdx-boxing-shoes/rdx-boxing-shoes-1.png", "RDX Pro Boxing Shoes", 69.99m, "[2,3,4]", 65 },
                    { new Guid("2660c650-bc5e-4bd0-b333-bb9280637c57"), new Guid("c498b09a-42d0-4f27-8e59-861ca965d73a"), new Guid("4a7a84e4-f630-4421-86f9-cf59029c76e1"), "Premium Muay Thai shorts with authentic design.", false, "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-1.png", "Fairtex Muay Thai Shorts", 34.99m, "[2,3,4]", 90 },
                    { new Guid("341b8d93-babc-4957-a3f6-912b78301288"), new Guid("53927afb-8a2e-431f-8709-6f5d130173e7"), new Guid("3cec27fe-1c9d-42d2-8280-7521129390e7"), "High-durability shin guards ideal for intense training.", false, "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-1.png", "Venum Challenger Shin Guards", 45.99m, "[1,2,3]", 95 },
                    { new Guid("5a3935ca-e41e-47a2-92da-d8ef3c1c0886"), new Guid("32ffeaf9-e3c6-47a5-85e8-aaa359a5f465"), new Guid("ce05fc3f-b257-4cfb-bbfb-02e1a0f0923d"), "Heavy-duty bag for all levels of training.", false, "/images/Products/ringside-punching-bag/ringside-punching-bag-1.png", "Ringside Punching Bag", 119.99m, "[3]", 40 },
                    { new Guid("87713410-2ef2-4b36-9493-b6dffddb9274"), new Guid("1944ef41-090d-4f22-b8a3-20057ae8fc52"), new Guid("63fcae3b-884b-4288-9c7e-ffe128d27148"), "High-quality leather gloves for all training levels.", false, "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-2.png", "RDX Boxing Gloves", 49.99m, "[1,2,3]", 100 },
                    { new Guid("b124cbc7-cf1e-419c-b17c-6bb08be158a4"), new Guid("9720bb3c-fcc8-4bc2-8bb2-d313ceb2dcd5"), new Guid("3a036573-b78c-45bc-85be-244c470e6c47"), "Classic wraps for wrist and knuckle protection.", false, "/images/Products/everlast-hand-wraps/everlast-hand-wraps-2.png", "Everlast Hand Wraps", 9.99m, "[2,3]", 200 },
                    { new Guid("b6fdcd98-8acd-4ae2-ba7b-9be6c3ea5697"), new Guid("53927afb-8a2e-431f-8709-6f5d130173e7"), new Guid("63fcae3b-884b-4288-9c7e-ffe128d27148"), "Lightweight and designed for all skill levels.", false, "/images/Products/venum-challenger-gloves/venum-challenger-gloves-1.png", "Venum Challenger Gloves", 39.99m, "[1,2,3]", 120 },
                    { new Guid("bd31c2fb-2552-476b-baef-52477e7c85b8"), new Guid("a00b5831-0901-4d0e-b35e-f7515ea9ec8b"), new Guid("ce05fc3f-b257-4cfb-bbfb-02e1a0f0923d"), "Perfect for accuracy and reflex training.", false, "/images/Products/title-boxing-gloves/title-boxing-gloves-1.png", "Title Boxing Double End Bag", 44.99m, "[3]", 70 },
                    { new Guid("c49b9f48-1def-403c-ba2c-82c60a094b8a"), new Guid("a93fa95f-e66c-4f41-8b4e-67e0d6f7b7cf"), new Guid("3cec27fe-1c9d-42d2-8280-7521129390e7"), "High-quality shin guards for protection and mobility.", false, "/images/Products/sanabul-shin-guards/sanabul-shin-guards-1.png", "Sanabul Essential Shin Guards", 35.99m, "[2,3,4]", 90 },
                    { new Guid("ca429e5b-0028-4692-8efb-5d7a600d6c5d"), new Guid("9720bb3c-fcc8-4bc2-8bb2-d313ceb2dcd5"), new Guid("39d6faef-c0c6-4473-9d0e-2e67182df0c9"), "Full-protection headgear with durable padding.", false, "/images/Products/everlasr-pro-headgear/everlast-pro-headgear-1.png", "Everlast Pro Headgear", 69.99m, "[2,3]", 50 },
                    { new Guid("ccfd99f6-7f49-49fe-a5c6-3790a627873f"), new Guid("a00b5831-0901-4d0e-b35e-f7515ea9ec8b"), new Guid("63fcae3b-884b-4288-9c7e-ffe128d27148"), "Durable leather gloves for heavy bag workouts.", false, "/images/Products/title-boxing-bag/title-boxing-bag-1.png", "Title Boxing Leather Bag Gloves", 59.99m, "[2,3]", 80 },
                    { new Guid("d825e718-d7b4-4275-8d57-d0a63f2107c9"), new Guid("ebbe76d6-c8d1-41e1-bb3b-9107ad5a3dd8"), new Guid("63fcae3b-884b-4288-9c7e-ffe128d27148"), "Top-notch gloves with exceptional durability.", false, "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-1.png", "Hayabusa T3 Boxing Gloves", 89.99m, "[2,3,4]", 50 },
                    { new Guid("e3f611c7-0d19-4d42-9462-194e583b5bf2"), new Guid("d62b5127-f62e-4c27-b508-966bc1341cb4"), new Guid("4a7a84e4-f630-4421-86f9-cf59029c76e1"), "Comfortable shorts designed for kickboxing.", false, "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-1.png", "Century Martial Arts Kickboxing Shorts", 29.99m, "[2,3,4]", 75 }
                });

            migrationBuilder.InsertData(
                table: "ProductsImages",
                columns: new[] { "ImageId", "ImageUrl", "ProductId" },
                values: new object[,]
                {
                    { new Guid("04a38bde-aa32-4348-a47d-8f04eec2657d"), "/images/Products/rdx-boxing-shoes/rdx-boxing-shoes-2.png", new Guid("1c43bf72-a827-49cd-a5c8-ddb098e0f0aa") },
                    { new Guid("0702b6bc-7ef5-486c-801c-52862dd1efac"), "/images/Products/sanabul-shin-guards/sanabul-shin-guards-1.png", new Guid("c49b9f48-1def-403c-ba2c-82c60a094b8a") },
                    { new Guid("08c7cd44-50fb-437f-ac9f-529514bc8e66"), "/images/Products/sanabul-shin-guards/sanabul-shin-guards-2.png", new Guid("c49b9f48-1def-403c-ba2c-82c60a094b8a") },
                    { new Guid("1029cb26-b008-4de1-a2fd-989c363c5a64"), "/images/Products/title-boxing-gloves/title-boxing-gloves-2.png", new Guid("bd31c2fb-2552-476b-baef-52477e7c85b8") },
                    { new Guid("1573ece9-a1c9-40b9-a591-bd8999fdd55e"), "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-3.png", new Guid("341b8d93-babc-4957-a3f6-912b78301288") },
                    { new Guid("17704f0d-3c7e-47c4-b09e-8e758c943b4a"), "/images/Products/everlasr-pro-headgear/everlast-headgear-3.png", new Guid("ca429e5b-0028-4692-8efb-5d7a600d6c5d") },
                    { new Guid("1cd3088d-b0b1-4f41-9bc9-5acef6174ef0"), "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-3.png", new Guid("d825e718-d7b4-4275-8d57-d0a63f2107c9") },
                    { new Guid("1f52c194-f6c1-49fc-a4b6-2c01a3cff1e1"), "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-2.png", new Guid("341b8d93-babc-4957-a3f6-912b78301288") },
                    { new Guid("275ef00f-72d3-4689-8de6-df819382c2d1"), "/images/Products/ringside-punching-bag/ringside-punching-bag-2.png", new Guid("5a3935ca-e41e-47a2-92da-d8ef3c1c0886") },
                    { new Guid("2b958cd8-5d41-4220-8cc5-04d6e43ec584"), "/images/Products/rdx-boxing-shoes/rdx-boxing-shoes-1.png", new Guid("1c43bf72-a827-49cd-a5c8-ddb098e0f0aa") },
                    { new Guid("3b8ad847-893b-478c-ab32-820fda4a7d29"), "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-2.png", new Guid("87713410-2ef2-4b36-9493-b6dffddb9274") },
                    { new Guid("3c94bb6b-983a-471e-ba36-352398c3f95a"), "/images/Products/twins-special-headgear/twins-special-headgear-1.png", new Guid("0a9c1a2f-6fd0-42f2-acce-e1ab006468c4") },
                    { new Guid("3d47bf64-4e42-4d71-b89c-74a4dfd87a34"), "/images/Products/title-boxing-bag/title-boxing-bag-1.png", new Guid("ccfd99f6-7f49-49fe-a5c6-3790a627873f") },
                    { new Guid("536a3625-89f5-4f19-a072-868bcc8101bb"), "/images/Products/ringside-punching-bag/ringside-punching-bag-1.png", new Guid("5a3935ca-e41e-47a2-92da-d8ef3c1c0886") },
                    { new Guid("5456036e-fcaa-46b7-aa43-7fc09558711f"), "/images/Products/title-boxing-bag/title-boxing-bag-2.png", new Guid("ccfd99f6-7f49-49fe-a5c6-3790a627873f") },
                    { new Guid("54d802d9-bd67-4c61-96b1-abfea62ec151"), "/images/Products/twins-special-headgear/twins-shin-headgear-3.png", new Guid("0a9c1a2f-6fd0-42f2-acce-e1ab006468c4") },
                    { new Guid("6497246c-4a8c-4172-912e-9e3b84a9c36c"), "/images/Products/venum-challenger-gloves/venum-challenger-gloves-1.png", new Guid("b6fdcd98-8acd-4ae2-ba7b-9be6c3ea5697") },
                    { new Guid("6b667aa0-bccc-4306-9dbc-5eed401e8cec"), "/images/Products/rdx-boxing-shoes/rdx-boxing-shoes-3.png", new Guid("1c43bf72-a827-49cd-a5c8-ddb098e0f0aa") },
                    { new Guid("6c24ad8b-5b4a-4690-8606-5176fd2ed6bf"), "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-2.png", new Guid("d825e718-d7b4-4275-8d57-d0a63f2107c9") },
                    { new Guid("767dfc64-97c7-4407-bdb7-67005be60b6b"), "/images/Products/venum-challenger-gloves/venum-challenger-gloves-2.png", new Guid("b6fdcd98-8acd-4ae2-ba7b-9be6c3ea5697") },
                    { new Guid("79730908-719f-4d19-a0c1-ed3c853fb1a4"), "/images/Products/title-boxing-bag/title-boxing-bag-3.png", new Guid("ccfd99f6-7f49-49fe-a5c6-3790a627873f") },
                    { new Guid("89fcae0c-0d2e-4731-afd4-674d8a9d7c25"), "/images/Products/everlast-hand-wraps/everlast-hand-wraps-2.png", new Guid("b124cbc7-cf1e-419c-b17c-6bb08be158a4") },
                    { new Guid("9661924e-2d8b-4230-993d-c71b48a877b2"), "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-3.png", new Guid("2660c650-bc5e-4bd0-b333-bb9280637c57") },
                    { new Guid("9f5052da-930f-4091-b285-6b4d1ff62dfc"), "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-2.png", new Guid("2660c650-bc5e-4bd0-b333-bb9280637c57") },
                    { new Guid("a9be592f-75fe-4d5b-a3f3-7574cbd73322"), "/images/Products/everlasr-pro-headgear/everlast-headgear-2.png", new Guid("ca429e5b-0028-4692-8efb-5d7a600d6c5d") },
                    { new Guid("aaf5e4e8-9273-4173-a6bb-0a3d14386083"), "/images/Products/venum-challenger-gloves/venum-challenger-gloves-3.png", new Guid("b6fdcd98-8acd-4ae2-ba7b-9be6c3ea5697") },
                    { new Guid("ad2a0d3a-cd7c-4090-847f-aa206cfd641c"), "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-1.png", new Guid("e3f611c7-0d19-4d42-9462-194e583b5bf2") },
                    { new Guid("b8ea749b-15b9-4d29-90af-6cb16dfd1f39"), "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-2.png", new Guid("e3f611c7-0d19-4d42-9462-194e583b5bf2") },
                    { new Guid("bd31fa45-1ade-4b2b-875d-80900bb892f8"), "/images/Products/twins-special-headgear/twins-special-headgear-2.png", new Guid("0a9c1a2f-6fd0-42f2-acce-e1ab006468c4") },
                    { new Guid("bd8777ef-eef2-4635-9457-c4541eade513"), "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-1.png", new Guid("87713410-2ef2-4b36-9493-b6dffddb9274") },
                    { new Guid("d5689ad2-d830-4c36-b488-53a636d1484d"), "/images/Products/everlasr-pro-headgear/everlast-headgear-1.png", new Guid("ca429e5b-0028-4692-8efb-5d7a600d6c5d") },
                    { new Guid("da1a479e-c4fa-430f-9fc8-0c28fb1fcdfe"), "/images/Products/ringside-punching-bag/ringside-punching-bag-3.png", new Guid("5a3935ca-e41e-47a2-92da-d8ef3c1c0886") },
                    { new Guid("dd61a442-c713-4292-aa40-a322c5cfe4df"), "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-1.png", new Guid("2660c650-bc5e-4bd0-b333-bb9280637c57") },
                    { new Guid("e4b633c8-4a38-4e4e-a955-1710ae74d37b"), "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-1.png", new Guid("d825e718-d7b4-4275-8d57-d0a63f2107c9") },
                    { new Guid("e529e035-2007-4551-af72-6698a39f52fa"), "/images/Products/everlast-hand-wraps/everlast-hand-wraps-1.png", new Guid("b124cbc7-cf1e-419c-b17c-6bb08be158a4") },
                    { new Guid("eac17d4f-f9a0-4c6f-9c7f-6e138bc08080"), "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-1.png", new Guid("341b8d93-babc-4957-a3f6-912b78301288") },
                    { new Guid("ebded454-e6c6-4957-bab1-40c310ace072"), "/images/Products/sanabul-shin-guards/sanabul-shin-guards-3.png", new Guid("c49b9f48-1def-403c-ba2c-82c60a094b8a") },
                    { new Guid("f0e1c685-9925-42c7-b861-cd72ddb6af98"), "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-3.png", new Guid("e3f611c7-0d19-4d42-9462-194e583b5bf2") },
                    { new Guid("f126a9f8-fd10-486c-b464-765c74d09b19"), "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-3.png", new Guid("87713410-2ef2-4b36-9493-b6dffddb9274") },
                    { new Guid("fa39762c-e98b-4ada-93b3-3b4a53c9f74d"), "/images/Products/everlast-hand-wraps/everlast-hand-wraps-3.png", new Guid("b124cbc7-cf1e-419c-b17c-6bb08be158a4") },
                    { new Guid("fc29f9b2-ab3d-4399-9ed9-7ef28f5aad37"), "/images/Products/title-boxing-gloves/title-boxing-gloves-1.png", new Guid("bd31c2fb-2552-476b-baef-52477e7c85b8") },
                    { new Guid("fc52d09b-5e3b-4b8e-b954-1e390749aa6e"), "/images/Products/title-boxing-gloves/title-boxing-gloves-3.png", new Guid("bd31c2fb-2552-476b-baef-52477e7c85b8") }
                });
        }
    }
}
