using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KickShop.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedTheProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandId", "Address", "Country", "ImageUrl", "IsDeleted", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("01009c14-b6a3-4fdb-a8d3-3fd0f934779d"), "567 Martial Arts Blvd, Oklahoma City, OK", "USA", "/images/Brands/century-logo.png", false, "Century", "345-678-9012" },
                    { new Guid("246ad0fc-7a10-4055-a975-e70f393ed6a8"), "789 Kick Rd, Phuket, TH", "Thailand", "/images/Brands/twins-special-logo.png", false, "Twins Special", "567-890-1234" },
                    { new Guid("45ed06fe-c39f-400b-bcd8-ac2fdf06c1ec"), "123 Boxing Blvd, New York, NY", "USA", "/images/Brands/everlast-logo.png", false, "Everlast", "123-456-7890" },
                    { new Guid("65d459e9-0126-4e4e-b493-b7ed93a091b9"), "345 Punch Ln, Los Angeles, CA", "USA", "/images/Brands/title-boxing-logo.png", false, "Title Boxing", "987-654-3210" },
                    { new Guid("9f022485-47db-4d0c-9069-abefdc0b973d"), "456 Sports Ave, London, UK", "UK", "/images/Brands/rdx-logo.png", false, "RDX", "456-789-0123" },
                    { new Guid("a4359f24-7957-412e-bc43-7927594ceee4"), "678 Fighter Ave, Miami, FL", "USA", "/images/Brands/sanabul-logo.png", false, "Sanabul", "456-789-0123" },
                    { new Guid("b2874b7b-a19e-4af3-8e8b-655ba901c40d"), "234 Fighter Rd, Bangkok, TH", "Thailand", "/images/Brands/fairtex-logo.png", false, "Fairtex", "876-543-2109" },
                    { new Guid("b803c421-643d-4bb4-94a0-9bd90c3a238f"), "456 Ring Rd, Chicago, IL", "USA", "/images/Brands/ringside-logo.png", false, "Ringside", "234-567-8901" },
                    { new Guid("d30d9669-9dd6-4795-828d-34e6c5c9a97e"), "101 Martial Arts Way, Paris, FR", "France", "/images/Brands/venum-logo.png", false, "Venum", "321-654-0987" },
                    { new Guid("f34d456f-059c-4f75-a734-cdf2635a3568"), "789 Fight St, Toronto, ON", "Canada", "/images/Brands/hayabusa-logo.png", false, "Hayabusa", "789-012-3456" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "ImageUrl", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { new Guid("2ab0ca07-4211-4275-859b-f869f1dbecf4"), "/images/Categories/training-equipment.png", false, "Training Equipment" },
                    { new Guid("417d2c32-3e34-4524-b770-df0a1efb39c6"), "/images/Categories/punching-bag.png", false, "Punching Bags" },
                    { new Guid("4a834943-07f5-4924-8cf2-a530fd49dc53"), "/images/Categories/protective-equipment.jfif", false, "Protective Gear" },
                    { new Guid("925bca40-3b23-4eea-85b7-a203bb11fd34"), "/images/Categories/head-gear.png", false, "Headgear" },
                    { new Guid("b1f57dfe-a80d-4241-be1b-53fbda7a043c"), "/images/Categories/hand-wraps.png", false, "Hand Wraps" },
                    { new Guid("b99ea429-9537-42e3-a07b-620761fdd5bd"), "/images/Categegories/boxing-gloves.jfif", false, "Gloves" },
                    { new Guid("bd628d4a-44af-4a35-b765-56a121be1679"), "/images/Categories/mouth-guard.png", false, "Mouthguards" },
                    { new Guid("c5c9e1d9-41af-49fd-9645-644427ff0d29"), "/images/Categories/clothing.png", false, "Clothing" },
                    { new Guid("c6baa8f2-bc25-4208-9af0-6b4ddc4751e7"), "/images/Categories/shin-guards.png", false, "Shinguards" },
                    { new Guid("c7ae29e1-e593-47f4-bc35-83616a914f33"), "/images/Categories/boxing-shoes.png", false, "Shoes" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "BrandId", "CategoryId", "Description", "IsDeleted", "MainImageUrl", "Name", "Price", "Sizes", "StockQuantity" },
                values: new object[,]
                {
                    { new Guid("084c6abe-687a-4d0d-8a80-5860a99b8584"), new Guid("45ed06fe-c39f-400b-bcd8-ac2fdf06c1ec"), new Guid("b1f57dfe-a80d-4241-be1b-53fbda7a043c"), "Classic wraps for wrist and knuckle protection.", false, "/images/Products/everlast-hand-wraps/everlast-hand-wraps-3.png", "Everlast Hand Wraps", 9.99m, "[2,3]", 200 },
                    { new Guid("0d73ecf5-0cc5-4d0c-8c84-0ffab596af80"), new Guid("d30d9669-9dd6-4795-828d-34e6c5c9a97e"), new Guid("c6baa8f2-bc25-4208-9af0-6b4ddc4751e7"), "High-durability shin guards ideal for intense training.", false, "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-1.png", "Venum Challenger Shin Guards", 105.99m, "[1,2,3]", 95 },
                    { new Guid("13d54d1c-2475-4fa6-b3fb-2bbc793a7873"), new Guid("01009c14-b6a3-4fdb-a8d3-3fd0f934779d"), new Guid("c5c9e1d9-41af-49fd-9645-644427ff0d29"), "Comfortable shorts designed for kickboxing.", false, "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-1.png", "Century Martial Arts Kickboxing Shorts", 79.99m, "[2,3,4]", 75 },
                    { new Guid("22c6fe6b-9225-48b1-97e7-5bb67955cc3a"), new Guid("246ad0fc-7a10-4055-a975-e70f393ed6a8"), new Guid("925bca40-3b23-4eea-85b7-a203bb11fd34"), "Full-face protection with Twins quality.", false, "/images/Products/twins-special-headgear/twins-special-headgear-1.png", "Twins Special Headgear", 89.99m, "[1,2,3]", 60 },
                    { new Guid("4a4b7c5e-cc07-49b1-9d95-901fc9ca5675"), new Guid("9f022485-47db-4d0c-9069-abefdc0b973d"), new Guid("c7ae29e1-e593-47f4-bc35-83616a914f33"), "Lightweight and supportive for agility in the ring.", false, "/images/Products/rdx-boxing-shoes/rdx-boxing-shoes-1.png", "RDX Pro Boxing Shoes", 109.99m, "[2,3,4]", 65 },
                    { new Guid("5c9f7917-0c0b-4abc-a489-d873b1dc1fbb"), new Guid("d30d9669-9dd6-4795-828d-34e6c5c9a97e"), new Guid("b99ea429-9537-42e3-a07b-620761fdd5bd"), "Lightweight and designed for all skill levels.", false, "/images/Products/venum-challenger-gloves/venum-challenger-gloves-2.png", "Venum Challenger Gloves", 89.99m, "[1,2,3]", 120 },
                    { new Guid("840b45a3-34dd-41af-985a-19d322c054ae"), new Guid("65d459e9-0126-4e4e-b493-b7ed93a091b9"), new Guid("417d2c32-3e34-4524-b770-df0a1efb39c6"), "Perfect for accuracy and reflex training.", false, "/images/Products/title-boxing-gloves/title-boxing-gloves-1.png", "Title Boxing Double End Bag", 99.99m, "[3]", 70 },
                    { new Guid("934ad617-f9fa-4690-8995-20dc85bee97a"), new Guid("65d459e9-0126-4e4e-b493-b7ed93a091b9"), new Guid("b99ea429-9537-42e3-a07b-620761fdd5bd"), "Durable leather gloves for heavy bag workouts.", false, "/images/Products/title-boxing-bag/title-boxing-bag-1.png", "Title Boxing Leather Bag Gloves", 79.99m, "[2,3]", 80 },
                    { new Guid("98163de1-d055-4d19-9252-86d793890f80"), new Guid("a4359f24-7957-412e-bc43-7927594ceee4"), new Guid("c6baa8f2-bc25-4208-9af0-6b4ddc4751e7"), "High-quality shin guards for protection and mobility.", false, "/images/Products/sanabul-shin-guards/sanabul-shin-guards-1.png", "Sanabul Essential Shin Guards", 105.99m, "[2,3,4]", 90 },
                    { new Guid("987c49d9-f9bc-4063-a0fe-2ff63ac20f36"), new Guid("b2874b7b-a19e-4af3-8e8b-655ba901c40d"), new Guid("c5c9e1d9-41af-49fd-9645-644427ff0d29"), "Premium Muay Thai shorts with authentic design.", false, "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-1.png", "Fairtex Muay Thai Shorts", 84.99m, "[2,3,4]", 90 },
                    { new Guid("ac55792c-aab7-4905-a41f-017cd6067b51"), new Guid("f34d456f-059c-4f75-a734-cdf2635a3568"), new Guid("b99ea429-9537-42e3-a07b-620761fdd5bd"), "Top-notch gloves with exceptional durability.", false, "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-1.png", "Hayabusa T3 Boxing Gloves", 189.99m, "[2,3,4]", 50 },
                    { new Guid("c12cf098-7608-4034-ba4a-1e6d27f7b330"), new Guid("b803c421-643d-4bb4-94a0-9bd90c3a238f"), new Guid("417d2c32-3e34-4524-b770-df0a1efb39c6"), "Heavy-duty bag for all levels of training.", false, "/images/Products/ringside-punching-bag/ringside-punching-bag-1.png", "Ringside Punching Bag", 219.99m, "[3]", 40 },
                    { new Guid("d5ec53e7-0d32-499b-9bf6-13bfbf0e106f"), new Guid("9f022485-47db-4d0c-9069-abefdc0b973d"), new Guid("b99ea429-9537-42e3-a07b-620761fdd5bd"), "High-quality leather gloves for all training levels.", false, "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-3.png", "RDX Boxing Gloves", 109.99m, "[1,2,3]", 100 },
                    { new Guid("db7f96be-af61-4793-90ec-93ac4f957bfb"), new Guid("45ed06fe-c39f-400b-bcd8-ac2fdf06c1ec"), new Guid("925bca40-3b23-4eea-85b7-a203bb11fd34"), "Full-protection headgear with durable padding.", false, "/images/Products/everlast-pro-headgear/everlast-headgear-1.png", "Everlast Pro Headgear", 89.99m, "[2,3]", 50 }
                });

            migrationBuilder.InsertData(
                table: "ProductsImages",
                columns: new[] { "ImageId", "ImageUrl", "ProductId" },
                values: new object[,]
                {
                    { new Guid("000758b7-23f9-4c57-9fb5-4158c85f480a"), "/images/Products/rdx-boxing-shoes/rdx-boxing-shoes-2.png", new Guid("4a4b7c5e-cc07-49b1-9d95-901fc9ca5675") },
                    { new Guid("02af7800-f407-4e10-aa58-7de0a518be86"), "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-1.png", new Guid("d5ec53e7-0d32-499b-9bf6-13bfbf0e106f") },
                    { new Guid("0c7c2fb8-69c4-4fca-be7b-7b34e56345e3"), "/images/Products/sanabul-shin-guards/sanabul-shin-guards-1.png", new Guid("98163de1-d055-4d19-9252-86d793890f80") },
                    { new Guid("2109cf56-0207-41a9-ae61-96e24244096d"), "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-2.png", new Guid("d5ec53e7-0d32-499b-9bf6-13bfbf0e106f") },
                    { new Guid("26a51e66-38ad-4bc1-a4a3-6658eb8aa20d"), "/images/Products/venum-challenger-gloves/venum-challenger-gloves-2.png", new Guid("5c9f7917-0c0b-4abc-a489-d873b1dc1fbb") },
                    { new Guid("28b59304-4e5c-4430-8397-3c943756efbb"), "/images/Products/everlasr-pro-headgear/everlast-headgear-2.png", new Guid("db7f96be-af61-4793-90ec-93ac4f957bfb") },
                    { new Guid("33742e0a-4e80-409e-adcc-c73a23c0886a"), "/images/Products/twins-special-headgear/twins-special-headgear-1.png", new Guid("22c6fe6b-9225-48b1-97e7-5bb67955cc3a") },
                    { new Guid("3f7384b0-8aa5-47fb-a17b-dce30c89466d"), "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-3.png", new Guid("987c49d9-f9bc-4063-a0fe-2ff63ac20f36") },
                    { new Guid("400147d6-3315-4813-b264-f6796c04f027"), "/images/Products/twins-special-headgear/twins-special-headgear-2.png", new Guid("22c6fe6b-9225-48b1-97e7-5bb67955cc3a") },
                    { new Guid("40e25110-0592-4c9a-928f-8985c100fa41"), "/images/Products/sanabul-shin-guards/sanabul-shin-guards-3.png", new Guid("98163de1-d055-4d19-9252-86d793890f80") },
                    { new Guid("4556a2d3-f9f7-41c4-b530-eb0d0c2409a0"), "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-2.png", new Guid("987c49d9-f9bc-4063-a0fe-2ff63ac20f36") },
                    { new Guid("45b987a0-25d9-495a-9d5a-83661e0b456a"), "/images/Products/venum-challenger-gloves/venum-challenger-gloves-3.png", new Guid("5c9f7917-0c0b-4abc-a489-d873b1dc1fbb") },
                    { new Guid("4ac487ba-f17b-4a38-9493-d1e48897c392"), "/images/Products/title-boxing-gloves/title-boxing-gloves-3.png", new Guid("840b45a3-34dd-41af-985a-19d322c054ae") },
                    { new Guid("4b6dcb09-6521-4108-83c9-e03a5adbf519"), "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-3.png", new Guid("13d54d1c-2475-4fa6-b3fb-2bbc793a7873") },
                    { new Guid("55285bb7-0ba8-4c14-8306-0cea2389b70d"), "/images/Products/ringside-punching-bag/ringside-punching-bag-1.png", new Guid("c12cf098-7608-4034-ba4a-1e6d27f7b330") },
                    { new Guid("5c04adfd-cd39-4b28-b35c-eb052c35c8da"), "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-1.png", new Guid("0d73ecf5-0cc5-4d0c-8c84-0ffab596af80") },
                    { new Guid("60bcefcd-6899-48a7-a3fd-83292da71070"), "/images/Products/title-boxing-gloves/title-boxing-gloves-2.png", new Guid("840b45a3-34dd-41af-985a-19d322c054ae") },
                    { new Guid("6ceae3fe-7e8e-415c-aa13-a35be27fd5fb"), "/images/Products/ringside-punching-bag/ringside-punching-bag-2.png", new Guid("c12cf098-7608-4034-ba4a-1e6d27f7b330") },
                    { new Guid("6d611d33-865c-4a28-908b-408d79db293b"), "/images/Products/twins-special-headgear/twins-shin-headgear-3.png", new Guid("22c6fe6b-9225-48b1-97e7-5bb67955cc3a") },
                    { new Guid("6d7edd0f-8589-41fb-93aa-b7d0053f75a4"), "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-2.png", new Guid("13d54d1c-2475-4fa6-b3fb-2bbc793a7873") },
                    { new Guid("75b93f90-0953-473a-b78a-66891ee15e13"), "/images/Products/everlasr-pro-headgear/everlast-headgear-1.png", new Guid("db7f96be-af61-4793-90ec-93ac4f957bfb") },
                    { new Guid("7bc91822-8694-4a4d-9465-8d662bb0c1ee"), "/images/Products/title-boxing-bag/title-boxing-bag-1.png", new Guid("934ad617-f9fa-4690-8995-20dc85bee97a") },
                    { new Guid("7da105c8-6751-4a87-bb78-b878df24c64a"), "/images/Products/everlast-hand-wraps/everlast-hand-wraps-3.png", new Guid("084c6abe-687a-4d0d-8a80-5860a99b8584") },
                    { new Guid("97aa9ea1-aaef-4f6f-820a-657fa7d23c8a"), "/images/Products/title-boxing-bag/title-boxing-bag-2.png", new Guid("934ad617-f9fa-4690-8995-20dc85bee97a") },
                    { new Guid("a03e6e05-7201-4f91-be0f-f470ccb09668"), "/images/Products/everlasr-pro-headgear/everlast-headgear-3.png", new Guid("db7f96be-af61-4793-90ec-93ac4f957bfb") },
                    { new Guid("a2938b37-02db-4d9e-afc9-1fcc717b3b41"), "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-1.png", new Guid("13d54d1c-2475-4fa6-b3fb-2bbc793a7873") },
                    { new Guid("ae02b1b6-afc7-4561-9966-d176e661910b"), "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-1.png", new Guid("987c49d9-f9bc-4063-a0fe-2ff63ac20f36") },
                    { new Guid("b9163b39-5dd3-466f-9f9c-6ee72fb7b249"), "/images/Products/everlast-hand-wraps/everlast-hand-wraps-1.png", new Guid("084c6abe-687a-4d0d-8a80-5860a99b8584") },
                    { new Guid("bc5d1ca9-538b-4c61-816a-e0d8ac8e0430"), "/images/Products/title-boxing-gloves/title-boxing-gloves-1.png", new Guid("840b45a3-34dd-41af-985a-19d322c054ae") },
                    { new Guid("c1fd54cf-eec8-43ee-8caa-d3077167d4d9"), "/images/Products/everlast-hand-wraps/everlast-hand-wraps-2.png", new Guid("084c6abe-687a-4d0d-8a80-5860a99b8584") },
                    { new Guid("c3e58941-77c5-4f75-8473-e32a501c6da0"), "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-3.png", new Guid("0d73ecf5-0cc5-4d0c-8c84-0ffab596af80") },
                    { new Guid("cdf0269f-3fdf-417e-91d4-ab25469ae8f7"), "/images/Products/sanabul-shin-guards/sanabul-shin-guards-2.png", new Guid("98163de1-d055-4d19-9252-86d793890f80") },
                    { new Guid("ce9f9e6a-809a-4307-b0c3-c0631edc3b89"), "/images/Products/rdx-boxing-shoes/rdx-boxing-shoes-1.png", new Guid("4a4b7c5e-cc07-49b1-9d95-901fc9ca5675") },
                    { new Guid("cfd36d59-e471-4a73-966b-a4153ca4688d"), "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-2.png", new Guid("ac55792c-aab7-4905-a41f-017cd6067b51") },
                    { new Guid("d19b28b4-709b-4e0e-bd5d-8045110a4d2a"), "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-3.png", new Guid("ac55792c-aab7-4905-a41f-017cd6067b51") },
                    { new Guid("d1bc6c10-cd27-4a7a-9416-7f4b1cec0ff6"), "/images/Products/venum-challenger-gloves/venum-challenger-gloves-1.png", new Guid("5c9f7917-0c0b-4abc-a489-d873b1dc1fbb") },
                    { new Guid("e4b840dc-9d04-4c9f-9f14-6da7c895e034"), "/images/Products/title-boxing-bag/title-boxing-bag-3.png", new Guid("934ad617-f9fa-4690-8995-20dc85bee97a") },
                    { new Guid("f0d95091-324b-42b1-9d9b-71dc46b2fd86"), "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-3.png", new Guid("d5ec53e7-0d32-499b-9bf6-13bfbf0e106f") },
                    { new Guid("f6243712-0cdb-454f-b758-3f995eb21150"), "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-1.png", new Guid("ac55792c-aab7-4905-a41f-017cd6067b51") },
                    { new Guid("fd34c5fa-bfd7-4006-b257-54dc014450bc"), "/images/Products/ringside-punching-bag/ringside-punching-bag-3.png", new Guid("c12cf098-7608-4034-ba4a-1e6d27f7b330") },
                    { new Guid("fd98bb2a-5a08-44cc-aeda-b71f1d6feafc"), "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-2.png", new Guid("0d73ecf5-0cc5-4d0c-8c84-0ffab596af80") },
                    { new Guid("fdfcc3dd-2d95-439c-827e-a4906a6d5a05"), "/images/Products/rdx-boxing-shoes/rdx-boxing-shoes-3.png", new Guid("4a4b7c5e-cc07-49b1-9d95-901fc9ca5675") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("2ab0ca07-4211-4275-859b-f869f1dbecf4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("4a834943-07f5-4924-8cf2-a530fd49dc53"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("bd628d4a-44af-4a35-b765-56a121be1679"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("000758b7-23f9-4c57-9fb5-4158c85f480a"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("02af7800-f407-4e10-aa58-7de0a518be86"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("0c7c2fb8-69c4-4fca-be7b-7b34e56345e3"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("2109cf56-0207-41a9-ae61-96e24244096d"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("26a51e66-38ad-4bc1-a4a3-6658eb8aa20d"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("28b59304-4e5c-4430-8397-3c943756efbb"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("33742e0a-4e80-409e-adcc-c73a23c0886a"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("3f7384b0-8aa5-47fb-a17b-dce30c89466d"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("400147d6-3315-4813-b264-f6796c04f027"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("40e25110-0592-4c9a-928f-8985c100fa41"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("4556a2d3-f9f7-41c4-b530-eb0d0c2409a0"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("45b987a0-25d9-495a-9d5a-83661e0b456a"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("4ac487ba-f17b-4a38-9493-d1e48897c392"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("4b6dcb09-6521-4108-83c9-e03a5adbf519"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("55285bb7-0ba8-4c14-8306-0cea2389b70d"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("5c04adfd-cd39-4b28-b35c-eb052c35c8da"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("60bcefcd-6899-48a7-a3fd-83292da71070"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("6ceae3fe-7e8e-415c-aa13-a35be27fd5fb"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("6d611d33-865c-4a28-908b-408d79db293b"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("6d7edd0f-8589-41fb-93aa-b7d0053f75a4"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("75b93f90-0953-473a-b78a-66891ee15e13"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("7bc91822-8694-4a4d-9465-8d662bb0c1ee"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("7da105c8-6751-4a87-bb78-b878df24c64a"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("97aa9ea1-aaef-4f6f-820a-657fa7d23c8a"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("a03e6e05-7201-4f91-be0f-f470ccb09668"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("a2938b37-02db-4d9e-afc9-1fcc717b3b41"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("ae02b1b6-afc7-4561-9966-d176e661910b"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("b9163b39-5dd3-466f-9f9c-6ee72fb7b249"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("bc5d1ca9-538b-4c61-816a-e0d8ac8e0430"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("c1fd54cf-eec8-43ee-8caa-d3077167d4d9"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("c3e58941-77c5-4f75-8473-e32a501c6da0"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("cdf0269f-3fdf-417e-91d4-ab25469ae8f7"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("ce9f9e6a-809a-4307-b0c3-c0631edc3b89"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("cfd36d59-e471-4a73-966b-a4153ca4688d"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("d19b28b4-709b-4e0e-bd5d-8045110a4d2a"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("d1bc6c10-cd27-4a7a-9416-7f4b1cec0ff6"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("e4b840dc-9d04-4c9f-9f14-6da7c895e034"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("f0d95091-324b-42b1-9d9b-71dc46b2fd86"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("f6243712-0cdb-454f-b758-3f995eb21150"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("fd34c5fa-bfd7-4006-b257-54dc014450bc"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("fd98bb2a-5a08-44cc-aeda-b71f1d6feafc"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("fdfcc3dd-2d95-439c-827e-a4906a6d5a05"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("084c6abe-687a-4d0d-8a80-5860a99b8584"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("0d73ecf5-0cc5-4d0c-8c84-0ffab596af80"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("13d54d1c-2475-4fa6-b3fb-2bbc793a7873"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("22c6fe6b-9225-48b1-97e7-5bb67955cc3a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4a4b7c5e-cc07-49b1-9d95-901fc9ca5675"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("5c9f7917-0c0b-4abc-a489-d873b1dc1fbb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("840b45a3-34dd-41af-985a-19d322c054ae"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("934ad617-f9fa-4690-8995-20dc85bee97a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("98163de1-d055-4d19-9252-86d793890f80"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("987c49d9-f9bc-4063-a0fe-2ff63ac20f36"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("ac55792c-aab7-4905-a41f-017cd6067b51"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c12cf098-7608-4034-ba4a-1e6d27f7b330"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d5ec53e7-0d32-499b-9bf6-13bfbf0e106f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("db7f96be-af61-4793-90ec-93ac4f957bfb"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("01009c14-b6a3-4fdb-a8d3-3fd0f934779d"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("246ad0fc-7a10-4055-a975-e70f393ed6a8"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("45ed06fe-c39f-400b-bcd8-ac2fdf06c1ec"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("65d459e9-0126-4e4e-b493-b7ed93a091b9"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("9f022485-47db-4d0c-9069-abefdc0b973d"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("a4359f24-7957-412e-bc43-7927594ceee4"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("b2874b7b-a19e-4af3-8e8b-655ba901c40d"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("b803c421-643d-4bb4-94a0-9bd90c3a238f"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("d30d9669-9dd6-4795-828d-34e6c5c9a97e"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("f34d456f-059c-4f75-a734-cdf2635a3568"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("417d2c32-3e34-4524-b770-df0a1efb39c6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("925bca40-3b23-4eea-85b7-a203bb11fd34"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("b1f57dfe-a80d-4241-be1b-53fbda7a043c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("b99ea429-9537-42e3-a07b-620761fdd5bd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("c5c9e1d9-41af-49fd-9645-644427ff0d29"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("c6baa8f2-bc25-4208-9af0-6b4ddc4751e7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("c7ae29e1-e593-47f4-bc35-83616a914f33"));

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
    }
}
