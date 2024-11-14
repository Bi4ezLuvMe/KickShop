using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KickShop.Migrations
{
    /// <inheritdoc />
    public partial class FixedImageUrls : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("34369468-46a0-43ab-b5a5-ec1d4fe15574"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("3ed9c652-85a1-4868-ac5a-454fe9f16897"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("71a2dcc6-0e39-4226-ae88-198be0d10f6b"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("2c951c7e-3a28-4f82-a101-9c30a0a1691e"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("2f2fa14b-1c4a-42ca-96d7-0d81d0440682"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("34659e02-9480-4180-bf82-4d79e2e4f493"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("455033ff-9e87-44dc-939f-c234c54edead"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("45c79e95-9bc4-4941-8c94-a7aba75cbed5"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("489e5e66-9857-4a41-917b-bcc00902ae5b"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("4f4c719f-2c88-4cd4-bc4b-d85351cf50e1"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("57ccc5ac-2d38-420b-9cb2-e31c0dc56908"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("5c6dec9a-f243-4499-b121-71351cf2913c"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("66b7a9b0-660e-446e-b69d-84e4d67b5976"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("6997be4e-929c-4c11-bacb-e4637c6cde66"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("6eedf657-f7a8-4bf9-a9fe-f6a5ff25e1f7"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("779d6d86-6f26-4b55-9a97-eb97783fba47"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("7ca2bd05-ec2b-451a-b3db-236981ab23ce"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("821fe652-fb3f-4b43-95d6-7f5be46abbaa"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("8ab31026-db22-448a-82d1-96a96c9295b2"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("8ad2f676-298a-48b8-9398-b64612076a41"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("a75c702b-99ee-4d2a-bfb0-c4950ff07c82"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("a8a43482-ecad-4372-9d7a-4b4428646b91"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("ad5ae592-f9e9-435e-9d9c-acc87e8bd8ba"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("af092770-a867-4e57-8f4e-c4c919c49c5e"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("b5f124c1-fb3c-45e4-9bc7-0c1e65780328"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("b7beb973-8f4a-4ea7-999e-fa8ffba826dd"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("b9203f3e-1947-4003-8120-07225e3bf31b"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("c3f463f6-9936-4662-935f-e84816ff3184"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("c968348f-e559-4096-8a89-8f6ce078df09"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("ca1b5789-87cf-4a8b-8fcf-9ea300c773b8"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("cab5c778-e751-4c2d-a388-e0b9778c4f7a"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("cd3aa934-4f99-4f33-ada2-a05c66697805"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("dc4546ae-c3a1-413c-b92d-6e2e25a6cf4c"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("e0960a87-142f-4aef-8bc0-3ed5997ff40e"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("e74e1da8-c3ad-4113-8526-e1bac6deb92e"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("e791330d-b61b-41f9-a079-aa870cc7c030"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("e8e0e62e-ec7a-4528-8ff4-f7a735330508"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("eea7b4ea-080b-4945-9824-2ed6dc170b42"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("f0067cc7-1fc1-4c55-8974-cf23fd9dab0f"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("f17d65b1-c7cc-472c-a625-a023887790e1"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("f19ebae5-8e65-4ad5-86fc-b9a7b00881c4"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("f3297299-f829-47bf-aba9-625ec8618d4e"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("f364f513-5e7e-4002-9e2e-f6d0491ced6a"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("f3afdb52-2ac7-4364-83dd-d71174c5d0e8"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("f8d4ccc2-fb3b-446d-8ee5-b98957c04838"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("15a4726d-e707-456d-bfc6-7477673011fd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1f2feb1f-b587-4bd5-ad44-d94bd564b541"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("51105908-90d2-4150-8614-9be83d53e5f1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("68f08706-037a-4729-9a1c-86f7ab333ce1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("823f6c84-6ee3-4e63-91a1-469624410af0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("82e4510c-ce5e-433f-9f8a-e42211a25c74"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("9105662e-fed0-42d4-8450-e394e1f9a81e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("bf4c9db9-efa6-4d4f-85ba-540f433972c6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("cb608d00-541e-4eef-b14c-c0a70a9af200"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("cfd93849-a0ff-43ed-a926-d9ea4aeb5198"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d324e2f2-e120-47c2-8f19-a65399b452bd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("dc42bcce-49dc-4aeb-9536-3596f996a060"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("de946b6c-7fe7-44c6-b449-0c12c9e0e55d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("fc0a05f4-0393-4539-b86c-d6c8dadc9cd9"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("317b0af4-eb65-4ac1-96cc-477c8586bad9"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("396fb452-580c-4de5-91bd-967d51189adc"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("44905b25-dfa8-439f-80e0-734b058803a8"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("474a58e5-5c30-4fc7-831d-e7ebcc4506ed"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("47ae1e7a-7dbb-421e-b71a-9d5df4a2ef49"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("4943f970-d595-409f-b4cc-7cdb92ebe239"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("64ddd18e-cd26-456c-9cd4-f72ab8eee89b"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("74c4ccd1-cc4b-4361-a079-1a2990612fb6"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("7e0d725d-e9e6-4136-8fd1-f79cfffa22ed"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("949906da-e984-426d-964d-7b4d9ac0c2c2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("32ebbcac-b51e-4796-b014-4ad7acfbd502"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("3b792e59-d2ad-42fe-80ec-26172985d772"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("67311058-0822-44b1-9f9a-ec0683c5bc69"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("aaa83208-c15f-4e32-aed9-380105e89d7c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("d43cf39a-b480-4195-82cf-cf536cee6baf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("dff5d80d-df91-4070-9502-dbf5597ea121"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f0d411a4-8557-413f-8111-2225a0bb9c17"));

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandId", "Address", "Country", "ImageUrl", "IsDeleted", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("0dbc89bc-f05b-480d-a485-71e03e9d4d2f"), "123 Boxing Blvd, New York, NY", "USA", "/images/Brands/everlast-logo.png", false, "Everlast", "123-456-7890" },
                    { new Guid("1ec6f994-2896-49ee-a8e5-f4f0bd34759d"), "456 Sports Ave, London, UK", "UK", "/images/Brands/rdx-logo.png", false, "RDX", "456-789-0123" },
                    { new Guid("2b8ce36d-3bc4-4f1d-aec4-e2983cbe101d"), "789 Fight St, Toronto, ON", "Canada", "/images/Brands/hayabusa-logo.png", false, "Hayabusa", "789-012-3456" },
                    { new Guid("52ce217f-d1b3-4c8d-98eb-304ded1863e2"), "567 Martial Arts Blvd, Oklahoma City, OK", "USA", "/images/Brands/century-logo.png", false, "Century", "345-678-9012" },
                    { new Guid("8a322464-6579-498f-bafb-40baf2bdfb29"), "101 Martial Arts Way, Paris, FR", "France", "/images/Brands/venum-logo.png", false, "Venum", "321-654-0987" },
                    { new Guid("b4095c5e-225c-44dd-98dd-a43428505fca"), "345 Punch Ln, Los Angeles, CA", "USA", "/images/Brands/title-boxing-logo.png", false, "Title Boxing", "987-654-3210" },
                    { new Guid("d103c2d4-3a8f-453b-a040-188188b609a4"), "456 Ring Rd, Chicago, IL", "USA", "/images/Brands/ringside-logo.png", false, "Ringside", "234-567-8901" },
                    { new Guid("d36c1d2c-9dc6-4272-bff8-7668a34f7d94"), "678 Fighter Ave, Miami, FL", "USA", "/images/Brands/sanabul-logo.png", false, "Sanabul", "456-789-0123" },
                    { new Guid("d3c7ccad-0d55-43af-a46b-7c9d9ead1de9"), "789 Kick Rd, Phuket, TH", "Thailand", "/images/Brands/twins-special-logo.png", false, "Twins Special", "567-890-1234" },
                    { new Guid("e23e89cf-03ab-4b63-8e3f-efe2a23dbdfd"), "234 Fighter Rd, Bangkok, TH", "Thailand", "/images/Brands/fairtex-logo.png", false, "Fairtex", "876-543-2109" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "ImageUrl", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { new Guid("150e24fd-7406-4e3d-b65b-d399c6a23a60"), "/images/Categories/boxing-shoes.png", false, "Shoes" },
                    { new Guid("32913907-7481-4277-8ded-4951d25a9012"), "/images/Categories/head-gear.png", false, "Headgear" },
                    { new Guid("474bfb92-4884-4f02-bee1-15b38c0ed45c"), "/images/Categories/clothing.png", false, "Clothing" },
                    { new Guid("51579095-a6e7-45e6-9743-67024a8400bd"), "/images/Categories/shinguards.png", false, "Shinguards" },
                    { new Guid("56a7c962-01b5-42dd-b258-09409a3b3b68"), "/images/Categories/punching-bag.png", false, "Punching Bags" },
                    { new Guid("60ede473-4f5d-4fe5-8f03-d68ae49ef8a5"), "/images/Categories/training-equipment.png", false, "Training Equipment" },
                    { new Guid("6dc2e527-4b6c-4782-a8fc-9059cf646ec9"), "/images/Categories/mouth-guard.png", false, "Mouthguards" },
                    { new Guid("91f3d47c-c2de-47cc-9fd4-f2cba2adfa4e"), "/images/Categories/protective-gear.png", false, "Protective Gear" },
                    { new Guid("ccadbad4-817c-4149-b3b7-3ed67d59d4f2"), "/images/Categories/hand-wraps.png", false, "Hand Wraps" },
                    { new Guid("e92a5096-2e4d-4f68-a488-59156ad8d859"), "/images/Categegories/boxing-gloves.png", false, "Gloves" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "BrandId", "CategoryId", "Description", "IsDeleted", "MainImageUrl", "Name", "Price", "Sizes", "StockQuantity" },
                values: new object[,]
                {
                    { new Guid("05df459d-08ff-4d54-b1df-51f40cfdb5d2"), new Guid("d103c2d4-3a8f-453b-a040-188188b609a4"), new Guid("56a7c962-01b5-42dd-b258-09409a3b3b68"), "Heavy-duty bag for all levels of training.", false, null, "Ringside Punching Bag", 119.99m, "[3]", 40 },
                    { new Guid("0f84bc1c-ca07-48a8-82ae-cebba592cab7"), new Guid("1ec6f994-2896-49ee-a8e5-f4f0bd34759d"), new Guid("e92a5096-2e4d-4f68-a488-59156ad8d859"), "High-quality leather gloves for all training levels.", false, null, "RDX Boxing Gloves", 49.99m, "[1,2,3]", 100 },
                    { new Guid("1a526c08-9e0c-46b1-8e31-a5a7bf9fc777"), new Guid("0dbc89bc-f05b-480d-a485-71e03e9d4d2f"), new Guid("32913907-7481-4277-8ded-4951d25a9012"), "Full-protection headgear with durable padding.", false, null, "Everlast Pro Headgear", 69.99m, "[2,3]", 50 },
                    { new Guid("2b11be27-96c8-4afa-b08c-c281850cbd29"), new Guid("8a322464-6579-498f-bafb-40baf2bdfb29"), new Guid("51579095-a6e7-45e6-9743-67024a8400bd"), "High-durability shin guards ideal for intense training.", false, null, "Venum Challenger Shin Guards", 45.99m, "[1,2,3]", 95 },
                    { new Guid("386447b9-057e-4578-9e53-bb02d7e49ff7"), new Guid("d36c1d2c-9dc6-4272-bff8-7668a34f7d94"), new Guid("51579095-a6e7-45e6-9743-67024a8400bd"), "High-quality shin guards for protection and mobility.", false, null, "Sanabul Essential Shin Guards", 35.99m, "[2,3,4]", 90 },
                    { new Guid("4b749ba6-a76c-4ae3-a1d8-5199caa8e5b3"), new Guid("e23e89cf-03ab-4b63-8e3f-efe2a23dbdfd"), new Guid("474bfb92-4884-4f02-bee1-15b38c0ed45c"), "Premium Muay Thai shorts with authentic design.", false, null, "Fairtex Muay Thai Shorts", 34.99m, "[2,3,4]", 90 },
                    { new Guid("4e24ebca-f60b-4ac6-91e1-9d6aefbc119c"), new Guid("1ec6f994-2896-49ee-a8e5-f4f0bd34759d"), new Guid("150e24fd-7406-4e3d-b65b-d399c6a23a60"), "Lightweight and supportive for agility in the ring.", false, null, "RDX Pro Boxing Shoes", 69.99m, "[2,3,4]", 65 },
                    { new Guid("5e57c952-06f6-46d3-96cf-74e407539fd7"), new Guid("8a322464-6579-498f-bafb-40baf2bdfb29"), new Guid("e92a5096-2e4d-4f68-a488-59156ad8d859"), "Lightweight and designed for all skill levels.", false, null, "Venum Challenger Gloves", 39.99m, "[1,2,3]", 120 },
                    { new Guid("6357f6cc-f4b4-407a-9710-71533d7e95ab"), new Guid("d3c7ccad-0d55-43af-a46b-7c9d9ead1de9"), new Guid("32913907-7481-4277-8ded-4951d25a9012"), "Full-face protection with Twins quality.", false, null, "Twins Special Headgear", 89.99m, "[1,2,3]", 60 },
                    { new Guid("9459b013-8289-44cb-b651-5d3689e1db5d"), new Guid("2b8ce36d-3bc4-4f1d-aec4-e2983cbe101d"), new Guid("e92a5096-2e4d-4f68-a488-59156ad8d859"), "Top-notch gloves with exceptional durability.", false, null, "Hayabusa T3 Boxing Gloves", 89.99m, "[2,3,4]", 50 },
                    { new Guid("9743c0ed-505f-4b0f-b681-b23f46f65963"), new Guid("52ce217f-d1b3-4c8d-98eb-304ded1863e2"), new Guid("474bfb92-4884-4f02-bee1-15b38c0ed45c"), "Comfortable shorts designed for kickboxing.", false, null, "Century Martial Arts Kickboxing Shorts", 29.99m, "[2,3,4]", 75 },
                    { new Guid("a64428a7-70a7-4bde-85e2-c6a964879003"), new Guid("b4095c5e-225c-44dd-98dd-a43428505fca"), new Guid("56a7c962-01b5-42dd-b258-09409a3b3b68"), "Perfect for accuracy and reflex training.", false, null, "Title Boxing Double End Bag", 44.99m, "[3]", 70 },
                    { new Guid("bb18467d-c79f-476a-aaa8-f216399699a4"), new Guid("0dbc89bc-f05b-480d-a485-71e03e9d4d2f"), new Guid("ccadbad4-817c-4149-b3b7-3ed67d59d4f2"), "Classic wraps for wrist and knuckle protection.", false, null, "Everlast Hand Wraps", 9.99m, "[2,3]", 200 },
                    { new Guid("c22789ca-4000-430d-9d97-362125f8e1e7"), new Guid("b4095c5e-225c-44dd-98dd-a43428505fca"), new Guid("e92a5096-2e4d-4f68-a488-59156ad8d859"), "Durable leather gloves for heavy bag workouts.", false, null, "Title Boxing Leather Bag Gloves", 59.99m, "[2,3]", 80 }
                });

            migrationBuilder.InsertData(
                table: "ProductsImages",
                columns: new[] { "ImageId", "ImageUrl", "ProductId" },
                values: new object[,]
                {
                    { new Guid("15a42637-0f00-4dc7-89fa-fd6fd3f11203"), "/images/Products/ringside-punching-bag/ringside-punching-bag-3.png", new Guid("05df459d-08ff-4d54-b1df-51f40cfdb5d2") },
                    { new Guid("1a02a2f3-224e-4c36-a83f-04245fd739f9"), "/images/Products/everlasr-pro-headgear/everlast-pro-headgear-1.png", new Guid("1a526c08-9e0c-46b1-8e31-a5a7bf9fc777") },
                    { new Guid("230dd617-053a-49ed-ac25-c96d9972f356"), "/images/Products/sanabul-shin-guards/sanabul-shin-guards-3.png", new Guid("386447b9-057e-4578-9e53-bb02d7e49ff7") },
                    { new Guid("2341dff9-82e8-41ea-b4bf-465c291db2c3"), "/images/Products/everlast-hand-wraps/everlast-hand-wraps-3.png", new Guid("bb18467d-c79f-476a-aaa8-f216399699a4") },
                    { new Guid("23ab83fd-decc-4025-8d78-47b01bbb62d8"), "/images/Products/sanabul-shin-guards/sanabul-shin-guards-2.png", new Guid("386447b9-057e-4578-9e53-bb02d7e49ff7") },
                    { new Guid("281ff4f4-c5f5-42b7-97b1-85f06db030a5"), "/images/Products/ringside-punching-bag/ringside-punching-bag-2.png", new Guid("05df459d-08ff-4d54-b1df-51f40cfdb5d2") },
                    { new Guid("4232f190-d657-4506-8386-a5b6ef3a32dd"), "/images/Products/everlast-hand-wraps/everlast-hand-wraps-1.png", new Guid("bb18467d-c79f-476a-aaa8-f216399699a4") },
                    { new Guid("42ab9b27-5584-43a8-9eca-58dc8ef505f6"), "/images/Products/title-boxing-bag/title-boxing-bag-1.png", new Guid("c22789ca-4000-430d-9d97-362125f8e1e7") },
                    { new Guid("4e6136e1-43a0-4943-973d-fa9110a0a93a"), "/images/Products/ringside-punching-bag/ringside-punching-bag-1.png", new Guid("05df459d-08ff-4d54-b1df-51f40cfdb5d2") },
                    { new Guid("521a8c3a-8a75-478d-ae1e-1f0a78ccf2eb"), "/images/Products/title-boxing-gloves/title-boxing-gloves-2.png", new Guid("a64428a7-70a7-4bde-85e2-c6a964879003") },
                    { new Guid("56894346-bdd6-4645-94b0-7a15b52c2ec5"), "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-1.png", new Guid("4b749ba6-a76c-4ae3-a1d8-5199caa8e5b3") },
                    { new Guid("596338b3-7e00-4b86-8899-329ae12a49da"), "/images/Products/rdx-boxing-bag/rdx-boxing-bag-2.png", new Guid("4e24ebca-f60b-4ac6-91e1-9d6aefbc119c") },
                    { new Guid("5e7751ef-470b-4695-b40a-6ed4193eb428"), "/images/Products/title-boxing-gloves/title-boxing-gloves-3.png", new Guid("a64428a7-70a7-4bde-85e2-c6a964879003") },
                    { new Guid("60266eec-e1c3-4b35-abbb-2ae030de512f"), "/images/Products/twins-special-headgear/twins-shin-headgear-3.png", new Guid("6357f6cc-f4b4-407a-9710-71533d7e95ab") },
                    { new Guid("6041296f-d0b7-4dd6-a415-0601b77c8465"), "/images/Products/rdx-boxing-gloves/rdx-boxing-gloves-3.png", new Guid("0f84bc1c-ca07-48a8-82ae-cebba592cab7") },
                    { new Guid("6b483774-9e4c-4198-8b30-1236e34ef53a"), "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-2.png", new Guid("4b749ba6-a76c-4ae3-a1d8-5199caa8e5b3") },
                    { new Guid("6e279bd0-a4a0-4565-addc-58fea40b96e0"), "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-1.png", new Guid("9459b013-8289-44cb-b651-5d3689e1db5d") },
                    { new Guid("7a591e76-eebb-4475-97f6-14caf4eec9e1"), "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-3.png", new Guid("4b749ba6-a76c-4ae3-a1d8-5199caa8e5b3") },
                    { new Guid("7c1e7222-640e-41e1-b541-0aa2d100fd23"), "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-1.png", new Guid("2b11be27-96c8-4afa-b08c-c281850cbd29") },
                    { new Guid("831644e2-74f4-4f7a-b846-ff6170df6c3d"), "/images/Products/title-boxing-bag/title-boxing-bag-3.png", new Guid("c22789ca-4000-430d-9d97-362125f8e1e7") },
                    { new Guid("86ab243e-b55d-4afc-887b-538489bf9333"), "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-2.png", new Guid("9459b013-8289-44cb-b651-5d3689e1db5d") },
                    { new Guid("8c225889-c315-496e-8154-dddae110aa88"), "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-2.png", new Guid("9743c0ed-505f-4b0f-b681-b23f46f65963") },
                    { new Guid("9a2688e4-0fe1-48ed-a7fa-aa2cbcbc6052"), "/images/Products/sanabul-shin-guards/sanabul-shin-guards-1.png", new Guid("386447b9-057e-4578-9e53-bb02d7e49ff7") },
                    { new Guid("a36010a4-d587-4956-a5ca-825d73f651a5"), "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-3.png", new Guid("2b11be27-96c8-4afa-b08c-c281850cbd29") },
                    { new Guid("a3dcd7c3-2218-4caa-b107-f90f5ad4fc7e"), "/images/Products/twins-special-headgear/twins-shin-headgear-2.png", new Guid("6357f6cc-f4b4-407a-9710-71533d7e95ab") },
                    { new Guid("aedd02b0-055f-458b-8d6c-771c2c8f9d3d"), "/images/Products/title-boxing-gloves/title-boxing-gloves-1.png", new Guid("a64428a7-70a7-4bde-85e2-c6a964879003") },
                    { new Guid("b821a79c-fbea-4d8e-9842-70f2b3e6f197"), "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-1.png", new Guid("9743c0ed-505f-4b0f-b681-b23f46f65963") },
                    { new Guid("b896c1b9-b262-4ed3-b139-11385e62f3f9"), "/images/Products/everlast-hand-wraps/everlast-hand-wraps-2.png", new Guid("bb18467d-c79f-476a-aaa8-f216399699a4") },
                    { new Guid("c51e659d-7855-495f-afe0-b003019c6c46"), "/images/Products/venum-challenger-gloves/venum-challenger-gloves-1.png", new Guid("5e57c952-06f6-46d3-96cf-74e407539fd7") },
                    { new Guid("c772dc5a-d5ab-4bf1-9cde-c4c0ad203b60"), "/images/Products/twins-special-headgear/twins-shin-headgear-1.png", new Guid("6357f6cc-f4b4-407a-9710-71533d7e95ab") },
                    { new Guid("d16e0702-fd9c-4a00-bcde-9809aa30c7f4"), "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-2.png", new Guid("2b11be27-96c8-4afa-b08c-c281850cbd29") },
                    { new Guid("d4e79b4d-2b8e-4710-a0e5-08073a36f534"), "/images/Products/everlasr-pro-headgear/everlast-pro-headgear-2.png", new Guid("1a526c08-9e0c-46b1-8e31-a5a7bf9fc777") },
                    { new Guid("d7b0b5be-de88-420f-b54f-f9bc09cf951f"), "/images/Products/title-boxing-bag/title-boxing-bag-2.png", new Guid("c22789ca-4000-430d-9d97-362125f8e1e7") },
                    { new Guid("d7b692d7-d115-4094-9786-719216e633a6"), "/images/Products/venum-challenger-gloves/venum-challenger-gloves-2.png", new Guid("5e57c952-06f6-46d3-96cf-74e407539fd7") },
                    { new Guid("dff15ad3-bf78-4f88-bd81-08e5b1ec9d11"), "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-3.png", new Guid("9459b013-8289-44cb-b651-5d3689e1db5d") },
                    { new Guid("e9c9c862-ef76-4071-9944-fbe95cd8c373"), "/images/Products/rdx-boxing-bag/rdx-boxing-bag-1.png", new Guid("4e24ebca-f60b-4ac6-91e1-9d6aefbc119c") },
                    { new Guid("ed5128ad-28c1-42ca-95ef-62e3e146eba1"), "/images/Products/rdx-boxing-bag/rdx-boxing-bag-3.png", new Guid("4e24ebca-f60b-4ac6-91e1-9d6aefbc119c") },
                    { new Guid("ee17092d-d898-478b-8ced-7cec9083548c"), "/images/Products/rdx-boxing-gloves/rdx-boxing-gloves-1.png", new Guid("0f84bc1c-ca07-48a8-82ae-cebba592cab7") },
                    { new Guid("f75161e3-9898-4416-8599-5891c13716bb"), "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-3.png", new Guid("9743c0ed-505f-4b0f-b681-b23f46f65963") },
                    { new Guid("fa241cdc-9945-4964-a668-0b2b9223a2bc"), "/images/Products/venum-challenger-gloves/venum-challenger-gloves-3.png", new Guid("5e57c952-06f6-46d3-96cf-74e407539fd7") },
                    { new Guid("fda25eac-aa48-407e-8b08-5a75aa8263ea"), "/images/Products/everlasr-pro-headgear/everlast-pro-headgear-3.png", new Guid("1a526c08-9e0c-46b1-8e31-a5a7bf9fc777") },
                    { new Guid("ff397a5e-1ed6-4b75-8873-7f316bbe80a6"), "/images/Products/rdx-boxing-gloves/rdx-boxing-gloves-2.png", new Guid("0f84bc1c-ca07-48a8-82ae-cebba592cab7") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("60ede473-4f5d-4fe5-8f03-d68ae49ef8a5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("6dc2e527-4b6c-4782-a8fc-9059cf646ec9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("91f3d47c-c2de-47cc-9fd4-f2cba2adfa4e"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("15a42637-0f00-4dc7-89fa-fd6fd3f11203"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("1a02a2f3-224e-4c36-a83f-04245fd739f9"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("230dd617-053a-49ed-ac25-c96d9972f356"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("2341dff9-82e8-41ea-b4bf-465c291db2c3"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("23ab83fd-decc-4025-8d78-47b01bbb62d8"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("281ff4f4-c5f5-42b7-97b1-85f06db030a5"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("4232f190-d657-4506-8386-a5b6ef3a32dd"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("42ab9b27-5584-43a8-9eca-58dc8ef505f6"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("4e6136e1-43a0-4943-973d-fa9110a0a93a"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("521a8c3a-8a75-478d-ae1e-1f0a78ccf2eb"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("56894346-bdd6-4645-94b0-7a15b52c2ec5"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("596338b3-7e00-4b86-8899-329ae12a49da"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("5e7751ef-470b-4695-b40a-6ed4193eb428"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("60266eec-e1c3-4b35-abbb-2ae030de512f"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("6041296f-d0b7-4dd6-a415-0601b77c8465"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("6b483774-9e4c-4198-8b30-1236e34ef53a"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("6e279bd0-a4a0-4565-addc-58fea40b96e0"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("7a591e76-eebb-4475-97f6-14caf4eec9e1"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("7c1e7222-640e-41e1-b541-0aa2d100fd23"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("831644e2-74f4-4f7a-b846-ff6170df6c3d"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("86ab243e-b55d-4afc-887b-538489bf9333"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("8c225889-c315-496e-8154-dddae110aa88"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("9a2688e4-0fe1-48ed-a7fa-aa2cbcbc6052"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("a36010a4-d587-4956-a5ca-825d73f651a5"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("a3dcd7c3-2218-4caa-b107-f90f5ad4fc7e"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("aedd02b0-055f-458b-8d6c-771c2c8f9d3d"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("b821a79c-fbea-4d8e-9842-70f2b3e6f197"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("b896c1b9-b262-4ed3-b139-11385e62f3f9"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("c51e659d-7855-495f-afe0-b003019c6c46"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("c772dc5a-d5ab-4bf1-9cde-c4c0ad203b60"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("d16e0702-fd9c-4a00-bcde-9809aa30c7f4"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("d4e79b4d-2b8e-4710-a0e5-08073a36f534"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("d7b0b5be-de88-420f-b54f-f9bc09cf951f"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("d7b692d7-d115-4094-9786-719216e633a6"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("dff15ad3-bf78-4f88-bd81-08e5b1ec9d11"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("e9c9c862-ef76-4071-9944-fbe95cd8c373"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("ed5128ad-28c1-42ca-95ef-62e3e146eba1"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("ee17092d-d898-478b-8ced-7cec9083548c"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("f75161e3-9898-4416-8599-5891c13716bb"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("fa241cdc-9945-4964-a668-0b2b9223a2bc"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("fda25eac-aa48-407e-8b08-5a75aa8263ea"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("ff397a5e-1ed6-4b75-8873-7f316bbe80a6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("05df459d-08ff-4d54-b1df-51f40cfdb5d2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("0f84bc1c-ca07-48a8-82ae-cebba592cab7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1a526c08-9e0c-46b1-8e31-a5a7bf9fc777"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("2b11be27-96c8-4afa-b08c-c281850cbd29"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("386447b9-057e-4578-9e53-bb02d7e49ff7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4b749ba6-a76c-4ae3-a1d8-5199caa8e5b3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4e24ebca-f60b-4ac6-91e1-9d6aefbc119c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("5e57c952-06f6-46d3-96cf-74e407539fd7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6357f6cc-f4b4-407a-9710-71533d7e95ab"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("9459b013-8289-44cb-b651-5d3689e1db5d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("9743c0ed-505f-4b0f-b681-b23f46f65963"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a64428a7-70a7-4bde-85e2-c6a964879003"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("bb18467d-c79f-476a-aaa8-f216399699a4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c22789ca-4000-430d-9d97-362125f8e1e7"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("0dbc89bc-f05b-480d-a485-71e03e9d4d2f"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("1ec6f994-2896-49ee-a8e5-f4f0bd34759d"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("2b8ce36d-3bc4-4f1d-aec4-e2983cbe101d"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("52ce217f-d1b3-4c8d-98eb-304ded1863e2"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("8a322464-6579-498f-bafb-40baf2bdfb29"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("b4095c5e-225c-44dd-98dd-a43428505fca"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("d103c2d4-3a8f-453b-a040-188188b609a4"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("d36c1d2c-9dc6-4272-bff8-7668a34f7d94"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("d3c7ccad-0d55-43af-a46b-7c9d9ead1de9"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("e23e89cf-03ab-4b63-8e3f-efe2a23dbdfd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("150e24fd-7406-4e3d-b65b-d399c6a23a60"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("32913907-7481-4277-8ded-4951d25a9012"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("474bfb92-4884-4f02-bee1-15b38c0ed45c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("51579095-a6e7-45e6-9743-67024a8400bd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("56a7c962-01b5-42dd-b258-09409a3b3b68"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ccadbad4-817c-4149-b3b7-3ed67d59d4f2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("e92a5096-2e4d-4f68-a488-59156ad8d859"));

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandId", "Address", "Country", "ImageUrl", "IsDeleted", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("317b0af4-eb65-4ac1-96cc-477c8586bad9"), "678 Fighter Ave, Miami, FL", "USA", "images/Brands/sanabul-logo.png", false, "Sanabul", "456-789-0123" },
                    { new Guid("396fb452-580c-4de5-91bd-967d51189adc"), "234 Fighter Rd, Bangkok, TH", "Thailand", "images/Brands/fairtex-logo.png", false, "Fairtex", "876-543-2109" },
                    { new Guid("44905b25-dfa8-439f-80e0-734b058803a8"), "789 Fight St, Toronto, ON", "Canada", "images/Brands/hayabusa-logo.png", false, "Hayabusa", "789-012-3456" },
                    { new Guid("474a58e5-5c30-4fc7-831d-e7ebcc4506ed"), "345 Punch Ln, Los Angeles, CA", "USA", "images/Brands/title-boxing-logo.png", false, "Title Boxing", "987-654-3210" },
                    { new Guid("47ae1e7a-7dbb-421e-b71a-9d5df4a2ef49"), "456 Ring Rd, Chicago, IL", "USA", "images/Brands/ringside-logo.png", false, "Ringside", "234-567-8901" },
                    { new Guid("4943f970-d595-409f-b4cc-7cdb92ebe239"), "101 Martial Arts Way, Paris, FR", "France", "images/Brands/venum-logo.png", false, "Venum", "321-654-0987" },
                    { new Guid("64ddd18e-cd26-456c-9cd4-f72ab8eee89b"), "456 Sports Ave, London, UK", "UK", "images/Brands/rdx-logo.png", false, "RDX", "456-789-0123" },
                    { new Guid("74c4ccd1-cc4b-4361-a079-1a2990612fb6"), "567 Martial Arts Blvd, Oklahoma City, OK", "USA", "images/Brands/century-logo.png", false, "Century", "345-678-9012" },
                    { new Guid("7e0d725d-e9e6-4136-8fd1-f79cfffa22ed"), "123 Boxing Blvd, New York, NY", "USA", "images/Brands/everlast-logo.png", false, "Everlast", "123-456-7890" },
                    { new Guid("949906da-e984-426d-964d-7b4d9ac0c2c2"), "789 Kick Rd, Phuket, TH", "Thailand", "images/Brands/twins-special-logo.png", false, "Twins Special", "567-890-1234" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "ImageUrl", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { new Guid("32ebbcac-b51e-4796-b014-4ad7acfbd502"), "images/Categories/boxing-shoes.png", false, "Shoes" },
                    { new Guid("34369468-46a0-43ab-b5a5-ec1d4fe15574"), "images/Categories/mouth-guard.png", false, "Mouthguards" },
                    { new Guid("3b792e59-d2ad-42fe-80ec-26172985d772"), "images/Categories/head-gear.png", false, "Headgear" },
                    { new Guid("3ed9c652-85a1-4868-ac5a-454fe9f16897"), "images/Categories/training-equipment.png", false, "Training Equipment" },
                    { new Guid("67311058-0822-44b1-9f9a-ec0683c5bc69"), "images/Categegories/boxing-gloves.png", false, "Gloves" },
                    { new Guid("71a2dcc6-0e39-4226-ae88-198be0d10f6b"), "images/Categories/protective-gear.png", false, "Protective Gear" },
                    { new Guid("aaa83208-c15f-4e32-aed9-380105e89d7c"), "images/Categories/shinguards.png", false, "Shinguards" },
                    { new Guid("d43cf39a-b480-4195-82cf-cf536cee6baf"), "images/Categories/punching-bag.png", false, "Punching Bags" },
                    { new Guid("dff5d80d-df91-4070-9502-dbf5597ea121"), "images/Categories/hand-wraps.png", false, "Hand Wraps" },
                    { new Guid("f0d411a4-8557-413f-8111-2225a0bb9c17"), "images/Categories/clothing.png", false, "Clothing" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "BrandId", "CategoryId", "Description", "IsDeleted", "MainImageUrl", "Name", "Price", "Sizes", "StockQuantity" },
                values: new object[,]
                {
                    { new Guid("15a4726d-e707-456d-bfc6-7477673011fd"), new Guid("64ddd18e-cd26-456c-9cd4-f72ab8eee89b"), new Guid("32ebbcac-b51e-4796-b014-4ad7acfbd502"), "Lightweight and supportive for agility in the ring.", false, null, "RDX Pro Boxing Shoes", 69.99m, "[2,3,4]", 65 },
                    { new Guid("1f2feb1f-b587-4bd5-ad44-d94bd564b541"), new Guid("4943f970-d595-409f-b4cc-7cdb92ebe239"), new Guid("67311058-0822-44b1-9f9a-ec0683c5bc69"), "Lightweight and designed for all skill levels.", false, null, "Venum Challenger Gloves", 39.99m, "[1,2,3]", 120 },
                    { new Guid("51105908-90d2-4150-8614-9be83d53e5f1"), new Guid("474a58e5-5c30-4fc7-831d-e7ebcc4506ed"), new Guid("67311058-0822-44b1-9f9a-ec0683c5bc69"), "Durable leather gloves for heavy bag workouts.", false, null, "Title Boxing Leather Bag Gloves", 59.99m, "[2,3]", 80 },
                    { new Guid("68f08706-037a-4729-9a1c-86f7ab333ce1"), new Guid("396fb452-580c-4de5-91bd-967d51189adc"), new Guid("f0d411a4-8557-413f-8111-2225a0bb9c17"), "Premium Muay Thai shorts with authentic design.", false, null, "Fairtex Muay Thai Shorts", 34.99m, "[2,3,4]", 90 },
                    { new Guid("823f6c84-6ee3-4e63-91a1-469624410af0"), new Guid("7e0d725d-e9e6-4136-8fd1-f79cfffa22ed"), new Guid("3b792e59-d2ad-42fe-80ec-26172985d772"), "Full-protection headgear with durable padding.", false, null, "Everlast Pro Headgear", 69.99m, "[2,3]", 50 },
                    { new Guid("82e4510c-ce5e-433f-9f8a-e42211a25c74"), new Guid("64ddd18e-cd26-456c-9cd4-f72ab8eee89b"), new Guid("67311058-0822-44b1-9f9a-ec0683c5bc69"), "High-quality leather gloves for all training levels.", false, null, "RDX Boxing Gloves", 49.99m, "[1,2,3]", 100 },
                    { new Guid("9105662e-fed0-42d4-8450-e394e1f9a81e"), new Guid("317b0af4-eb65-4ac1-96cc-477c8586bad9"), new Guid("aaa83208-c15f-4e32-aed9-380105e89d7c"), "High-quality shin guards for protection and mobility.", false, null, "Sanabul Essential Shin Guards", 35.99m, "[2,3,4]", 90 },
                    { new Guid("bf4c9db9-efa6-4d4f-85ba-540f433972c6"), new Guid("4943f970-d595-409f-b4cc-7cdb92ebe239"), new Guid("aaa83208-c15f-4e32-aed9-380105e89d7c"), "High-durability shin guards ideal for intense training.", false, null, "Venum Challenger Shin Guards", 45.99m, "[1,2,3]", 95 },
                    { new Guid("cb608d00-541e-4eef-b14c-c0a70a9af200"), new Guid("74c4ccd1-cc4b-4361-a079-1a2990612fb6"), new Guid("f0d411a4-8557-413f-8111-2225a0bb9c17"), "Comfortable shorts designed for kickboxing.", false, null, "Century Martial Arts Kickboxing Shorts", 29.99m, "[2,3,4]", 75 },
                    { new Guid("cfd93849-a0ff-43ed-a926-d9ea4aeb5198"), new Guid("474a58e5-5c30-4fc7-831d-e7ebcc4506ed"), new Guid("d43cf39a-b480-4195-82cf-cf536cee6baf"), "Perfect for accuracy and reflex training.", false, null, "Title Boxing Double End Bag", 44.99m, "[3]", 70 },
                    { new Guid("d324e2f2-e120-47c2-8f19-a65399b452bd"), new Guid("949906da-e984-426d-964d-7b4d9ac0c2c2"), new Guid("3b792e59-d2ad-42fe-80ec-26172985d772"), "Full-face protection with Twins quality.", false, null, "Twins Special Headgear", 89.99m, "[1,2,3]", 60 },
                    { new Guid("dc42bcce-49dc-4aeb-9536-3596f996a060"), new Guid("7e0d725d-e9e6-4136-8fd1-f79cfffa22ed"), new Guid("dff5d80d-df91-4070-9502-dbf5597ea121"), "Classic wraps for wrist and knuckle protection.", false, null, "Everlast Hand Wraps", 9.99m, "[2,3]", 200 },
                    { new Guid("de946b6c-7fe7-44c6-b449-0c12c9e0e55d"), new Guid("47ae1e7a-7dbb-421e-b71a-9d5df4a2ef49"), new Guid("d43cf39a-b480-4195-82cf-cf536cee6baf"), "Heavy-duty bag for all levels of training.", false, null, "Ringside Punching Bag", 119.99m, "[3]", 40 },
                    { new Guid("fc0a05f4-0393-4539-b86c-d6c8dadc9cd9"), new Guid("44905b25-dfa8-439f-80e0-734b058803a8"), new Guid("67311058-0822-44b1-9f9a-ec0683c5bc69"), "Top-notch gloves with exceptional durability.", false, null, "Hayabusa T3 Boxing Gloves", 89.99m, "[2,3,4]", 50 }
                });

            migrationBuilder.InsertData(
                table: "ProductsImages",
                columns: new[] { "ImageId", "ImageUrl", "ProductId" },
                values: new object[,]
                {
                    { new Guid("2c951c7e-3a28-4f82-a101-9c30a0a1691e"), "images/Products/rdx-boxing-bag/rdx-boxing-bag-2.png", new Guid("15a4726d-e707-456d-bfc6-7477673011fd") },
                    { new Guid("2f2fa14b-1c4a-42ca-96d7-0d81d0440682"), "images/Products/rdx-boxing-gloves/rdx-boxing-gloves-3.png", new Guid("82e4510c-ce5e-433f-9f8a-e42211a25c74") },
                    { new Guid("34659e02-9480-4180-bf82-4d79e2e4f493"), "images/Products/everlasr-pro-headgear/everlast-pro-headgear-3.png", new Guid("823f6c84-6ee3-4e63-91a1-469624410af0") },
                    { new Guid("455033ff-9e87-44dc-939f-c234c54edead"), "images/Products/rdx-boxing-gloves/rdx-boxing-gloves-1.png", new Guid("82e4510c-ce5e-433f-9f8a-e42211a25c74") },
                    { new Guid("45c79e95-9bc4-4941-8c94-a7aba75cbed5"), "images/Products/ringside-punching-bag/ringside-punching-bag-3.png", new Guid("de946b6c-7fe7-44c6-b449-0c12c9e0e55d") },
                    { new Guid("489e5e66-9857-4a41-917b-bcc00902ae5b"), "images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-2.png", new Guid("fc0a05f4-0393-4539-b86c-d6c8dadc9cd9") },
                    { new Guid("4f4c719f-2c88-4cd4-bc4b-d85351cf50e1"), "images/Products/twins-special-headgear/twins-shin-headgear-1.png", new Guid("d324e2f2-e120-47c2-8f19-a65399b452bd") },
                    { new Guid("57ccc5ac-2d38-420b-9cb2-e31c0dc56908"), "images/Products/sanabul-shin-guards/sanabul-shin-guards-2.png", new Guid("9105662e-fed0-42d4-8450-e394e1f9a81e") },
                    { new Guid("5c6dec9a-f243-4499-b121-71351cf2913c"), "images/Products/title-boxing-bag/title-boxing-bag-3.png", new Guid("51105908-90d2-4150-8614-9be83d53e5f1") },
                    { new Guid("66b7a9b0-660e-446e-b69d-84e4d67b5976"), "images/Products/everlasr-pro-headgear/everlast-pro-headgear-1.png", new Guid("823f6c84-6ee3-4e63-91a1-469624410af0") },
                    { new Guid("6997be4e-929c-4c11-bacb-e4637c6cde66"), "images/Products/title-boxing-gloves/title-boxing-gloves-1.png", new Guid("cfd93849-a0ff-43ed-a926-d9ea4aeb5198") },
                    { new Guid("6eedf657-f7a8-4bf9-a9fe-f6a5ff25e1f7"), "images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-3.png", new Guid("bf4c9db9-efa6-4d4f-85ba-540f433972c6") },
                    { new Guid("779d6d86-6f26-4b55-9a97-eb97783fba47"), "images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-3.png", new Guid("68f08706-037a-4729-9a1c-86f7ab333ce1") },
                    { new Guid("7ca2bd05-ec2b-451a-b3db-236981ab23ce"), "images/Products/sanabul-shin-guards/sanabul-shin-guards-3.png", new Guid("9105662e-fed0-42d4-8450-e394e1f9a81e") },
                    { new Guid("821fe652-fb3f-4b43-95d6-7f5be46abbaa"), "images/Products/venum-challenger-gloves/venum-challenger-gloves-2.png", new Guid("1f2feb1f-b587-4bd5-ad44-d94bd564b541") },
                    { new Guid("8ab31026-db22-448a-82d1-96a96c9295b2"), "images/Products/venum-challenger-gloves/venum-challenger-gloves-3.png", new Guid("1f2feb1f-b587-4bd5-ad44-d94bd564b541") },
                    { new Guid("8ad2f676-298a-48b8-9398-b64612076a41"), "images/Products/rdx-boxing-bag/rdx-boxing-bag-3.png", new Guid("15a4726d-e707-456d-bfc6-7477673011fd") },
                    { new Guid("a75c702b-99ee-4d2a-bfb0-c4950ff07c82"), "images/Products/everlast-hand-wraps/everlast-hand-wraps-3.png", new Guid("dc42bcce-49dc-4aeb-9536-3596f996a060") },
                    { new Guid("a8a43482-ecad-4372-9d7a-4b4428646b91"), "images/Products/ringside-punching-bag/ringside-punching-bag-2.png", new Guid("de946b6c-7fe7-44c6-b449-0c12c9e0e55d") },
                    { new Guid("ad5ae592-f9e9-435e-9d9c-acc87e8bd8ba"), "images/Products/century-kickboxing-shorts/century-kickboxing-shorts-2.png", new Guid("cb608d00-541e-4eef-b14c-c0a70a9af200") },
                    { new Guid("af092770-a867-4e57-8f4e-c4c919c49c5e"), "images/Products/title-boxing-gloves/title-boxing-gloves-3.png", new Guid("cfd93849-a0ff-43ed-a926-d9ea4aeb5198") },
                    { new Guid("b5f124c1-fb3c-45e4-9bc7-0c1e65780328"), "images/Products/everlasr-pro-headgear/everlast-pro-headgear-2.png", new Guid("823f6c84-6ee3-4e63-91a1-469624410af0") },
                    { new Guid("b7beb973-8f4a-4ea7-999e-fa8ffba826dd"), "images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-1.png", new Guid("68f08706-037a-4729-9a1c-86f7ab333ce1") },
                    { new Guid("b9203f3e-1947-4003-8120-07225e3bf31b"), "images/Products/title-boxing-gloves/title-boxing-gloves-2.png", new Guid("cfd93849-a0ff-43ed-a926-d9ea4aeb5198") },
                    { new Guid("c3f463f6-9936-4662-935f-e84816ff3184"), "images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-2.png", new Guid("bf4c9db9-efa6-4d4f-85ba-540f433972c6") },
                    { new Guid("c968348f-e559-4096-8a89-8f6ce078df09"), "images/Products/title-boxing-bag/title-boxing-bag-1.png", new Guid("51105908-90d2-4150-8614-9be83d53e5f1") },
                    { new Guid("ca1b5789-87cf-4a8b-8fcf-9ea300c773b8"), "images/Products/ringside-punching-bag/ringside-punching-bag-1.png", new Guid("de946b6c-7fe7-44c6-b449-0c12c9e0e55d") },
                    { new Guid("cab5c778-e751-4c2d-a388-e0b9778c4f7a"), "images/Products/twins-special-headgear/twins-shin-headgear-3.png", new Guid("d324e2f2-e120-47c2-8f19-a65399b452bd") },
                    { new Guid("cd3aa934-4f99-4f33-ada2-a05c66697805"), "images/Products/everlast-hand-wraps/everlast-hand-wraps-1.png", new Guid("dc42bcce-49dc-4aeb-9536-3596f996a060") },
                    { new Guid("dc4546ae-c3a1-413c-b92d-6e2e25a6cf4c"), "images/Products/rdx-boxing-gloves/rdx-boxing-gloves-2.png", new Guid("82e4510c-ce5e-433f-9f8a-e42211a25c74") },
                    { new Guid("e0960a87-142f-4aef-8bc0-3ed5997ff40e"), "images/Products/century-kickboxing-shorts/century-kickboxing-shorts-3.png", new Guid("cb608d00-541e-4eef-b14c-c0a70a9af200") },
                    { new Guid("e74e1da8-c3ad-4113-8526-e1bac6deb92e"), "images/Products/title-boxing-bag/title-boxing-bag-2.png", new Guid("51105908-90d2-4150-8614-9be83d53e5f1") },
                    { new Guid("e791330d-b61b-41f9-a079-aa870cc7c030"), "images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-1.png", new Guid("fc0a05f4-0393-4539-b86c-d6c8dadc9cd9") },
                    { new Guid("e8e0e62e-ec7a-4528-8ff4-f7a735330508"), "images/Products/sanabul-shin-guards/sanabul-shin-guards-1.png", new Guid("9105662e-fed0-42d4-8450-e394e1f9a81e") },
                    { new Guid("eea7b4ea-080b-4945-9824-2ed6dc170b42"), "images/Products/venum-challenger-gloves/venum-challenger-gloves-1.png", new Guid("1f2feb1f-b587-4bd5-ad44-d94bd564b541") },
                    { new Guid("f0067cc7-1fc1-4c55-8974-cf23fd9dab0f"), "images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-1.png", new Guid("bf4c9db9-efa6-4d4f-85ba-540f433972c6") },
                    { new Guid("f17d65b1-c7cc-472c-a625-a023887790e1"), "images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-3.png", new Guid("fc0a05f4-0393-4539-b86c-d6c8dadc9cd9") },
                    { new Guid("f19ebae5-8e65-4ad5-86fc-b9a7b00881c4"), "images/Products/twins-special-headgear/twins-shin-headgear-2.png", new Guid("d324e2f2-e120-47c2-8f19-a65399b452bd") },
                    { new Guid("f3297299-f829-47bf-aba9-625ec8618d4e"), "images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-2.png", new Guid("68f08706-037a-4729-9a1c-86f7ab333ce1") },
                    { new Guid("f364f513-5e7e-4002-9e2e-f6d0491ced6a"), "images/Products/everlast-hand-wraps/everlast-hand-wraps-2.png", new Guid("dc42bcce-49dc-4aeb-9536-3596f996a060") },
                    { new Guid("f3afdb52-2ac7-4364-83dd-d71174c5d0e8"), "images/Products/rdx-boxing-bag/rdx-boxing-bag-1.png", new Guid("15a4726d-e707-456d-bfc6-7477673011fd") },
                    { new Guid("f8d4ccc2-fb3b-446d-8ee5-b98957c04838"), "images/Products/century-kickboxing-shorts/century-kickboxing-shorts-1.png", new Guid("cb608d00-541e-4eef-b14c-c0a70a9af200") }
                });
        }
    }
}
