using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KickShop.Migrations
{
    /// <inheritdoc />
    public partial class RemovedTheBillingCountryFromOrderModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "BillingCountry",
                table: "Orders");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "BillingCountry",
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
    }
}
