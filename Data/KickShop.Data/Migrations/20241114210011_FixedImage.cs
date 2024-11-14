using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KickShop.Migrations
{
    /// <inheritdoc />
    public partial class FixedImage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
