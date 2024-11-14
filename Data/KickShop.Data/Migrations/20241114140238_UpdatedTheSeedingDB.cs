using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KickShop.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedTheSeedingDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4ae180ab-e5ab-4b3e-b105-d6fc984612af"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("64c2a68a-7071-4bdc-8a2e-91c5d8df1424"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("80904993-56d5-4324-acbe-3753ce1cb0f6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("999888a3-89a0-46fa-b2cd-a9d8645fda77"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("bb2722c4-0258-48c3-8f14-4d954ce153d3"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("0aeb1752-e356-4934-a55b-f2e279b68bab"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("8da67b86-e855-40f0-846f-bc7bd1a57b35"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("c25077e7-3cd4-4491-a9b4-19d23802026a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("25843867-fead-46ef-bb13-1b15d2fc7393"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("43c9094e-c5b0-4d28-90e8-ef959556803e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("50eca588-3281-4991-acbc-447ed3492c52"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandId", "Address", "Country", "ImageUrl", "IsDeleted", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("0aeb1752-e356-4934-a55b-f2e279b68bab"), "Las Vegas,Nevada", "France", "Venum-Logo.png", false, "Venum", "1-888-200-5032" },
                    { new Guid("8da67b86-e855-40f0-846f-bc7bd1a57b35"), "Everlast Canada c/o ACI Brands Inc. 2616 Sheridan Garden Drive Oakville, ON L6J 7Z2", "USA", "Everlast-Logo.png", false, "Everlast", "1-800-668-5593" },
                    { new Guid("c25077e7-3cd4-4491-a9b4-19d23802026a"), "Adi-Dassler-Strasse 1 91074 Herzogenaurach, Germany", "Germany", "Adidas-Logo.png", false, "Adidas", "+49 9132 84 0" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "ImageUrl", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { new Guid("25843867-fead-46ef-bb13-1b15d2fc7393"), "/images/protective-gear-category.jpg", false, "Protective Gear" },
                    { new Guid("43c9094e-c5b0-4d28-90e8-ef959556803e"), "/images/apparel-category.jpg", false, "Apparel" },
                    { new Guid("50eca588-3281-4991-acbc-447ed3492c52"), "/images/gloves-category.jpg", false, "Gloves" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "BrandId", "CategoryId", "Description", "ImageUrl", "IsDeleted", "Name", "Price", "Sizes", "StockQuantity" },
                values: new object[,]
                {
                    { new Guid("4ae180ab-e5ab-4b3e-b105-d6fc984612af"), new Guid("0aeb1752-e356-4934-a55b-f2e279b68bab"), new Guid("25843867-fead-46ef-bb13-1b15d2fc7393"), "Essential mouth guard for protecting your teeth.", "/images/mouth-guard.jpg", false, "Mouth Guard", 12.99m, "[0,1,2,3]", 6 },
                    { new Guid("64c2a68a-7071-4bdc-8a2e-91c5d8df1424"), new Guid("8da67b86-e855-40f0-846f-bc7bd1a57b35"), new Guid("50eca588-3281-4991-acbc-447ed3492c52"), "High-quality kickboxing gloves for training and competition.", "/images/gloves.jpg", false, "Kickboxing Gloves", 49.99m, "[0,1,2,3]", 5 },
                    { new Guid("80904993-56d5-4324-acbe-3753ce1cb0f6"), new Guid("0aeb1752-e356-4934-a55b-f2e279b68bab"), new Guid("50eca588-3281-4991-acbc-447ed3492c52"), "Durable shin guards for protection during sparring.", "/images/shin-guards.jpg", false, "Shin Guards", 35.99m, "[0,1,2,3]", 6 },
                    { new Guid("999888a3-89a0-46fa-b2cd-a9d8645fda77"), new Guid("c25077e7-3cd4-4491-a9b4-19d23802026a"), new Guid("25843867-fead-46ef-bb13-1b15d2fc7393"), "Protective headgear for safety during training.", "/images/headgear.jpg", false, "Headgear", 59.99m, "[0,1,2,3]", 2 },
                    { new Guid("bb2722c4-0258-48c3-8f14-4d954ce153d3"), new Guid("8da67b86-e855-40f0-846f-bc7bd1a57b35"), new Guid("43c9094e-c5b0-4d28-90e8-ef959556803e"), "Comfortable shorts designed for kickboxing training.", "/images/shorts.jpg", false, "Kickboxing Shorts", 29.99m, "[0,1,2,3]", 4 }
                });
        }
    }
}
