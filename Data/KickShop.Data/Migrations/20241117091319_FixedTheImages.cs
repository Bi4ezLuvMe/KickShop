using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KickShop.Migrations
{
    /// <inheritdoc />
    public partial class FixedTheImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("01ad82dd-7ceb-4cfa-9609-8c65b0c30c67"), "456 Sports Ave, London, UK", "UK", "/images/Brands/rdx-logo.png", false, "RDX", "456-789-0123" },
                    { new Guid("391afcb1-7081-4fb6-b9e6-dbc9a068c4ee"), "101 Martial Arts Way, Paris, FR", "France", "/images/Brands/venum-logo.png", false, "Venum", "321-654-0987" },
                    { new Guid("5b01ec2f-60ed-40d9-b300-16f7157251ac"), "789 Kick Rd, Phuket, TH", "Thailand", "/images/Brands/twins-special-logo.png", false, "Twins Special", "567-890-1234" },
                    { new Guid("5bbafe85-7896-4328-babc-b6dc410dc05b"), "123 Boxing Blvd, New York, NY", "USA", "/images/Brands/everlast-logo.png", false, "Everlast", "123-456-7890" },
                    { new Guid("845996f3-0390-412e-8cb1-6c884c8cfbda"), "234 Fighter Rd, Bangkok, TH", "Thailand", "/images/Brands/fairtex-logo.png", false, "Fairtex", "876-543-2109" },
                    { new Guid("854e474e-d67b-491f-92a4-a8d444876fdc"), "456 Ring Rd, Chicago, IL", "USA", "/images/Brands/ringside-logo.png", false, "Ringside", "234-567-8901" },
                    { new Guid("98ff6677-6673-491d-afd3-5a7905a75d84"), "567 Martial Arts Blvd, Oklahoma City, OK", "USA", "/images/Brands/century-logo.png", false, "Century", "345-678-9012" },
                    { new Guid("9e521fc9-d808-4328-81a8-4f3181ddb590"), "345 Punch Ln, Los Angeles, CA", "USA", "/images/Brands/title-boxing-logo.png", false, "Title Boxing", "987-654-3210" },
                    { new Guid("bd361206-00f5-4603-b66b-439f7a084817"), "678 Fighter Ave, Miami, FL", "USA", "/images/Brands/sanabul-logo.png", false, "Sanabul", "456-789-0123" },
                    { new Guid("c7ba8a37-fb4d-4e90-8f97-b4bae566f1f7"), "789 Fight St, Toronto, ON", "Canada", "/images/Brands/hayabusa-logo.png", false, "Hayabusa", "789-012-3456" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "ImageUrl", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { new Guid("03b9c507-bf04-40e4-9bf1-6bd98bedc20a"), "/images/Categories/head-gear.png", false, "Headgear" },
                    { new Guid("0a25f5fe-20e8-40ab-b2ee-d363e74bc4f2"), "/images/Categories/clothing.png", false, "Clothing" },
                    { new Guid("478ebbe4-7b27-4ee6-9956-6b3ad83a1145"), "/images/Categories/punching-bag.png", false, "Punching Bags" },
                    { new Guid("6c35710d-52a8-45af-b5d0-018072c20a36"), "/images/Categories/training-equipment.png", false, "Training Equipment" },
                    { new Guid("6d966a9d-85f9-480c-83d8-438620d35196"), "/images/Categegories/boxing-gloves.jfif", false, "Gloves" },
                    { new Guid("7328b4bc-4edc-479c-9697-5b286d7ea4f4"), "/images/Categories/protective-equipment.jfif", false, "Protective Gear" },
                    { new Guid("8d9a1146-5fee-4cb2-b223-56bf09ce5556"), "/images/Categories/mouth-guard.png", false, "Mouthguards" },
                    { new Guid("9be893e1-a8ee-4a77-8b0a-7aa41bd34bf8"), "/images/Categories/hand-wraps.png", false, "Hand Wraps" },
                    { new Guid("ebe9170c-3b2c-41bd-942d-987302a70cdc"), "/images/Categories/boxing-shoes.png", false, "Shoes" },
                    { new Guid("edda8e65-6406-4e62-b269-b201272b7bfb"), "/images/Categories/shin-guards.png", false, "Shinguards" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "BrandId", "CategoryId", "Description", "IsDeleted", "MainImageUrl", "Name", "Price", "Sizes", "StockQuantity" },
                values: new object[,]
                {
                    { new Guid("30f37733-2eca-4d36-8cad-28796cc958d2"), new Guid("98ff6677-6673-491d-afd3-5a7905a75d84"), new Guid("0a25f5fe-20e8-40ab-b2ee-d363e74bc4f2"), "Comfortable shorts designed for kickboxing.", false, "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-1.png", "Century Martial Arts Kickboxing Shorts", 79.99m, "[2,3,4]", 75 },
                    { new Guid("4fab337b-8138-4324-86d2-df661c188f73"), new Guid("845996f3-0390-412e-8cb1-6c884c8cfbda"), new Guid("0a25f5fe-20e8-40ab-b2ee-d363e74bc4f2"), "Premium Muay Thai shorts with authentic design.", false, "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-1.png", "Fairtex Muay Thai Shorts", 84.99m, "[2,3,4]", 90 },
                    { new Guid("5d65d531-9910-47b1-bee3-22041de50f62"), new Guid("c7ba8a37-fb4d-4e90-8f97-b4bae566f1f7"), new Guid("6d966a9d-85f9-480c-83d8-438620d35196"), "Top-notch gloves with exceptional durability.", false, "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-1.png", "Hayabusa T3 Boxing Gloves", 189.99m, "[2,3,4]", 50 },
                    { new Guid("804937c5-2686-4613-a337-9abb8d047a8b"), new Guid("01ad82dd-7ceb-4cfa-9609-8c65b0c30c67"), new Guid("ebe9170c-3b2c-41bd-942d-987302a70cdc"), "Lightweight and supportive for agility in the ring.", false, "/images/Products/rdx-boxing-shoes/rdx-boxing-shoes-1.png", "RDX Pro Boxing Shoes", 109.99m, "[2,3,4]", 65 },
                    { new Guid("9cc28bce-6a0e-4b94-9529-4d538bdca47d"), new Guid("391afcb1-7081-4fb6-b9e6-dbc9a068c4ee"), new Guid("6d966a9d-85f9-480c-83d8-438620d35196"), "Lightweight and designed for all skill levels.", false, "/images/Products/venum-challenger-gloves/venum-challenger-gloves-2.png", "Venum Challenger Gloves", 89.99m, "[1,2,3]", 120 },
                    { new Guid("afa36881-e1ff-4ac6-aa8d-86c20b0f755d"), new Guid("bd361206-00f5-4603-b66b-439f7a084817"), new Guid("edda8e65-6406-4e62-b269-b201272b7bfb"), "High-quality shin guards for protection and mobility.", false, "/images/Products/sanabul-shin-guards/sanabul-shin-guards-1.png", "Sanabul Essential Shin Guards", 105.99m, "[2,3,4]", 90 },
                    { new Guid("bfb88375-9fc9-413a-b7e1-5360ba04b94e"), new Guid("854e474e-d67b-491f-92a4-a8d444876fdc"), new Guid("478ebbe4-7b27-4ee6-9956-6b3ad83a1145"), "Heavy-duty bag for all levels of training.", false, "/images/Products/ringside-punching-bag/ringside-punching-bag-1.png", "Ringside Punching Bag", 219.99m, "[3]", 40 },
                    { new Guid("c54e3937-11c8-4c47-a977-e6400a7b38e7"), new Guid("9e521fc9-d808-4328-81a8-4f3181ddb590"), new Guid("6d966a9d-85f9-480c-83d8-438620d35196"), "Durable leather gloves for heavy bag workouts.", false, "/images/Products/title-boxing-bag/title-boxing-bag-1.png", "Title Boxing Leather Bag Gloves", 79.99m, "[2,3]", 80 },
                    { new Guid("cc6cb2e7-af44-4ed2-9fd3-d6f50ed2a409"), new Guid("9e521fc9-d808-4328-81a8-4f3181ddb590"), new Guid("478ebbe4-7b27-4ee6-9956-6b3ad83a1145"), "Perfect for accuracy and reflex training.", false, "/images/Products/title-boxing-gloves/title-boxing-gloves-1.png", "Title Boxing Double End Bag", 99.99m, "[3]", 70 },
                    { new Guid("d790ab11-2e1c-4b13-83f8-b76b2ffce0b8"), new Guid("5bbafe85-7896-4328-babc-b6dc410dc05b"), new Guid("9be893e1-a8ee-4a77-8b0a-7aa41bd34bf8"), "Classic wraps for wrist and knuckle protection.", false, "/images/Products/everlast-hand-wraps/everlast-hand-wraps-3.png", "Everlast Hand Wraps", 9.99m, "[2,3]", 200 },
                    { new Guid("f3c44a97-14ec-401b-887c-100467cb8289"), new Guid("391afcb1-7081-4fb6-b9e6-dbc9a068c4ee"), new Guid("edda8e65-6406-4e62-b269-b201272b7bfb"), "High-durability shin guards ideal for intense training.", false, "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-1.png", "Venum Challenger Shin Guards", 105.99m, "[1,2,3]", 95 },
                    { new Guid("f7440893-cb6a-469e-af1f-747b04335776"), new Guid("5b01ec2f-60ed-40d9-b300-16f7157251ac"), new Guid("03b9c507-bf04-40e4-9bf1-6bd98bedc20a"), "Full-face protection with Twins quality.", false, "/images/Products/twins-special-headgear/twins-special-headgear-1.png", "Twins Special Headgear", 89.99m, "[1,2,3]", 60 },
                    { new Guid("fa2baf92-7643-43fd-998a-668a1c15bb4e"), new Guid("5bbafe85-7896-4328-babc-b6dc410dc05b"), new Guid("03b9c507-bf04-40e4-9bf1-6bd98bedc20a"), "Full-protection headgear with durable padding.", false, "/images/Products/everlast-pro-headgear/everlast-headgear-1.png", "Everlast Pro Headgear", 89.99m, "[2,3]", 50 },
                    { new Guid("fbd39678-90c1-4804-838f-ef9e5d7b3f4f"), new Guid("01ad82dd-7ceb-4cfa-9609-8c65b0c30c67"), new Guid("6d966a9d-85f9-480c-83d8-438620d35196"), "High-quality leather gloves for all training levels.", false, "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-3.png", "RDX Boxing Gloves", 109.99m, "[1,2,3]", 100 }
                });

            migrationBuilder.InsertData(
                table: "ProductsImages",
                columns: new[] { "ImageId", "ImageUrl", "ProductId" },
                values: new object[,]
                {
                    { new Guid("055164c3-121a-4838-a8d7-80a78fa23597"), "/images/Products/ringside-punching-bag/ringside-punching-bag-1.png", new Guid("bfb88375-9fc9-413a-b7e1-5360ba04b94e") },
                    { new Guid("084fd581-ba17-4e44-9c36-2c3595bab324"), "/images/Products/title-boxing-bag/title-boxing-bag-3.png", new Guid("c54e3937-11c8-4c47-a977-e6400a7b38e7") },
                    { new Guid("0a2b1460-1671-48c8-b50b-076dde72076a"), "/images/Products/title-boxing-bag/title-boxing-bag-2.png", new Guid("c54e3937-11c8-4c47-a977-e6400a7b38e7") },
                    { new Guid("0a73ce6f-7477-4dd7-91ef-fd6d5cc284bb"), "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-1.png", new Guid("5d65d531-9910-47b1-bee3-22041de50f62") },
                    { new Guid("0be64908-4990-402a-b1d9-700b56e372d6"), "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-2.png", new Guid("30f37733-2eca-4d36-8cad-28796cc958d2") },
                    { new Guid("1655019c-c5cd-4eb9-9681-b866c9d1f5cf"), "/images/Products/twins-special-headgear/twins-shin-headgear-3.png", new Guid("f7440893-cb6a-469e-af1f-747b04335776") },
                    { new Guid("1fded78d-7329-4658-981b-5af0d46da2b7"), "/images/Products/ringside-punching-bag/ringside-punching-bag-3.png", new Guid("bfb88375-9fc9-413a-b7e1-5360ba04b94e") },
                    { new Guid("2c8d39a5-ee5d-4c09-8050-6afe60f8a209"), "/images/Products/sanabul-shin-guards/sanabul-shin-guards-3.png", new Guid("afa36881-e1ff-4ac6-aa8d-86c20b0f755d") },
                    { new Guid("3c212e9d-55b7-4420-81ab-d6adcd9e915e"), "/images/Products/title-boxing-gloves/title-boxing-gloves-3.png", new Guid("cc6cb2e7-af44-4ed2-9fd3-d6f50ed2a409") },
                    { new Guid("41777fe8-efcc-4f93-9a75-c26b8b93ca2e"), "/images/Products/rdx-boxing-shoes/rdx-boxing-shoes-1.png", new Guid("804937c5-2686-4613-a337-9abb8d047a8b") },
                    { new Guid("45a328bf-8aca-49d2-9e90-8f87a3a2fb3f"), "/images/Products/rdx-boxing-shoes/rdx-boxing-shoes-2.png", new Guid("804937c5-2686-4613-a337-9abb8d047a8b") },
                    { new Guid("46dd9cca-86cd-40cf-9c86-38b9d35c159a"), "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-2.png", new Guid("fbd39678-90c1-4804-838f-ef9e5d7b3f4f") },
                    { new Guid("521fe64a-de06-44d7-9d2a-4f62d25044ca"), "/images/Products/everlasr-pro-headgear/everlast-headgear-2.png", new Guid("fa2baf92-7643-43fd-998a-668a1c15bb4e") },
                    { new Guid("5b855403-e9b8-4bbb-a6a1-34ea75968fa4"), "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-2.png", new Guid("5d65d531-9910-47b1-bee3-22041de50f62") },
                    { new Guid("5fce7b20-a928-4424-94d9-57216fef3982"), "/images/Products/everlasr-pro-headgear/everlast-headgear-3.png", new Guid("fa2baf92-7643-43fd-998a-668a1c15bb4e") },
                    { new Guid("609fa3d5-a451-40a4-9c2b-8405515cbad0"), "/images/Products/ringside-punching-bag/ringside-punching-bag-2.png", new Guid("bfb88375-9fc9-413a-b7e1-5360ba04b94e") },
                    { new Guid("614dc21a-7efc-4da1-9025-f31d7f6a316d"), "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-1.png", new Guid("30f37733-2eca-4d36-8cad-28796cc958d2") },
                    { new Guid("6435049a-1b40-4062-8939-73d80b060764"), "/images/Products/everlast-hand-wraps/everlast-hand-wraps-3.png", new Guid("d790ab11-2e1c-4b13-83f8-b76b2ffce0b8") },
                    { new Guid("6b27806f-2741-4a2f-9416-80a6d59746fb"), "/images/Products/sanabul-shin-guards/sanabul-shin-guards-2.png", new Guid("afa36881-e1ff-4ac6-aa8d-86c20b0f755d") },
                    { new Guid("717e640d-e5f6-423c-b3bd-4fd2111bfeab"), "/images/Products/venum-challenger-gloves/venum-challenger-gloves-2.png", new Guid("9cc28bce-6a0e-4b94-9529-4d538bdca47d") },
                    { new Guid("807b9ef7-46fc-4318-9d7a-8765f390704a"), "/images/Products/rdx-boxing-shoes/rdx-boxing-shoes-3.png", new Guid("804937c5-2686-4613-a337-9abb8d047a8b") },
                    { new Guid("8ea64e48-9c5e-4579-b7c0-aa8770f475de"), "/images/Products/title-boxing-gloves/title-boxing-gloves-1.png", new Guid("cc6cb2e7-af44-4ed2-9fd3-d6f50ed2a409") },
                    { new Guid("9080f116-fcec-4a83-8999-a8122eba92a7"), "/images/Products/sanabul-shin-guards/sanabul-shin-guards-1.png", new Guid("afa36881-e1ff-4ac6-aa8d-86c20b0f755d") },
                    { new Guid("93826ccf-ce6f-4f6f-83a2-694d1cce1f34"), "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-2.png", new Guid("4fab337b-8138-4324-86d2-df661c188f73") },
                    { new Guid("947f0a47-5c52-4483-b7e3-cd48c29814b8"), "/images/Products/title-boxing-gloves/title-boxing-gloves-2.png", new Guid("cc6cb2e7-af44-4ed2-9fd3-d6f50ed2a409") },
                    { new Guid("963b7ae1-687a-462a-bd02-ac59f2ed47af"), "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-3.png", new Guid("5d65d531-9910-47b1-bee3-22041de50f62") },
                    { new Guid("9e00d081-eb4e-444a-9575-b79afe7ecefb"), "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-3.png", new Guid("30f37733-2eca-4d36-8cad-28796cc958d2") },
                    { new Guid("b82e36bc-91d4-4f50-b64d-7169408df18d"), "/images/Products/venum-challenger-gloves/venum-challenger-gloves-1.png", new Guid("9cc28bce-6a0e-4b94-9529-4d538bdca47d") },
                    { new Guid("ba13d07e-6a63-47f5-a4bf-77536b8f1a6d"), "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-1.png", new Guid("f3c44a97-14ec-401b-887c-100467cb8289") },
                    { new Guid("bab15880-e7e9-4b79-927f-a6d5e374fd44"), "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-3.png", new Guid("fbd39678-90c1-4804-838f-ef9e5d7b3f4f") },
                    { new Guid("c14fd1e8-3c51-4510-80e1-d0fe2387726c"), "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-3.png", new Guid("f3c44a97-14ec-401b-887c-100467cb8289") },
                    { new Guid("d45b7ed7-5075-42ed-9630-e5dbb6ae8d1a"), "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-1.png", new Guid("fbd39678-90c1-4804-838f-ef9e5d7b3f4f") },
                    { new Guid("d4f99389-66d4-4b24-9bba-c4244f31fe5f"), "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-2.png", new Guid("f3c44a97-14ec-401b-887c-100467cb8289") },
                    { new Guid("dba5ccaf-d56c-4192-8dfa-438087a37529"), "/images/Products/everlasr-pro-headgear/everlast-headgear-1.png", new Guid("fa2baf92-7643-43fd-998a-668a1c15bb4e") },
                    { new Guid("dc8abe8a-d042-4839-9093-512fe35d8d00"), "/images/Products/everlast-hand-wraps/everlast-hand-wraps-1.png", new Guid("d790ab11-2e1c-4b13-83f8-b76b2ffce0b8") },
                    { new Guid("e3f28b29-3c92-4dcb-816b-d8cbe896aeac"), "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-3.png", new Guid("4fab337b-8138-4324-86d2-df661c188f73") },
                    { new Guid("e8f956bb-4244-480c-b318-5916b4bd5304"), "/images/Products/twins-special-headgear/twins-special-headgear-1.png", new Guid("f7440893-cb6a-469e-af1f-747b04335776") },
                    { new Guid("eac20acc-c419-4967-b719-97d9d47909be"), "/images/Products/everlast-hand-wraps/everlast-hand-wraps-2.png", new Guid("d790ab11-2e1c-4b13-83f8-b76b2ffce0b8") },
                    { new Guid("f3fe51a1-965c-44b7-9e1b-8cee228b4e5d"), "/images/Products/title-boxing-bag/title-boxing-bag-1.png", new Guid("c54e3937-11c8-4c47-a977-e6400a7b38e7") },
                    { new Guid("fba4d166-8b33-400e-bf87-37453afeae0a"), "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-1.png", new Guid("4fab337b-8138-4324-86d2-df661c188f73") },
                    { new Guid("fd1c331b-b534-4737-873e-7faf00ce6ce7"), "/images/Products/twins-special-headgear/twins-special-headgear-2.png", new Guid("f7440893-cb6a-469e-af1f-747b04335776") },
                    { new Guid("ffa4264c-542f-49f4-ba45-891ec805f7b4"), "/images/Products/venum-challenger-gloves/venum-challenger-gloves-3.png", new Guid("9cc28bce-6a0e-4b94-9529-4d538bdca47d") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("6c35710d-52a8-45af-b5d0-018072c20a36"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("7328b4bc-4edc-479c-9697-5b286d7ea4f4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("8d9a1146-5fee-4cb2-b223-56bf09ce5556"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("055164c3-121a-4838-a8d7-80a78fa23597"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("084fd581-ba17-4e44-9c36-2c3595bab324"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("0a2b1460-1671-48c8-b50b-076dde72076a"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("0a73ce6f-7477-4dd7-91ef-fd6d5cc284bb"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("0be64908-4990-402a-b1d9-700b56e372d6"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("1655019c-c5cd-4eb9-9681-b866c9d1f5cf"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("1fded78d-7329-4658-981b-5af0d46da2b7"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("2c8d39a5-ee5d-4c09-8050-6afe60f8a209"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("3c212e9d-55b7-4420-81ab-d6adcd9e915e"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("41777fe8-efcc-4f93-9a75-c26b8b93ca2e"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("45a328bf-8aca-49d2-9e90-8f87a3a2fb3f"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("46dd9cca-86cd-40cf-9c86-38b9d35c159a"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("521fe64a-de06-44d7-9d2a-4f62d25044ca"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("5b855403-e9b8-4bbb-a6a1-34ea75968fa4"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("5fce7b20-a928-4424-94d9-57216fef3982"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("609fa3d5-a451-40a4-9c2b-8405515cbad0"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("614dc21a-7efc-4da1-9025-f31d7f6a316d"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("6435049a-1b40-4062-8939-73d80b060764"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("6b27806f-2741-4a2f-9416-80a6d59746fb"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("717e640d-e5f6-423c-b3bd-4fd2111bfeab"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("807b9ef7-46fc-4318-9d7a-8765f390704a"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("8ea64e48-9c5e-4579-b7c0-aa8770f475de"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("9080f116-fcec-4a83-8999-a8122eba92a7"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("93826ccf-ce6f-4f6f-83a2-694d1cce1f34"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("947f0a47-5c52-4483-b7e3-cd48c29814b8"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("963b7ae1-687a-462a-bd02-ac59f2ed47af"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("9e00d081-eb4e-444a-9575-b79afe7ecefb"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("b82e36bc-91d4-4f50-b64d-7169408df18d"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("ba13d07e-6a63-47f5-a4bf-77536b8f1a6d"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("bab15880-e7e9-4b79-927f-a6d5e374fd44"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("c14fd1e8-3c51-4510-80e1-d0fe2387726c"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("d45b7ed7-5075-42ed-9630-e5dbb6ae8d1a"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("d4f99389-66d4-4b24-9bba-c4244f31fe5f"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("dba5ccaf-d56c-4192-8dfa-438087a37529"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("dc8abe8a-d042-4839-9093-512fe35d8d00"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("e3f28b29-3c92-4dcb-816b-d8cbe896aeac"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("e8f956bb-4244-480c-b318-5916b4bd5304"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("eac20acc-c419-4967-b719-97d9d47909be"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("f3fe51a1-965c-44b7-9e1b-8cee228b4e5d"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("fba4d166-8b33-400e-bf87-37453afeae0a"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("fd1c331b-b534-4737-873e-7faf00ce6ce7"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("ffa4264c-542f-49f4-ba45-891ec805f7b4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("30f37733-2eca-4d36-8cad-28796cc958d2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4fab337b-8138-4324-86d2-df661c188f73"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("5d65d531-9910-47b1-bee3-22041de50f62"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("804937c5-2686-4613-a337-9abb8d047a8b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("9cc28bce-6a0e-4b94-9529-4d538bdca47d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("afa36881-e1ff-4ac6-aa8d-86c20b0f755d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("bfb88375-9fc9-413a-b7e1-5360ba04b94e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c54e3937-11c8-4c47-a977-e6400a7b38e7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("cc6cb2e7-af44-4ed2-9fd3-d6f50ed2a409"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d790ab11-2e1c-4b13-83f8-b76b2ffce0b8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f3c44a97-14ec-401b-887c-100467cb8289"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f7440893-cb6a-469e-af1f-747b04335776"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("fa2baf92-7643-43fd-998a-668a1c15bb4e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("fbd39678-90c1-4804-838f-ef9e5d7b3f4f"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("01ad82dd-7ceb-4cfa-9609-8c65b0c30c67"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("391afcb1-7081-4fb6-b9e6-dbc9a068c4ee"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("5b01ec2f-60ed-40d9-b300-16f7157251ac"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("5bbafe85-7896-4328-babc-b6dc410dc05b"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("845996f3-0390-412e-8cb1-6c884c8cfbda"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("854e474e-d67b-491f-92a4-a8d444876fdc"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("98ff6677-6673-491d-afd3-5a7905a75d84"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("9e521fc9-d808-4328-81a8-4f3181ddb590"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("bd361206-00f5-4603-b66b-439f7a084817"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("c7ba8a37-fb4d-4e90-8f97-b4bae566f1f7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("03b9c507-bf04-40e4-9bf1-6bd98bedc20a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("0a25f5fe-20e8-40ab-b2ee-d363e74bc4f2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("478ebbe4-7b27-4ee6-9956-6b3ad83a1145"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("6d966a9d-85f9-480c-83d8-438620d35196"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("9be893e1-a8ee-4a77-8b0a-7aa41bd34bf8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ebe9170c-3b2c-41bd-942d-987302a70cdc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("edda8e65-6406-4e62-b269-b201272b7bfb"));

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
    }
}
