using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KickShop.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedTheBrandDescriptionMaxLengthAndAddedDescriptiopnForEachBrand : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("3146397f-da18-4ce0-94c0-fe4164c2c258"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("935ea6a5-27e3-4194-9028-e3a0a50aef73"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("e4ff917c-706f-4404-939c-491962f2b872"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("01655682-0715-4cce-8087-a41dc80cf6dc"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("022ec505-0bfb-4414-8065-9eeef1160869"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("05a8b586-21b4-4c7d-b857-d53086beb17b"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("072ebc68-2c6e-482a-9d17-dbd456ff967a"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("0e29dcd3-1cbb-42f5-8416-b78efe5adc83"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("0f38da4e-6846-4a15-86b6-269404ee4c58"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("186e02bb-b205-4288-8f80-afd6e4ab7a49"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("1a5dc103-87da-47f0-aa01-f5e8f8ad6d4d"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("231fe42d-6edb-4fde-af77-c0db632768ee"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("2abb60f9-2420-42be-948a-4797a2fc859c"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("3bb5e6ec-05e8-4d16-808a-c9ea52e8482e"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("4202f39a-e5cb-4828-93b6-a3ad81e7d3e0"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("4606dd4b-bf2a-44c8-a7f8-e3b0cf15b665"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("48e1363e-a3a9-43d1-a236-a9d175c8afd2"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("49359630-4be4-4a50-97d8-b8391bc03609"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("497bfce1-9db5-4e6f-b638-da69de0ccf09"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("4da9bcbb-78d0-4023-aa5a-d780fca01812"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("4ea665c3-b1e1-4851-af02-98a0c5814836"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("5a3e1a69-6507-4917-bbbf-5b85371cee61"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("5bd4f206-f424-4bf6-96b1-0d631d01c17d"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("63b0282a-578d-4f7a-bd1e-5e4173cfee26"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("64403fdd-6027-4c9f-bfd8-a2b75ac9e49e"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("690478c1-b46b-46ab-82ad-1a23d2d004cc"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("719bdd46-8cd8-4f72-b581-a539d8a644cb"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("72b24a57-9d47-44b8-a3ca-66540b6c71cd"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("74206a8f-753d-4473-a4ee-a09459bbc39b"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("7a11c64e-006d-436e-84ee-db9fbb486fa4"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("7df95ac8-6383-403c-8ff1-b1f7f44fe8ad"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("8261b6d0-b8bf-4f24-9d30-ec6302b805b2"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("83984342-992d-42f6-9672-7c9d91ee81f8"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("8a0ebc47-820d-4618-b03f-cd8ef28b37b5"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("9cfb117a-73ee-4d42-b8e4-56deb03fbc89"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("a1b77e0f-a3d5-4e16-bbd9-c12e7ded7e0a"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("b1df5c02-fcbc-4842-8a3e-7cf453ac5c7f"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("bd34b7a8-347f-4684-9ead-4e1a085e7430"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("c31e8296-1560-4fbb-ac5d-7635ca7ebfa4"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("c823169f-7615-42dd-96ec-509493c83917"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("f13ba724-f883-49e9-aec5-eabe03bfbd14"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("f15f6896-4167-4f98-b1b2-ba0a0f9392b6"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("f425df77-63fb-4e85-b422-908a90d7d4de"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("f430553c-c451-47fe-bcba-d96598995354"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("f736a9c9-0dab-4e5a-9c89-62ff9073a1c3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("0a888e78-b5ad-43e2-a43a-187b67097bb9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1450dd84-6138-40f3-8c6e-9f764a9a49e7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("14a0d82d-a618-47e3-a629-275e30c17e56"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("20d6fefd-6ba9-4178-aec2-aff4dc771320"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("25804e3e-6d6c-40c5-b8d0-d3f07efe107e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("353063d8-23af-4de4-a068-55d06aa94a65"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("3f881285-1e5b-4751-96fc-f09940c26fbe"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("43ccf38c-e4a1-4cb7-8fa5-d767f94ab55d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4e41e922-61da-4718-ba7c-353d20d46a05"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("70789fa6-f621-4b1c-ba2e-877821b46070"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("bb2d353f-6d8b-4c3c-9a8c-34c1679717ff"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("bd2feaf1-5c01-4b07-b7ed-44f3db0c7d8c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c62dfb64-b442-4f6d-8eb2-788b2a6aec32"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d2044fab-500f-4f6a-b7b5-6e225f6cedb9"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("19a0dfba-b08e-4e15-b80a-26082eb1f627"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("28e179ed-8b9d-456d-943f-e6ba529f4f6d"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("2e448849-4e4c-448b-af63-e5030cd08cdf"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("358e2866-ef11-4bc5-b424-838fdecf3557"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("3eafbdad-0b64-4e82-89f9-868670a7d1a6"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("6346c34c-0c2c-4bec-95e2-9dc2dafcf4c0"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("7eac8ec9-0afe-4ac0-8de5-aa2b04fbe063"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("94c4c067-c4df-47be-aa24-d04888b1832c"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("97de8194-322d-40ab-8fe8-34667f6a92f6"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("bbd57117-d8bd-4952-a1ac-ced5b6776061"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("00694156-dd1c-43cb-a6a2-38283d99ac13"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("20ab88f5-89b3-4bcf-9f5b-91ec21f25a39"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("42da36bd-7c41-4c37-8738-8ca4e818deb9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("8955275a-5d44-44e3-8698-8d613bd504df"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("9320d3a6-daa1-489b-bf0d-c49272956d05"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ccdf3650-fcd2-4869-9625-618dc512af41"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ece2abad-2cc9-4e5e-b21b-be16b5abd340"));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Brands",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandId", "Address", "Country", "Description", "ImageUrl", "IsDeleted", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("216c9687-c020-4114-b5c1-f1a0b5a32634"), "123 Boxing Blvd, New York, NY", "USA", "Known as one of the oldest and most reputable brands in the boxing world, Everlast is a staple in combat sports. From gloves to training equipment, Everlast provides high-quality gear trusted by professional fighters and trainers alike.", "/images/Brands/everlast-logo.png", false, "Everlast", "123-456-7890" },
                    { new Guid("565886c6-c50e-40e6-98c4-80cc8ed25187"), "789 Fight St, Toronto, ON", "Canada", "Hayabusa is synonymous with premium quality and cutting-edge technology in combat sports. Their gloves and apparel are designed to provide exceptional protection, performance, and style for fighters at all levels.", "/images/Brands/hayabusa-logo.png", false, "Hayabusa", "789-012-3456" },
                    { new Guid("75d603e4-d0fe-4d83-ba3b-7b240726ae48"), "456 Ring Rd, Chicago, IL", "USA", "Ringside is a trusted name in boxing and kickboxing, providing high-performance equipment and apparel. Its focus on durability and craftsmanship has made it a favorite among gyms and professionals.", "/images/Brands/ringside-logo.png", false, "Ringside", "234-567-8901" },
                    { new Guid("815475f1-7008-4238-b233-c32094a28c88"), "678 Fighter Ave, Miami, FL", "USA", "Sanabul is a modern combat sports brand offering stylish and affordable gear. Its products are designed for both beginners and experienced athletes, with a focus on innovation and performance.", "/images/Brands/sanabul-logo.png", false, "Sanabul", "456-789-0123" },
                    { new Guid("aeeb017a-31de-4790-9010-b8a3d874ca02"), "101 Martial Arts Way, Paris, FR", "France", "Venum is a globally recognized brand known for its bold designs and top-tier combat sports equipment. From gloves to apparel, Venum caters to athletes who demand performance and style in the ring and beyond.", "/images/Brands/venum-logo.png", false, "Venum", "321-654-0987" },
                    { new Guid("b71b4301-afc0-4bae-9d64-e49b22bbae2c"), "234 Fighter Rd, Bangkok, TH", "Thailand", "Fairtex is a legendary Thai brand specializing in Muay Thai and kickboxing gear. Renowned for its authenticity and quality, Fairtex is the choice of champions in traditional and modern combat sports.", "/images/Brands/fairtex-logo.png", false, "Fairtex", "876-543-2109" },
                    { new Guid("bb8bdc3c-5075-4e6a-af2f-f53b2a1ae180"), "345 Punch Ln, Los Angeles, CA", "USA", "Title Boxing is a leading brand offering an extensive range of boxing and kickboxing gear. Known for its reliability and innovation, Title Boxing supports athletes with training and competition essentials.", "/images/Brands/title-boxing-logo.png", false, "Title Boxing", "987-654-3210" },
                    { new Guid("befc0e38-419e-4abe-ac63-f5b18c8178f6"), "456 Sports Ave, London, UK", "UK", "RDX is renowned for its innovative designs and durable equipment that cater to a wide range of combat sports, including kickboxing, MMA, and boxing. Its focus on affordability and quality makes it a favorite among beginners and professionals.", "/images/Brands/rdx-logo.png", false, "RDX", "456-789-0123" },
                    { new Guid("c3673aca-dd90-485b-9825-150a66518715"), "567 Martial Arts Blvd, Oklahoma City, OK", "USA", "Century is known for its innovative training gear, including punching bags and protective equipment. Widely used in martial arts and kickboxing, Century products are designed to enhance performance and safety.", "/images/Brands/century-logo.png", false, "Century", "345-678-9012" },
                    { new Guid("ff3cfd3c-573a-46e0-a4cc-0c24e5435a73"), "789 Kick Rd, Phuket, TH", "Thailand", "Twins Special is a renowned brand in Muay Thai and kickboxing, celebrated for its handcrafted gear. Their gloves and pads are known for their durability, quality, and traditional Thai craftsmanship.", "/images/Brands/twins-special-logo.png", false, "Twins Special", "567-890-1234" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "ImageUrl", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { new Guid("4bfd7f25-654a-4ba6-bd83-f9f1062409c6"), "/images/Categories/training-equipment.png", false, "Training Equipment" },
                    { new Guid("54f7057c-b5d2-477a-9a96-f94d80ef6d4f"), "/images/Categories/clothing.png", false, "Clothing" },
                    { new Guid("6b27b9c7-6387-49ec-823d-93dca9d49027"), "/images/Categories/head-gear.png", false, "Headgear" },
                    { new Guid("799c9a34-9ceb-4e96-94c9-0d227c2e1c32"), "/images/Categories/hand-wraps.png", false, "Hand Wraps" },
                    { new Guid("7a6de819-f99d-455f-a047-938797986e4a"), "/images/Categories/boxing-shoes.png", false, "Shoes" },
                    { new Guid("b715239f-e22f-4338-ad95-5883091ae042"), "/images/Categories/shin-guards.png", false, "Shinguards" },
                    { new Guid("c82e8e4d-61fb-4bbd-b2b1-dcd417401f24"), "/images/Categories/punching-bag.png", false, "Punching Bags" },
                    { new Guid("cedd2625-e0f4-4f11-89fe-fb601fd55e4d"), "/images/Categories/mouth-guard.png", false, "Mouthguards" },
                    { new Guid("d80d28b7-f769-43b9-beb2-d42db3839542"), "/images/Categories/protective-equipment.jfif", false, "Protective Gear" },
                    { new Guid("db956cdf-3752-4e35-a3e9-283e47732f52"), "/images/Categegories/boxing-gloves.jfif", false, "Gloves" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "BrandId", "CategoryId", "Description", "IsDeleted", "MainImageUrl", "Name", "Price", "Sizes", "StockQuantity" },
                values: new object[,]
                {
                    { new Guid("01f54de1-7391-4793-a4d4-b83a60105120"), new Guid("bb8bdc3c-5075-4e6a-af2f-f53b2a1ae180"), new Guid("db956cdf-3752-4e35-a3e9-283e47732f52"), "Durable leather gloves for heavy bag workouts.", false, "/images/Products/title-boxing-bag/title-boxing-bag-1.png", "Title Boxing Leather Bag Gloves", 79.99m, "[2,3]", 80 },
                    { new Guid("0ed90269-09de-4565-8187-28b93d755914"), new Guid("bb8bdc3c-5075-4e6a-af2f-f53b2a1ae180"), new Guid("c82e8e4d-61fb-4bbd-b2b1-dcd417401f24"), "Perfect for accuracy and reflex training.", false, "/images/Products/title-boxing-gloves/title-boxing-gloves-1.png", "Title Boxing Double End Bag", 99.99m, "[3]", 70 },
                    { new Guid("16b168c3-b311-4faf-84c1-dda801c9a9cc"), new Guid("ff3cfd3c-573a-46e0-a4cc-0c24e5435a73"), new Guid("6b27b9c7-6387-49ec-823d-93dca9d49027"), "Full-face protection with Twins quality.", false, "/images/Products/twins-special-headgear/twins-special-headgear-1.png", "Twins Special Headgear", 89.99m, "[1,2,3]", 60 },
                    { new Guid("1a1f1f64-392d-4696-bf1d-3c05da7a2743"), new Guid("565886c6-c50e-40e6-98c4-80cc8ed25187"), new Guid("db956cdf-3752-4e35-a3e9-283e47732f52"), "Top-notch gloves with exceptional durability.", false, "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-1.png", "Hayabusa T3 Boxing Gloves", 189.99m, "[2,3,4]", 50 },
                    { new Guid("25f0dfd5-4d5d-4504-9c0c-7093bca5cb35"), new Guid("befc0e38-419e-4abe-ac63-f5b18c8178f6"), new Guid("7a6de819-f99d-455f-a047-938797986e4a"), "Lightweight and supportive for agility in the ring.", false, "/images/Products/rdx-boxing-shoes/rdx-boxing-shoes-1.png", "RDX Pro Boxing Shoes", 109.99m, "[2,3,4]", 65 },
                    { new Guid("26f1b68c-1fe2-4dc7-9c88-b690e77296c5"), new Guid("b71b4301-afc0-4bae-9d64-e49b22bbae2c"), new Guid("54f7057c-b5d2-477a-9a96-f94d80ef6d4f"), "Premium Muay Thai shorts with authentic design.", false, "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-1.png", "Fairtex Muay Thai Shorts", 84.99m, "[2,3,4]", 90 },
                    { new Guid("27385718-6412-4058-b28b-cae17b5c7f18"), new Guid("befc0e38-419e-4abe-ac63-f5b18c8178f6"), new Guid("db956cdf-3752-4e35-a3e9-283e47732f52"), "High-quality leather gloves for all training levels.", false, "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-3.png", "RDX Boxing Gloves", 109.99m, "[1,2,3]", 100 },
                    { new Guid("3c3e153b-50f0-426f-a67d-96b3f6f96b23"), new Guid("c3673aca-dd90-485b-9825-150a66518715"), new Guid("54f7057c-b5d2-477a-9a96-f94d80ef6d4f"), "Comfortable shorts designed for kickboxing.", false, "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-1.png", "Century Martial Arts Kickboxing Shorts", 79.99m, "[2,3,4]", 75 },
                    { new Guid("7ee20921-0511-4c9b-be54-06c6886ce5ef"), new Guid("216c9687-c020-4114-b5c1-f1a0b5a32634"), new Guid("6b27b9c7-6387-49ec-823d-93dca9d49027"), "Full-protection headgear with durable padding.", false, "/images/Products/everlast-pro-headgear/everlast-headgear-1.png", "Everlast Pro Headgear", 89.99m, "[2,3]", 50 },
                    { new Guid("9eff6472-6df3-431e-a063-2129f846117e"), new Guid("aeeb017a-31de-4790-9010-b8a3d874ca02"), new Guid("db956cdf-3752-4e35-a3e9-283e47732f52"), "Lightweight and designed for all skill levels.", false, "/images/Products/venum-challenger-gloves/venum-challenger-gloves-2.png", "Venum Challenger Gloves", 89.99m, "[1,2,3]", 120 },
                    { new Guid("a03a79c6-8bf9-4257-83b0-b729887a632e"), new Guid("216c9687-c020-4114-b5c1-f1a0b5a32634"), new Guid("799c9a34-9ceb-4e96-94c9-0d227c2e1c32"), "Classic wraps for wrist and knuckle protection.", false, "/images/Products/everlast-hand-wraps/everlast-hand-wraps-3.png", "Everlast Hand Wraps", 9.99m, "[2,3]", 200 },
                    { new Guid("a6e134e5-8879-4e1b-9703-8375f9cb897d"), new Guid("aeeb017a-31de-4790-9010-b8a3d874ca02"), new Guid("b715239f-e22f-4338-ad95-5883091ae042"), "High-durability shin guards ideal for intense training.", false, "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-1.png", "Venum Challenger Shin Guards", 105.99m, "[1,2,3]", 95 },
                    { new Guid("d847fa90-e4f6-48d7-8453-266c45fa3d88"), new Guid("75d603e4-d0fe-4d83-ba3b-7b240726ae48"), new Guid("c82e8e4d-61fb-4bbd-b2b1-dcd417401f24"), "Heavy-duty bag for all levels of training.", false, "/images/Products/ringside-punching-bag/ringside-punching-bag-1.png", "Ringside Punching Bag", 219.99m, "[3]", 40 },
                    { new Guid("f140e803-b30f-44b6-9cf4-e27a00fc3805"), new Guid("815475f1-7008-4238-b233-c32094a28c88"), new Guid("b715239f-e22f-4338-ad95-5883091ae042"), "High-quality shin guards for protection and mobility.", false, "/images/Products/sanabul-shin-guards/sanabul-shin-guards-1.png", "Sanabul Essential Shin Guards", 105.99m, "[2,3,4]", 90 }
                });

            migrationBuilder.InsertData(
                table: "ProductsImages",
                columns: new[] { "ImageId", "ImageUrl", "ProductId" },
                values: new object[,]
                {
                    { new Guid("01168a4c-55bb-492e-8735-afac60695f1b"), "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-2.png", new Guid("3c3e153b-50f0-426f-a67d-96b3f6f96b23") },
                    { new Guid("0c9976a5-a350-46d1-bdca-ea5730c21eec"), "/images/Products/rdx-boxing-shoes/rdx-boxing-shoes-3.png", new Guid("25f0dfd5-4d5d-4504-9c0c-7093bca5cb35") },
                    { new Guid("19daffee-9be9-4b8a-9187-e4af8790e9fd"), "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-2.png", new Guid("26f1b68c-1fe2-4dc7-9c88-b690e77296c5") },
                    { new Guid("1c93ba5c-0319-4dac-b540-e4b658e2c1d1"), "/images/Products/sanabul-shin-guards/sanabul-shin-guards-1.png", new Guid("f140e803-b30f-44b6-9cf4-e27a00fc3805") },
                    { new Guid("25a6296c-a329-44b0-8450-cb3fc55632f1"), "/images/Products/title-boxing-gloves/title-boxing-gloves-3.png", new Guid("0ed90269-09de-4565-8187-28b93d755914") },
                    { new Guid("25a94cd9-b6a5-4b34-85fc-77432f92829d"), "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-3.png", new Guid("1a1f1f64-392d-4696-bf1d-3c05da7a2743") },
                    { new Guid("39b9da01-7ba9-469d-a748-175b7da3270b"), "/images/Products/title-boxing-gloves/title-boxing-gloves-1.png", new Guid("0ed90269-09de-4565-8187-28b93d755914") },
                    { new Guid("3a321544-7e27-4b9a-9400-7fb7d2c93323"), "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-3.png", new Guid("a6e134e5-8879-4e1b-9703-8375f9cb897d") },
                    { new Guid("499f06d4-2cb1-492c-bd54-843da7e67f86"), "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-1.png", new Guid("3c3e153b-50f0-426f-a67d-96b3f6f96b23") },
                    { new Guid("63b68d86-9344-484b-ba31-717b3ef6fea2"), "/images/Products/ringside-punching-bag/ringside-punching-bag-3.png", new Guid("d847fa90-e4f6-48d7-8453-266c45fa3d88") },
                    { new Guid("663eec6b-2429-4118-bf2d-6443515c619c"), "/images/Products/sanabul-shin-guards/sanabul-shin-guards-3.png", new Guid("f140e803-b30f-44b6-9cf4-e27a00fc3805") },
                    { new Guid("67c672c6-7323-45be-8499-a1ffeb40ca1f"), "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-1.png", new Guid("a6e134e5-8879-4e1b-9703-8375f9cb897d") },
                    { new Guid("6a6ded3e-d441-4f62-89ac-95776749cc58"), "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-1.png", new Guid("1a1f1f64-392d-4696-bf1d-3c05da7a2743") },
                    { new Guid("6a96e00f-bb1f-448c-a8ec-df3b5d96b6ed"), "/images/Products/everlasr-pro-headgear/everlast-headgear-2.png", new Guid("7ee20921-0511-4c9b-be54-06c6886ce5ef") },
                    { new Guid("71e6925a-2390-4307-9d6a-4ee9ad9ba6e9"), "/images/Products/rdx-boxing-shoes/rdx-boxing-shoes-2.png", new Guid("25f0dfd5-4d5d-4504-9c0c-7093bca5cb35") },
                    { new Guid("724a3544-ba06-4622-a387-f0b9b5729770"), "/images/Products/everlasr-pro-headgear/everlast-headgear-1.png", new Guid("7ee20921-0511-4c9b-be54-06c6886ce5ef") },
                    { new Guid("7282df3b-3aad-4beb-828e-1fd827457251"), "/images/Products/everlasr-pro-headgear/everlast-headgear-3.png", new Guid("7ee20921-0511-4c9b-be54-06c6886ce5ef") },
                    { new Guid("7326d623-a0d5-434a-a17c-b55eee1c1744"), "/images/Products/everlast-hand-wraps/everlast-hand-wraps-3.png", new Guid("a03a79c6-8bf9-4257-83b0-b729887a632e") },
                    { new Guid("7450dd99-718a-4c1c-869e-4ff3160719d5"), "/images/Products/title-boxing-bag/title-boxing-bag-1.png", new Guid("01f54de1-7391-4793-a4d4-b83a60105120") },
                    { new Guid("8390f33a-780e-4bbc-9ea0-f784a5ef72e7"), "/images/Products/twins-special-headgear/twins-shin-headgear-3.png", new Guid("16b168c3-b311-4faf-84c1-dda801c9a9cc") },
                    { new Guid("90f56c98-00a7-46ef-ae2d-81adf33b4163"), "/images/Products/title-boxing-gloves/title-boxing-gloves-2.png", new Guid("0ed90269-09de-4565-8187-28b93d755914") },
                    { new Guid("a0dd8734-7001-428b-81ae-398102c0b6e4"), "/images/Products/title-boxing-bag/title-boxing-bag-2.png", new Guid("01f54de1-7391-4793-a4d4-b83a60105120") },
                    { new Guid("a27a8c28-84a6-4c4d-8548-40b6a44af957"), "/images/Products/twins-special-headgear/twins-special-headgear-2.png", new Guid("16b168c3-b311-4faf-84c1-dda801c9a9cc") },
                    { new Guid("aa5b0554-9393-481c-a731-b9c8a98caf79"), "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-2.png", new Guid("1a1f1f64-392d-4696-bf1d-3c05da7a2743") },
                    { new Guid("aaf4311e-7e46-444a-8253-b0000e587630"), "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-2.png", new Guid("a6e134e5-8879-4e1b-9703-8375f9cb897d") },
                    { new Guid("b1602796-e6ec-47d5-9574-f1f7f36dce39"), "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-1.png", new Guid("27385718-6412-4058-b28b-cae17b5c7f18") },
                    { new Guid("bc6b7e0e-9842-4638-9de4-b7627890a4cd"), "/images/Products/venum-challenger-gloves/venum-challenger-gloves-2.png", new Guid("9eff6472-6df3-431e-a063-2129f846117e") },
                    { new Guid("c1070f86-1b67-4e50-8458-f1e73b317692"), "/images/Products/sanabul-shin-guards/sanabul-shin-guards-2.png", new Guid("f140e803-b30f-44b6-9cf4-e27a00fc3805") },
                    { new Guid("c908fa66-0aff-4e48-8629-24a4cc4be782"), "/images/Products/twins-special-headgear/twins-special-headgear-1.png", new Guid("16b168c3-b311-4faf-84c1-dda801c9a9cc") },
                    { new Guid("cbfba9b7-09f6-4a13-ac51-b4b1c5256664"), "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-3.png", new Guid("27385718-6412-4058-b28b-cae17b5c7f18") },
                    { new Guid("ccddf5bb-4046-495d-b18f-38e0fd59343d"), "/images/Products/ringside-punching-bag/ringside-punching-bag-2.png", new Guid("d847fa90-e4f6-48d7-8453-266c45fa3d88") },
                    { new Guid("ce1b5d81-2701-4bbf-a41b-ff7123ee3f8f"), "/images/Products/everlast-hand-wraps/everlast-hand-wraps-2.png", new Guid("a03a79c6-8bf9-4257-83b0-b729887a632e") },
                    { new Guid("d76476a6-d6cb-4997-a694-25d9687bd9b7"), "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-1.png", new Guid("26f1b68c-1fe2-4dc7-9c88-b690e77296c5") },
                    { new Guid("d85a39e9-4aa3-4dfe-b263-aaf5830cb319"), "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-3.png", new Guid("26f1b68c-1fe2-4dc7-9c88-b690e77296c5") },
                    { new Guid("d8943473-c2bd-4b8d-9f0b-edd8bb50eeae"), "/images/Products/title-boxing-bag/title-boxing-bag-3.png", new Guid("01f54de1-7391-4793-a4d4-b83a60105120") },
                    { new Guid("d9134a62-58d6-4d63-b600-9391f7852c98"), "/images/Products/rdx-boxing-shoes/rdx-boxing-shoes-1.png", new Guid("25f0dfd5-4d5d-4504-9c0c-7093bca5cb35") },
                    { new Guid("dfeb1b09-c03c-48e5-9877-0b83647766cc"), "/images/Products/venum-challenger-gloves/venum-challenger-gloves-3.png", new Guid("9eff6472-6df3-431e-a063-2129f846117e") },
                    { new Guid("e6753f73-1f79-4111-a6a2-78f6d3496a2b"), "/images/Products/ringside-punching-bag/ringside-punching-bag-1.png", new Guid("d847fa90-e4f6-48d7-8453-266c45fa3d88") },
                    { new Guid("eb6b66c6-6ba5-48f2-a419-c08b0ee6d524"), "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-3.png", new Guid("3c3e153b-50f0-426f-a67d-96b3f6f96b23") },
                    { new Guid("ef0c1e04-df07-4000-a17d-041c4568893d"), "/images/Products/venum-challenger-gloves/venum-challenger-gloves-1.png", new Guid("9eff6472-6df3-431e-a063-2129f846117e") },
                    { new Guid("ef42656e-baca-4d11-9085-891694911d35"), "/images/Products/everlast-hand-wraps/everlast-hand-wraps-1.png", new Guid("a03a79c6-8bf9-4257-83b0-b729887a632e") },
                    { new Guid("f0c62c15-3f2f-402b-b03b-96e97e91b290"), "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-2.png", new Guid("27385718-6412-4058-b28b-cae17b5c7f18") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("4bfd7f25-654a-4ba6-bd83-f9f1062409c6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("cedd2625-e0f4-4f11-89fe-fb601fd55e4d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("d80d28b7-f769-43b9-beb2-d42db3839542"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("01168a4c-55bb-492e-8735-afac60695f1b"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("0c9976a5-a350-46d1-bdca-ea5730c21eec"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("19daffee-9be9-4b8a-9187-e4af8790e9fd"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("1c93ba5c-0319-4dac-b540-e4b658e2c1d1"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("25a6296c-a329-44b0-8450-cb3fc55632f1"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("25a94cd9-b6a5-4b34-85fc-77432f92829d"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("39b9da01-7ba9-469d-a748-175b7da3270b"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("3a321544-7e27-4b9a-9400-7fb7d2c93323"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("499f06d4-2cb1-492c-bd54-843da7e67f86"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("63b68d86-9344-484b-ba31-717b3ef6fea2"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("663eec6b-2429-4118-bf2d-6443515c619c"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("67c672c6-7323-45be-8499-a1ffeb40ca1f"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("6a6ded3e-d441-4f62-89ac-95776749cc58"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("6a96e00f-bb1f-448c-a8ec-df3b5d96b6ed"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("71e6925a-2390-4307-9d6a-4ee9ad9ba6e9"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("724a3544-ba06-4622-a387-f0b9b5729770"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("7282df3b-3aad-4beb-828e-1fd827457251"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("7326d623-a0d5-434a-a17c-b55eee1c1744"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("7450dd99-718a-4c1c-869e-4ff3160719d5"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("8390f33a-780e-4bbc-9ea0-f784a5ef72e7"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("90f56c98-00a7-46ef-ae2d-81adf33b4163"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("a0dd8734-7001-428b-81ae-398102c0b6e4"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("a27a8c28-84a6-4c4d-8548-40b6a44af957"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("aa5b0554-9393-481c-a731-b9c8a98caf79"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("aaf4311e-7e46-444a-8253-b0000e587630"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("b1602796-e6ec-47d5-9574-f1f7f36dce39"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("bc6b7e0e-9842-4638-9de4-b7627890a4cd"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("c1070f86-1b67-4e50-8458-f1e73b317692"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("c908fa66-0aff-4e48-8629-24a4cc4be782"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("cbfba9b7-09f6-4a13-ac51-b4b1c5256664"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("ccddf5bb-4046-495d-b18f-38e0fd59343d"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("ce1b5d81-2701-4bbf-a41b-ff7123ee3f8f"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("d76476a6-d6cb-4997-a694-25d9687bd9b7"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("d85a39e9-4aa3-4dfe-b263-aaf5830cb319"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("d8943473-c2bd-4b8d-9f0b-edd8bb50eeae"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("d9134a62-58d6-4d63-b600-9391f7852c98"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("dfeb1b09-c03c-48e5-9877-0b83647766cc"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("e6753f73-1f79-4111-a6a2-78f6d3496a2b"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("eb6b66c6-6ba5-48f2-a419-c08b0ee6d524"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("ef0c1e04-df07-4000-a17d-041c4568893d"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("ef42656e-baca-4d11-9085-891694911d35"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("f0c62c15-3f2f-402b-b03b-96e97e91b290"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("01f54de1-7391-4793-a4d4-b83a60105120"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("0ed90269-09de-4565-8187-28b93d755914"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("16b168c3-b311-4faf-84c1-dda801c9a9cc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1a1f1f64-392d-4696-bf1d-3c05da7a2743"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("25f0dfd5-4d5d-4504-9c0c-7093bca5cb35"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("26f1b68c-1fe2-4dc7-9c88-b690e77296c5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("27385718-6412-4058-b28b-cae17b5c7f18"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("3c3e153b-50f0-426f-a67d-96b3f6f96b23"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("7ee20921-0511-4c9b-be54-06c6886ce5ef"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("9eff6472-6df3-431e-a063-2129f846117e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a03a79c6-8bf9-4257-83b0-b729887a632e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a6e134e5-8879-4e1b-9703-8375f9cb897d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d847fa90-e4f6-48d7-8453-266c45fa3d88"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f140e803-b30f-44b6-9cf4-e27a00fc3805"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("216c9687-c020-4114-b5c1-f1a0b5a32634"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("565886c6-c50e-40e6-98c4-80cc8ed25187"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("75d603e4-d0fe-4d83-ba3b-7b240726ae48"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("815475f1-7008-4238-b233-c32094a28c88"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("aeeb017a-31de-4790-9010-b8a3d874ca02"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("b71b4301-afc0-4bae-9d64-e49b22bbae2c"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("bb8bdc3c-5075-4e6a-af2f-f53b2a1ae180"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("befc0e38-419e-4abe-ac63-f5b18c8178f6"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("c3673aca-dd90-485b-9825-150a66518715"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("ff3cfd3c-573a-46e0-a4cc-0c24e5435a73"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("54f7057c-b5d2-477a-9a96-f94d80ef6d4f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("6b27b9c7-6387-49ec-823d-93dca9d49027"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("799c9a34-9ceb-4e96-94c9-0d227c2e1c32"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("7a6de819-f99d-455f-a047-938797986e4a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("b715239f-e22f-4338-ad95-5883091ae042"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("c82e8e4d-61fb-4bbd-b2b1-dcd417401f24"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("db956cdf-3752-4e35-a3e9-283e47732f52"));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Brands",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000,
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandId", "Address", "Country", "Description", "ImageUrl", "IsDeleted", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("19a0dfba-b08e-4e15-b80a-26082eb1f627"), "789 Kick Rd, Phuket, TH", "Thailand", null, "/images/Brands/twins-special-logo.png", false, "Twins Special", "567-890-1234" },
                    { new Guid("28e179ed-8b9d-456d-943f-e6ba529f4f6d"), "101 Martial Arts Way, Paris, FR", "France", null, "/images/Brands/venum-logo.png", false, "Venum", "321-654-0987" },
                    { new Guid("2e448849-4e4c-448b-af63-e5030cd08cdf"), "123 Boxing Blvd, New York, NY", "USA", null, "/images/Brands/everlast-logo.png", false, "Everlast", "123-456-7890" },
                    { new Guid("358e2866-ef11-4bc5-b424-838fdecf3557"), "567 Martial Arts Blvd, Oklahoma City, OK", "USA", null, "/images/Brands/century-logo.png", false, "Century", "345-678-9012" },
                    { new Guid("3eafbdad-0b64-4e82-89f9-868670a7d1a6"), "456 Sports Ave, London, UK", "UK", null, "/images/Brands/rdx-logo.png", false, "RDX", "456-789-0123" },
                    { new Guid("6346c34c-0c2c-4bec-95e2-9dc2dafcf4c0"), "789 Fight St, Toronto, ON", "Canada", null, "/images/Brands/hayabusa-logo.png", false, "Hayabusa", "789-012-3456" },
                    { new Guid("7eac8ec9-0afe-4ac0-8de5-aa2b04fbe063"), "456 Ring Rd, Chicago, IL", "USA", null, "/images/Brands/ringside-logo.png", false, "Ringside", "234-567-8901" },
                    { new Guid("94c4c067-c4df-47be-aa24-d04888b1832c"), "345 Punch Ln, Los Angeles, CA", "USA", null, "/images/Brands/title-boxing-logo.png", false, "Title Boxing", "987-654-3210" },
                    { new Guid("97de8194-322d-40ab-8fe8-34667f6a92f6"), "678 Fighter Ave, Miami, FL", "USA", null, "/images/Brands/sanabul-logo.png", false, "Sanabul", "456-789-0123" },
                    { new Guid("bbd57117-d8bd-4952-a1ac-ced5b6776061"), "234 Fighter Rd, Bangkok, TH", "Thailand", null, "/images/Brands/fairtex-logo.png", false, "Fairtex", "876-543-2109" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "ImageUrl", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { new Guid("00694156-dd1c-43cb-a6a2-38283d99ac13"), "/images/Categories/shin-guards.png", false, "Shinguards" },
                    { new Guid("20ab88f5-89b3-4bcf-9f5b-91ec21f25a39"), "/images/Categories/hand-wraps.png", false, "Hand Wraps" },
                    { new Guid("3146397f-da18-4ce0-94c0-fe4164c2c258"), "/images/Categories/mouth-guard.png", false, "Mouthguards" },
                    { new Guid("42da36bd-7c41-4c37-8738-8ca4e818deb9"), "/images/Categegories/boxing-gloves.jfif", false, "Gloves" },
                    { new Guid("8955275a-5d44-44e3-8698-8d613bd504df"), "/images/Categories/head-gear.png", false, "Headgear" },
                    { new Guid("9320d3a6-daa1-489b-bf0d-c49272956d05"), "/images/Categories/boxing-shoes.png", false, "Shoes" },
                    { new Guid("935ea6a5-27e3-4194-9028-e3a0a50aef73"), "/images/Categories/protective-equipment.jfif", false, "Protective Gear" },
                    { new Guid("ccdf3650-fcd2-4869-9625-618dc512af41"), "/images/Categories/clothing.png", false, "Clothing" },
                    { new Guid("e4ff917c-706f-4404-939c-491962f2b872"), "/images/Categories/training-equipment.png", false, "Training Equipment" },
                    { new Guid("ece2abad-2cc9-4e5e-b21b-be16b5abd340"), "/images/Categories/punching-bag.png", false, "Punching Bags" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "BrandId", "CategoryId", "Description", "IsDeleted", "MainImageUrl", "Name", "Price", "Sizes", "StockQuantity" },
                values: new object[,]
                {
                    { new Guid("0a888e78-b5ad-43e2-a43a-187b67097bb9"), new Guid("3eafbdad-0b64-4e82-89f9-868670a7d1a6"), new Guid("42da36bd-7c41-4c37-8738-8ca4e818deb9"), "High-quality leather gloves for all training levels.", false, "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-3.png", "RDX Boxing Gloves", 109.99m, "[1,2,3]", 100 },
                    { new Guid("1450dd84-6138-40f3-8c6e-9f764a9a49e7"), new Guid("7eac8ec9-0afe-4ac0-8de5-aa2b04fbe063"), new Guid("ece2abad-2cc9-4e5e-b21b-be16b5abd340"), "Heavy-duty bag for all levels of training.", false, "/images/Products/ringside-punching-bag/ringside-punching-bag-1.png", "Ringside Punching Bag", 219.99m, "[3]", 40 },
                    { new Guid("14a0d82d-a618-47e3-a629-275e30c17e56"), new Guid("28e179ed-8b9d-456d-943f-e6ba529f4f6d"), new Guid("00694156-dd1c-43cb-a6a2-38283d99ac13"), "High-durability shin guards ideal for intense training.", false, "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-1.png", "Venum Challenger Shin Guards", 105.99m, "[1,2,3]", 95 },
                    { new Guid("20d6fefd-6ba9-4178-aec2-aff4dc771320"), new Guid("94c4c067-c4df-47be-aa24-d04888b1832c"), new Guid("ece2abad-2cc9-4e5e-b21b-be16b5abd340"), "Perfect for accuracy and reflex training.", false, "/images/Products/title-boxing-gloves/title-boxing-gloves-1.png", "Title Boxing Double End Bag", 99.99m, "[3]", 70 },
                    { new Guid("25804e3e-6d6c-40c5-b8d0-d3f07efe107e"), new Guid("3eafbdad-0b64-4e82-89f9-868670a7d1a6"), new Guid("9320d3a6-daa1-489b-bf0d-c49272956d05"), "Lightweight and supportive for agility in the ring.", false, "/images/Products/rdx-boxing-shoes/rdx-boxing-shoes-1.png", "RDX Pro Boxing Shoes", 109.99m, "[2,3,4]", 65 },
                    { new Guid("353063d8-23af-4de4-a068-55d06aa94a65"), new Guid("28e179ed-8b9d-456d-943f-e6ba529f4f6d"), new Guid("42da36bd-7c41-4c37-8738-8ca4e818deb9"), "Lightweight and designed for all skill levels.", false, "/images/Products/venum-challenger-gloves/venum-challenger-gloves-2.png", "Venum Challenger Gloves", 89.99m, "[1,2,3]", 120 },
                    { new Guid("3f881285-1e5b-4751-96fc-f09940c26fbe"), new Guid("19a0dfba-b08e-4e15-b80a-26082eb1f627"), new Guid("8955275a-5d44-44e3-8698-8d613bd504df"), "Full-face protection with Twins quality.", false, "/images/Products/twins-special-headgear/twins-special-headgear-1.png", "Twins Special Headgear", 89.99m, "[1,2,3]", 60 },
                    { new Guid("43ccf38c-e4a1-4cb7-8fa5-d767f94ab55d"), new Guid("358e2866-ef11-4bc5-b424-838fdecf3557"), new Guid("ccdf3650-fcd2-4869-9625-618dc512af41"), "Comfortable shorts designed for kickboxing.", false, "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-1.png", "Century Martial Arts Kickboxing Shorts", 79.99m, "[2,3,4]", 75 },
                    { new Guid("4e41e922-61da-4718-ba7c-353d20d46a05"), new Guid("97de8194-322d-40ab-8fe8-34667f6a92f6"), new Guid("00694156-dd1c-43cb-a6a2-38283d99ac13"), "High-quality shin guards for protection and mobility.", false, "/images/Products/sanabul-shin-guards/sanabul-shin-guards-1.png", "Sanabul Essential Shin Guards", 105.99m, "[2,3,4]", 90 },
                    { new Guid("70789fa6-f621-4b1c-ba2e-877821b46070"), new Guid("94c4c067-c4df-47be-aa24-d04888b1832c"), new Guid("42da36bd-7c41-4c37-8738-8ca4e818deb9"), "Durable leather gloves for heavy bag workouts.", false, "/images/Products/title-boxing-bag/title-boxing-bag-1.png", "Title Boxing Leather Bag Gloves", 79.99m, "[2,3]", 80 },
                    { new Guid("bb2d353f-6d8b-4c3c-9a8c-34c1679717ff"), new Guid("2e448849-4e4c-448b-af63-e5030cd08cdf"), new Guid("8955275a-5d44-44e3-8698-8d613bd504df"), "Full-protection headgear with durable padding.", false, "/images/Products/everlast-pro-headgear/everlast-headgear-1.png", "Everlast Pro Headgear", 89.99m, "[2,3]", 50 },
                    { new Guid("bd2feaf1-5c01-4b07-b7ed-44f3db0c7d8c"), new Guid("6346c34c-0c2c-4bec-95e2-9dc2dafcf4c0"), new Guid("42da36bd-7c41-4c37-8738-8ca4e818deb9"), "Top-notch gloves with exceptional durability.", false, "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-1.png", "Hayabusa T3 Boxing Gloves", 189.99m, "[2,3,4]", 50 },
                    { new Guid("c62dfb64-b442-4f6d-8eb2-788b2a6aec32"), new Guid("2e448849-4e4c-448b-af63-e5030cd08cdf"), new Guid("20ab88f5-89b3-4bcf-9f5b-91ec21f25a39"), "Classic wraps for wrist and knuckle protection.", false, "/images/Products/everlast-hand-wraps/everlast-hand-wraps-3.png", "Everlast Hand Wraps", 9.99m, "[2,3]", 200 },
                    { new Guid("d2044fab-500f-4f6a-b7b5-6e225f6cedb9"), new Guid("bbd57117-d8bd-4952-a1ac-ced5b6776061"), new Guid("ccdf3650-fcd2-4869-9625-618dc512af41"), "Premium Muay Thai shorts with authentic design.", false, "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-1.png", "Fairtex Muay Thai Shorts", 84.99m, "[2,3,4]", 90 }
                });

            migrationBuilder.InsertData(
                table: "ProductsImages",
                columns: new[] { "ImageId", "ImageUrl", "ProductId" },
                values: new object[,]
                {
                    { new Guid("01655682-0715-4cce-8087-a41dc80cf6dc"), "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-3.png", new Guid("bd2feaf1-5c01-4b07-b7ed-44f3db0c7d8c") },
                    { new Guid("022ec505-0bfb-4414-8065-9eeef1160869"), "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-2.png", new Guid("bd2feaf1-5c01-4b07-b7ed-44f3db0c7d8c") },
                    { new Guid("05a8b586-21b4-4c7d-b857-d53086beb17b"), "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-3.png", new Guid("0a888e78-b5ad-43e2-a43a-187b67097bb9") },
                    { new Guid("072ebc68-2c6e-482a-9d17-dbd456ff967a"), "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-2.png", new Guid("14a0d82d-a618-47e3-a629-275e30c17e56") },
                    { new Guid("0e29dcd3-1cbb-42f5-8416-b78efe5adc83"), "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-1.png", new Guid("43ccf38c-e4a1-4cb7-8fa5-d767f94ab55d") },
                    { new Guid("0f38da4e-6846-4a15-86b6-269404ee4c58"), "/images/Products/everlasr-pro-headgear/everlast-headgear-2.png", new Guid("bb2d353f-6d8b-4c3c-9a8c-34c1679717ff") },
                    { new Guid("186e02bb-b205-4288-8f80-afd6e4ab7a49"), "/images/Products/venum-challenger-gloves/venum-challenger-gloves-2.png", new Guid("353063d8-23af-4de4-a068-55d06aa94a65") },
                    { new Guid("1a5dc103-87da-47f0-aa01-f5e8f8ad6d4d"), "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-1.png", new Guid("0a888e78-b5ad-43e2-a43a-187b67097bb9") },
                    { new Guid("231fe42d-6edb-4fde-af77-c0db632768ee"), "/images/Products/rdx-boxing-shoes/rdx-boxing-shoes-3.png", new Guid("25804e3e-6d6c-40c5-b8d0-d3f07efe107e") },
                    { new Guid("2abb60f9-2420-42be-948a-4797a2fc859c"), "/images/Products/venum-challenger-gloves/venum-challenger-gloves-1.png", new Guid("353063d8-23af-4de4-a068-55d06aa94a65") },
                    { new Guid("3bb5e6ec-05e8-4d16-808a-c9ea52e8482e"), "/images/Products/title-boxing-bag/title-boxing-bag-2.png", new Guid("70789fa6-f621-4b1c-ba2e-877821b46070") },
                    { new Guid("4202f39a-e5cb-4828-93b6-a3ad81e7d3e0"), "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-3.png", new Guid("14a0d82d-a618-47e3-a629-275e30c17e56") },
                    { new Guid("4606dd4b-bf2a-44c8-a7f8-e3b0cf15b665"), "/images/Products/title-boxing-gloves/title-boxing-gloves-1.png", new Guid("20d6fefd-6ba9-4178-aec2-aff4dc771320") },
                    { new Guid("48e1363e-a3a9-43d1-a236-a9d175c8afd2"), "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-3.png", new Guid("43ccf38c-e4a1-4cb7-8fa5-d767f94ab55d") },
                    { new Guid("49359630-4be4-4a50-97d8-b8391bc03609"), "/images/Products/sanabul-shin-guards/sanabul-shin-guards-2.png", new Guid("4e41e922-61da-4718-ba7c-353d20d46a05") },
                    { new Guid("497bfce1-9db5-4e6f-b638-da69de0ccf09"), "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-2.png", new Guid("43ccf38c-e4a1-4cb7-8fa5-d767f94ab55d") },
                    { new Guid("4da9bcbb-78d0-4023-aa5a-d780fca01812"), "/images/Products/everlast-hand-wraps/everlast-hand-wraps-2.png", new Guid("c62dfb64-b442-4f6d-8eb2-788b2a6aec32") },
                    { new Guid("4ea665c3-b1e1-4851-af02-98a0c5814836"), "/images/Products/twins-special-headgear/twins-shin-headgear-3.png", new Guid("3f881285-1e5b-4751-96fc-f09940c26fbe") },
                    { new Guid("5a3e1a69-6507-4917-bbbf-5b85371cee61"), "/images/Products/twins-special-headgear/twins-special-headgear-1.png", new Guid("3f881285-1e5b-4751-96fc-f09940c26fbe") },
                    { new Guid("5bd4f206-f424-4bf6-96b1-0d631d01c17d"), "/images/Products/everlasr-pro-headgear/everlast-headgear-1.png", new Guid("bb2d353f-6d8b-4c3c-9a8c-34c1679717ff") },
                    { new Guid("63b0282a-578d-4f7a-bd1e-5e4173cfee26"), "/images/Products/sanabul-shin-guards/sanabul-shin-guards-3.png", new Guid("4e41e922-61da-4718-ba7c-353d20d46a05") },
                    { new Guid("64403fdd-6027-4c9f-bfd8-a2b75ac9e49e"), "/images/Products/twins-special-headgear/twins-special-headgear-2.png", new Guid("3f881285-1e5b-4751-96fc-f09940c26fbe") },
                    { new Guid("690478c1-b46b-46ab-82ad-1a23d2d004cc"), "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-2.png", new Guid("0a888e78-b5ad-43e2-a43a-187b67097bb9") },
                    { new Guid("719bdd46-8cd8-4f72-b581-a539d8a644cb"), "/images/Products/ringside-punching-bag/ringside-punching-bag-2.png", new Guid("1450dd84-6138-40f3-8c6e-9f764a9a49e7") },
                    { new Guid("72b24a57-9d47-44b8-a3ca-66540b6c71cd"), "/images/Products/title-boxing-gloves/title-boxing-gloves-3.png", new Guid("20d6fefd-6ba9-4178-aec2-aff4dc771320") },
                    { new Guid("74206a8f-753d-4473-a4ee-a09459bbc39b"), "/images/Products/title-boxing-gloves/title-boxing-gloves-2.png", new Guid("20d6fefd-6ba9-4178-aec2-aff4dc771320") },
                    { new Guid("7a11c64e-006d-436e-84ee-db9fbb486fa4"), "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-3.png", new Guid("d2044fab-500f-4f6a-b7b5-6e225f6cedb9") },
                    { new Guid("7df95ac8-6383-403c-8ff1-b1f7f44fe8ad"), "/images/Products/title-boxing-bag/title-boxing-bag-3.png", new Guid("70789fa6-f621-4b1c-ba2e-877821b46070") },
                    { new Guid("8261b6d0-b8bf-4f24-9d30-ec6302b805b2"), "/images/Products/rdx-boxing-shoes/rdx-boxing-shoes-1.png", new Guid("25804e3e-6d6c-40c5-b8d0-d3f07efe107e") },
                    { new Guid("83984342-992d-42f6-9672-7c9d91ee81f8"), "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-2.png", new Guid("d2044fab-500f-4f6a-b7b5-6e225f6cedb9") },
                    { new Guid("8a0ebc47-820d-4618-b03f-cd8ef28b37b5"), "/images/Products/ringside-punching-bag/ringside-punching-bag-3.png", new Guid("1450dd84-6138-40f3-8c6e-9f764a9a49e7") },
                    { new Guid("9cfb117a-73ee-4d42-b8e4-56deb03fbc89"), "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-1.png", new Guid("bd2feaf1-5c01-4b07-b7ed-44f3db0c7d8c") },
                    { new Guid("a1b77e0f-a3d5-4e16-bbd9-c12e7ded7e0a"), "/images/Products/ringside-punching-bag/ringside-punching-bag-1.png", new Guid("1450dd84-6138-40f3-8c6e-9f764a9a49e7") },
                    { new Guid("b1df5c02-fcbc-4842-8a3e-7cf453ac5c7f"), "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-1.png", new Guid("d2044fab-500f-4f6a-b7b5-6e225f6cedb9") },
                    { new Guid("bd34b7a8-347f-4684-9ead-4e1a085e7430"), "/images/Products/sanabul-shin-guards/sanabul-shin-guards-1.png", new Guid("4e41e922-61da-4718-ba7c-353d20d46a05") },
                    { new Guid("c31e8296-1560-4fbb-ac5d-7635ca7ebfa4"), "/images/Products/title-boxing-bag/title-boxing-bag-1.png", new Guid("70789fa6-f621-4b1c-ba2e-877821b46070") },
                    { new Guid("c823169f-7615-42dd-96ec-509493c83917"), "/images/Products/rdx-boxing-shoes/rdx-boxing-shoes-2.png", new Guid("25804e3e-6d6c-40c5-b8d0-d3f07efe107e") },
                    { new Guid("f13ba724-f883-49e9-aec5-eabe03bfbd14"), "/images/Products/everlasr-pro-headgear/everlast-headgear-3.png", new Guid("bb2d353f-6d8b-4c3c-9a8c-34c1679717ff") },
                    { new Guid("f15f6896-4167-4f98-b1b2-ba0a0f9392b6"), "/images/Products/everlast-hand-wraps/everlast-hand-wraps-1.png", new Guid("c62dfb64-b442-4f6d-8eb2-788b2a6aec32") },
                    { new Guid("f425df77-63fb-4e85-b422-908a90d7d4de"), "/images/Products/everlast-hand-wraps/everlast-hand-wraps-3.png", new Guid("c62dfb64-b442-4f6d-8eb2-788b2a6aec32") },
                    { new Guid("f430553c-c451-47fe-bcba-d96598995354"), "/images/Products/venum-challenger-gloves/venum-challenger-gloves-3.png", new Guid("353063d8-23af-4de4-a068-55d06aa94a65") },
                    { new Guid("f736a9c9-0dab-4e5a-9c89-62ff9073a1c3"), "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-1.png", new Guid("14a0d82d-a618-47e3-a629-275e30c17e56") }
                });
        }
    }
}
