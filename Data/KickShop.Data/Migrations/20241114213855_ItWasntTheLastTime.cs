using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KickShop.Migrations
{
    /// <inheritdoc />
    public partial class ItWasntTheLastTime : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("0659a2e0-4200-40cd-ae5d-17e56a4968ef"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("9de841da-b9ab-44b4-9938-0b0b32d358c4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("af1753a9-8b30-4462-a347-290f3172183a"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("008ebeb7-a3af-438c-966f-3b77f81ef626"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("01a28735-e4fe-41f3-b7c2-4ee1f56932e3"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("0444da81-4e6b-4f30-84bd-c23f0a03f450"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("1776df6c-dc11-4665-bafc-2a288cfd1941"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("1b280404-5eaf-4c26-a7c6-96d66a418331"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("1f2ab667-9277-493d-a746-8be3924ad6a6"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("21ab4c7d-fb53-463b-a1d2-f15befe50490"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("292d3c0f-64fd-44b9-a053-20251695c12f"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("2e181b6f-3a30-4285-a8d1-543456b7cf63"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("2f536e6b-ec59-4a0f-8539-2ed53dfe04c1"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("30e364a6-9c8f-4236-9c03-9986bb17ec79"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("3178f90b-1b2d-4c67-a2f2-eb8692c30162"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("341749d3-7eeb-45b2-bd1b-a954b0bbbdcc"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("3dd4e077-a171-4a1e-8884-91893bca6d6a"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("43fb7a6b-2ac3-4322-87b9-dcf87aac0270"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("462d24c2-bc84-4dec-b6d0-1fcf6450cdb2"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("4c65de81-0ee8-4f74-b12d-c50a89a036bf"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("4efd2adf-af88-4d62-ad0e-ddbb1ed69f8f"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("63836401-25d8-4852-82b1-41c0f179be9c"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("6569aa27-b3d8-4dfd-b025-260f57239279"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("6cc63898-fa03-4afd-a7b0-af910f923e5b"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("6e006855-aac9-4977-98b4-b878aff86156"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("7322d4a5-7718-4ceb-a1a1-2212fb08a2a5"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("8886b820-9c88-40af-add3-10b783507796"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("889caba7-0781-426d-b450-b5a8ebbb2fb9"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("9a1cd67b-d1c9-41eb-a06d-c07afa477b41"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("9b2d798e-ebf2-4d2d-b03c-b4069e5574eb"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("a6f4d2fb-b838-47e4-af68-7ea245877102"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("a7213658-9949-4b87-aec2-add7dec5674c"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("b3d8b2a0-ece9-4352-aa75-39f5e13eb9fd"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("b90d5dd9-23e2-45fb-86e8-07294c8cddf0"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("bb5478da-93d1-4cd4-9786-ff7b236574dc"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("c0640fb9-2bc6-4690-abfc-13ef5efb7866"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("c4ae7eeb-0c2a-4afe-a552-671341bfc3c0"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("c5ff4ec1-4a47-4e0d-a323-64660e93c1b3"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("c962d598-bde0-4d18-8d56-acf1815b3922"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("cbbe39a4-bf39-49b7-be90-9ee353c57904"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("cdfe227b-9429-4926-94f0-a9164bb3133a"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("de2f3899-c829-4a71-834b-b7bfed5287ec"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("deb0143b-8b4e-4de5-9033-9e20e2bc714b"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("fe85774e-6c2f-4033-8111-505a8672c694"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("ffca33e2-cfdd-4f6b-8c67-7b978fd7a6e5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("042c9735-e56e-4bd7-ba56-0a0a283c0c0f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("12cde0d4-3d11-4695-ba57-42e8a268c529"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("2685121a-5f7b-43f4-b69c-fa344adc8346"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("32228ed5-8d49-409b-9c96-dc32542ae8b2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("3a9990a5-f425-4cc6-b77d-196948ace0a1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("45a233dc-9883-44f6-b579-4c0d541792b1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4df8c923-8371-41d6-abef-8297becbeb76"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4f567824-e0ba-4140-bc9b-32a2ac4de9b1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("77d7dbbf-a669-4528-96e0-5604cc32d46d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("7884662a-1758-4755-80bb-c44ee2c494f6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("ae743f72-aa41-42a1-a8c1-4d9428e6236a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b1fdd2f9-79bc-466b-8852-35a63d841712"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b6d2093d-a605-466d-b948-b5fb17d9cc74"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c015cb70-cce7-43d5-9601-96cabca98b46"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("0e645416-ea53-4b67-95cb-f60b7c0cd9ff"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("10a7bd70-e198-4524-8a60-4bba90b598eb"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("14b18f69-0cab-425e-9b5a-917864f48a1a"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("57e5c22e-0a41-48a5-9a43-71f397f5c6c6"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("8292a722-5fd5-4610-8c3e-95ed28eaedc9"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("972e41f1-329e-4cd9-88c1-63a32a60305e"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("9943b502-b592-4dec-9f72-437465c0a075"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("9a4c6f04-ca07-41cf-a29d-5013f66b30b6"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("f882f50a-692d-4d6c-a747-07d1ffdc872a"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("f979f5f4-5832-495f-977a-9119afef6e70"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("13b721cd-ef9c-4f1d-b055-47ef52b61fcc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("34a0353d-4c28-4bc4-a161-5313b6600238"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("38a5e3a4-47ef-41eb-8f2b-8e055e687a3d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("5faeec0e-bfd8-4df0-a822-e4dec9f7bc36"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("8575dff1-dcf4-49a6-971d-8779c8a87475"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("cc0b5252-7cd3-4459-ba39-85d6d44edaab"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("e5e3c675-87a3-45a0-bd08-9dcccccd4b9f"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("0e645416-ea53-4b67-95cb-f60b7c0cd9ff"), "345 Punch Ln, Los Angeles, CA", "USA", "/images/Brands/title-boxing-logo.png", false, "Title Boxing", "987-654-3210" },
                    { new Guid("10a7bd70-e198-4524-8a60-4bba90b598eb"), "678 Fighter Ave, Miami, FL", "USA", "/images/Brands/sanabul-logo.png", false, "Sanabul", "456-789-0123" },
                    { new Guid("14b18f69-0cab-425e-9b5a-917864f48a1a"), "234 Fighter Rd, Bangkok, TH", "Thailand", "/images/Brands/fairtex-logo.png", false, "Fairtex", "876-543-2109" },
                    { new Guid("57e5c22e-0a41-48a5-9a43-71f397f5c6c6"), "101 Martial Arts Way, Paris, FR", "France", "/images/Brands/venum-logo.png", false, "Venum", "321-654-0987" },
                    { new Guid("8292a722-5fd5-4610-8c3e-95ed28eaedc9"), "123 Boxing Blvd, New York, NY", "USA", "/images/Brands/everlast-logo.png", false, "Everlast", "123-456-7890" },
                    { new Guid("972e41f1-329e-4cd9-88c1-63a32a60305e"), "456 Sports Ave, London, UK", "UK", "/images/Brands/rdx-logo.png", false, "RDX", "456-789-0123" },
                    { new Guid("9943b502-b592-4dec-9f72-437465c0a075"), "567 Martial Arts Blvd, Oklahoma City, OK", "USA", "/images/Brands/century-logo.png", false, "Century", "345-678-9012" },
                    { new Guid("9a4c6f04-ca07-41cf-a29d-5013f66b30b6"), "789 Fight St, Toronto, ON", "Canada", "/images/Brands/hayabusa-logo.png", false, "Hayabusa", "789-012-3456" },
                    { new Guid("f882f50a-692d-4d6c-a747-07d1ffdc872a"), "789 Kick Rd, Phuket, TH", "Thailand", "/images/Brands/twins-special-logo.png", false, "Twins Special", "567-890-1234" },
                    { new Guid("f979f5f4-5832-495f-977a-9119afef6e70"), "456 Ring Rd, Chicago, IL", "USA", "/images/Brands/ringside-logo.png", false, "Ringside", "234-567-8901" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "ImageUrl", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { new Guid("0659a2e0-4200-40cd-ae5d-17e56a4968ef"), "/images/Categories/mouth-guard.png", false, "Mouthguards" },
                    { new Guid("13b721cd-ef9c-4f1d-b055-47ef52b61fcc"), "/images/Categories/punching-bag.png", false, "Punching Bags" },
                    { new Guid("34a0353d-4c28-4bc4-a161-5313b6600238"), "/images/Categories/clothing.png", false, "Clothing" },
                    { new Guid("38a5e3a4-47ef-41eb-8f2b-8e055e687a3d"), "/images/Categories/shinguards.png", false, "Shinguards" },
                    { new Guid("5faeec0e-bfd8-4df0-a822-e4dec9f7bc36"), "/images/Categories/head-gear.png", false, "Headgear" },
                    { new Guid("8575dff1-dcf4-49a6-971d-8779c8a87475"), "/images/Categegories/boxing-gloves.png", false, "Gloves" },
                    { new Guid("9de841da-b9ab-44b4-9938-0b0b32d358c4"), "/images/Categories/protective-gear.png", false, "Protective Gear" },
                    { new Guid("af1753a9-8b30-4462-a347-290f3172183a"), "/images/Categories/training-equipment.png", false, "Training Equipment" },
                    { new Guid("cc0b5252-7cd3-4459-ba39-85d6d44edaab"), "/images/Categories/hand-wraps.png", false, "Hand Wraps" },
                    { new Guid("e5e3c675-87a3-45a0-bd08-9dcccccd4b9f"), "/images/Categories/boxing-shoes.png", false, "Shoes" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "BrandId", "CategoryId", "Description", "IsDeleted", "MainImageUrl", "Name", "Price", "Sizes", "StockQuantity" },
                values: new object[,]
                {
                    { new Guid("042c9735-e56e-4bd7-ba56-0a0a283c0c0f"), new Guid("8292a722-5fd5-4610-8c3e-95ed28eaedc9"), new Guid("5faeec0e-bfd8-4df0-a822-e4dec9f7bc36"), "Full-protection headgear with durable padding.", false, "/images/Products/everlasr-pro-headgear/everlast-pro-headgear-1.png", "Everlast Pro Headgear", 69.99m, "[2,3]", 50 },
                    { new Guid("12cde0d4-3d11-4695-ba57-42e8a268c529"), new Guid("14b18f69-0cab-425e-9b5a-917864f48a1a"), new Guid("34a0353d-4c28-4bc4-a161-5313b6600238"), "Premium Muay Thai shorts with authentic design.", false, "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-1.png", "Fairtex Muay Thai Shorts", 34.99m, "[2,3,4]", 90 },
                    { new Guid("2685121a-5f7b-43f4-b69c-fa344adc8346"), new Guid("57e5c22e-0a41-48a5-9a43-71f397f5c6c6"), new Guid("8575dff1-dcf4-49a6-971d-8779c8a87475"), "Lightweight and designed for all skill levels.", false, "/images/Products/venum-challenger-gloves/venum-challenger-gloves-1.png", "Venum Challenger Gloves", 39.99m, "[1,2,3]", 120 },
                    { new Guid("32228ed5-8d49-409b-9c96-dc32542ae8b2"), new Guid("f882f50a-692d-4d6c-a747-07d1ffdc872a"), new Guid("5faeec0e-bfd8-4df0-a822-e4dec9f7bc36"), "Full-face protection with Twins quality.", false, "/images/Products/twins-special-headgear/twins-special-headgear-1.png", "Twins Special Headgear", 89.99m, "[1,2,3]", 60 },
                    { new Guid("3a9990a5-f425-4cc6-b77d-196948ace0a1"), new Guid("972e41f1-329e-4cd9-88c1-63a32a60305e"), new Guid("e5e3c675-87a3-45a0-bd08-9dcccccd4b9f"), "Lightweight and supportive for agility in the ring.", false, "/images/Products/rdx-boxing-shoes/rdx-boxing-shoes-1.png", "RDX Pro Boxing Shoes", 69.99m, "[2,3,4]", 65 },
                    { new Guid("45a233dc-9883-44f6-b579-4c0d541792b1"), new Guid("9943b502-b592-4dec-9f72-437465c0a075"), new Guid("34a0353d-4c28-4bc4-a161-5313b6600238"), "Comfortable shorts designed for kickboxing.", false, "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-1.png", "Century Martial Arts Kickboxing Shorts", 29.99m, "[2,3,4]", 75 },
                    { new Guid("4df8c923-8371-41d6-abef-8297becbeb76"), new Guid("972e41f1-329e-4cd9-88c1-63a32a60305e"), new Guid("8575dff1-dcf4-49a6-971d-8779c8a87475"), "High-quality leather gloves for all training levels.", false, "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-2.png", "RDX Boxing Gloves", 49.99m, "[1,2,3]", 100 },
                    { new Guid("4f567824-e0ba-4140-bc9b-32a2ac4de9b1"), new Guid("57e5c22e-0a41-48a5-9a43-71f397f5c6c6"), new Guid("38a5e3a4-47ef-41eb-8f2b-8e055e687a3d"), "High-durability shin guards ideal for intense training.", false, "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-1.png", "Venum Challenger Shin Guards", 45.99m, "[1,2,3]", 95 },
                    { new Guid("77d7dbbf-a669-4528-96e0-5604cc32d46d"), new Guid("10a7bd70-e198-4524-8a60-4bba90b598eb"), new Guid("38a5e3a4-47ef-41eb-8f2b-8e055e687a3d"), "High-quality shin guards for protection and mobility.", false, "/images/Products/sanabul-shin-guards/sanabul-shin-guards-1.png", "Sanabul Essential Shin Guards", 35.99m, "[2,3,4]", 90 },
                    { new Guid("7884662a-1758-4755-80bb-c44ee2c494f6"), new Guid("9a4c6f04-ca07-41cf-a29d-5013f66b30b6"), new Guid("8575dff1-dcf4-49a6-971d-8779c8a87475"), "Top-notch gloves with exceptional durability.", false, "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-1.png", "Hayabusa T3 Boxing Gloves", 89.99m, "[2,3,4]", 50 },
                    { new Guid("ae743f72-aa41-42a1-a8c1-4d9428e6236a"), new Guid("8292a722-5fd5-4610-8c3e-95ed28eaedc9"), new Guid("cc0b5252-7cd3-4459-ba39-85d6d44edaab"), "Classic wraps for wrist and knuckle protection.", false, "/images/Products/everlast-hand-wraps/everlast-hand-wraps-2.png", "Everlast Hand Wraps", 9.99m, "[2,3]", 200 },
                    { new Guid("b1fdd2f9-79bc-466b-8852-35a63d841712"), new Guid("f979f5f4-5832-495f-977a-9119afef6e70"), new Guid("13b721cd-ef9c-4f1d-b055-47ef52b61fcc"), "Heavy-duty bag for all levels of training.", false, "/images/Products/ringside-punching-bag/ringside-punching-bag-1.png", "Ringside Punching Bag", 119.99m, "[3]", 40 },
                    { new Guid("b6d2093d-a605-466d-b948-b5fb17d9cc74"), new Guid("0e645416-ea53-4b67-95cb-f60b7c0cd9ff"), new Guid("13b721cd-ef9c-4f1d-b055-47ef52b61fcc"), "Perfect for accuracy and reflex training.", false, "/images/Products/title-boxing-gloves/title-boxing-gloves-1.png", "Title Boxing Double End Bag", 44.99m, "[3]", 70 },
                    { new Guid("c015cb70-cce7-43d5-9601-96cabca98b46"), new Guid("0e645416-ea53-4b67-95cb-f60b7c0cd9ff"), new Guid("8575dff1-dcf4-49a6-971d-8779c8a87475"), "Durable leather gloves for heavy bag workouts.", false, "/images/Products/title-boxing-bag/title-boxing-bag-1.png", "Title Boxing Leather Bag Gloves", 59.99m, "[2,3]", 80 }
                });

            migrationBuilder.InsertData(
                table: "ProductsImages",
                columns: new[] { "ImageId", "ImageUrl", "ProductId" },
                values: new object[,]
                {
                    { new Guid("008ebeb7-a3af-438c-966f-3b77f81ef626"), "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-3.png", new Guid("4f567824-e0ba-4140-bc9b-32a2ac4de9b1") },
                    { new Guid("01a28735-e4fe-41f3-b7c2-4ee1f56932e3"), "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-1.png", new Guid("12cde0d4-3d11-4695-ba57-42e8a268c529") },
                    { new Guid("0444da81-4e6b-4f30-84bd-c23f0a03f450"), "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-2.png", new Guid("4df8c923-8371-41d6-abef-8297becbeb76") },
                    { new Guid("1776df6c-dc11-4665-bafc-2a288cfd1941"), "/images/Products/venum-challenger-gloves/venum-challenger-gloves-3.png", new Guid("2685121a-5f7b-43f4-b69c-fa344adc8346") },
                    { new Guid("1b280404-5eaf-4c26-a7c6-96d66a418331"), "/images/Products/rdx-boxing-shoes/rdx-boxing-shoes-2.png", new Guid("3a9990a5-f425-4cc6-b77d-196948ace0a1") },
                    { new Guid("1f2ab667-9277-493d-a746-8be3924ad6a6"), "/images/Products/everlasr-pro-headgear/everlast-pro-headgear-1.png", new Guid("042c9735-e56e-4bd7-ba56-0a0a283c0c0f") },
                    { new Guid("21ab4c7d-fb53-463b-a1d2-f15befe50490"), "/images/Products/everlast-hand-wraps/everlast-hand-wraps-2.png", new Guid("ae743f72-aa41-42a1-a8c1-4d9428e6236a") },
                    { new Guid("292d3c0f-64fd-44b9-a053-20251695c12f"), "/images/Products/twins-special-headgear/twins-special-headgear-2.png", new Guid("32228ed5-8d49-409b-9c96-dc32542ae8b2") },
                    { new Guid("2e181b6f-3a30-4285-a8d1-543456b7cf63"), "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-1.png", new Guid("45a233dc-9883-44f6-b579-4c0d541792b1") },
                    { new Guid("2f536e6b-ec59-4a0f-8539-2ed53dfe04c1"), "/images/Products/ringside-punching-bag/ringside-punching-bag-1.png", new Guid("b1fdd2f9-79bc-466b-8852-35a63d841712") },
                    { new Guid("30e364a6-9c8f-4236-9c03-9986bb17ec79"), "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-3.png", new Guid("4df8c923-8371-41d6-abef-8297becbeb76") },
                    { new Guid("3178f90b-1b2d-4c67-a2f2-eb8692c30162"), "/images/Products/ringside-punching-bag/ringside-punching-bag-3.png", new Guid("b1fdd2f9-79bc-466b-8852-35a63d841712") },
                    { new Guid("341749d3-7eeb-45b2-bd1b-a954b0bbbdcc"), "/images/Products/title-boxing-bag/title-boxing-bag-2.png", new Guid("c015cb70-cce7-43d5-9601-96cabca98b46") },
                    { new Guid("3dd4e077-a171-4a1e-8884-91893bca6d6a"), "/images/Products/twins-special-headgear/twins-shin-headgear-3.png", new Guid("32228ed5-8d49-409b-9c96-dc32542ae8b2") },
                    { new Guid("43fb7a6b-2ac3-4322-87b9-dcf87aac0270"), "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-3.png", new Guid("7884662a-1758-4755-80bb-c44ee2c494f6") },
                    { new Guid("462d24c2-bc84-4dec-b6d0-1fcf6450cdb2"), "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-1.png", new Guid("4f567824-e0ba-4140-bc9b-32a2ac4de9b1") },
                    { new Guid("4c65de81-0ee8-4f74-b12d-c50a89a036bf"), "/images/Products/rdx-boxing-shoes/rdx-boxing-shoes-3.png", new Guid("3a9990a5-f425-4cc6-b77d-196948ace0a1") },
                    { new Guid("4efd2adf-af88-4d62-ad0e-ddbb1ed69f8f"), "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-3.png", new Guid("45a233dc-9883-44f6-b579-4c0d541792b1") },
                    { new Guid("63836401-25d8-4852-82b1-41c0f179be9c"), "/images/Products/title-boxing-gloves/title-boxing-gloves-2.png", new Guid("b6d2093d-a605-466d-b948-b5fb17d9cc74") },
                    { new Guid("6569aa27-b3d8-4dfd-b025-260f57239279"), "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-2.png", new Guid("7884662a-1758-4755-80bb-c44ee2c494f6") },
                    { new Guid("6cc63898-fa03-4afd-a7b0-af910f923e5b"), "/images/Products/title-boxing-gloves/title-boxing-gloves-3.png", new Guid("b6d2093d-a605-466d-b948-b5fb17d9cc74") },
                    { new Guid("6e006855-aac9-4977-98b4-b878aff86156"), "/images/Products/title-boxing-bag/title-boxing-bag-3.png", new Guid("c015cb70-cce7-43d5-9601-96cabca98b46") },
                    { new Guid("7322d4a5-7718-4ceb-a1a1-2212fb08a2a5"), "/images/Products/everlast-hand-wraps/everlast-hand-wraps-3.png", new Guid("ae743f72-aa41-42a1-a8c1-4d9428e6236a") },
                    { new Guid("8886b820-9c88-40af-add3-10b783507796"), "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-1.png", new Guid("7884662a-1758-4755-80bb-c44ee2c494f6") },
                    { new Guid("889caba7-0781-426d-b450-b5a8ebbb2fb9"), "/images/Products/everlasr-pro-headgear/everlast-pro-headgear-2.png", new Guid("042c9735-e56e-4bd7-ba56-0a0a283c0c0f") },
                    { new Guid("9a1cd67b-d1c9-41eb-a06d-c07afa477b41"), "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-2.png", new Guid("45a233dc-9883-44f6-b579-4c0d541792b1") },
                    { new Guid("9b2d798e-ebf2-4d2d-b03c-b4069e5574eb"), "/images/Products/everlast-hand-wraps/everlast-hand-wraps-1.png", new Guid("ae743f72-aa41-42a1-a8c1-4d9428e6236a") },
                    { new Guid("a6f4d2fb-b838-47e4-af68-7ea245877102"), "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-1.png", new Guid("4df8c923-8371-41d6-abef-8297becbeb76") },
                    { new Guid("a7213658-9949-4b87-aec2-add7dec5674c"), "/images/Products/venum-challenger-gloves/venum-challenger-gloves-1.png", new Guid("2685121a-5f7b-43f4-b69c-fa344adc8346") },
                    { new Guid("b3d8b2a0-ece9-4352-aa75-39f5e13eb9fd"), "/images/Products/twins-special-headgear/twins-special-headgear-1.png", new Guid("32228ed5-8d49-409b-9c96-dc32542ae8b2") },
                    { new Guid("b90d5dd9-23e2-45fb-86e8-07294c8cddf0"), "/images/Products/venum-challenger-gloves/venum-challenger-gloves-2.png", new Guid("2685121a-5f7b-43f4-b69c-fa344adc8346") },
                    { new Guid("bb5478da-93d1-4cd4-9786-ff7b236574dc"), "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-3.png", new Guid("12cde0d4-3d11-4695-ba57-42e8a268c529") },
                    { new Guid("c0640fb9-2bc6-4690-abfc-13ef5efb7866"), "/images/Products/sanabul-shin-guards/sanabul-shin-guards-3.png", new Guid("77d7dbbf-a669-4528-96e0-5604cc32d46d") },
                    { new Guid("c4ae7eeb-0c2a-4afe-a552-671341bfc3c0"), "/images/Products/ringside-punching-bag/ringside-punching-bag-2.png", new Guid("b1fdd2f9-79bc-466b-8852-35a63d841712") },
                    { new Guid("c5ff4ec1-4a47-4e0d-a323-64660e93c1b3"), "/images/Products/sanabul-shin-guards/sanabul-shin-guards-2.png", new Guid("77d7dbbf-a669-4528-96e0-5604cc32d46d") },
                    { new Guid("c962d598-bde0-4d18-8d56-acf1815b3922"), "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-2.png", new Guid("4f567824-e0ba-4140-bc9b-32a2ac4de9b1") },
                    { new Guid("cbbe39a4-bf39-49b7-be90-9ee353c57904"), "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-2.png", new Guid("12cde0d4-3d11-4695-ba57-42e8a268c529") },
                    { new Guid("cdfe227b-9429-4926-94f0-a9164bb3133a"), "/images/Products/title-boxing-gloves/title-boxing-gloves-1.png", new Guid("b6d2093d-a605-466d-b948-b5fb17d9cc74") },
                    { new Guid("de2f3899-c829-4a71-834b-b7bfed5287ec"), "/images/Products/everlasr-pro-headgear/everlast-pro-headgear-3.png", new Guid("042c9735-e56e-4bd7-ba56-0a0a283c0c0f") },
                    { new Guid("deb0143b-8b4e-4de5-9033-9e20e2bc714b"), "/images/Products/sanabul-shin-guards/sanabul-shin-guards-1.png", new Guid("77d7dbbf-a669-4528-96e0-5604cc32d46d") },
                    { new Guid("fe85774e-6c2f-4033-8111-505a8672c694"), "/images/Products/title-boxing-bag/title-boxing-bag-1.png", new Guid("c015cb70-cce7-43d5-9601-96cabca98b46") },
                    { new Guid("ffca33e2-cfdd-4f6b-8c67-7b978fd7a6e5"), "/images/Products/rdx-boxing-shoes/rdx-boxing-shoes-1.png", new Guid("3a9990a5-f425-4cc6-b77d-196948ace0a1") }
                });
        }
    }
}
