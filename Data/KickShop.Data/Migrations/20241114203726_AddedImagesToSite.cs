using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KickShop.Migrations
{
    /// <inheritdoc />
    public partial class AddedImagesToSite : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("37be8411-a69c-430e-8a1e-521e90c2dcad"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("44819421-bb9c-49cd-97f5-c330cfcb83ca"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("bd1cfe93-69f5-4099-9ef0-6507733f0289"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("3c16b872-1902-44cc-9311-4de4db4dae7c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("3c612bf3-e963-4962-bc08-de751bff6ffc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4593d61a-743d-422b-b2f7-1f38003d41e8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("769c210c-4220-4d5c-a27b-e0e767c2348b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("7b0d50ed-7e60-4551-bda2-7a8fec25a63a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("841145e9-7194-4182-9041-fa02101a6238"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("8545e073-bf10-4d8a-be4d-5c2b7aefad99"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("8b61d563-49cb-4106-8b1e-ec1808a3ca1b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b4f2a367-8eb9-431f-a474-570aa68285bc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("be048d3a-98d0-4d0f-aef7-1e2638893ba5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("cb4be276-f14a-460e-8129-ef375588a40f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("dbb6087d-92e6-4ae8-a64b-104486a9e39c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f190f061-bf05-4951-a64c-95d98ee8cda9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f53173d9-f36b-46b2-9e83-52e95168bd3d"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("19c2d8a2-ba8b-4d7b-ac9d-e76d145821dd"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("21d13304-5432-4ac5-9849-8546c85facec"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("44a2fcbc-cf85-4ea3-abec-1ded8da458f7"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("8696d3f9-49d4-49b7-82c9-5813ca495be4"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("95576e20-6e91-485a-a007-a060b72ee7da"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("a6e70309-8507-4449-b781-53a32476964e"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("bea004ae-5bbc-47b1-9d24-dc50771ea70b"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("df984dfd-1d7e-489b-af08-3987bbcd6998"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("f2530fbe-33d3-4ea0-a8d9-38df8912c298"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("fe053a8b-b1e3-4301-95b4-34b68f752988"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("30869246-465a-492d-a275-de6eb457992a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("61dcdf45-1c31-48bc-a7e7-a9cdef66d0f0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("7b9809d3-3771-4005-90c8-e1afb149fe39"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("dfa1342f-c9f5-4351-b841-0c88ad3e6518"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("eca3bfd7-2c1a-45e6-b90c-62fa5a4932e4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ecf349bb-71ce-4ec1-accc-a6194d5ecca6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ff92c7d6-a347-4797-9d84-71bbc4c63962"));

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "MainImageUrl",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ProductsImages",
                columns: table => new
                {
                    ImageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "The Unique Identifier"),
                    ImageUrl = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, comment: "The Url To The Image"),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Foreign Key To The Product Entity To Which The Picture Belongs")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsImages", x => x.ImageId);
                    table.ForeignKey(
                        name: "FK_ProductsImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ProductsImages_ProductId",
                table: "ProductsImages",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductsImages");

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

            migrationBuilder.DropColumn(
                name: "MainImageUrl",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Products",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                comment: "URL To The Product Image");

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandId", "Address", "Country", "ImageUrl", "IsDeleted", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("19c2d8a2-ba8b-4d7b-ac9d-e76d145821dd"), "234 Fighter Rd, Bangkok, TH", "Thailand", "https://example.com/fairtex.jpg", false, "Fairtex", "876-543-2109" },
                    { new Guid("21d13304-5432-4ac5-9849-8546c85facec"), "123 Boxing Blvd, New York, NY", "USA", "https://example.com/everlast.jpg", false, "Everlast", "123-456-7890" },
                    { new Guid("44a2fcbc-cf85-4ea3-abec-1ded8da458f7"), "101 Martial Arts Way, Paris, FR", "France", "https://example.com/venum.jpg", false, "Venum", "321-654-0987" },
                    { new Guid("8696d3f9-49d4-49b7-82c9-5813ca495be4"), "678 Fighter Ave, Miami, FL", "USA", "https://example.com/sanabul.jpg", false, "Sanabul", "456-789-0123" },
                    { new Guid("95576e20-6e91-485a-a007-a060b72ee7da"), "345 Punch Ln, Los Angeles, CA", "USA", "https://example.com/titleboxing.jpg", false, "Title Boxing", "987-654-3210" },
                    { new Guid("a6e70309-8507-4449-b781-53a32476964e"), "567 Martial Arts Blvd, Oklahoma City, OK", "USA", "https://example.com/century.jpg", false, "Century", "345-678-9012" },
                    { new Guid("bea004ae-5bbc-47b1-9d24-dc50771ea70b"), "456 Ring Rd, Chicago, IL", "USA", "https://example.com/ringside.jpg", false, "Ringside", "234-567-8901" },
                    { new Guid("df984dfd-1d7e-489b-af08-3987bbcd6998"), "789 Fight St, Toronto, ON", "Canada", "https://example.com/hayabusa.jpg", false, "Hayabusa", "789-012-3456" },
                    { new Guid("f2530fbe-33d3-4ea0-a8d9-38df8912c298"), "456 Sports Ave, London, UK", "UK", "https://example.com/rdx.jpg", false, "RDX", "456-789-0123" },
                    { new Guid("fe053a8b-b1e3-4301-95b4-34b68f752988"), "789 Kick Rd, Phuket, TH", "Thailand", "https://example.com/twinsspecial.jpg", false, "Twins Special", "567-890-1234" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "ImageUrl", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { new Guid("30869246-465a-492d-a275-de6eb457992a"), "https://example.com/gloves.jpg", false, "Gloves" },
                    { new Guid("37be8411-a69c-430e-8a1e-521e90c2dcad"), "https://example.com/trainingequipment.jpg", false, "Training Equipment" },
                    { new Guid("44819421-bb9c-49cd-97f5-c330cfcb83ca"), "https://example.com/mouthguards.jpg", false, "Mouthguards" },
                    { new Guid("61dcdf45-1c31-48bc-a7e7-a9cdef66d0f0"), "https://example.com/headgear.jpg", false, "Headgear" },
                    { new Guid("7b9809d3-3771-4005-90c8-e1afb149fe39"), "https://example.com/handwraps.jpg", false, "Hand Wraps" },
                    { new Guid("bd1cfe93-69f5-4099-9ef0-6507733f0289"), "https://example.com/protectivegear.jpg", false, "Protective Gear" },
                    { new Guid("dfa1342f-c9f5-4351-b841-0c88ad3e6518"), "https://example.com/punchingbags.jpg", false, "Punching Bags" },
                    { new Guid("eca3bfd7-2c1a-45e6-b90c-62fa5a4932e4"), "https://example.com/clothing.jpg", false, "Clothing" },
                    { new Guid("ecf349bb-71ce-4ec1-accc-a6194d5ecca6"), "https://example.com/shinguards.jpg", false, "Shinguards" },
                    { new Guid("ff92c7d6-a347-4797-9d84-71bbc4c63962"), "https://example.com/shoes.jpg", false, "Shoes" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "BrandId", "CategoryId", "Description", "ImageUrl", "IsDeleted", "Name", "Price", "Sizes", "StockQuantity" },
                values: new object[,]
                {
                    { new Guid("3c16b872-1902-44cc-9311-4de4db4dae7c"), new Guid("df984dfd-1d7e-489b-af08-3987bbcd6998"), new Guid("30869246-465a-492d-a275-de6eb457992a"), "Top-notch gloves with exceptional durability.", "https://example.com/hayabusa-t3.jpg", false, "Hayabusa T3 Boxing Gloves", 89.99m, "[2,3,4]", 50 },
                    { new Guid("3c612bf3-e963-4962-bc08-de751bff6ffc"), new Guid("a6e70309-8507-4449-b781-53a32476964e"), new Guid("eca3bfd7-2c1a-45e6-b90c-62fa5a4932e4"), "Comfortable shorts designed for kickboxing.", "https://example.com/century-shorts.jpg", false, "Century Martial Arts Kickboxing Shorts", 29.99m, "[2,3,4]", 75 },
                    { new Guid("4593d61a-743d-422b-b2f7-1f38003d41e8"), new Guid("44a2fcbc-cf85-4ea3-abec-1ded8da458f7"), new Guid("ecf349bb-71ce-4ec1-accc-a6194d5ecca6"), "High-durability shin guards ideal for intense training.", "https://example.com/venum-shin.jpg", false, "Venum Challenger Shin Guards", 45.99m, "[1,2,3]", 95 },
                    { new Guid("769c210c-4220-4d5c-a27b-e0e767c2348b"), new Guid("19c2d8a2-ba8b-4d7b-ac9d-e76d145821dd"), new Guid("eca3bfd7-2c1a-45e6-b90c-62fa5a4932e4"), "Premium Muay Thai shorts with authentic design.", "https://example.com/fairtex-shorts.jpg", false, "Fairtex Muay Thai Shorts", 34.99m, "[2,3,4]", 90 },
                    { new Guid("7b0d50ed-7e60-4551-bda2-7a8fec25a63a"), new Guid("21d13304-5432-4ac5-9849-8546c85facec"), new Guid("7b9809d3-3771-4005-90c8-e1afb149fe39"), "Classic wraps for wrist and knuckle protection.", "https://example.com/everlast-wraps.jpg", false, "Everlast Hand Wraps", 9.99m, "[2,3]", 200 },
                    { new Guid("841145e9-7194-4182-9041-fa02101a6238"), new Guid("f2530fbe-33d3-4ea0-a8d9-38df8912c298"), new Guid("ff92c7d6-a347-4797-9d84-71bbc4c63962"), "Lightweight and supportive for agility in the ring.", "https://example.com/rdx-shoes.jpg", false, "RDX Pro Boxing Shoes", 69.99m, "[2,3,4]", 65 },
                    { new Guid("8545e073-bf10-4d8a-be4d-5c2b7aefad99"), new Guid("fe053a8b-b1e3-4301-95b4-34b68f752988"), new Guid("61dcdf45-1c31-48bc-a7e7-a9cdef66d0f0"), "Full-face protection with Twins quality.", "https://example.com/twins-headgear.jpg", false, "Twins Special Headgear", 89.99m, "[1,2,3]", 60 },
                    { new Guid("8b61d563-49cb-4106-8b1e-ec1808a3ca1b"), new Guid("95576e20-6e91-485a-a007-a060b72ee7da"), new Guid("dfa1342f-c9f5-4351-b841-0c88ad3e6518"), "Perfect for accuracy and reflex training.", "https://example.com/title-double.jpg", false, "Title Boxing Double End Bag", 44.99m, "[3]", 70 },
                    { new Guid("b4f2a367-8eb9-431f-a474-570aa68285bc"), new Guid("f2530fbe-33d3-4ea0-a8d9-38df8912c298"), new Guid("30869246-465a-492d-a275-de6eb457992a"), "High-quality leather gloves for all training levels.", "https://example.com/rdx-gloves.jpg", false, "RDX Boxing Gloves", 49.99m, "[1,2,3]", 100 },
                    { new Guid("be048d3a-98d0-4d0f-aef7-1e2638893ba5"), new Guid("44a2fcbc-cf85-4ea3-abec-1ded8da458f7"), new Guid("30869246-465a-492d-a275-de6eb457992a"), "Lightweight and designed for all skill levels.", "https://example.com/venum-challenger.jpg", false, "Venum Challenger Gloves", 39.99m, "[1,2,3]", 120 },
                    { new Guid("cb4be276-f14a-460e-8129-ef375588a40f"), new Guid("95576e20-6e91-485a-a007-a060b72ee7da"), new Guid("30869246-465a-492d-a275-de6eb457992a"), "Durable leather gloves for heavy bag workouts.", "https://example.com/title-leather.jpg", false, "Title Boxing Leather Bag Gloves", 59.99m, "[2,3]", 80 },
                    { new Guid("dbb6087d-92e6-4ae8-a64b-104486a9e39c"), new Guid("8696d3f9-49d4-49b7-82c9-5813ca495be4"), new Guid("ecf349bb-71ce-4ec1-accc-a6194d5ecca6"), "High-quality shin guards for protection and mobility.", "https://example.com/sanabul-shin.jpg", false, "Sanabul Essential Shin Guards", 35.99m, "[2,3,4]", 90 },
                    { new Guid("f190f061-bf05-4951-a64c-95d98ee8cda9"), new Guid("bea004ae-5bbc-47b1-9d24-dc50771ea70b"), new Guid("dfa1342f-c9f5-4351-b841-0c88ad3e6518"), "Heavy-duty bag for all levels of training.", "https://example.com/ringside-bag.jpg", false, "Ringside Punching Bag", 119.99m, "[3]", 40 },
                    { new Guid("f53173d9-f36b-46b2-9e83-52e95168bd3d"), new Guid("21d13304-5432-4ac5-9849-8546c85facec"), new Guid("61dcdf45-1c31-48bc-a7e7-a9cdef66d0f0"), "Full-protection headgear with durable padding.", "https://example.com/everlast-headgear.jpg", false, "Everlast Pro Headgear", 69.99m, "[2,3]", 50 }
                });
        }
    }
}
