using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KickShop.Migrations
{
    /// <inheritdoc />
    public partial class FixedMainImageUrlProblem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("1e1ede8d-3b30-4c64-9043-d7a2bfa9bfcb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("50c08702-a1c9-424a-bc28-68519e6b6a8b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f4c6db4c-d09c-4ba0-ac14-6937de7fade5"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("0c20dfa4-d113-42f4-8a5c-d28dda1305d4"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("0e123fab-f452-4053-bbd2-755de0e7ed29"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("11131b7a-90e7-4209-bc6b-69ea9c24a4bf"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("1483d46f-f122-43e5-a54a-ab86d76d50cb"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("1eccf3d8-05c2-445e-81de-83f5294ec9be"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("2b53ff0e-5e71-4e5e-a9ff-f32ec3dfb972"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("31b72d61-407e-4bf1-b6f8-e92bf49ed584"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("329cba95-8fc9-4f73-9c93-0d4a606c423e"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("387a79d5-dcf3-4ca4-a937-4949a96fe66c"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("3f902e72-7481-4add-b891-d28e9ee25d4e"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("4042458b-e0ee-4a00-8214-35251346e697"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("41c575e2-5783-47b7-92c3-79426074dba8"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("4d5a85e7-b682-425f-8e46-b5c693395a16"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("4e27f6b1-13c3-4b05-87ff-89d7aa9f2f77"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("5a244e77-1517-4b4a-810b-532f7a289b5e"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("5d0a1247-033b-49c2-bebc-498200d0d276"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("67b64dd4-71ab-413b-8f84-b28656c904ba"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("68050623-709f-4c99-8810-f3be193c5eb8"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("6a4d540f-0de5-47a6-b336-f2ca1ec0fd36"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("76e7b3ef-491d-4527-858c-58de6fddec4b"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("82859ca3-875e-460d-9c50-6bb0e98a2141"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("86cf93de-856f-4677-b83b-06afa0724b35"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("87f5968c-7128-4f25-835c-2710c31b9344"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("8f3abdee-1178-44b9-9abf-bc1a596768ef"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("96215abe-fb99-46e2-b416-f2824e85d7bd"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("9ce45abe-4ebc-423c-851a-99bfc1dd285f"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("9ff83138-fe1e-44fc-867e-7e23e1ec0e9b"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("a838ee14-7307-427a-94f4-44d4d3b69942"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("ac18b2e7-47d6-4a28-9b52-4886dff937f0"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("acc55ab9-3389-4c44-bbbf-84812a710cd7"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("ae7ed184-6c82-44dc-8128-24cfae1cf8c6"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("b1d420d2-aabd-4cb6-8d37-f8f62cc60a8a"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("b83c66b5-9fa0-4502-8ed6-a026b6f069e8"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("bde323d4-7551-4a28-99ca-e6029e0d2004"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("c3c08194-17d0-4a89-bfd5-2287c4b15bad"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("c74d6d3a-74d8-443c-98c8-de4b8237f55b"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("c7f11e32-33a2-436f-9f9e-eba080ed3941"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("cf11227a-ec55-4dd7-9cbc-ccffa6fe22eb"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("d7fd3655-3b9b-4427-8cc2-d47f8a10b607"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("dd3f8acb-7882-4a33-bc60-0b310ac6c6e4"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("fbfef284-0573-4554-aaad-eb0c9cc22b80"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("fe9ca250-5718-479b-ac95-0b628a339683"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("29eca57a-81ff-4e3a-9d59-ee215619f628"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("2ef2c970-b80a-4f78-9792-d17e139bc400"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("3121c01c-f7a8-4e98-b20a-7d114d25caeb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("385cc09b-aee6-42ef-b767-4cac18dded80"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("3fa04aac-4923-41a5-ac3a-969fd1394c70"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("54057643-6224-4fbb-9ec0-8e761c8b068e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("83fe2b76-bb52-4920-aba8-4c93ddf5a2d0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("91111577-7e3d-4dff-b37a-3310c498065a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("94b05df8-64fd-4976-973d-62362ad7d5e2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a808e4bc-e5bd-4efa-98d5-44393e9102fa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("ad9e91b8-6144-4f9c-81e3-0559cc5830a1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("bcabe895-6c3e-4930-ad10-b7756981ca39"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c52f77d5-a6eb-4a53-bc07-c024be560d38"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f2af4558-e395-4b88-b67f-abb596b9c6d0"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("38532feb-6f94-4bea-84d5-744a0b35af5c"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("536f127f-dea8-4ca4-9539-446d1f86daee"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("5a044fc0-7328-494d-b11f-c07ed1229a59"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("5aba4088-59af-47c0-bd33-3fa1aedc6824"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("7f2a4214-e5b5-4794-aec8-8736e5c22a83"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("a0c523fa-38a4-4df7-bf77-a9967bcaa77a"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("aa4f36b5-1c98-4060-8d62-325adc60f324"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("cb03ff7f-6ca9-4efe-b2de-b0ca5be62fc3"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("e52aa911-aa63-498b-8bce-51baab3b5dde"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("ea2375ce-e821-4bd6-a76d-46e751a5b26f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("187fe48d-e704-4774-9d76-b2b64323bf7b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("2a625349-7880-4e8f-ad41-b660a7ebeef7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("5bde86bf-fe68-48ed-8baf-ddd97501a944"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("5df8dc80-f152-4795-923c-0561b6f85ce5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("835fc42a-2f19-4dc2-be95-be3b82082a40"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("c9ccf53a-822b-4c8b-8fef-5422cefb1ef5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("fc5123b5-7e38-4fab-8b8f-71cc9754ed44"));

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandId", "Address", "Country", "ImageUrl", "IsDeleted", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("23f367a6-991a-4e05-b066-f5facbcbf549"), "678 Fighter Ave, Miami, FL", "USA", "/images/Brands/sanabul-logo.png", false, "Sanabul", "456-789-0123" },
                    { new Guid("248cc2e8-ddaf-4823-9be7-2b849acb9d8a"), "101 Martial Arts Way, Paris, FR", "France", "/images/Brands/venum-logo.png", false, "Venum", "321-654-0987" },
                    { new Guid("30d3c248-fc96-48c8-8fa8-221544ae2fc8"), "456 Sports Ave, London, UK", "UK", "/images/Brands/rdx-logo.png", false, "RDX", "456-789-0123" },
                    { new Guid("313e4559-45bc-41df-b670-fc949899bbc4"), "123 Boxing Blvd, New York, NY", "USA", "/images/Brands/everlast-logo.png", false, "Everlast", "123-456-7890" },
                    { new Guid("4479663d-9879-4466-a9b7-f8193992b3a6"), "789 Fight St, Toronto, ON", "Canada", "/images/Brands/hayabusa-logo.png", false, "Hayabusa", "789-012-3456" },
                    { new Guid("4eced22a-c181-4870-9d60-b244ac446838"), "234 Fighter Rd, Bangkok, TH", "Thailand", "/images/Brands/fairtex-logo.png", false, "Fairtex", "876-543-2109" },
                    { new Guid("716bdc21-f89c-41d3-bc74-e35d7bc02e2c"), "789 Kick Rd, Phuket, TH", "Thailand", "/images/Brands/twins-special-logo.png", false, "Twins Special", "567-890-1234" },
                    { new Guid("7b07e107-99e2-40be-ba06-d0b5a705350b"), "456 Ring Rd, Chicago, IL", "USA", "/images/Brands/ringside-logo.png", false, "Ringside", "234-567-8901" },
                    { new Guid("b10113d8-6c04-4d01-8bff-6fa31b882f08"), "567 Martial Arts Blvd, Oklahoma City, OK", "USA", "/images/Brands/century-logo.png", false, "Century", "345-678-9012" },
                    { new Guid("be4b4f23-b0e4-4d42-9315-147df5ffc3e0"), "345 Punch Ln, Los Angeles, CA", "USA", "/images/Brands/title-boxing-logo.png", false, "Title Boxing", "987-654-3210" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "ImageUrl", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { new Guid("0aeedcb1-18ff-4150-a4a2-414c3acbc3b7"), "/images/Categories/mouth-guard.png", false, "Mouthguards" },
                    { new Guid("0bcb7b6c-f815-4de8-bf96-86707047cd5d"), "/images/Categories/training-equipment.png", false, "Training Equipment" },
                    { new Guid("4a2ac05e-d9d4-4391-88d4-9b65c24790dc"), "/images/Categories/protective-gear.png", false, "Protective Gear" },
                    { new Guid("56ea514b-ed66-4b38-a9c0-597a30f98ac6"), "/images/Categegories/boxing-gloves.png", false, "Gloves" },
                    { new Guid("597d624a-1919-4316-8710-176a021ad9b3"), "/images/Categories/hand-wraps.png", false, "Hand Wraps" },
                    { new Guid("5b3ac614-76fe-4460-9996-e6c148d101e1"), "/images/Categories/shinguards.png", false, "Shinguards" },
                    { new Guid("63144409-4afa-4a11-adc8-2b4889f192a3"), "/images/Categories/head-gear.png", false, "Headgear" },
                    { new Guid("65a54501-fb5b-460b-9631-1f936ccbb98f"), "/images/Categories/boxing-shoes.png", false, "Shoes" },
                    { new Guid("74ef25f0-faa9-497e-8a33-608f9afaeb51"), "/images/Categories/punching-bag.png", false, "Punching Bags" },
                    { new Guid("b70d37e3-fe2f-42ae-aa89-5b8f2695e8e7"), "/images/Categories/clothing.png", false, "Clothing" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "BrandId", "CategoryId", "Description", "IsDeleted", "MainImageUrl", "Name", "Price", "Sizes", "StockQuantity" },
                values: new object[,]
                {
                    { new Guid("14213bcd-4f55-4c5e-a358-149b27245252"), new Guid("be4b4f23-b0e4-4d42-9315-147df5ffc3e0"), new Guid("74ef25f0-faa9-497e-8a33-608f9afaeb51"), "Perfect for accuracy and reflex training.", false, "/images/Products/title-boxing-gloves/title-boxing-gloves-1.png", "Title Boxing Double End Bag", 44.99m, "[3]", 70 },
                    { new Guid("1c85b2f1-778c-4866-9b88-7324c9331381"), new Guid("23f367a6-991a-4e05-b066-f5facbcbf549"), new Guid("5b3ac614-76fe-4460-9996-e6c148d101e1"), "High-quality shin guards for protection and mobility.", false, "/images/Products/sanabul-shin-guards/sanabul-shin-guards-1.png", "Sanabul Essential Shin Guards", 35.99m, "[2,3,4]", 90 },
                    { new Guid("2f761748-ec2f-4d80-b994-d16cf9198a3f"), new Guid("7b07e107-99e2-40be-ba06-d0b5a705350b"), new Guid("74ef25f0-faa9-497e-8a33-608f9afaeb51"), "Heavy-duty bag for all levels of training.", false, "/images/Products/ringside-punching-bag/ringside-punching-bag-1.png", "Ringside Punching Bag", 119.99m, "[3]", 40 },
                    { new Guid("635480f0-b7dc-45f1-8d2f-1fd4e7c4a797"), new Guid("313e4559-45bc-41df-b670-fc949899bbc4"), new Guid("63144409-4afa-4a11-adc8-2b4889f192a3"), "Full-protection headgear with durable padding.", false, "/images/Products/everlasr-pro-headgear/everlast-pro-headgear-1.png", "Everlast Pro Headgear", 69.99m, "[2,3]", 50 },
                    { new Guid("6c1f0b6f-b5e6-4565-9f6f-e61983355a20"), new Guid("30d3c248-fc96-48c8-8fa8-221544ae2fc8"), new Guid("65a54501-fb5b-460b-9631-1f936ccbb98f"), "Lightweight and supportive for agility in the ring.", false, "/images/Products/rdx-boxing-bag/rdx-boxing-bag-1.png", "RDX Pro Boxing Shoes", 69.99m, "[2,3,4]", 65 },
                    { new Guid("7184e4a1-7ad8-4894-a37e-10c885eb1203"), new Guid("716bdc21-f89c-41d3-bc74-e35d7bc02e2c"), new Guid("63144409-4afa-4a11-adc8-2b4889f192a3"), "Full-face protection with Twins quality.", false, "/images/Products/twins-special-headgear/twins-shin-headgear-1.png", "Twins Special Headgear", 89.99m, "[1,2,3]", 60 },
                    { new Guid("7a0e08e2-7ef6-45af-8c60-a9ee7688bbc1"), new Guid("b10113d8-6c04-4d01-8bff-6fa31b882f08"), new Guid("b70d37e3-fe2f-42ae-aa89-5b8f2695e8e7"), "Comfortable shorts designed for kickboxing.", false, "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-1.png", "Century Martial Arts Kickboxing Shorts", 29.99m, "[2,3,4]", 75 },
                    { new Guid("817a03d7-5550-4c8b-8afa-5d49aa47931b"), new Guid("248cc2e8-ddaf-4823-9be7-2b849acb9d8a"), new Guid("56ea514b-ed66-4b38-a9c0-597a30f98ac6"), "Lightweight and designed for all skill levels.", false, "/images/Products/venum-challenger-gloves/venum-challenger-gloves-1.png", "Venum Challenger Gloves", 39.99m, "[1,2,3]", 120 },
                    { new Guid("8334bf0d-3c8f-4adf-970d-12a27ce0de6f"), new Guid("313e4559-45bc-41df-b670-fc949899bbc4"), new Guid("597d624a-1919-4316-8710-176a021ad9b3"), "Classic wraps for wrist and knuckle protection.", false, "/images/Products/everlast-hand-wraps/everlast-hand-wraps-1.png", "Everlast Hand Wraps", 9.99m, "[2,3]", 200 },
                    { new Guid("9f583531-77c6-4df1-a26e-31ebce5ac44b"), new Guid("4eced22a-c181-4870-9d60-b244ac446838"), new Guid("b70d37e3-fe2f-42ae-aa89-5b8f2695e8e7"), "Premium Muay Thai shorts with authentic design.", false, "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-1.png", "Fairtex Muay Thai Shorts", 34.99m, "[2,3,4]", 90 },
                    { new Guid("ab3ee8b6-eebb-43c5-8c32-b332d5c4ad10"), new Guid("4479663d-9879-4466-a9b7-f8193992b3a6"), new Guid("56ea514b-ed66-4b38-a9c0-597a30f98ac6"), "Top-notch gloves with exceptional durability.", false, "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-1.png", "Hayabusa T3 Boxing Gloves", 89.99m, "[2,3,4]", 50 },
                    { new Guid("cabe6b67-bb24-4c5e-b495-8b426cb4323b"), new Guid("be4b4f23-b0e4-4d42-9315-147df5ffc3e0"), new Guid("56ea514b-ed66-4b38-a9c0-597a30f98ac6"), "Durable leather gloves for heavy bag workouts.", false, "/images/Products/title-boxing-bag/title-boxing-bag-1.png", "Title Boxing Leather Bag Gloves", 59.99m, "[2,3]", 80 },
                    { new Guid("cac4733a-d4e6-4a20-8545-82d86cf2908f"), new Guid("248cc2e8-ddaf-4823-9be7-2b849acb9d8a"), new Guid("5b3ac614-76fe-4460-9996-e6c148d101e1"), "High-durability shin guards ideal for intense training.", false, "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-1.png", "Venum Challenger Shin Guards", 45.99m, "[1,2,3]", 95 },
                    { new Guid("fc9d22a4-ce0f-496c-9f89-428b6c1b1c15"), new Guid("30d3c248-fc96-48c8-8fa8-221544ae2fc8"), new Guid("56ea514b-ed66-4b38-a9c0-597a30f98ac6"), "High-quality leather gloves for all training levels.", false, "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-1.png", "RDX Boxing Gloves", 49.99m, "[1,2,3]", 100 }
                });

            migrationBuilder.InsertData(
                table: "ProductsImages",
                columns: new[] { "ImageId", "ImageUrl", "ProductId" },
                values: new object[,]
                {
                    { new Guid("09537be1-6ce8-4cea-a165-3d6bcf286791"), "/images/Products/venum-challenger-gloves/venum-challenger-gloves-3.png", new Guid("817a03d7-5550-4c8b-8afa-5d49aa47931b") },
                    { new Guid("0f625fe2-110d-4e64-8f0b-7730fd4c9e92"), "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-3.png", new Guid("7a0e08e2-7ef6-45af-8c60-a9ee7688bbc1") },
                    { new Guid("0fd799bb-e739-4fdb-be18-c1ce0770227b"), "/images/Products/title-boxing-bag/title-boxing-bag-2.png", new Guid("cabe6b67-bb24-4c5e-b495-8b426cb4323b") },
                    { new Guid("119a7a85-a3d4-4826-9894-6e1dc71b759a"), "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-2.png", new Guid("9f583531-77c6-4df1-a26e-31ebce5ac44b") },
                    { new Guid("13238791-cfaf-4bca-94f9-6c706f43cc40"), "/images/Products/everlast-hand-wraps/everlast-hand-wraps-1.png", new Guid("8334bf0d-3c8f-4adf-970d-12a27ce0de6f") },
                    { new Guid("154dd9b6-bcf3-417b-b41c-3741bf3eb4a6"), "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-2.png", new Guid("ab3ee8b6-eebb-43c5-8c32-b332d5c4ad10") },
                    { new Guid("1631da05-82ae-4632-8d66-bd81c5e05d91"), "/images/Products/everlasr-pro-headgear/everlast-pro-headgear-3.png", new Guid("635480f0-b7dc-45f1-8d2f-1fd4e7c4a797") },
                    { new Guid("17d41fac-10f9-4e48-94af-5e507d9049fe"), "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-1.png", new Guid("fc9d22a4-ce0f-496c-9f89-428b6c1b1c15") },
                    { new Guid("1b1cad53-569d-4ec7-b074-cd211029bd10"), "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-3.png", new Guid("fc9d22a4-ce0f-496c-9f89-428b6c1b1c15") },
                    { new Guid("1d2bdb9b-4801-475f-b478-dc16992006d6"), "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-1.png", new Guid("9f583531-77c6-4df1-a26e-31ebce5ac44b") },
                    { new Guid("2943f00d-f7bb-46b5-906a-c6eb69d62443"), "/images/Products/twins-special-headgear/twins-shin-headgear-1.png", new Guid("7184e4a1-7ad8-4894-a37e-10c885eb1203") },
                    { new Guid("2b4eddff-50fa-46cc-9c49-0f3a2c7559f2"), "/images/Products/title-boxing-gloves/title-boxing-gloves-1.png", new Guid("14213bcd-4f55-4c5e-a358-149b27245252") },
                    { new Guid("3a87e9b5-f203-40ba-8931-1ec2af1c0c55"), "/images/Products/title-boxing-bag/title-boxing-bag-1.png", new Guid("cabe6b67-bb24-4c5e-b495-8b426cb4323b") },
                    { new Guid("3c07c5eb-702f-40e4-a531-f2900964bf91"), "/images/Products/ringside-punching-bag/ringside-punching-bag-1.png", new Guid("2f761748-ec2f-4d80-b994-d16cf9198a3f") },
                    { new Guid("420c0a7a-3403-48c6-836d-ae18371491c9"), "/images/Products/ringside-punching-bag/ringside-punching-bag-3.png", new Guid("2f761748-ec2f-4d80-b994-d16cf9198a3f") },
                    { new Guid("4342daee-c990-4afb-9bf0-8b7bd5a15086"), "/images/Products/everlasr-pro-headgear/everlast-pro-headgear-2.png", new Guid("635480f0-b7dc-45f1-8d2f-1fd4e7c4a797") },
                    { new Guid("532ccf69-66a0-4269-9633-62e6b9101303"), "/images/Products/sanabul-shin-guards/sanabul-shin-guards-1.png", new Guid("1c85b2f1-778c-4866-9b88-7324c9331381") },
                    { new Guid("66633be3-ae8c-4653-9417-df6c0ec43365"), "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-1.png", new Guid("ab3ee8b6-eebb-43c5-8c32-b332d5c4ad10") },
                    { new Guid("6bcaa668-2c62-4321-93e2-bd9ef4ae1e7c"), "/images/Products/twins-special-headgear/twins-shin-headgear-2.png", new Guid("7184e4a1-7ad8-4894-a37e-10c885eb1203") },
                    { new Guid("6d4009e7-6240-43ce-82c6-0238bc133540"), "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-1.png", new Guid("7a0e08e2-7ef6-45af-8c60-a9ee7688bbc1") },
                    { new Guid("6f4f95a2-9cb7-4192-b7a0-7fbaec194e03"), "/images/Products/sanabul-shin-guards/sanabul-shin-guards-3.png", new Guid("1c85b2f1-778c-4866-9b88-7324c9331381") },
                    { new Guid("70ddbb2b-02dd-43e3-92ff-6552233a5824"), "/images/Products/everlast-hand-wraps/everlast-hand-wraps-2.png", new Guid("8334bf0d-3c8f-4adf-970d-12a27ce0de6f") },
                    { new Guid("7251134e-c42c-44f2-8206-46b61ae19445"), "/images/Products/venum-challenger-gloves/venum-challenger-gloves-2.png", new Guid("817a03d7-5550-4c8b-8afa-5d49aa47931b") },
                    { new Guid("7a98d444-28d2-4eec-97fe-ed27ebd80ff2"), "/images/Products/sanabul-shin-guards/sanabul-shin-guards-2.png", new Guid("1c85b2f1-778c-4866-9b88-7324c9331381") },
                    { new Guid("7f15566d-68be-49aa-a8e6-aa9c20bb2c62"), "/images/Products/title-boxing-gloves/title-boxing-gloves-2.png", new Guid("14213bcd-4f55-4c5e-a358-149b27245252") },
                    { new Guid("876930a1-4411-405b-b440-5fe88c977f16"), "/images/Products/everlast-hand-wraps/everlast-hand-wraps-3.png", new Guid("8334bf0d-3c8f-4adf-970d-12a27ce0de6f") },
                    { new Guid("88c4e890-d621-4ae1-b452-e7d7211f5a20"), "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-3.png", new Guid("9f583531-77c6-4df1-a26e-31ebce5ac44b") },
                    { new Guid("8d229d96-112e-46b9-94f4-2175f7b41c07"), "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-3.png", new Guid("ab3ee8b6-eebb-43c5-8c32-b332d5c4ad10") },
                    { new Guid("92e2cc2a-b609-4c25-9d5e-d2c0ecd5ef79"), "/images/Products/title-boxing-gloves/title-boxing-gloves-3.png", new Guid("14213bcd-4f55-4c5e-a358-149b27245252") },
                    { new Guid("993518ac-69f2-46c3-9423-2fc70cc66074"), "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-1.png", new Guid("cac4733a-d4e6-4a20-8545-82d86cf2908f") },
                    { new Guid("aaeea6f4-9f68-4825-a0e2-41ec128d4d60"), "/images/Products/ringside-punching-bag/ringside-punching-bag-2.png", new Guid("2f761748-ec2f-4d80-b994-d16cf9198a3f") },
                    { new Guid("ae069fba-97f9-41f7-a366-e04ea69bd125"), "/images/Products/title-boxing-bag/title-boxing-bag-3.png", new Guid("cabe6b67-bb24-4c5e-b495-8b426cb4323b") },
                    { new Guid("b1da83a7-f7a0-4537-8e76-f120628ff15d"), "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-2.png", new Guid("cac4733a-d4e6-4a20-8545-82d86cf2908f") },
                    { new Guid("bc09697f-ead3-4075-a721-6c6672f348ab"), "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-2.png", new Guid("7a0e08e2-7ef6-45af-8c60-a9ee7688bbc1") },
                    { new Guid("bcf8391c-4b98-40b2-9899-63fef8adc3fb"), "/images/Products/rdx-boxing-bag/rdx-boxing-bag-2.png", new Guid("6c1f0b6f-b5e6-4565-9f6f-e61983355a20") },
                    { new Guid("c16d3d63-b328-451a-a6af-309a7b587857"), "/images/Products/twins-special-headgear/twins-shin-headgear-3.png", new Guid("7184e4a1-7ad8-4894-a37e-10c885eb1203") },
                    { new Guid("c5f09e4c-90b1-4c48-a6a5-db44346b7a84"), "/images/Products/venum-challenger-gloves/venum-challenger-gloves-1.png", new Guid("817a03d7-5550-4c8b-8afa-5d49aa47931b") },
                    { new Guid("dffca137-9877-431b-a52b-b8ab9cd410ef"), "/images/Products/everlasr-pro-headgear/everlast-pro-headgear-1.png", new Guid("635480f0-b7dc-45f1-8d2f-1fd4e7c4a797") },
                    { new Guid("e121333b-7b9f-4c88-b448-433f6220cf5b"), "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-3.png", new Guid("cac4733a-d4e6-4a20-8545-82d86cf2908f") },
                    { new Guid("f3da87a4-450f-4330-ac01-eb5941237f2b"), "/images/Products/rdx-boxing-bag/rdx-boxing-bag-3.png", new Guid("6c1f0b6f-b5e6-4565-9f6f-e61983355a20") },
                    { new Guid("fa70ce47-4649-4eb4-b4df-41b2aee5e1aa"), "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-2.png", new Guid("fc9d22a4-ce0f-496c-9f89-428b6c1b1c15") },
                    { new Guid("fb25a841-b6f5-467d-910c-6b818290c2da"), "/images/Products/rdx-boxing-bag/rdx-boxing-bag-1.png", new Guid("6c1f0b6f-b5e6-4565-9f6f-e61983355a20") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("0aeedcb1-18ff-4150-a4a2-414c3acbc3b7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("0bcb7b6c-f815-4de8-bf96-86707047cd5d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("4a2ac05e-d9d4-4391-88d4-9b65c24790dc"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("09537be1-6ce8-4cea-a165-3d6bcf286791"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("0f625fe2-110d-4e64-8f0b-7730fd4c9e92"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("0fd799bb-e739-4fdb-be18-c1ce0770227b"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("119a7a85-a3d4-4826-9894-6e1dc71b759a"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("13238791-cfaf-4bca-94f9-6c706f43cc40"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("154dd9b6-bcf3-417b-b41c-3741bf3eb4a6"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("1631da05-82ae-4632-8d66-bd81c5e05d91"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("17d41fac-10f9-4e48-94af-5e507d9049fe"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("1b1cad53-569d-4ec7-b074-cd211029bd10"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("1d2bdb9b-4801-475f-b478-dc16992006d6"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("2943f00d-f7bb-46b5-906a-c6eb69d62443"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("2b4eddff-50fa-46cc-9c49-0f3a2c7559f2"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("3a87e9b5-f203-40ba-8931-1ec2af1c0c55"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("3c07c5eb-702f-40e4-a531-f2900964bf91"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("420c0a7a-3403-48c6-836d-ae18371491c9"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("4342daee-c990-4afb-9bf0-8b7bd5a15086"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("532ccf69-66a0-4269-9633-62e6b9101303"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("66633be3-ae8c-4653-9417-df6c0ec43365"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("6bcaa668-2c62-4321-93e2-bd9ef4ae1e7c"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("6d4009e7-6240-43ce-82c6-0238bc133540"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("6f4f95a2-9cb7-4192-b7a0-7fbaec194e03"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("70ddbb2b-02dd-43e3-92ff-6552233a5824"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("7251134e-c42c-44f2-8206-46b61ae19445"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("7a98d444-28d2-4eec-97fe-ed27ebd80ff2"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("7f15566d-68be-49aa-a8e6-aa9c20bb2c62"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("876930a1-4411-405b-b440-5fe88c977f16"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("88c4e890-d621-4ae1-b452-e7d7211f5a20"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("8d229d96-112e-46b9-94f4-2175f7b41c07"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("92e2cc2a-b609-4c25-9d5e-d2c0ecd5ef79"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("993518ac-69f2-46c3-9423-2fc70cc66074"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("aaeea6f4-9f68-4825-a0e2-41ec128d4d60"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("ae069fba-97f9-41f7-a366-e04ea69bd125"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("b1da83a7-f7a0-4537-8e76-f120628ff15d"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("bc09697f-ead3-4075-a721-6c6672f348ab"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("bcf8391c-4b98-40b2-9899-63fef8adc3fb"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("c16d3d63-b328-451a-a6af-309a7b587857"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("c5f09e4c-90b1-4c48-a6a5-db44346b7a84"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("dffca137-9877-431b-a52b-b8ab9cd410ef"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("e121333b-7b9f-4c88-b448-433f6220cf5b"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("f3da87a4-450f-4330-ac01-eb5941237f2b"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("fa70ce47-4649-4eb4-b4df-41b2aee5e1aa"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("fb25a841-b6f5-467d-910c-6b818290c2da"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("14213bcd-4f55-4c5e-a358-149b27245252"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1c85b2f1-778c-4866-9b88-7324c9331381"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("2f761748-ec2f-4d80-b994-d16cf9198a3f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("635480f0-b7dc-45f1-8d2f-1fd4e7c4a797"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6c1f0b6f-b5e6-4565-9f6f-e61983355a20"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("7184e4a1-7ad8-4894-a37e-10c885eb1203"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("7a0e08e2-7ef6-45af-8c60-a9ee7688bbc1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("817a03d7-5550-4c8b-8afa-5d49aa47931b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("8334bf0d-3c8f-4adf-970d-12a27ce0de6f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("9f583531-77c6-4df1-a26e-31ebce5ac44b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("ab3ee8b6-eebb-43c5-8c32-b332d5c4ad10"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("cabe6b67-bb24-4c5e-b495-8b426cb4323b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("cac4733a-d4e6-4a20-8545-82d86cf2908f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("fc9d22a4-ce0f-496c-9f89-428b6c1b1c15"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("23f367a6-991a-4e05-b066-f5facbcbf549"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("248cc2e8-ddaf-4823-9be7-2b849acb9d8a"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("30d3c248-fc96-48c8-8fa8-221544ae2fc8"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("313e4559-45bc-41df-b670-fc949899bbc4"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("4479663d-9879-4466-a9b7-f8193992b3a6"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("4eced22a-c181-4870-9d60-b244ac446838"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("716bdc21-f89c-41d3-bc74-e35d7bc02e2c"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("7b07e107-99e2-40be-ba06-d0b5a705350b"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("b10113d8-6c04-4d01-8bff-6fa31b882f08"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("be4b4f23-b0e4-4d42-9315-147df5ffc3e0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("56ea514b-ed66-4b38-a9c0-597a30f98ac6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("597d624a-1919-4316-8710-176a021ad9b3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("5b3ac614-76fe-4460-9996-e6c148d101e1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("63144409-4afa-4a11-adc8-2b4889f192a3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("65a54501-fb5b-460b-9631-1f936ccbb98f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("74ef25f0-faa9-497e-8a33-608f9afaeb51"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("b70d37e3-fe2f-42ae-aa89-5b8f2695e8e7"));

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandId", "Address", "Country", "ImageUrl", "IsDeleted", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("38532feb-6f94-4bea-84d5-744a0b35af5c"), "789 Fight St, Toronto, ON", "Canada", "/images/Brands/hayabusa-logo.png", false, "Hayabusa", "789-012-3456" },
                    { new Guid("536f127f-dea8-4ca4-9539-446d1f86daee"), "345 Punch Ln, Los Angeles, CA", "USA", "/images/Brands/title-boxing-logo.png", false, "Title Boxing", "987-654-3210" },
                    { new Guid("5a044fc0-7328-494d-b11f-c07ed1229a59"), "456 Sports Ave, London, UK", "UK", "/images/Brands/rdx-logo.png", false, "RDX", "456-789-0123" },
                    { new Guid("5aba4088-59af-47c0-bd33-3fa1aedc6824"), "234 Fighter Rd, Bangkok, TH", "Thailand", "/images/Brands/fairtex-logo.png", false, "Fairtex", "876-543-2109" },
                    { new Guid("7f2a4214-e5b5-4794-aec8-8736e5c22a83"), "567 Martial Arts Blvd, Oklahoma City, OK", "USA", "/images/Brands/century-logo.png", false, "Century", "345-678-9012" },
                    { new Guid("a0c523fa-38a4-4df7-bf77-a9967bcaa77a"), "123 Boxing Blvd, New York, NY", "USA", "/images/Brands/everlast-logo.png", false, "Everlast", "123-456-7890" },
                    { new Guid("aa4f36b5-1c98-4060-8d62-325adc60f324"), "101 Martial Arts Way, Paris, FR", "France", "/images/Brands/venum-logo.png", false, "Venum", "321-654-0987" },
                    { new Guid("cb03ff7f-6ca9-4efe-b2de-b0ca5be62fc3"), "678 Fighter Ave, Miami, FL", "USA", "/images/Brands/sanabul-logo.png", false, "Sanabul", "456-789-0123" },
                    { new Guid("e52aa911-aa63-498b-8bce-51baab3b5dde"), "789 Kick Rd, Phuket, TH", "Thailand", "/images/Brands/twins-special-logo.png", false, "Twins Special", "567-890-1234" },
                    { new Guid("ea2375ce-e821-4bd6-a76d-46e751a5b26f"), "456 Ring Rd, Chicago, IL", "USA", "/images/Brands/ringside-logo.png", false, "Ringside", "234-567-8901" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "ImageUrl", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { new Guid("187fe48d-e704-4774-9d76-b2b64323bf7b"), "/images/Categories/boxing-shoes.png", false, "Shoes" },
                    { new Guid("1e1ede8d-3b30-4c64-9043-d7a2bfa9bfcb"), "/images/Categories/mouth-guard.png", false, "Mouthguards" },
                    { new Guid("2a625349-7880-4e8f-ad41-b660a7ebeef7"), "/images/Categories/shinguards.png", false, "Shinguards" },
                    { new Guid("50c08702-a1c9-424a-bc28-68519e6b6a8b"), "/images/Categories/protective-gear.png", false, "Protective Gear" },
                    { new Guid("5bde86bf-fe68-48ed-8baf-ddd97501a944"), "/images/Categories/clothing.png", false, "Clothing" },
                    { new Guid("5df8dc80-f152-4795-923c-0561b6f85ce5"), "/images/Categories/hand-wraps.png", false, "Hand Wraps" },
                    { new Guid("835fc42a-2f19-4dc2-be95-be3b82082a40"), "/images/Categegories/boxing-gloves.png", false, "Gloves" },
                    { new Guid("c9ccf53a-822b-4c8b-8fef-5422cefb1ef5"), "/images/Categories/head-gear.png", false, "Headgear" },
                    { new Guid("f4c6db4c-d09c-4ba0-ac14-6937de7fade5"), "/images/Categories/training-equipment.png", false, "Training Equipment" },
                    { new Guid("fc5123b5-7e38-4fab-8b8f-71cc9754ed44"), "/images/Categories/punching-bag.png", false, "Punching Bags" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "BrandId", "CategoryId", "Description", "IsDeleted", "MainImageUrl", "Name", "Price", "Sizes", "StockQuantity" },
                values: new object[,]
                {
                    { new Guid("29eca57a-81ff-4e3a-9d59-ee215619f628"), new Guid("e52aa911-aa63-498b-8bce-51baab3b5dde"), new Guid("c9ccf53a-822b-4c8b-8fef-5422cefb1ef5"), "Full-face protection with Twins quality.", false, null, "Twins Special Headgear", 89.99m, "[1,2,3]", 60 },
                    { new Guid("2ef2c970-b80a-4f78-9792-d17e139bc400"), new Guid("a0c523fa-38a4-4df7-bf77-a9967bcaa77a"), new Guid("c9ccf53a-822b-4c8b-8fef-5422cefb1ef5"), "Full-protection headgear with durable padding.", false, null, "Everlast Pro Headgear", 69.99m, "[2,3]", 50 },
                    { new Guid("3121c01c-f7a8-4e98-b20a-7d114d25caeb"), new Guid("536f127f-dea8-4ca4-9539-446d1f86daee"), new Guid("fc5123b5-7e38-4fab-8b8f-71cc9754ed44"), "Perfect for accuracy and reflex training.", false, null, "Title Boxing Double End Bag", 44.99m, "[3]", 70 },
                    { new Guid("385cc09b-aee6-42ef-b767-4cac18dded80"), new Guid("aa4f36b5-1c98-4060-8d62-325adc60f324"), new Guid("835fc42a-2f19-4dc2-be95-be3b82082a40"), "Lightweight and designed for all skill levels.", false, null, "Venum Challenger Gloves", 39.99m, "[1,2,3]", 120 },
                    { new Guid("3fa04aac-4923-41a5-ac3a-969fd1394c70"), new Guid("ea2375ce-e821-4bd6-a76d-46e751a5b26f"), new Guid("fc5123b5-7e38-4fab-8b8f-71cc9754ed44"), "Heavy-duty bag for all levels of training.", false, null, "Ringside Punching Bag", 119.99m, "[3]", 40 },
                    { new Guid("54057643-6224-4fbb-9ec0-8e761c8b068e"), new Guid("38532feb-6f94-4bea-84d5-744a0b35af5c"), new Guid("835fc42a-2f19-4dc2-be95-be3b82082a40"), "Top-notch gloves with exceptional durability.", false, null, "Hayabusa T3 Boxing Gloves", 89.99m, "[2,3,4]", 50 },
                    { new Guid("83fe2b76-bb52-4920-aba8-4c93ddf5a2d0"), new Guid("a0c523fa-38a4-4df7-bf77-a9967bcaa77a"), new Guid("5df8dc80-f152-4795-923c-0561b6f85ce5"), "Classic wraps for wrist and knuckle protection.", false, null, "Everlast Hand Wraps", 9.99m, "[2,3]", 200 },
                    { new Guid("91111577-7e3d-4dff-b37a-3310c498065a"), new Guid("5aba4088-59af-47c0-bd33-3fa1aedc6824"), new Guid("5bde86bf-fe68-48ed-8baf-ddd97501a944"), "Premium Muay Thai shorts with authentic design.", false, null, "Fairtex Muay Thai Shorts", 34.99m, "[2,3,4]", 90 },
                    { new Guid("94b05df8-64fd-4976-973d-62362ad7d5e2"), new Guid("7f2a4214-e5b5-4794-aec8-8736e5c22a83"), new Guid("5bde86bf-fe68-48ed-8baf-ddd97501a944"), "Comfortable shorts designed for kickboxing.", false, null, "Century Martial Arts Kickboxing Shorts", 29.99m, "[2,3,4]", 75 },
                    { new Guid("a808e4bc-e5bd-4efa-98d5-44393e9102fa"), new Guid("aa4f36b5-1c98-4060-8d62-325adc60f324"), new Guid("2a625349-7880-4e8f-ad41-b660a7ebeef7"), "High-durability shin guards ideal for intense training.", false, null, "Venum Challenger Shin Guards", 45.99m, "[1,2,3]", 95 },
                    { new Guid("ad9e91b8-6144-4f9c-81e3-0559cc5830a1"), new Guid("536f127f-dea8-4ca4-9539-446d1f86daee"), new Guid("835fc42a-2f19-4dc2-be95-be3b82082a40"), "Durable leather gloves for heavy bag workouts.", false, null, "Title Boxing Leather Bag Gloves", 59.99m, "[2,3]", 80 },
                    { new Guid("bcabe895-6c3e-4930-ad10-b7756981ca39"), new Guid("5a044fc0-7328-494d-b11f-c07ed1229a59"), new Guid("835fc42a-2f19-4dc2-be95-be3b82082a40"), "High-quality leather gloves for all training levels.", false, null, "RDX Boxing Gloves", 49.99m, "[1,2,3]", 100 },
                    { new Guid("c52f77d5-a6eb-4a53-bc07-c024be560d38"), new Guid("5a044fc0-7328-494d-b11f-c07ed1229a59"), new Guid("187fe48d-e704-4774-9d76-b2b64323bf7b"), "Lightweight and supportive for agility in the ring.", false, null, "RDX Pro Boxing Shoes", 69.99m, "[2,3,4]", 65 },
                    { new Guid("f2af4558-e395-4b88-b67f-abb596b9c6d0"), new Guid("cb03ff7f-6ca9-4efe-b2de-b0ca5be62fc3"), new Guid("2a625349-7880-4e8f-ad41-b660a7ebeef7"), "High-quality shin guards for protection and mobility.", false, null, "Sanabul Essential Shin Guards", 35.99m, "[2,3,4]", 90 }
                });

            migrationBuilder.InsertData(
                table: "ProductsImages",
                columns: new[] { "ImageId", "ImageUrl", "ProductId" },
                values: new object[,]
                {
                    { new Guid("0c20dfa4-d113-42f4-8a5c-d28dda1305d4"), "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-3.png", new Guid("a808e4bc-e5bd-4efa-98d5-44393e9102fa") },
                    { new Guid("0e123fab-f452-4053-bbd2-755de0e7ed29"), "/images/Products/title-boxing-bag/title-boxing-bag-3.png", new Guid("ad9e91b8-6144-4f9c-81e3-0559cc5830a1") },
                    { new Guid("11131b7a-90e7-4209-bc6b-69ea9c24a4bf"), "/images/Products/twins-special-headgear/twins-shin-headgear-1.png", new Guid("29eca57a-81ff-4e3a-9d59-ee215619f628") },
                    { new Guid("1483d46f-f122-43e5-a54a-ab86d76d50cb"), "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-1.png", new Guid("94b05df8-64fd-4976-973d-62362ad7d5e2") },
                    { new Guid("1eccf3d8-05c2-445e-81de-83f5294ec9be"), "/images/Products/venum-challenger-gloves/venum-challenger-gloves-1.png", new Guid("385cc09b-aee6-42ef-b767-4cac18dded80") },
                    { new Guid("2b53ff0e-5e71-4e5e-a9ff-f32ec3dfb972"), "/images/Products/title-boxing-gloves/title-boxing-gloves-3.png", new Guid("3121c01c-f7a8-4e98-b20a-7d114d25caeb") },
                    { new Guid("31b72d61-407e-4bf1-b6f8-e92bf49ed584"), "/images/Products/sanabul-shin-guards/sanabul-shin-guards-1.png", new Guid("f2af4558-e395-4b88-b67f-abb596b9c6d0") },
                    { new Guid("329cba95-8fc9-4f73-9c93-0d4a606c423e"), "/images/Products/sanabul-shin-guards/sanabul-shin-guards-2.png", new Guid("f2af4558-e395-4b88-b67f-abb596b9c6d0") },
                    { new Guid("387a79d5-dcf3-4ca4-a937-4949a96fe66c"), "/images/Products/everlast-hand-wraps/everlast-hand-wraps-2.png", new Guid("83fe2b76-bb52-4920-aba8-4c93ddf5a2d0") },
                    { new Guid("3f902e72-7481-4add-b891-d28e9ee25d4e"), "/images/Products/everlasr-pro-headgear/everlast-pro-headgear-1.png", new Guid("2ef2c970-b80a-4f78-9792-d17e139bc400") },
                    { new Guid("4042458b-e0ee-4a00-8214-35251346e697"), "/images/Products/everlasr-pro-headgear/everlast-pro-headgear-3.png", new Guid("2ef2c970-b80a-4f78-9792-d17e139bc400") },
                    { new Guid("41c575e2-5783-47b7-92c3-79426074dba8"), "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-1.png", new Guid("91111577-7e3d-4dff-b37a-3310c498065a") },
                    { new Guid("4d5a85e7-b682-425f-8e46-b5c693395a16"), "/images/Products/venum-challenger-gloves/venum-challenger-gloves-2.png", new Guid("385cc09b-aee6-42ef-b767-4cac18dded80") },
                    { new Guid("4e27f6b1-13c3-4b05-87ff-89d7aa9f2f77"), "/images/Products/twins-special-headgear/twins-shin-headgear-2.png", new Guid("29eca57a-81ff-4e3a-9d59-ee215619f628") },
                    { new Guid("5a244e77-1517-4b4a-810b-532f7a289b5e"), "/images/Products/title-boxing-gloves/title-boxing-gloves-2.png", new Guid("3121c01c-f7a8-4e98-b20a-7d114d25caeb") },
                    { new Guid("5d0a1247-033b-49c2-bebc-498200d0d276"), "/images/Products/ringside-punching-bag/ringside-punching-bag-3.png", new Guid("3fa04aac-4923-41a5-ac3a-969fd1394c70") },
                    { new Guid("67b64dd4-71ab-413b-8f84-b28656c904ba"), "/images/Products/title-boxing-gloves/title-boxing-gloves-1.png", new Guid("3121c01c-f7a8-4e98-b20a-7d114d25caeb") },
                    { new Guid("68050623-709f-4c99-8810-f3be193c5eb8"), "/images/Products/ringside-punching-bag/ringside-punching-bag-1.png", new Guid("3fa04aac-4923-41a5-ac3a-969fd1394c70") },
                    { new Guid("6a4d540f-0de5-47a6-b336-f2ca1ec0fd36"), "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-1.png", new Guid("54057643-6224-4fbb-9ec0-8e761c8b068e") },
                    { new Guid("76e7b3ef-491d-4527-858c-58de6fddec4b"), "/images/Products/twins-special-headgear/twins-shin-headgear-3.png", new Guid("29eca57a-81ff-4e3a-9d59-ee215619f628") },
                    { new Guid("82859ca3-875e-460d-9c50-6bb0e98a2141"), "/images/Products/sanabul-shin-guards/sanabul-shin-guards-3.png", new Guid("f2af4558-e395-4b88-b67f-abb596b9c6d0") },
                    { new Guid("86cf93de-856f-4677-b83b-06afa0724b35"), "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-2.png", new Guid("91111577-7e3d-4dff-b37a-3310c498065a") },
                    { new Guid("87f5968c-7128-4f25-835c-2710c31b9344"), "/images/Products/rdx-boxing-bag/rdx-boxing-bag-3.png", new Guid("c52f77d5-a6eb-4a53-bc07-c024be560d38") },
                    { new Guid("8f3abdee-1178-44b9-9abf-bc1a596768ef"), "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-2.png", new Guid("a808e4bc-e5bd-4efa-98d5-44393e9102fa") },
                    { new Guid("96215abe-fb99-46e2-b416-f2824e85d7bd"), "/images/Products/title-boxing-bag/title-boxing-bag-1.png", new Guid("ad9e91b8-6144-4f9c-81e3-0559cc5830a1") },
                    { new Guid("9ce45abe-4ebc-423c-851a-99bfc1dd285f"), "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-1.png", new Guid("a808e4bc-e5bd-4efa-98d5-44393e9102fa") },
                    { new Guid("9ff83138-fe1e-44fc-867e-7e23e1ec0e9b"), "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-2.png", new Guid("94b05df8-64fd-4976-973d-62362ad7d5e2") },
                    { new Guid("a838ee14-7307-427a-94f4-44d4d3b69942"), "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-1.png", new Guid("bcabe895-6c3e-4930-ad10-b7756981ca39") },
                    { new Guid("ac18b2e7-47d6-4a28-9b52-4886dff937f0"), "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-2.png", new Guid("54057643-6224-4fbb-9ec0-8e761c8b068e") },
                    { new Guid("acc55ab9-3389-4c44-bbbf-84812a710cd7"), "/images/Products/venum-challenger-gloves/venum-challenger-gloves-3.png", new Guid("385cc09b-aee6-42ef-b767-4cac18dded80") },
                    { new Guid("ae7ed184-6c82-44dc-8128-24cfae1cf8c6"), "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-3.png", new Guid("54057643-6224-4fbb-9ec0-8e761c8b068e") },
                    { new Guid("b1d420d2-aabd-4cb6-8d37-f8f62cc60a8a"), "/images/Products/title-boxing-bag/title-boxing-bag-2.png", new Guid("ad9e91b8-6144-4f9c-81e3-0559cc5830a1") },
                    { new Guid("b83c66b5-9fa0-4502-8ed6-a026b6f069e8"), "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-3.png", new Guid("91111577-7e3d-4dff-b37a-3310c498065a") },
                    { new Guid("bde323d4-7551-4a28-99ca-e6029e0d2004"), "/images/Products/everlast-hand-wraps/everlast-hand-wraps-1.png", new Guid("83fe2b76-bb52-4920-aba8-4c93ddf5a2d0") },
                    { new Guid("c3c08194-17d0-4a89-bfd5-2287c4b15bad"), "/images/Products/rdx-boxing-bag/rdx-boxing-bag-1.png", new Guid("c52f77d5-a6eb-4a53-bc07-c024be560d38") },
                    { new Guid("c74d6d3a-74d8-443c-98c8-de4b8237f55b"), "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-3.png", new Guid("bcabe895-6c3e-4930-ad10-b7756981ca39") },
                    { new Guid("c7f11e32-33a2-436f-9f9e-eba080ed3941"), "/images/Products/everlasr-pro-headgear/everlast-pro-headgear-2.png", new Guid("2ef2c970-b80a-4f78-9792-d17e139bc400") },
                    { new Guid("cf11227a-ec55-4dd7-9cbc-ccffa6fe22eb"), "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-2.png", new Guid("bcabe895-6c3e-4930-ad10-b7756981ca39") },
                    { new Guid("d7fd3655-3b9b-4427-8cc2-d47f8a10b607"), "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-3.png", new Guid("94b05df8-64fd-4976-973d-62362ad7d5e2") },
                    { new Guid("dd3f8acb-7882-4a33-bc60-0b310ac6c6e4"), "/images/Products/ringside-punching-bag/ringside-punching-bag-2.png", new Guid("3fa04aac-4923-41a5-ac3a-969fd1394c70") },
                    { new Guid("fbfef284-0573-4554-aaad-eb0c9cc22b80"), "/images/Products/everlast-hand-wraps/everlast-hand-wraps-3.png", new Guid("83fe2b76-bb52-4920-aba8-4c93ddf5a2d0") },
                    { new Guid("fe9ca250-5718-479b-ac95-0b628a339683"), "/images/Products/rdx-boxing-bag/rdx-boxing-bag-2.png", new Guid("c52f77d5-a6eb-4a53-bc07-c024be560d38") }
                });
        }
    }
}
