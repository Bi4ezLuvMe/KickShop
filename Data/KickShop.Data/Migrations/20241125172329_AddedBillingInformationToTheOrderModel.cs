using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KickShop.Migrations
{
    /// <inheritdoc />
    public partial class AddedBillingInformationToTheOrderModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "BillingAddress",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BillingCity",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BillingCountry",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BillingName",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BillingPostalCode",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandId", "Address", "Country", "ImageUrl", "IsDeleted", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("1114e770-ea18-4f88-8a14-322c113fb984"), "789 Kick Rd, Phuket, TH", "Thailand", "/images/Brands/twins-special-logo.png", false, "Twins Special", "567-890-1234" },
                    { new Guid("30dd4097-2bce-47c9-8f13-9f675dde8abf"), "456 Sports Ave, London, UK", "UK", "/images/Brands/rdx-logo.png", false, "RDX", "456-789-0123" },
                    { new Guid("4dc7da48-fb18-4f0e-bea0-3d1c6030dc8b"), "567 Martial Arts Blvd, Oklahoma City, OK", "USA", "/images/Brands/century-logo.png", false, "Century", "345-678-9012" },
                    { new Guid("4fcfaef5-c095-44a5-9f56-932c114014be"), "345 Punch Ln, Los Angeles, CA", "USA", "/images/Brands/title-boxing-logo.png", false, "Title Boxing", "987-654-3210" },
                    { new Guid("4fe75116-2fea-48be-9aaa-3ce2a8ffcb24"), "101 Martial Arts Way, Paris, FR", "France", "/images/Brands/venum-logo.png", false, "Venum", "321-654-0987" },
                    { new Guid("6ca5e2bc-15cf-4f19-8c50-a2beffa397e2"), "456 Ring Rd, Chicago, IL", "USA", "/images/Brands/ringside-logo.png", false, "Ringside", "234-567-8901" },
                    { new Guid("78323be2-1844-49a3-81ff-72760772364e"), "234 Fighter Rd, Bangkok, TH", "Thailand", "/images/Brands/fairtex-logo.png", false, "Fairtex", "876-543-2109" },
                    { new Guid("8483b067-dede-49a1-97de-e2b90dd0ba12"), "123 Boxing Blvd, New York, NY", "USA", "/images/Brands/everlast-logo.png", false, "Everlast", "123-456-7890" },
                    { new Guid("cf31837c-e28b-4141-81b7-223a54ccbb67"), "789 Fight St, Toronto, ON", "Canada", "/images/Brands/hayabusa-logo.png", false, "Hayabusa", "789-012-3456" },
                    { new Guid("f40d1fd5-8c84-4b00-b8a0-4f6f23afc6c2"), "678 Fighter Ave, Miami, FL", "USA", "/images/Brands/sanabul-logo.png", false, "Sanabul", "456-789-0123" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "ImageUrl", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { new Guid("07851cbd-6823-45f4-b345-fc24532ec6d4"), "/images/Categories/head-gear.png", false, "Headgear" },
                    { new Guid("0e4ad09e-f443-4278-978c-f75a00d52a42"), "/images/Categories/punching-bag.png", false, "Punching Bags" },
                    { new Guid("15c52185-9e6c-4022-85db-7e2b610c7869"), "/images/Categories/training-equipment.png", false, "Training Equipment" },
                    { new Guid("2b2b80bb-7597-49eb-b227-e9bcdaf8ca1f"), "/images/Categories/hand-wraps.png", false, "Hand Wraps" },
                    { new Guid("2d65314e-3420-4a73-bc68-9c0456c37bdd"), "/images/Categories/clothing.png", false, "Clothing" },
                    { new Guid("30633a20-c106-4e7d-8c64-be1c3ba8e6c5"), "/images/Categories/boxing-shoes.png", false, "Shoes" },
                    { new Guid("63aab44e-ea1e-4007-9b57-a39ed80f5438"), "/images/Categegories/boxing-gloves.jfif", false, "Gloves" },
                    { new Guid("a7211e22-b692-46de-82ba-8190a0572157"), "/images/Categories/mouth-guard.png", false, "Mouthguards" },
                    { new Guid("c3831f77-59ae-43d3-a9a1-c57ccee38e69"), "/images/Categories/shin-guards.png", false, "Shinguards" },
                    { new Guid("cf3b972d-6b0f-4baf-8f13-f82c0967550d"), "/images/Categories/protective-equipment.jfif", false, "Protective Gear" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "BrandId", "CategoryId", "Description", "IsDeleted", "MainImageUrl", "Name", "Price", "Sizes", "StockQuantity" },
                values: new object[,]
                {
                    { new Guid("184597a5-1379-4af8-818a-3ae135cc741d"), new Guid("4dc7da48-fb18-4f0e-bea0-3d1c6030dc8b"), new Guid("2d65314e-3420-4a73-bc68-9c0456c37bdd"), "Comfortable shorts designed for kickboxing.", false, "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-1.png", "Century Martial Arts Kickboxing Shorts", 79.99m, "[2,3,4]", 75 },
                    { new Guid("185caf1c-8f73-4e61-bc31-b3fbf403df39"), new Guid("6ca5e2bc-15cf-4f19-8c50-a2beffa397e2"), new Guid("0e4ad09e-f443-4278-978c-f75a00d52a42"), "Heavy-duty bag for all levels of training.", false, "/images/Products/ringside-punching-bag/ringside-punching-bag-1.png", "Ringside Punching Bag", 219.99m, "[3]", 40 },
                    { new Guid("1be197de-b4f6-4987-b25b-2fbce598fc98"), new Guid("1114e770-ea18-4f88-8a14-322c113fb984"), new Guid("07851cbd-6823-45f4-b345-fc24532ec6d4"), "Full-face protection with Twins quality.", false, "/images/Products/twins-special-headgear/twins-special-headgear-1.png", "Twins Special Headgear", 89.99m, "[1,2,3]", 60 },
                    { new Guid("25c1f6da-49ee-414c-92f0-ff0c6add833e"), new Guid("f40d1fd5-8c84-4b00-b8a0-4f6f23afc6c2"), new Guid("c3831f77-59ae-43d3-a9a1-c57ccee38e69"), "High-quality shin guards for protection and mobility.", false, "/images/Products/sanabul-shin-guards/sanabul-shin-guards-1.png", "Sanabul Essential Shin Guards", 105.99m, "[2,3,4]", 90 },
                    { new Guid("359c7d95-eaa3-4294-b86c-efe35fbfd498"), new Guid("4fe75116-2fea-48be-9aaa-3ce2a8ffcb24"), new Guid("63aab44e-ea1e-4007-9b57-a39ed80f5438"), "Lightweight and designed for all skill levels.", false, "/images/Products/venum-challenger-gloves/venum-challenger-gloves-2.png", "Venum Challenger Gloves", 89.99m, "[1,2,3]", 120 },
                    { new Guid("4b03da9e-fe39-456b-97c3-53b4d666ac32"), new Guid("8483b067-dede-49a1-97de-e2b90dd0ba12"), new Guid("2b2b80bb-7597-49eb-b227-e9bcdaf8ca1f"), "Classic wraps for wrist and knuckle protection.", false, "/images/Products/everlast-hand-wraps/everlast-hand-wraps-3.png", "Everlast Hand Wraps", 9.99m, "[2,3]", 200 },
                    { new Guid("6bae8099-873a-43db-af18-4a70514c37b1"), new Guid("78323be2-1844-49a3-81ff-72760772364e"), new Guid("2d65314e-3420-4a73-bc68-9c0456c37bdd"), "Premium Muay Thai shorts with authentic design.", false, "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-1.png", "Fairtex Muay Thai Shorts", 84.99m, "[2,3,4]", 90 },
                    { new Guid("767bf0c4-53cd-4f5c-9339-bc8bfdd4fa3c"), new Guid("4fcfaef5-c095-44a5-9f56-932c114014be"), new Guid("63aab44e-ea1e-4007-9b57-a39ed80f5438"), "Durable leather gloves for heavy bag workouts.", false, "/images/Products/title-boxing-bag/title-boxing-bag-1.png", "Title Boxing Leather Bag Gloves", 79.99m, "[2,3]", 80 },
                    { new Guid("9010c19e-27f5-47e8-8abe-29b3f5ddc65b"), new Guid("30dd4097-2bce-47c9-8f13-9f675dde8abf"), new Guid("63aab44e-ea1e-4007-9b57-a39ed80f5438"), "High-quality leather gloves for all training levels.", false, "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-3.png", "RDX Boxing Gloves", 109.99m, "[1,2,3]", 100 },
                    { new Guid("953d91c5-54b4-4719-a760-97a6996eeb6e"), new Guid("4fe75116-2fea-48be-9aaa-3ce2a8ffcb24"), new Guid("c3831f77-59ae-43d3-a9a1-c57ccee38e69"), "High-durability shin guards ideal for intense training.", false, "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-1.png", "Venum Challenger Shin Guards", 105.99m, "[1,2,3]", 95 },
                    { new Guid("b19de7d5-d11d-4528-b732-c448e1f3aa7b"), new Guid("30dd4097-2bce-47c9-8f13-9f675dde8abf"), new Guid("30633a20-c106-4e7d-8c64-be1c3ba8e6c5"), "Lightweight and supportive for agility in the ring.", false, "/images/Products/rdx-boxing-shoes/rdx-boxing-shoes-1.png", "RDX Pro Boxing Shoes", 109.99m, "[2,3,4]", 65 },
                    { new Guid("cfcc20d6-89c2-4205-9d79-8fd4f8b7f749"), new Guid("8483b067-dede-49a1-97de-e2b90dd0ba12"), new Guid("07851cbd-6823-45f4-b345-fc24532ec6d4"), "Full-protection headgear with durable padding.", false, "/images/Products/everlast-pro-headgear/everlast-headgear-1.png", "Everlast Pro Headgear", 89.99m, "[2,3]", 50 },
                    { new Guid("e9c348f5-f0f6-41a0-b1c7-8d9848245d64"), new Guid("4fcfaef5-c095-44a5-9f56-932c114014be"), new Guid("0e4ad09e-f443-4278-978c-f75a00d52a42"), "Perfect for accuracy and reflex training.", false, "/images/Products/title-boxing-gloves/title-boxing-gloves-1.png", "Title Boxing Double End Bag", 99.99m, "[3]", 70 },
                    { new Guid("f74669b7-6165-4ded-8547-9f548e66ca47"), new Guid("cf31837c-e28b-4141-81b7-223a54ccbb67"), new Guid("63aab44e-ea1e-4007-9b57-a39ed80f5438"), "Top-notch gloves with exceptional durability.", false, "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-1.png", "Hayabusa T3 Boxing Gloves", 189.99m, "[2,3,4]", 50 }
                });

            migrationBuilder.InsertData(
                table: "ProductsImages",
                columns: new[] { "ImageId", "ImageUrl", "ProductId" },
                values: new object[,]
                {
                    { new Guid("01311f77-62c9-440a-92e2-67208067a046"), "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-3.png", new Guid("9010c19e-27f5-47e8-8abe-29b3f5ddc65b") },
                    { new Guid("059a0f59-9724-41fa-8e41-e964a854c261"), "/images/Products/rdx-boxing-shoes/rdx-boxing-shoes-2.png", new Guid("b19de7d5-d11d-4528-b732-c448e1f3aa7b") },
                    { new Guid("0d5d5193-3c35-4af8-a307-52550c927f88"), "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-3.png", new Guid("184597a5-1379-4af8-818a-3ae135cc741d") },
                    { new Guid("0e9921de-9132-4c75-a431-3d323b0440f2"), "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-1.png", new Guid("953d91c5-54b4-4719-a760-97a6996eeb6e") },
                    { new Guid("1b3abc6f-71c0-49b4-9efe-62347e3f677e"), "/images/Products/ringside-punching-bag/ringside-punching-bag-3.png", new Guid("185caf1c-8f73-4e61-bc31-b3fbf403df39") },
                    { new Guid("1e59dea3-45ee-41dc-a7f8-35402b609f19"), "/images/Products/everlasr-pro-headgear/everlast-headgear-2.png", new Guid("cfcc20d6-89c2-4205-9d79-8fd4f8b7f749") },
                    { new Guid("1f0d828f-7bdc-4b65-b53c-203d79a860ba"), "/images/Products/title-boxing-gloves/title-boxing-gloves-2.png", new Guid("e9c348f5-f0f6-41a0-b1c7-8d9848245d64") },
                    { new Guid("326af1cf-f2c5-4c2b-8517-734ec8a57732"), "/images/Products/everlasr-pro-headgear/everlast-headgear-1.png", new Guid("cfcc20d6-89c2-4205-9d79-8fd4f8b7f749") },
                    { new Guid("333d5819-9407-4c93-85f8-4f12597a6ea1"), "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-3.png", new Guid("f74669b7-6165-4ded-8547-9f548e66ca47") },
                    { new Guid("396a23cf-2b7f-43ba-bdc6-26683e343eb3"), "/images/Products/everlast-hand-wraps/everlast-hand-wraps-2.png", new Guid("4b03da9e-fe39-456b-97c3-53b4d666ac32") },
                    { new Guid("40d63b5f-71b3-4678-9365-933fe1caa730"), "/images/Products/twins-special-headgear/twins-special-headgear-1.png", new Guid("1be197de-b4f6-4987-b25b-2fbce598fc98") },
                    { new Guid("4283684b-cc4d-4686-91b9-0894936baf7b"), "/images/Products/everlasr-pro-headgear/everlast-headgear-3.png", new Guid("cfcc20d6-89c2-4205-9d79-8fd4f8b7f749") },
                    { new Guid("443b8754-f2db-4fdb-a119-898f348f8d93"), "/images/Products/sanabul-shin-guards/sanabul-shin-guards-1.png", new Guid("25c1f6da-49ee-414c-92f0-ff0c6add833e") },
                    { new Guid("4a0715da-60b0-4818-be2e-3222839c7d0c"), "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-1.png", new Guid("f74669b7-6165-4ded-8547-9f548e66ca47") },
                    { new Guid("4ef0cef0-2f7a-4824-bffc-1aa40c980bbf"), "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-2.png", new Guid("953d91c5-54b4-4719-a760-97a6996eeb6e") },
                    { new Guid("541f3945-d736-4365-bcd7-2ffe78fe6cb4"), "/images/Products/title-boxing-gloves/title-boxing-gloves-3.png", new Guid("e9c348f5-f0f6-41a0-b1c7-8d9848245d64") },
                    { new Guid("542677f7-c3fd-473a-b9ff-6992dde706ed"), "/images/Products/title-boxing-bag/title-boxing-bag-2.png", new Guid("767bf0c4-53cd-4f5c-9339-bc8bfdd4fa3c") },
                    { new Guid("54d1efee-1428-48ee-9184-c6aceb38c3d3"), "/images/Products/rdx-boxing-shoes/rdx-boxing-shoes-3.png", new Guid("b19de7d5-d11d-4528-b732-c448e1f3aa7b") },
                    { new Guid("5dfc7c50-be6b-40ef-8403-b47f91993958"), "/images/Products/ringside-punching-bag/ringside-punching-bag-1.png", new Guid("185caf1c-8f73-4e61-bc31-b3fbf403df39") },
                    { new Guid("625f5121-c250-47c3-a7fb-ae451e2bf95a"), "/images/Products/twins-special-headgear/twins-shin-headgear-3.png", new Guid("1be197de-b4f6-4987-b25b-2fbce598fc98") },
                    { new Guid("76fc7e00-12f6-4aa9-bb02-5305cee4df33"), "/images/Products/twins-special-headgear/twins-special-headgear-2.png", new Guid("1be197de-b4f6-4987-b25b-2fbce598fc98") },
                    { new Guid("8693227e-09d8-49c9-93b4-aeb39877d12b"), "/images/Products/title-boxing-gloves/title-boxing-gloves-1.png", new Guid("e9c348f5-f0f6-41a0-b1c7-8d9848245d64") },
                    { new Guid("8acd1942-22ca-462c-9729-c28b866e2271"), "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-1.png", new Guid("6bae8099-873a-43db-af18-4a70514c37b1") },
                    { new Guid("92385138-8b70-41da-900d-e17a8e2279e0"), "/images/Products/sanabul-shin-guards/sanabul-shin-guards-2.png", new Guid("25c1f6da-49ee-414c-92f0-ff0c6add833e") },
                    { new Guid("978b3316-2a6b-4569-bd4e-591c45a86e37"), "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-2.png", new Guid("f74669b7-6165-4ded-8547-9f548e66ca47") },
                    { new Guid("9a04b5a8-7119-4f8b-8e6b-68481d57f82d"), "/images/Products/rdx-boxing-shoes/rdx-boxing-shoes-1.png", new Guid("b19de7d5-d11d-4528-b732-c448e1f3aa7b") },
                    { new Guid("a701a031-6c49-4de9-9534-51dc256e0df3"), "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-2.png", new Guid("9010c19e-27f5-47e8-8abe-29b3f5ddc65b") },
                    { new Guid("b04ad9ec-6be4-4763-a684-8f9cff1f6820"), "/images/Products/title-boxing-bag/title-boxing-bag-1.png", new Guid("767bf0c4-53cd-4f5c-9339-bc8bfdd4fa3c") },
                    { new Guid("bb6fd4f0-c7f9-4d87-892e-075aef562146"), "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-2.png", new Guid("6bae8099-873a-43db-af18-4a70514c37b1") },
                    { new Guid("c917ef03-2da1-4fa0-897f-3458ea987ae1"), "/images/Products/everlast-hand-wraps/everlast-hand-wraps-1.png", new Guid("4b03da9e-fe39-456b-97c3-53b4d666ac32") },
                    { new Guid("ca141667-782f-42a0-888f-122cc6533e8c"), "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-2.png", new Guid("184597a5-1379-4af8-818a-3ae135cc741d") },
                    { new Guid("d1a69d47-21a8-44b0-9c2e-69ab531b2c5f"), "/images/Products/title-boxing-bag/title-boxing-bag-3.png", new Guid("767bf0c4-53cd-4f5c-9339-bc8bfdd4fa3c") },
                    { new Guid("e07ef572-7f13-49d6-8d21-d346f7162a51"), "/images/Products/ringside-punching-bag/ringside-punching-bag-2.png", new Guid("185caf1c-8f73-4e61-bc31-b3fbf403df39") },
                    { new Guid("e54fa4f1-ff62-426a-aff2-5d5a10fd1dbb"), "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-1.png", new Guid("9010c19e-27f5-47e8-8abe-29b3f5ddc65b") },
                    { new Guid("e7014659-357f-4c81-9392-51920805aa64"), "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-3.png", new Guid("6bae8099-873a-43db-af18-4a70514c37b1") },
                    { new Guid("e99e6bb2-6771-4b94-8a80-1803a28680a4"), "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-1.png", new Guid("184597a5-1379-4af8-818a-3ae135cc741d") },
                    { new Guid("ef6dd1f9-18fd-4feb-a980-160c9c62f4d2"), "/images/Products/venum-challenger-gloves/venum-challenger-gloves-2.png", new Guid("359c7d95-eaa3-4294-b86c-efe35fbfd498") },
                    { new Guid("f1f948fe-3d62-4f49-9241-2b202f3b1756"), "/images/Products/venum-challenger-gloves/venum-challenger-gloves-3.png", new Guid("359c7d95-eaa3-4294-b86c-efe35fbfd498") },
                    { new Guid("f30ab5cf-8fd2-471f-951f-1d2465c8b568"), "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-3.png", new Guid("953d91c5-54b4-4719-a760-97a6996eeb6e") },
                    { new Guid("f3d418b1-dbf7-4c7e-80ef-4ce19015f4e4"), "/images/Products/sanabul-shin-guards/sanabul-shin-guards-3.png", new Guid("25c1f6da-49ee-414c-92f0-ff0c6add833e") },
                    { new Guid("f3e95b6e-1ef4-408d-b862-381cc6a73582"), "/images/Products/everlast-hand-wraps/everlast-hand-wraps-3.png", new Guid("4b03da9e-fe39-456b-97c3-53b4d666ac32") },
                    { new Guid("f4983766-bf34-47a6-a3d8-cf5dd5ff1d29"), "/images/Products/venum-challenger-gloves/venum-challenger-gloves-1.png", new Guid("359c7d95-eaa3-4294-b86c-efe35fbfd498") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("15c52185-9e6c-4022-85db-7e2b610c7869"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("a7211e22-b692-46de-82ba-8190a0572157"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("cf3b972d-6b0f-4baf-8f13-f82c0967550d"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("01311f77-62c9-440a-92e2-67208067a046"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("059a0f59-9724-41fa-8e41-e964a854c261"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("0d5d5193-3c35-4af8-a307-52550c927f88"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("0e9921de-9132-4c75-a431-3d323b0440f2"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("1b3abc6f-71c0-49b4-9efe-62347e3f677e"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("1e59dea3-45ee-41dc-a7f8-35402b609f19"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("1f0d828f-7bdc-4b65-b53c-203d79a860ba"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("326af1cf-f2c5-4c2b-8517-734ec8a57732"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("333d5819-9407-4c93-85f8-4f12597a6ea1"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("396a23cf-2b7f-43ba-bdc6-26683e343eb3"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("40d63b5f-71b3-4678-9365-933fe1caa730"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("4283684b-cc4d-4686-91b9-0894936baf7b"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("443b8754-f2db-4fdb-a119-898f348f8d93"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("4a0715da-60b0-4818-be2e-3222839c7d0c"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("4ef0cef0-2f7a-4824-bffc-1aa40c980bbf"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("541f3945-d736-4365-bcd7-2ffe78fe6cb4"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("542677f7-c3fd-473a-b9ff-6992dde706ed"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("54d1efee-1428-48ee-9184-c6aceb38c3d3"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("5dfc7c50-be6b-40ef-8403-b47f91993958"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("625f5121-c250-47c3-a7fb-ae451e2bf95a"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("76fc7e00-12f6-4aa9-bb02-5305cee4df33"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("8693227e-09d8-49c9-93b4-aeb39877d12b"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("8acd1942-22ca-462c-9729-c28b866e2271"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("92385138-8b70-41da-900d-e17a8e2279e0"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("978b3316-2a6b-4569-bd4e-591c45a86e37"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("9a04b5a8-7119-4f8b-8e6b-68481d57f82d"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("a701a031-6c49-4de9-9534-51dc256e0df3"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("b04ad9ec-6be4-4763-a684-8f9cff1f6820"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("bb6fd4f0-c7f9-4d87-892e-075aef562146"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("c917ef03-2da1-4fa0-897f-3458ea987ae1"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("ca141667-782f-42a0-888f-122cc6533e8c"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("d1a69d47-21a8-44b0-9c2e-69ab531b2c5f"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("e07ef572-7f13-49d6-8d21-d346f7162a51"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("e54fa4f1-ff62-426a-aff2-5d5a10fd1dbb"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("e7014659-357f-4c81-9392-51920805aa64"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("e99e6bb2-6771-4b94-8a80-1803a28680a4"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("ef6dd1f9-18fd-4feb-a980-160c9c62f4d2"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("f1f948fe-3d62-4f49-9241-2b202f3b1756"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("f30ab5cf-8fd2-471f-951f-1d2465c8b568"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("f3d418b1-dbf7-4c7e-80ef-4ce19015f4e4"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("f3e95b6e-1ef4-408d-b862-381cc6a73582"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("f4983766-bf34-47a6-a3d8-cf5dd5ff1d29"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("184597a5-1379-4af8-818a-3ae135cc741d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("185caf1c-8f73-4e61-bc31-b3fbf403df39"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1be197de-b4f6-4987-b25b-2fbce598fc98"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("25c1f6da-49ee-414c-92f0-ff0c6add833e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("359c7d95-eaa3-4294-b86c-efe35fbfd498"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4b03da9e-fe39-456b-97c3-53b4d666ac32"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6bae8099-873a-43db-af18-4a70514c37b1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("767bf0c4-53cd-4f5c-9339-bc8bfdd4fa3c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("9010c19e-27f5-47e8-8abe-29b3f5ddc65b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("953d91c5-54b4-4719-a760-97a6996eeb6e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b19de7d5-d11d-4528-b732-c448e1f3aa7b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("cfcc20d6-89c2-4205-9d79-8fd4f8b7f749"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e9c348f5-f0f6-41a0-b1c7-8d9848245d64"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f74669b7-6165-4ded-8547-9f548e66ca47"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("1114e770-ea18-4f88-8a14-322c113fb984"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("30dd4097-2bce-47c9-8f13-9f675dde8abf"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("4dc7da48-fb18-4f0e-bea0-3d1c6030dc8b"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("4fcfaef5-c095-44a5-9f56-932c114014be"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("4fe75116-2fea-48be-9aaa-3ce2a8ffcb24"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("6ca5e2bc-15cf-4f19-8c50-a2beffa397e2"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("78323be2-1844-49a3-81ff-72760772364e"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("8483b067-dede-49a1-97de-e2b90dd0ba12"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("cf31837c-e28b-4141-81b7-223a54ccbb67"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("f40d1fd5-8c84-4b00-b8a0-4f6f23afc6c2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("07851cbd-6823-45f4-b345-fc24532ec6d4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("0e4ad09e-f443-4278-978c-f75a00d52a42"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("2b2b80bb-7597-49eb-b227-e9bcdaf8ca1f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("2d65314e-3420-4a73-bc68-9c0456c37bdd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("30633a20-c106-4e7d-8c64-be1c3ba8e6c5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("63aab44e-ea1e-4007-9b57-a39ed80f5438"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("c3831f77-59ae-43d3-a9a1-c57ccee38e69"));

            migrationBuilder.DropColumn(
                name: "BillingAddress",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "BillingCity",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "BillingCountry",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "BillingName",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "BillingPostalCode",
                table: "Orders");

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
    }
}
