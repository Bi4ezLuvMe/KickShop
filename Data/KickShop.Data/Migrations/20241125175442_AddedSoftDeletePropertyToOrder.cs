using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KickShop.Migrations
{
    /// <inheritdoc />
    public partial class AddedSoftDeletePropertyToOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("2f736787-4467-4d17-9e3a-bb1490ee7f5d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("3f9c9cf5-b4c0-4045-b0e1-3311fbc4b23f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("d7a4a46c-5b3e-4ff8-848b-54094d7a2ee7"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("03d4cb7a-9c55-4e35-99bd-fbe2a4933f67"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("07863c4f-d2f9-4a6c-92da-d8167f1f23dd"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("07e67631-c914-4c6d-99bc-6f9f0c53a6c1"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("175caa7b-cb13-4088-835d-cc1047d50b3c"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("1eb982c2-0003-4564-9e8e-0331b2ec2141"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("214f7ab1-365d-4493-bc49-fb4c1e224116"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("23bb28f5-77bd-4a10-8885-612983a453e5"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("253f38ec-72c0-42a3-97a5-2b68b40f33cd"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("274a3573-4cc3-4c25-a3cd-d1208d00f999"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("28526d47-118b-49ae-8669-9a8445112526"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("29113fc5-119a-418b-b222-dbf6e1b5ecba"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("302f1dcd-9088-422c-a6ea-5c409ec42ae3"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("3094514e-8d92-4f15-bef2-aac5505449ec"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("3692639a-b49f-43fc-9f5c-4ef05ead6d2f"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("38027a90-2ab1-4fd7-8a62-f7b114ed7352"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("406d50a1-5640-4f0e-83a9-978703beae24"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("45e27749-9a74-490c-b778-caa9c3936a41"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("57cd91eb-a414-43c9-8d12-debfd1dbb29d"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("61212ebf-20fa-4a3a-b48a-7d31b264fa40"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("6c1c02a0-2da6-48ae-839e-21a74e53fe46"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("830ec297-ca79-49fe-8e59-4c06bcd69d89"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("840a5970-aa12-4cdb-9c6d-7f5a5665ff84"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("85fa2087-7b82-41be-9b06-8509751ca042"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("8a2ed08c-f4ac-4d8a-aaae-43a26345f003"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("8af0069f-0975-4aed-acbc-ada4aea197b7"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("91beb3bb-1fd3-408a-a6a2-036cdfa09872"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("934cfd85-1722-49fb-b1cc-b0299b428d04"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("9af5e311-6ba8-4f16-9f14-00f7b1f4680e"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("acd78b1a-4034-4cc0-a23f-76ff3c9752d1"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("b1f38df7-41cc-46c5-8c39-52028c81e4ae"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("b3304c1d-bc14-4fd2-a916-24458b31fb1e"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("b414f226-e2c5-4a4c-ae7b-cd2e159499a8"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("b6377182-d60e-40c1-9713-34bbbe5d5c22"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("c426e664-2138-4e45-859e-635f98f79c9e"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("ccd56e84-2756-40e7-b2c5-9de6a922a44f"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("d1ef0617-8090-4899-9a01-a3221e89da78"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("db071a02-6d67-4ebf-acbc-e162fb9acabc"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("dd9423ea-0b1c-4c2c-8fb4-f8548d049f44"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("de48f1b6-7501-4e17-a6df-5467dfdfe13b"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("e36c6c52-e742-410b-a23f-3233cdbeefa6"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("faae7f28-1118-401a-9ac7-c5fbc1fdbe38"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("fbb0fd62-0f0f-415d-9811-0e5a6fe74a1a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("05fdb469-3891-4f31-8fb2-f531c8509133"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("184fb352-6c6e-4757-b60b-7478e5759508"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1edcc73b-e2fe-4ba8-a3e7-6795d0f00b03"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("254fecf8-1739-444c-afb6-af4a29a262f0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("47ab64e1-fd21-435e-b4e4-aa54947a2005"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("77101c8e-a057-4f16-b53d-b558822e12ec"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("79868aab-bc98-4628-8443-509173147add"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("7b2bc133-a5e6-43e3-9886-b1b34625e680"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("8539ecb7-9af5-4bbe-a8d4-a05f517f1a21"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("9e2577a1-34d4-4255-8a3a-9736db4f1d0a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a1ca1686-b1d2-4db0-b42f-84c51f07d938"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a767dd5b-b242-43ac-a857-c0a971b27ace"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e2fb6902-f7fe-47cc-bbae-7886a7c89360"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e92b007b-5106-42c3-9234-11cf251a7747"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("066f6c6a-94b4-4792-b8cd-c816d5c5a46a"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("29ab1e43-6441-47c7-9c76-d4e5595258f2"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("40e1aa4a-3254-4529-9b06-56bde4c33c16"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("72207e09-81e8-4487-a561-26c98c982797"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("8203ff8f-7887-4f6d-b572-95e345cab201"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("a2250aa6-f7b2-4fb0-a061-7e4b119a270d"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("dd49b911-bb46-4a24-9e1e-452b60f6ee87"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("f3b98572-dccf-4c3e-a8af-6f111c6f25ca"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("f55049ce-5ade-4bc6-ada6-f80d1259ef01"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("fb49864a-2034-465c-8475-3293a4e50287"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("1abab5e2-ecf3-4adf-bba0-89a7ca8208fa"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("3f596856-d7c9-4093-a17d-570fb1384d39"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("4aad9df9-28c6-46a8-98f1-c4f6cc1bc270"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("97eb9081-8c18-48c9-8de6-a44bf32fb805"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("c47178b2-6495-4721-aa09-1c726ac2d643"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("e2040311-9676-47de-b141-bc53cf23a86a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ef0fcbba-94d3-436f-bc5d-6b6ca28e6fc9"));

            migrationBuilder.AlterColumn<string>(
                name: "BillingPostalCode",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                comment: "The Billing PostCode Of The Order",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "BillingName",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                comment: "The Billing Name Of The Order",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "BillingCity",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                comment: "The Billing City Of The Order",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "BillingAddress",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                comment: "The Billing Address Of The Order",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Orders",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "Soft Delete Property");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "CustomersOrders",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "Soft Delete Property");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandId", "Address", "Country", "ImageUrl", "IsDeleted", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("07cf0ee3-6555-4e9a-b366-eaa5de6d9f46"), "345 Punch Ln, Los Angeles, CA", "USA", "/images/Brands/title-boxing-logo.png", false, "Title Boxing", "987-654-3210" },
                    { new Guid("110287f3-443a-41c9-bc39-756fd90a34d4"), "101 Martial Arts Way, Paris, FR", "France", "/images/Brands/venum-logo.png", false, "Venum", "321-654-0987" },
                    { new Guid("1a81d4f2-921b-4822-8379-4394b77fd2e5"), "678 Fighter Ave, Miami, FL", "USA", "/images/Brands/sanabul-logo.png", false, "Sanabul", "456-789-0123" },
                    { new Guid("68a907c7-3c05-4b72-bd8b-dc500742c001"), "789 Kick Rd, Phuket, TH", "Thailand", "/images/Brands/twins-special-logo.png", false, "Twins Special", "567-890-1234" },
                    { new Guid("7d529bb0-e558-4947-8fd2-3b6472f84dd7"), "234 Fighter Rd, Bangkok, TH", "Thailand", "/images/Brands/fairtex-logo.png", false, "Fairtex", "876-543-2109" },
                    { new Guid("87dbf881-2c8d-4654-a3fa-f8d030f31d45"), "123 Boxing Blvd, New York, NY", "USA", "/images/Brands/everlast-logo.png", false, "Everlast", "123-456-7890" },
                    { new Guid("c81bae19-8a4b-4d52-8b5d-1160ebf41adf"), "567 Martial Arts Blvd, Oklahoma City, OK", "USA", "/images/Brands/century-logo.png", false, "Century", "345-678-9012" },
                    { new Guid("c8396007-04a1-4ca3-8cd0-6c5c910f2375"), "789 Fight St, Toronto, ON", "Canada", "/images/Brands/hayabusa-logo.png", false, "Hayabusa", "789-012-3456" },
                    { new Guid("ed861016-1e1c-48a4-ad51-1c7a8674eff9"), "456 Ring Rd, Chicago, IL", "USA", "/images/Brands/ringside-logo.png", false, "Ringside", "234-567-8901" },
                    { new Guid("f18554fb-6fae-4a2f-8f7b-916aef7d2fc7"), "456 Sports Ave, London, UK", "UK", "/images/Brands/rdx-logo.png", false, "RDX", "456-789-0123" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "ImageUrl", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { new Guid("0c2cec2f-adad-42c8-a3b0-f91bf46e7f0f"), "/images/Categories/training-equipment.png", false, "Training Equipment" },
                    { new Guid("1c2e748e-6c81-46ac-9f53-7f636dfcda7d"), "/images/Categories/protective-equipment.jfif", false, "Protective Gear" },
                    { new Guid("235c5d7d-1ba6-4751-a3d7-b0ae27de0f8f"), "/images/Categories/shin-guards.png", false, "Shinguards" },
                    { new Guid("25e75a5f-fcd7-40ab-b6f7-b65cfa620b04"), "/images/Categories/head-gear.png", false, "Headgear" },
                    { new Guid("654c0f7e-3583-407a-9cd1-90f1478c2ca0"), "/images/Categories/punching-bag.png", false, "Punching Bags" },
                    { new Guid("b25ddb17-a18b-4531-8cf3-2d27af224e4a"), "/images/Categegories/boxing-gloves.jfif", false, "Gloves" },
                    { new Guid("c0d36680-5696-4f2e-94e4-45099a12fe39"), "/images/Categories/boxing-shoes.png", false, "Shoes" },
                    { new Guid("d2124e41-b311-4e56-a6d7-d32f67b3368c"), "/images/Categories/clothing.png", false, "Clothing" },
                    { new Guid("e2f2567e-cb5e-4faf-a931-9371f568f395"), "/images/Categories/hand-wraps.png", false, "Hand Wraps" },
                    { new Guid("fa8f4dcb-f4b6-484c-bdee-64eed73f6acf"), "/images/Categories/mouth-guard.png", false, "Mouthguards" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "BrandId", "CategoryId", "Description", "IsDeleted", "MainImageUrl", "Name", "Price", "Sizes", "StockQuantity" },
                values: new object[,]
                {
                    { new Guid("33e60ab1-75f5-422a-a6b5-6a9461057834"), new Guid("f18554fb-6fae-4a2f-8f7b-916aef7d2fc7"), new Guid("c0d36680-5696-4f2e-94e4-45099a12fe39"), "Lightweight and supportive for agility in the ring.", false, "/images/Products/rdx-boxing-shoes/rdx-boxing-shoes-1.png", "RDX Pro Boxing Shoes", 109.99m, "[2,3,4]", 65 },
                    { new Guid("3905538a-060d-42f1-90e7-d6f4f6ea8023"), new Guid("87dbf881-2c8d-4654-a3fa-f8d030f31d45"), new Guid("25e75a5f-fcd7-40ab-b6f7-b65cfa620b04"), "Full-protection headgear with durable padding.", false, "/images/Products/everlast-pro-headgear/everlast-headgear-1.png", "Everlast Pro Headgear", 89.99m, "[2,3]", 50 },
                    { new Guid("40eae73d-3f82-4ad1-8af3-a77fab3c5982"), new Guid("7d529bb0-e558-4947-8fd2-3b6472f84dd7"), new Guid("d2124e41-b311-4e56-a6d7-d32f67b3368c"), "Premium Muay Thai shorts with authentic design.", false, "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-1.png", "Fairtex Muay Thai Shorts", 84.99m, "[2,3,4]", 90 },
                    { new Guid("60c9bcda-5bd2-420b-86b3-d0294c4e241e"), new Guid("1a81d4f2-921b-4822-8379-4394b77fd2e5"), new Guid("235c5d7d-1ba6-4751-a3d7-b0ae27de0f8f"), "High-quality shin guards for protection and mobility.", false, "/images/Products/sanabul-shin-guards/sanabul-shin-guards-1.png", "Sanabul Essential Shin Guards", 105.99m, "[2,3,4]", 90 },
                    { new Guid("660ab8ef-62a5-49f9-b78f-8e5129b1ad6d"), new Guid("07cf0ee3-6555-4e9a-b366-eaa5de6d9f46"), new Guid("654c0f7e-3583-407a-9cd1-90f1478c2ca0"), "Perfect for accuracy and reflex training.", false, "/images/Products/title-boxing-gloves/title-boxing-gloves-1.png", "Title Boxing Double End Bag", 99.99m, "[3]", 70 },
                    { new Guid("894613c6-97f7-4a7a-ad74-74ae66a3f84d"), new Guid("68a907c7-3c05-4b72-bd8b-dc500742c001"), new Guid("25e75a5f-fcd7-40ab-b6f7-b65cfa620b04"), "Full-face protection with Twins quality.", false, "/images/Products/twins-special-headgear/twins-special-headgear-1.png", "Twins Special Headgear", 89.99m, "[1,2,3]", 60 },
                    { new Guid("8c5c53e0-5632-4201-8ed2-a348638dafa7"), new Guid("ed861016-1e1c-48a4-ad51-1c7a8674eff9"), new Guid("654c0f7e-3583-407a-9cd1-90f1478c2ca0"), "Heavy-duty bag for all levels of training.", false, "/images/Products/ringside-punching-bag/ringside-punching-bag-1.png", "Ringside Punching Bag", 219.99m, "[3]", 40 },
                    { new Guid("a0072c0f-2c8c-4782-958a-1d00703fe406"), new Guid("110287f3-443a-41c9-bc39-756fd90a34d4"), new Guid("b25ddb17-a18b-4531-8cf3-2d27af224e4a"), "Lightweight and designed for all skill levels.", false, "/images/Products/venum-challenger-gloves/venum-challenger-gloves-2.png", "Venum Challenger Gloves", 89.99m, "[1,2,3]", 120 },
                    { new Guid("a237f3fc-03fd-41a9-9e4e-d92fc0427c5e"), new Guid("f18554fb-6fae-4a2f-8f7b-916aef7d2fc7"), new Guid("b25ddb17-a18b-4531-8cf3-2d27af224e4a"), "High-quality leather gloves for all training levels.", false, "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-3.png", "RDX Boxing Gloves", 109.99m, "[1,2,3]", 100 },
                    { new Guid("a83d310d-9c10-4f51-a130-a8d9178e7df6"), new Guid("87dbf881-2c8d-4654-a3fa-f8d030f31d45"), new Guid("e2f2567e-cb5e-4faf-a931-9371f568f395"), "Classic wraps for wrist and knuckle protection.", false, "/images/Products/everlast-hand-wraps/everlast-hand-wraps-3.png", "Everlast Hand Wraps", 9.99m, "[2,3]", 200 },
                    { new Guid("b0a1b119-967d-4e0f-8383-363e4e4095b4"), new Guid("110287f3-443a-41c9-bc39-756fd90a34d4"), new Guid("235c5d7d-1ba6-4751-a3d7-b0ae27de0f8f"), "High-durability shin guards ideal for intense training.", false, "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-1.png", "Venum Challenger Shin Guards", 105.99m, "[1,2,3]", 95 },
                    { new Guid("b8f29bd2-363a-4f64-84c6-e272e838d00e"), new Guid("c8396007-04a1-4ca3-8cd0-6c5c910f2375"), new Guid("b25ddb17-a18b-4531-8cf3-2d27af224e4a"), "Top-notch gloves with exceptional durability.", false, "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-1.png", "Hayabusa T3 Boxing Gloves", 189.99m, "[2,3,4]", 50 },
                    { new Guid("dcddba1b-acc2-4089-b25e-227f99f47c6f"), new Guid("c81bae19-8a4b-4d52-8b5d-1160ebf41adf"), new Guid("d2124e41-b311-4e56-a6d7-d32f67b3368c"), "Comfortable shorts designed for kickboxing.", false, "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-1.png", "Century Martial Arts Kickboxing Shorts", 79.99m, "[2,3,4]", 75 },
                    { new Guid("fd2bd1a9-b7ee-41df-b9ff-6ce44bbf2521"), new Guid("07cf0ee3-6555-4e9a-b366-eaa5de6d9f46"), new Guid("b25ddb17-a18b-4531-8cf3-2d27af224e4a"), "Durable leather gloves for heavy bag workouts.", false, "/images/Products/title-boxing-bag/title-boxing-bag-1.png", "Title Boxing Leather Bag Gloves", 79.99m, "[2,3]", 80 }
                });

            migrationBuilder.InsertData(
                table: "ProductsImages",
                columns: new[] { "ImageId", "ImageUrl", "ProductId" },
                values: new object[,]
                {
                    { new Guid("04845ee6-3827-47bf-bbe9-83dcc36bf037"), "/images/Products/venum-challenger-gloves/venum-challenger-gloves-3.png", new Guid("a0072c0f-2c8c-4782-958a-1d00703fe406") },
                    { new Guid("06969107-a194-4a22-948a-970e852d7a97"), "/images/Products/everlasr-pro-headgear/everlast-headgear-2.png", new Guid("3905538a-060d-42f1-90e7-d6f4f6ea8023") },
                    { new Guid("0c6f8b87-66bd-4746-81a3-b38f14e7dbb8"), "/images/Products/twins-special-headgear/twins-shin-headgear-3.png", new Guid("894613c6-97f7-4a7a-ad74-74ae66a3f84d") },
                    { new Guid("0ea7014c-97f6-4a19-8b08-f9b059fa3985"), "/images/Products/twins-special-headgear/twins-special-headgear-1.png", new Guid("894613c6-97f7-4a7a-ad74-74ae66a3f84d") },
                    { new Guid("16600136-a5eb-468d-b127-579100467411"), "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-3.png", new Guid("a237f3fc-03fd-41a9-9e4e-d92fc0427c5e") },
                    { new Guid("187a5c29-14b4-4123-a631-aa68d1b805f6"), "/images/Products/twins-special-headgear/twins-special-headgear-2.png", new Guid("894613c6-97f7-4a7a-ad74-74ae66a3f84d") },
                    { new Guid("1ea8d3fb-ffd8-4b63-aa83-5de902a52cec"), "/images/Products/venum-challenger-gloves/venum-challenger-gloves-1.png", new Guid("a0072c0f-2c8c-4782-958a-1d00703fe406") },
                    { new Guid("2d91a990-e13c-4ff9-8c2b-59f1e1e2f9c4"), "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-1.png", new Guid("b0a1b119-967d-4e0f-8383-363e4e4095b4") },
                    { new Guid("32ee6e7c-18a6-4a4f-8479-4e91ed00a43c"), "/images/Products/everlasr-pro-headgear/everlast-headgear-1.png", new Guid("3905538a-060d-42f1-90e7-d6f4f6ea8023") },
                    { new Guid("39afc354-148f-4321-bf83-04b24cfddc09"), "/images/Products/sanabul-shin-guards/sanabul-shin-guards-3.png", new Guid("60c9bcda-5bd2-420b-86b3-d0294c4e241e") },
                    { new Guid("4a559fbb-9f2e-425a-b414-9643047ea641"), "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-1.png", new Guid("dcddba1b-acc2-4089-b25e-227f99f47c6f") },
                    { new Guid("4d798757-37a1-4c0f-b8b6-4470737e8a04"), "/images/Products/title-boxing-gloves/title-boxing-gloves-3.png", new Guid("660ab8ef-62a5-49f9-b78f-8e5129b1ad6d") },
                    { new Guid("4e5a5d86-c32f-4c43-9ff4-60f750c56445"), "/images/Products/sanabul-shin-guards/sanabul-shin-guards-1.png", new Guid("60c9bcda-5bd2-420b-86b3-d0294c4e241e") },
                    { new Guid("507f2f7d-a376-4ae2-a25a-1c418e776ab6"), "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-3.png", new Guid("b8f29bd2-363a-4f64-84c6-e272e838d00e") },
                    { new Guid("6c68e807-0cd8-4c65-ae59-ac9d5032a9dd"), "/images/Products/ringside-punching-bag/ringside-punching-bag-1.png", new Guid("8c5c53e0-5632-4201-8ed2-a348638dafa7") },
                    { new Guid("8810cac7-485e-4ebc-92d9-f97b8a8063f3"), "/images/Products/sanabul-shin-guards/sanabul-shin-guards-2.png", new Guid("60c9bcda-5bd2-420b-86b3-d0294c4e241e") },
                    { new Guid("8e64fa31-bcc1-404f-bfc6-454ae196374b"), "/images/Products/everlast-hand-wraps/everlast-hand-wraps-2.png", new Guid("a83d310d-9c10-4f51-a130-a8d9178e7df6") },
                    { new Guid("90171adc-e7a9-4680-80ac-91a7026e4444"), "/images/Products/everlast-hand-wraps/everlast-hand-wraps-1.png", new Guid("a83d310d-9c10-4f51-a130-a8d9178e7df6") },
                    { new Guid("96289231-200c-4ed0-8953-8bf9d5c17cfd"), "/images/Products/title-boxing-bag/title-boxing-bag-3.png", new Guid("fd2bd1a9-b7ee-41df-b9ff-6ce44bbf2521") },
                    { new Guid("9ce0ab17-7567-43f6-a709-29089f85e1d1"), "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-3.png", new Guid("40eae73d-3f82-4ad1-8af3-a77fab3c5982") },
                    { new Guid("a7273c9b-dc7b-4404-8dae-ad44d71b5f8c"), "/images/Products/title-boxing-gloves/title-boxing-gloves-1.png", new Guid("660ab8ef-62a5-49f9-b78f-8e5129b1ad6d") },
                    { new Guid("ac0cc2f3-3509-4b2f-b666-a7b81c918a63"), "/images/Products/venum-challenger-gloves/venum-challenger-gloves-2.png", new Guid("a0072c0f-2c8c-4782-958a-1d00703fe406") },
                    { new Guid("b072a725-6f80-4514-9a1d-4d5842b7f2a8"), "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-1.png", new Guid("a237f3fc-03fd-41a9-9e4e-d92fc0427c5e") },
                    { new Guid("be9adf42-4a3d-4203-979c-27306a0eb6aa"), "/images/Products/title-boxing-bag/title-boxing-bag-2.png", new Guid("fd2bd1a9-b7ee-41df-b9ff-6ce44bbf2521") },
                    { new Guid("bf1a372a-e448-46df-ac1d-6e13cef0cc0a"), "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-2.png", new Guid("dcddba1b-acc2-4089-b25e-227f99f47c6f") },
                    { new Guid("c1f133ec-eab1-4c85-a12c-d745a2a2d55b"), "/images/Products/ringside-punching-bag/ringside-punching-bag-3.png", new Guid("8c5c53e0-5632-4201-8ed2-a348638dafa7") },
                    { new Guid("c503490d-c9b8-4d63-894d-f2142d08b344"), "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-2.png", new Guid("b8f29bd2-363a-4f64-84c6-e272e838d00e") },
                    { new Guid("c69a17a7-6bcf-4ede-9008-891f4ff98f4a"), "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-1.png", new Guid("40eae73d-3f82-4ad1-8af3-a77fab3c5982") },
                    { new Guid("c7b2aabf-a963-4474-abeb-d3bcca2459f2"), "/images/Products/ringside-punching-bag/ringside-punching-bag-2.png", new Guid("8c5c53e0-5632-4201-8ed2-a348638dafa7") },
                    { new Guid("c9bb1b09-02bb-4df5-9b70-03deac93e1ab"), "/images/Products/title-boxing-gloves/title-boxing-gloves-2.png", new Guid("660ab8ef-62a5-49f9-b78f-8e5129b1ad6d") },
                    { new Guid("ca5be104-a244-4824-b278-45fcbd14ca5a"), "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-3.png", new Guid("dcddba1b-acc2-4089-b25e-227f99f47c6f") },
                    { new Guid("ca80141b-bcfa-424b-a876-18a3f58fce82"), "/images/Products/rdx-boxing-shoes/rdx-boxing-shoes-2.png", new Guid("33e60ab1-75f5-422a-a6b5-6a9461057834") },
                    { new Guid("cbdd51df-869c-4e69-8b96-0d99298d543e"), "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-2.png", new Guid("a237f3fc-03fd-41a9-9e4e-d92fc0427c5e") },
                    { new Guid("d37e9a21-27e5-47d3-b4f5-4b3706b89268"), "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-3.png", new Guid("b0a1b119-967d-4e0f-8383-363e4e4095b4") },
                    { new Guid("d882715d-b3a2-453a-a89e-5f43572cdde8"), "/images/Products/title-boxing-bag/title-boxing-bag-1.png", new Guid("fd2bd1a9-b7ee-41df-b9ff-6ce44bbf2521") },
                    { new Guid("db2ba12a-1896-48a4-b74a-9e122c394bd9"), "/images/Products/everlasr-pro-headgear/everlast-headgear-3.png", new Guid("3905538a-060d-42f1-90e7-d6f4f6ea8023") },
                    { new Guid("e12c615e-431d-4ffa-99bd-88f748662cd6"), "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-1.png", new Guid("b8f29bd2-363a-4f64-84c6-e272e838d00e") },
                    { new Guid("e65a4c07-6aa3-4d16-aadf-ae563d83071d"), "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-2.png", new Guid("b0a1b119-967d-4e0f-8383-363e4e4095b4") },
                    { new Guid("e6b42b87-624f-4ea3-b50c-e82eabf6b6d1"), "/images/Products/everlast-hand-wraps/everlast-hand-wraps-3.png", new Guid("a83d310d-9c10-4f51-a130-a8d9178e7df6") },
                    { new Guid("ee97fd1c-f166-47ed-9227-e289fcf7415c"), "/images/Products/rdx-boxing-shoes/rdx-boxing-shoes-3.png", new Guid("33e60ab1-75f5-422a-a6b5-6a9461057834") },
                    { new Guid("f9ad83e7-9445-4d43-b906-b9ddf1afcef0"), "/images/Products/rdx-boxing-shoes/rdx-boxing-shoes-1.png", new Guid("33e60ab1-75f5-422a-a6b5-6a9461057834") },
                    { new Guid("fc45e725-7838-4032-9882-8df1212ac486"), "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-2.png", new Guid("40eae73d-3f82-4ad1-8af3-a77fab3c5982") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("0c2cec2f-adad-42c8-a3b0-f91bf46e7f0f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("1c2e748e-6c81-46ac-9f53-7f636dfcda7d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("fa8f4dcb-f4b6-484c-bdee-64eed73f6acf"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("04845ee6-3827-47bf-bbe9-83dcc36bf037"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("06969107-a194-4a22-948a-970e852d7a97"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("0c6f8b87-66bd-4746-81a3-b38f14e7dbb8"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("0ea7014c-97f6-4a19-8b08-f9b059fa3985"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("16600136-a5eb-468d-b127-579100467411"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("187a5c29-14b4-4123-a631-aa68d1b805f6"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("1ea8d3fb-ffd8-4b63-aa83-5de902a52cec"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("2d91a990-e13c-4ff9-8c2b-59f1e1e2f9c4"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("32ee6e7c-18a6-4a4f-8479-4e91ed00a43c"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("39afc354-148f-4321-bf83-04b24cfddc09"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("4a559fbb-9f2e-425a-b414-9643047ea641"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("4d798757-37a1-4c0f-b8b6-4470737e8a04"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("4e5a5d86-c32f-4c43-9ff4-60f750c56445"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("507f2f7d-a376-4ae2-a25a-1c418e776ab6"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("6c68e807-0cd8-4c65-ae59-ac9d5032a9dd"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("8810cac7-485e-4ebc-92d9-f97b8a8063f3"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("8e64fa31-bcc1-404f-bfc6-454ae196374b"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("90171adc-e7a9-4680-80ac-91a7026e4444"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("96289231-200c-4ed0-8953-8bf9d5c17cfd"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("9ce0ab17-7567-43f6-a709-29089f85e1d1"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("a7273c9b-dc7b-4404-8dae-ad44d71b5f8c"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("ac0cc2f3-3509-4b2f-b666-a7b81c918a63"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("b072a725-6f80-4514-9a1d-4d5842b7f2a8"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("be9adf42-4a3d-4203-979c-27306a0eb6aa"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("bf1a372a-e448-46df-ac1d-6e13cef0cc0a"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("c1f133ec-eab1-4c85-a12c-d745a2a2d55b"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("c503490d-c9b8-4d63-894d-f2142d08b344"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("c69a17a7-6bcf-4ede-9008-891f4ff98f4a"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("c7b2aabf-a963-4474-abeb-d3bcca2459f2"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("c9bb1b09-02bb-4df5-9b70-03deac93e1ab"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("ca5be104-a244-4824-b278-45fcbd14ca5a"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("ca80141b-bcfa-424b-a876-18a3f58fce82"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("cbdd51df-869c-4e69-8b96-0d99298d543e"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("d37e9a21-27e5-47d3-b4f5-4b3706b89268"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("d882715d-b3a2-453a-a89e-5f43572cdde8"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("db2ba12a-1896-48a4-b74a-9e122c394bd9"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("e12c615e-431d-4ffa-99bd-88f748662cd6"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("e65a4c07-6aa3-4d16-aadf-ae563d83071d"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("e6b42b87-624f-4ea3-b50c-e82eabf6b6d1"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("ee97fd1c-f166-47ed-9227-e289fcf7415c"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("f9ad83e7-9445-4d43-b906-b9ddf1afcef0"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("fc45e725-7838-4032-9882-8df1212ac486"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("33e60ab1-75f5-422a-a6b5-6a9461057834"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("3905538a-060d-42f1-90e7-d6f4f6ea8023"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("40eae73d-3f82-4ad1-8af3-a77fab3c5982"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("60c9bcda-5bd2-420b-86b3-d0294c4e241e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("660ab8ef-62a5-49f9-b78f-8e5129b1ad6d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("894613c6-97f7-4a7a-ad74-74ae66a3f84d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("8c5c53e0-5632-4201-8ed2-a348638dafa7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a0072c0f-2c8c-4782-958a-1d00703fe406"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a237f3fc-03fd-41a9-9e4e-d92fc0427c5e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a83d310d-9c10-4f51-a130-a8d9178e7df6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b0a1b119-967d-4e0f-8383-363e4e4095b4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b8f29bd2-363a-4f64-84c6-e272e838d00e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("dcddba1b-acc2-4089-b25e-227f99f47c6f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("fd2bd1a9-b7ee-41df-b9ff-6ce44bbf2521"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("07cf0ee3-6555-4e9a-b366-eaa5de6d9f46"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("110287f3-443a-41c9-bc39-756fd90a34d4"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("1a81d4f2-921b-4822-8379-4394b77fd2e5"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("68a907c7-3c05-4b72-bd8b-dc500742c001"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("7d529bb0-e558-4947-8fd2-3b6472f84dd7"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("87dbf881-2c8d-4654-a3fa-f8d030f31d45"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("c81bae19-8a4b-4d52-8b5d-1160ebf41adf"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("c8396007-04a1-4ca3-8cd0-6c5c910f2375"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("ed861016-1e1c-48a4-ad51-1c7a8674eff9"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("f18554fb-6fae-4a2f-8f7b-916aef7d2fc7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("235c5d7d-1ba6-4751-a3d7-b0ae27de0f8f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("25e75a5f-fcd7-40ab-b6f7-b65cfa620b04"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("654c0f7e-3583-407a-9cd1-90f1478c2ca0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("b25ddb17-a18b-4531-8cf3-2d27af224e4a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("c0d36680-5696-4f2e-94e4-45099a12fe39"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("d2124e41-b311-4e56-a6d7-d32f67b3368c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("e2f2567e-cb5e-4faf-a931-9371f568f395"));

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "CustomersOrders");

            migrationBuilder.AlterColumn<string>(
                name: "BillingPostalCode",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "The Billing PostCode Of The Order");

            migrationBuilder.AlterColumn<string>(
                name: "BillingName",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "The Billing Name Of The Order");

            migrationBuilder.AlterColumn<string>(
                name: "BillingCity",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "The Billing City Of The Order");

            migrationBuilder.AlterColumn<string>(
                name: "BillingAddress",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "The Billing Address Of The Order");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandId", "Address", "Country", "ImageUrl", "IsDeleted", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("066f6c6a-94b4-4792-b8cd-c816d5c5a46a"), "789 Kick Rd, Phuket, TH", "Thailand", "/images/Brands/twins-special-logo.png", false, "Twins Special", "567-890-1234" },
                    { new Guid("29ab1e43-6441-47c7-9c76-d4e5595258f2"), "456 Sports Ave, London, UK", "UK", "/images/Brands/rdx-logo.png", false, "RDX", "456-789-0123" },
                    { new Guid("40e1aa4a-3254-4529-9b06-56bde4c33c16"), "678 Fighter Ave, Miami, FL", "USA", "/images/Brands/sanabul-logo.png", false, "Sanabul", "456-789-0123" },
                    { new Guid("72207e09-81e8-4487-a561-26c98c982797"), "456 Ring Rd, Chicago, IL", "USA", "/images/Brands/ringside-logo.png", false, "Ringside", "234-567-8901" },
                    { new Guid("8203ff8f-7887-4f6d-b572-95e345cab201"), "789 Fight St, Toronto, ON", "Canada", "/images/Brands/hayabusa-logo.png", false, "Hayabusa", "789-012-3456" },
                    { new Guid("a2250aa6-f7b2-4fb0-a061-7e4b119a270d"), "234 Fighter Rd, Bangkok, TH", "Thailand", "/images/Brands/fairtex-logo.png", false, "Fairtex", "876-543-2109" },
                    { new Guid("dd49b911-bb46-4a24-9e1e-452b60f6ee87"), "567 Martial Arts Blvd, Oklahoma City, OK", "USA", "/images/Brands/century-logo.png", false, "Century", "345-678-9012" },
                    { new Guid("f3b98572-dccf-4c3e-a8af-6f111c6f25ca"), "101 Martial Arts Way, Paris, FR", "France", "/images/Brands/venum-logo.png", false, "Venum", "321-654-0987" },
                    { new Guid("f55049ce-5ade-4bc6-ada6-f80d1259ef01"), "345 Punch Ln, Los Angeles, CA", "USA", "/images/Brands/title-boxing-logo.png", false, "Title Boxing", "987-654-3210" },
                    { new Guid("fb49864a-2034-465c-8475-3293a4e50287"), "123 Boxing Blvd, New York, NY", "USA", "/images/Brands/everlast-logo.png", false, "Everlast", "123-456-7890" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "ImageUrl", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { new Guid("1abab5e2-ecf3-4adf-bba0-89a7ca8208fa"), "/images/Categegories/boxing-gloves.jfif", false, "Gloves" },
                    { new Guid("2f736787-4467-4d17-9e3a-bb1490ee7f5d"), "/images/Categories/protective-equipment.jfif", false, "Protective Gear" },
                    { new Guid("3f596856-d7c9-4093-a17d-570fb1384d39"), "/images/Categories/clothing.png", false, "Clothing" },
                    { new Guid("3f9c9cf5-b4c0-4045-b0e1-3311fbc4b23f"), "/images/Categories/training-equipment.png", false, "Training Equipment" },
                    { new Guid("4aad9df9-28c6-46a8-98f1-c4f6cc1bc270"), "/images/Categories/boxing-shoes.png", false, "Shoes" },
                    { new Guid("97eb9081-8c18-48c9-8de6-a44bf32fb805"), "/images/Categories/punching-bag.png", false, "Punching Bags" },
                    { new Guid("c47178b2-6495-4721-aa09-1c726ac2d643"), "/images/Categories/shin-guards.png", false, "Shinguards" },
                    { new Guid("d7a4a46c-5b3e-4ff8-848b-54094d7a2ee7"), "/images/Categories/mouth-guard.png", false, "Mouthguards" },
                    { new Guid("e2040311-9676-47de-b141-bc53cf23a86a"), "/images/Categories/head-gear.png", false, "Headgear" },
                    { new Guid("ef0fcbba-94d3-436f-bc5d-6b6ca28e6fc9"), "/images/Categories/hand-wraps.png", false, "Hand Wraps" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "BrandId", "CategoryId", "Description", "IsDeleted", "MainImageUrl", "Name", "Price", "Sizes", "StockQuantity" },
                values: new object[,]
                {
                    { new Guid("05fdb469-3891-4f31-8fb2-f531c8509133"), new Guid("8203ff8f-7887-4f6d-b572-95e345cab201"), new Guid("1abab5e2-ecf3-4adf-bba0-89a7ca8208fa"), "Top-notch gloves with exceptional durability.", false, "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-1.png", "Hayabusa T3 Boxing Gloves", 189.99m, "[2,3,4]", 50 },
                    { new Guid("184fb352-6c6e-4757-b60b-7478e5759508"), new Guid("a2250aa6-f7b2-4fb0-a061-7e4b119a270d"), new Guid("3f596856-d7c9-4093-a17d-570fb1384d39"), "Premium Muay Thai shorts with authentic design.", false, "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-1.png", "Fairtex Muay Thai Shorts", 84.99m, "[2,3,4]", 90 },
                    { new Guid("1edcc73b-e2fe-4ba8-a3e7-6795d0f00b03"), new Guid("72207e09-81e8-4487-a561-26c98c982797"), new Guid("97eb9081-8c18-48c9-8de6-a44bf32fb805"), "Heavy-duty bag for all levels of training.", false, "/images/Products/ringside-punching-bag/ringside-punching-bag-1.png", "Ringside Punching Bag", 219.99m, "[3]", 40 },
                    { new Guid("254fecf8-1739-444c-afb6-af4a29a262f0"), new Guid("f3b98572-dccf-4c3e-a8af-6f111c6f25ca"), new Guid("c47178b2-6495-4721-aa09-1c726ac2d643"), "High-durability shin guards ideal for intense training.", false, "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-1.png", "Venum Challenger Shin Guards", 105.99m, "[1,2,3]", 95 },
                    { new Guid("47ab64e1-fd21-435e-b4e4-aa54947a2005"), new Guid("29ab1e43-6441-47c7-9c76-d4e5595258f2"), new Guid("4aad9df9-28c6-46a8-98f1-c4f6cc1bc270"), "Lightweight and supportive for agility in the ring.", false, "/images/Products/rdx-boxing-shoes/rdx-boxing-shoes-1.png", "RDX Pro Boxing Shoes", 109.99m, "[2,3,4]", 65 },
                    { new Guid("77101c8e-a057-4f16-b53d-b558822e12ec"), new Guid("f55049ce-5ade-4bc6-ada6-f80d1259ef01"), new Guid("97eb9081-8c18-48c9-8de6-a44bf32fb805"), "Perfect for accuracy and reflex training.", false, "/images/Products/title-boxing-gloves/title-boxing-gloves-1.png", "Title Boxing Double End Bag", 99.99m, "[3]", 70 },
                    { new Guid("79868aab-bc98-4628-8443-509173147add"), new Guid("f55049ce-5ade-4bc6-ada6-f80d1259ef01"), new Guid("1abab5e2-ecf3-4adf-bba0-89a7ca8208fa"), "Durable leather gloves for heavy bag workouts.", false, "/images/Products/title-boxing-bag/title-boxing-bag-1.png", "Title Boxing Leather Bag Gloves", 79.99m, "[2,3]", 80 },
                    { new Guid("7b2bc133-a5e6-43e3-9886-b1b34625e680"), new Guid("40e1aa4a-3254-4529-9b06-56bde4c33c16"), new Guid("c47178b2-6495-4721-aa09-1c726ac2d643"), "High-quality shin guards for protection and mobility.", false, "/images/Products/sanabul-shin-guards/sanabul-shin-guards-1.png", "Sanabul Essential Shin Guards", 105.99m, "[2,3,4]", 90 },
                    { new Guid("8539ecb7-9af5-4bbe-a8d4-a05f517f1a21"), new Guid("fb49864a-2034-465c-8475-3293a4e50287"), new Guid("ef0fcbba-94d3-436f-bc5d-6b6ca28e6fc9"), "Classic wraps for wrist and knuckle protection.", false, "/images/Products/everlast-hand-wraps/everlast-hand-wraps-3.png", "Everlast Hand Wraps", 9.99m, "[2,3]", 200 },
                    { new Guid("9e2577a1-34d4-4255-8a3a-9736db4f1d0a"), new Guid("dd49b911-bb46-4a24-9e1e-452b60f6ee87"), new Guid("3f596856-d7c9-4093-a17d-570fb1384d39"), "Comfortable shorts designed for kickboxing.", false, "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-1.png", "Century Martial Arts Kickboxing Shorts", 79.99m, "[2,3,4]", 75 },
                    { new Guid("a1ca1686-b1d2-4db0-b42f-84c51f07d938"), new Guid("29ab1e43-6441-47c7-9c76-d4e5595258f2"), new Guid("1abab5e2-ecf3-4adf-bba0-89a7ca8208fa"), "High-quality leather gloves for all training levels.", false, "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-3.png", "RDX Boxing Gloves", 109.99m, "[1,2,3]", 100 },
                    { new Guid("a767dd5b-b242-43ac-a857-c0a971b27ace"), new Guid("fb49864a-2034-465c-8475-3293a4e50287"), new Guid("e2040311-9676-47de-b141-bc53cf23a86a"), "Full-protection headgear with durable padding.", false, "/images/Products/everlast-pro-headgear/everlast-headgear-1.png", "Everlast Pro Headgear", 89.99m, "[2,3]", 50 },
                    { new Guid("e2fb6902-f7fe-47cc-bbae-7886a7c89360"), new Guid("f3b98572-dccf-4c3e-a8af-6f111c6f25ca"), new Guid("1abab5e2-ecf3-4adf-bba0-89a7ca8208fa"), "Lightweight and designed for all skill levels.", false, "/images/Products/venum-challenger-gloves/venum-challenger-gloves-2.png", "Venum Challenger Gloves", 89.99m, "[1,2,3]", 120 },
                    { new Guid("e92b007b-5106-42c3-9234-11cf251a7747"), new Guid("066f6c6a-94b4-4792-b8cd-c816d5c5a46a"), new Guid("e2040311-9676-47de-b141-bc53cf23a86a"), "Full-face protection with Twins quality.", false, "/images/Products/twins-special-headgear/twins-special-headgear-1.png", "Twins Special Headgear", 89.99m, "[1,2,3]", 60 }
                });

            migrationBuilder.InsertData(
                table: "ProductsImages",
                columns: new[] { "ImageId", "ImageUrl", "ProductId" },
                values: new object[,]
                {
                    { new Guid("03d4cb7a-9c55-4e35-99bd-fbe2a4933f67"), "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-3.png", new Guid("a1ca1686-b1d2-4db0-b42f-84c51f07d938") },
                    { new Guid("07863c4f-d2f9-4a6c-92da-d8167f1f23dd"), "/images/Products/ringside-punching-bag/ringside-punching-bag-3.png", new Guid("1edcc73b-e2fe-4ba8-a3e7-6795d0f00b03") },
                    { new Guid("07e67631-c914-4c6d-99bc-6f9f0c53a6c1"), "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-1.png", new Guid("9e2577a1-34d4-4255-8a3a-9736db4f1d0a") },
                    { new Guid("175caa7b-cb13-4088-835d-cc1047d50b3c"), "/images/Products/everlasr-pro-headgear/everlast-headgear-1.png", new Guid("a767dd5b-b242-43ac-a857-c0a971b27ace") },
                    { new Guid("1eb982c2-0003-4564-9e8e-0331b2ec2141"), "/images/Products/sanabul-shin-guards/sanabul-shin-guards-3.png", new Guid("7b2bc133-a5e6-43e3-9886-b1b34625e680") },
                    { new Guid("214f7ab1-365d-4493-bc49-fb4c1e224116"), "/images/Products/title-boxing-bag/title-boxing-bag-3.png", new Guid("79868aab-bc98-4628-8443-509173147add") },
                    { new Guid("23bb28f5-77bd-4a10-8885-612983a453e5"), "/images/Products/twins-special-headgear/twins-special-headgear-2.png", new Guid("e92b007b-5106-42c3-9234-11cf251a7747") },
                    { new Guid("253f38ec-72c0-42a3-97a5-2b68b40f33cd"), "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-3.png", new Guid("9e2577a1-34d4-4255-8a3a-9736db4f1d0a") },
                    { new Guid("274a3573-4cc3-4c25-a3cd-d1208d00f999"), "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-1.png", new Guid("a1ca1686-b1d2-4db0-b42f-84c51f07d938") },
                    { new Guid("28526d47-118b-49ae-8669-9a8445112526"), "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-3.png", new Guid("254fecf8-1739-444c-afb6-af4a29a262f0") },
                    { new Guid("29113fc5-119a-418b-b222-dbf6e1b5ecba"), "/images/Products/sanabul-shin-guards/sanabul-shin-guards-2.png", new Guid("7b2bc133-a5e6-43e3-9886-b1b34625e680") },
                    { new Guid("302f1dcd-9088-422c-a6ea-5c409ec42ae3"), "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-1.png", new Guid("254fecf8-1739-444c-afb6-af4a29a262f0") },
                    { new Guid("3094514e-8d92-4f15-bef2-aac5505449ec"), "/images/Products/everlasr-pro-headgear/everlast-headgear-2.png", new Guid("a767dd5b-b242-43ac-a857-c0a971b27ace") },
                    { new Guid("3692639a-b49f-43fc-9f5c-4ef05ead6d2f"), "/images/Products/twins-special-headgear/twins-special-headgear-1.png", new Guid("e92b007b-5106-42c3-9234-11cf251a7747") },
                    { new Guid("38027a90-2ab1-4fd7-8a62-f7b114ed7352"), "/images/Products/title-boxing-bag/title-boxing-bag-1.png", new Guid("79868aab-bc98-4628-8443-509173147add") },
                    { new Guid("406d50a1-5640-4f0e-83a9-978703beae24"), "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-2.png", new Guid("05fdb469-3891-4f31-8fb2-f531c8509133") },
                    { new Guid("45e27749-9a74-490c-b778-caa9c3936a41"), "/images/Products/venum-challenger-gloves/venum-challenger-gloves-1.png", new Guid("e2fb6902-f7fe-47cc-bbae-7886a7c89360") },
                    { new Guid("57cd91eb-a414-43c9-8d12-debfd1dbb29d"), "/images/Products/everlast-hand-wraps/everlast-hand-wraps-1.png", new Guid("8539ecb7-9af5-4bbe-a8d4-a05f517f1a21") },
                    { new Guid("61212ebf-20fa-4a3a-b48a-7d31b264fa40"), "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-2.png", new Guid("254fecf8-1739-444c-afb6-af4a29a262f0") },
                    { new Guid("6c1c02a0-2da6-48ae-839e-21a74e53fe46"), "/images/Products/venum-challenger-gloves/venum-challenger-gloves-2.png", new Guid("e2fb6902-f7fe-47cc-bbae-7886a7c89360") },
                    { new Guid("830ec297-ca79-49fe-8e59-4c06bcd69d89"), "/images/Products/rdx-boxing-shoes/rdx-boxing-shoes-3.png", new Guid("47ab64e1-fd21-435e-b4e4-aa54947a2005") },
                    { new Guid("840a5970-aa12-4cdb-9c6d-7f5a5665ff84"), "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-2.png", new Guid("a1ca1686-b1d2-4db0-b42f-84c51f07d938") },
                    { new Guid("85fa2087-7b82-41be-9b06-8509751ca042"), "/images/Products/title-boxing-gloves/title-boxing-gloves-1.png", new Guid("77101c8e-a057-4f16-b53d-b558822e12ec") },
                    { new Guid("8a2ed08c-f4ac-4d8a-aaae-43a26345f003"), "/images/Products/everlast-hand-wraps/everlast-hand-wraps-3.png", new Guid("8539ecb7-9af5-4bbe-a8d4-a05f517f1a21") },
                    { new Guid("8af0069f-0975-4aed-acbc-ada4aea197b7"), "/images/Products/ringside-punching-bag/ringside-punching-bag-1.png", new Guid("1edcc73b-e2fe-4ba8-a3e7-6795d0f00b03") },
                    { new Guid("91beb3bb-1fd3-408a-a6a2-036cdfa09872"), "/images/Products/rdx-boxing-shoes/rdx-boxing-shoes-2.png", new Guid("47ab64e1-fd21-435e-b4e4-aa54947a2005") },
                    { new Guid("934cfd85-1722-49fb-b1cc-b0299b428d04"), "/images/Products/ringside-punching-bag/ringside-punching-bag-2.png", new Guid("1edcc73b-e2fe-4ba8-a3e7-6795d0f00b03") },
                    { new Guid("9af5e311-6ba8-4f16-9f14-00f7b1f4680e"), "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-1.png", new Guid("05fdb469-3891-4f31-8fb2-f531c8509133") },
                    { new Guid("acd78b1a-4034-4cc0-a23f-76ff3c9752d1"), "/images/Products/twins-special-headgear/twins-shin-headgear-3.png", new Guid("e92b007b-5106-42c3-9234-11cf251a7747") },
                    { new Guid("b1f38df7-41cc-46c5-8c39-52028c81e4ae"), "/images/Products/everlast-hand-wraps/everlast-hand-wraps-2.png", new Guid("8539ecb7-9af5-4bbe-a8d4-a05f517f1a21") },
                    { new Guid("b3304c1d-bc14-4fd2-a916-24458b31fb1e"), "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-3.png", new Guid("05fdb469-3891-4f31-8fb2-f531c8509133") },
                    { new Guid("b414f226-e2c5-4a4c-ae7b-cd2e159499a8"), "/images/Products/title-boxing-bag/title-boxing-bag-2.png", new Guid("79868aab-bc98-4628-8443-509173147add") },
                    { new Guid("b6377182-d60e-40c1-9713-34bbbe5d5c22"), "/images/Products/everlasr-pro-headgear/everlast-headgear-3.png", new Guid("a767dd5b-b242-43ac-a857-c0a971b27ace") },
                    { new Guid("c426e664-2138-4e45-859e-635f98f79c9e"), "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-3.png", new Guid("184fb352-6c6e-4757-b60b-7478e5759508") },
                    { new Guid("ccd56e84-2756-40e7-b2c5-9de6a922a44f"), "/images/Products/title-boxing-gloves/title-boxing-gloves-3.png", new Guid("77101c8e-a057-4f16-b53d-b558822e12ec") },
                    { new Guid("d1ef0617-8090-4899-9a01-a3221e89da78"), "/images/Products/venum-challenger-gloves/venum-challenger-gloves-3.png", new Guid("e2fb6902-f7fe-47cc-bbae-7886a7c89360") },
                    { new Guid("db071a02-6d67-4ebf-acbc-e162fb9acabc"), "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-2.png", new Guid("184fb352-6c6e-4757-b60b-7478e5759508") },
                    { new Guid("dd9423ea-0b1c-4c2c-8fb4-f8548d049f44"), "/images/Products/title-boxing-gloves/title-boxing-gloves-2.png", new Guid("77101c8e-a057-4f16-b53d-b558822e12ec") },
                    { new Guid("de48f1b6-7501-4e17-a6df-5467dfdfe13b"), "/images/Products/rdx-boxing-shoes/rdx-boxing-shoes-1.png", new Guid("47ab64e1-fd21-435e-b4e4-aa54947a2005") },
                    { new Guid("e36c6c52-e742-410b-a23f-3233cdbeefa6"), "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-2.png", new Guid("9e2577a1-34d4-4255-8a3a-9736db4f1d0a") },
                    { new Guid("faae7f28-1118-401a-9ac7-c5fbc1fdbe38"), "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-1.png", new Guid("184fb352-6c6e-4757-b60b-7478e5759508") },
                    { new Guid("fbb0fd62-0f0f-415d-9811-0e5a6fe74a1a"), "/images/Products/sanabul-shin-guards/sanabul-shin-guards-1.png", new Guid("7b2bc133-a5e6-43e3-9886-b1b34625e680") }
                });
        }
    }
}
