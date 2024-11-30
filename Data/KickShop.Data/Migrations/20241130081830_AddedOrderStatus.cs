using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KickShop.Migrations
{
    /// <inheritdoc />
    public partial class AddedOrderStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                comment: "The Status Of The Order");

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandId", "Address", "Country", "Description", "ImageUrl", "IsDeleted", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("1d08b21a-b1cf-40a3-8405-1ca352848200"), "678 Fighter Ave, Miami, FL", "USA", "Sanabul is a modern combat sports brand offering stylish and affordable gear. Its products are designed for both beginners and experienced athletes, with a focus on innovation and performance.", "/images/Brands/sanabul-logo.png", false, "Sanabul", "456-789-0123" },
                    { new Guid("38199f38-a5bc-4d87-a169-0e188be11af8"), "567 Martial Arts Blvd, Oklahoma City, OK", "USA", "Century is known for its innovative training gear, including punching bags and protective equipment. Widely used in martial arts and kickboxing, Century products are designed to enhance performance and safety.", "/images/Brands/century-logo.png", false, "Century", "345-678-9012" },
                    { new Guid("56ba66cb-5834-4934-b837-d2b133bf24c5"), "789 Fight St, Toronto, ON", "Canada", "Hayabusa is synonymous with premium quality and cutting-edge technology in combat sports. Their gloves and apparel are designed to provide exceptional protection, performance, and style for fighters at all levels.", "/images/Brands/hayabusa-logo.png", false, "Hayabusa", "789-012-3456" },
                    { new Guid("60ac3437-c62d-43fc-a283-9a5e64876965"), "101 Martial Arts Way, Paris, FR", "France", "Venum is a globally recognized brand known for its bold designs and top-tier combat sports equipment. From gloves to apparel, Venum caters to athletes who demand performance and style in the ring and beyond.", "/images/Brands/venum-logo.png", false, "Venum", "321-654-0987" },
                    { new Guid("7964b8b3-5a31-498f-b309-325d600336f3"), "456 Ring Rd, Chicago, IL", "USA", "Ringside is a trusted name in boxing and kickboxing, providing high-performance equipment and apparel. Its focus on durability and craftsmanship has made it a favorite among gyms and professionals.", "/images/Brands/ringside-logo.png", false, "Ringside", "234-567-8901" },
                    { new Guid("7b0145ed-f9f2-46b1-9f6d-975e514e5277"), "123 Boxing Blvd, New York, NY", "USA", "Known as one of the oldest and most reputable brands in the boxing world, Everlast is a staple in combat sports. From gloves to training equipment, Everlast provides high-quality gear trusted by professional fighters and trainers alike.", "/images/Brands/everlast-logo.png", false, "Everlast", "123-456-7890" },
                    { new Guid("8c8ddec9-78c5-4317-8334-4761db90001a"), "456 Sports Ave, London, UK", "UK", "RDX is renowned for its innovative designs and durable equipment that cater to a wide range of combat sports, including kickboxing, MMA, and boxing. Its focus on affordability and quality makes it a favorite among beginners and professionals.", "/images/Brands/rdx-logo.png", false, "RDX", "456-789-0123" },
                    { new Guid("94841e6c-ed71-4539-b668-1561225a32d5"), "234 Fighter Rd, Bangkok, TH", "Thailand", "Fairtex is a legendary Thai brand specializing in Muay Thai and kickboxing gear. Renowned for its authenticity and quality, Fairtex is the choice of champions in traditional and modern combat sports.", "/images/Brands/fairtex-logo.png", false, "Fairtex", "876-543-2109" },
                    { new Guid("bd0507ce-fa0d-4a77-ac4f-887bdf08091d"), "345 Punch Ln, Los Angeles, CA", "USA", "Title Boxing is a leading brand offering an extensive range of boxing and kickboxing gear. Known for its reliability and innovation, Title Boxing supports athletes with training and competition essentials.", "/images/Brands/title-boxing-logo.png", false, "Title Boxing", "987-654-3210" },
                    { new Guid("e80dee77-e1c8-4e99-bfff-4593e3a6c3bb"), "789 Kick Rd, Phuket, TH", "Thailand", "Twins Special is a renowned brand in Muay Thai and kickboxing, celebrated for its handcrafted gear. Their gloves and pads are known for their durability, quality, and traditional Thai craftsmanship.", "/images/Brands/twins-special-logo.png", false, "Twins Special", "567-890-1234" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "ImageUrl", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { new Guid("250936ca-4c53-46f1-b434-1ba2f9eea517"), "/images/Categories/training-equipment.png", false, "Training Equipment" },
                    { new Guid("2ec7c695-5dce-4a54-9bfd-ca712740676f"), "/images/Categegories/boxing-gloves.jfif", false, "Gloves" },
                    { new Guid("34714b31-ac14-41e4-88d5-0048542bbdce"), "/images/Categories/punching-bag.png", false, "Punching Bags" },
                    { new Guid("479fbb1b-4abf-4dc9-a6c8-5a9cb91fa783"), "/images/Categories/mouth-guard.png", false, "Mouthguards" },
                    { new Guid("4ebbc604-f734-4a1c-89e6-65f2c5fd83df"), "/images/Categories/hand-wraps.png", false, "Hand Wraps" },
                    { new Guid("53d50852-2065-4ddd-be05-9edfad07f74c"), "/images/Categories/shin-guards.png", false, "Shinguards" },
                    { new Guid("6bf9a0c4-49a7-47e7-a716-6fcdf1731b0c"), "/images/Categories/boxing-shoes.png", false, "Shoes" },
                    { new Guid("90052465-516f-4789-9bd4-5566d5e49e61"), "/images/Categories/head-gear.png", false, "Headgear" },
                    { new Guid("d5dca49b-ee6c-4a00-b4d4-b4139b1f32d0"), "/images/Categories/protective-equipment.jfif", false, "Protective Gear" },
                    { new Guid("f5b3dee1-b256-45f5-8c6a-e7060db34c53"), "/images/Categories/clothing.png", false, "Clothing" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "BrandId", "CategoryId", "Description", "IsDeleted", "MainImageUrl", "Name", "Price", "Sizes", "StockQuantity" },
                values: new object[,]
                {
                    { new Guid("09eb5b51-9dff-4e58-8876-6fd1f02e5c98"), new Guid("56ba66cb-5834-4934-b837-d2b133bf24c5"), new Guid("2ec7c695-5dce-4a54-9bfd-ca712740676f"), "Top-notch gloves with exceptional durability.", false, "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-1.png", "Hayabusa T3 Boxing Gloves", 189.99m, "[2,3,4]", 50 },
                    { new Guid("0c352e41-43eb-4cab-baff-f226c5f96bc1"), new Guid("60ac3437-c62d-43fc-a283-9a5e64876965"), new Guid("2ec7c695-5dce-4a54-9bfd-ca712740676f"), "Lightweight and designed for all skill levels.", false, "/images/Products/venum-challenger-gloves/venum-challenger-gloves-2.png", "Venum Challenger Gloves", 89.99m, "[1,2,3]", 120 },
                    { new Guid("23a4b2d9-bb00-4474-b563-5fa13806a622"), new Guid("bd0507ce-fa0d-4a77-ac4f-887bdf08091d"), new Guid("34714b31-ac14-41e4-88d5-0048542bbdce"), "Perfect for accuracy and reflex training.", false, "/images/Products/title-boxing-gloves/title-boxing-gloves-1.png", "Title Boxing Double End Bag", 99.99m, "[3]", 70 },
                    { new Guid("58006584-f63a-4b03-8dc2-e2c0a8007578"), new Guid("8c8ddec9-78c5-4317-8334-4761db90001a"), new Guid("6bf9a0c4-49a7-47e7-a716-6fcdf1731b0c"), "Lightweight and supportive for agility in the ring.", false, "/images/Products/rdx-boxing-shoes/rdx-boxing-shoes-1.png", "RDX Pro Boxing Shoes", 109.99m, "[2,3,4]", 65 },
                    { new Guid("6b4e0e29-8962-403c-b8db-ee1493f57b92"), new Guid("38199f38-a5bc-4d87-a169-0e188be11af8"), new Guid("f5b3dee1-b256-45f5-8c6a-e7060db34c53"), "Comfortable shorts designed for kickboxing.", false, "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-1.png", "Century Martial Arts Kickboxing Shorts", 79.99m, "[2,3,4]", 75 },
                    { new Guid("6c36b256-8cd6-40a8-a74a-cb9399b6e029"), new Guid("94841e6c-ed71-4539-b668-1561225a32d5"), new Guid("f5b3dee1-b256-45f5-8c6a-e7060db34c53"), "Premium Muay Thai shorts with authentic design.", false, "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-1.png", "Fairtex Muay Thai Shorts", 84.99m, "[2,3,4]", 90 },
                    { new Guid("76d76855-3bc1-4c37-81a8-f3e50ff806a1"), new Guid("60ac3437-c62d-43fc-a283-9a5e64876965"), new Guid("53d50852-2065-4ddd-be05-9edfad07f74c"), "High-durability shin guards ideal for intense training.", false, "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-1.png", "Venum Challenger Shin Guards", 105.99m, "[1,2,3]", 95 },
                    { new Guid("9bf94695-68a6-4fde-8acd-20ea9f83db89"), new Guid("bd0507ce-fa0d-4a77-ac4f-887bdf08091d"), new Guid("2ec7c695-5dce-4a54-9bfd-ca712740676f"), "Durable leather gloves for heavy bag workouts.", false, "/images/Products/title-boxing-bag/title-boxing-bag-1.png", "Title Boxing Leather Bag Gloves", 79.99m, "[2,3]", 80 },
                    { new Guid("ac4146c2-58d8-40e7-9ad8-ea556962d5dd"), new Guid("1d08b21a-b1cf-40a3-8405-1ca352848200"), new Guid("53d50852-2065-4ddd-be05-9edfad07f74c"), "High-quality shin guards for protection and mobility.", false, "/images/Products/sanabul-shin-guards/sanabul-shin-guards-1.png", "Sanabul Essential Shin Guards", 105.99m, "[2,3,4]", 90 },
                    { new Guid("ae8ac464-46e0-45b7-93b8-3b4f332e2c6e"), new Guid("7b0145ed-f9f2-46b1-9f6d-975e514e5277"), new Guid("90052465-516f-4789-9bd4-5566d5e49e61"), "Full-protection headgear with durable padding.", false, "/images/Products/everlast-pro-headgear/everlast-headgear-1.png", "Everlast Pro Headgear", 89.99m, "[2,3]", 50 },
                    { new Guid("c3e223c6-8b0f-475a-9333-2e67ffd08efd"), new Guid("7964b8b3-5a31-498f-b309-325d600336f3"), new Guid("34714b31-ac14-41e4-88d5-0048542bbdce"), "Heavy-duty bag for all levels of training.", false, "/images/Products/ringside-punching-bag/ringside-punching-bag-1.png", "Ringside Punching Bag", 219.99m, "[3]", 40 },
                    { new Guid("e4f7340c-8af7-47cb-92f7-b739b58585ed"), new Guid("8c8ddec9-78c5-4317-8334-4761db90001a"), new Guid("2ec7c695-5dce-4a54-9bfd-ca712740676f"), "High-quality leather gloves for all training levels.", false, "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-3.png", "RDX Boxing Gloves", 109.99m, "[1,2,3]", 100 },
                    { new Guid("e645da3d-8af0-411f-9bf0-7100476ba727"), new Guid("7b0145ed-f9f2-46b1-9f6d-975e514e5277"), new Guid("4ebbc604-f734-4a1c-89e6-65f2c5fd83df"), "Classic wraps for wrist and knuckle protection.", false, "/images/Products/everlast-hand-wraps/everlast-hand-wraps-3.png", "Everlast Hand Wraps", 9.99m, "[2,3]", 200 },
                    { new Guid("f73284b3-0e00-49bf-ace0-1743980be512"), new Guid("e80dee77-e1c8-4e99-bfff-4593e3a6c3bb"), new Guid("90052465-516f-4789-9bd4-5566d5e49e61"), "Full-face protection with Twins quality.", false, "/images/Products/twins-special-headgear/twins-special-headgear-1.png", "Twins Special Headgear", 89.99m, "[1,2,3]", 60 }
                });

            migrationBuilder.InsertData(
                table: "ProductsImages",
                columns: new[] { "ImageId", "ImageUrl", "ProductId" },
                values: new object[,]
                {
                    { new Guid("16346e54-0a18-4322-8101-f4ca6f4ff416"), "/images/Products/everlast-hand-wraps/everlast-hand-wraps-2.png", new Guid("e645da3d-8af0-411f-9bf0-7100476ba727") },
                    { new Guid("1f9aa35c-37fb-4c1c-9870-f1d1959440fc"), "/images/Products/venum-challenger-gloves/venum-challenger-gloves-3.png", new Guid("0c352e41-43eb-4cab-baff-f226c5f96bc1") },
                    { new Guid("236b6813-aad4-4fe6-a7b8-c5dcc088a107"), "/images/Products/rdx-boxing-shoes/rdx-boxing-shoes-1.png", new Guid("58006584-f63a-4b03-8dc2-e2c0a8007578") },
                    { new Guid("2e3775ec-9a85-49f1-bb73-cec0eab9c321"), "/images/Products/everlast-hand-wraps/everlast-hand-wraps-1.png", new Guid("e645da3d-8af0-411f-9bf0-7100476ba727") },
                    { new Guid("2e6ac40a-1136-4da4-a244-deb454eb7f19"), "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-2.png", new Guid("09eb5b51-9dff-4e58-8876-6fd1f02e5c98") },
                    { new Guid("3a186f5e-82f1-40d0-9e19-c87c9c184705"), "/images/Products/rdx-boxing-shoes/rdx-boxing-shoes-3.png", new Guid("58006584-f63a-4b03-8dc2-e2c0a8007578") },
                    { new Guid("3b9dc145-cab1-41bf-b29b-869b50e30278"), "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-2.png", new Guid("76d76855-3bc1-4c37-81a8-f3e50ff806a1") },
                    { new Guid("3d6e22b7-22e4-43f7-b5b8-af0944c616ca"), "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-2.png", new Guid("6c36b256-8cd6-40a8-a74a-cb9399b6e029") },
                    { new Guid("48a42c81-24d4-4e9f-aaf6-62cc5fa96072"), "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-1.png", new Guid("09eb5b51-9dff-4e58-8876-6fd1f02e5c98") },
                    { new Guid("4dcfd955-bd43-4ec6-a0b1-edff8327246c"), "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-3.png", new Guid("6b4e0e29-8962-403c-b8db-ee1493f57b92") },
                    { new Guid("566919bd-f6b7-4234-afa6-020390425c28"), "/images/Products/twins-special-headgear/twins-special-headgear-2.png", new Guid("f73284b3-0e00-49bf-ace0-1743980be512") },
                    { new Guid("5b5c069c-bf5b-4a9e-83cc-f184f54d483c"), "/images/Products/twins-special-headgear/twins-special-headgear-1.png", new Guid("f73284b3-0e00-49bf-ace0-1743980be512") },
                    { new Guid("66f2a6d3-a07a-4527-89f8-048cb97904cb"), "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-1.png", new Guid("6c36b256-8cd6-40a8-a74a-cb9399b6e029") },
                    { new Guid("6a7ef4e7-9537-4550-943e-6789a69ca95d"), "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-3.png", new Guid("09eb5b51-9dff-4e58-8876-6fd1f02e5c98") },
                    { new Guid("6d9d1468-6906-411f-9d98-c2fd92c8ac0e"), "/images/Products/title-boxing-gloves/title-boxing-gloves-3.png", new Guid("23a4b2d9-bb00-4474-b563-5fa13806a622") },
                    { new Guid("70fb52a3-a4c6-4325-8e9e-a06d17fae776"), "/images/Products/venum-challenger-gloves/venum-challenger-gloves-2.png", new Guid("0c352e41-43eb-4cab-baff-f226c5f96bc1") },
                    { new Guid("71bae4ff-a1b3-4764-b193-3a86916a2e3a"), "/images/Products/ringside-punching-bag/ringside-punching-bag-3.png", new Guid("c3e223c6-8b0f-475a-9333-2e67ffd08efd") },
                    { new Guid("738c4998-cca8-4dd2-8de6-7f85e90999b7"), "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-1.png", new Guid("e4f7340c-8af7-47cb-92f7-b739b58585ed") },
                    { new Guid("7a58c340-c965-4974-96b2-28bdfa4fc299"), "/images/Products/title-boxing-bag/title-boxing-bag-1.png", new Guid("9bf94695-68a6-4fde-8acd-20ea9f83db89") },
                    { new Guid("7a826c9b-e432-498e-ba42-4fa5625933e9"), "/images/Products/title-boxing-gloves/title-boxing-gloves-1.png", new Guid("23a4b2d9-bb00-4474-b563-5fa13806a622") },
                    { new Guid("7c7f7d92-45d9-443f-b3a5-acffd9ae7775"), "/images/Products/ringside-punching-bag/ringside-punching-bag-2.png", new Guid("c3e223c6-8b0f-475a-9333-2e67ffd08efd") },
                    { new Guid("8214822d-071e-47dd-b9ec-f3c2d975a4c6"), "/images/Products/title-boxing-bag/title-boxing-bag-3.png", new Guid("9bf94695-68a6-4fde-8acd-20ea9f83db89") },
                    { new Guid("8889c023-71fe-4b82-92d5-06996fbb5dd6"), "/images/Products/twins-special-headgear/twins-shin-headgear-3.png", new Guid("f73284b3-0e00-49bf-ace0-1743980be512") },
                    { new Guid("89c761f6-a150-4a89-b286-062fddcd6ce6"), "/images/Products/everlasr-pro-headgear/everlast-headgear-3.png", new Guid("ae8ac464-46e0-45b7-93b8-3b4f332e2c6e") },
                    { new Guid("9533ccf2-1866-438b-9692-0083138a228a"), "/images/Products/title-boxing-gloves/title-boxing-gloves-2.png", new Guid("23a4b2d9-bb00-4474-b563-5fa13806a622") },
                    { new Guid("9b1d8894-2197-4c75-bd16-515fd6dd021a"), "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-1.png", new Guid("76d76855-3bc1-4c37-81a8-f3e50ff806a1") },
                    { new Guid("9b28fce3-8b6c-4141-905f-9ed58f499951"), "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-2.png", new Guid("e4f7340c-8af7-47cb-92f7-b739b58585ed") },
                    { new Guid("aab7aa3c-8b15-4a45-aaaa-02a9897b0ee5"), "/images/Products/sanabul-shin-guards/sanabul-shin-guards-3.png", new Guid("ac4146c2-58d8-40e7-9ad8-ea556962d5dd") },
                    { new Guid("ad06ddfb-1a89-4626-85c7-c276d47ddcd9"), "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-1.png", new Guid("6b4e0e29-8962-403c-b8db-ee1493f57b92") },
                    { new Guid("b53c38e3-d140-4c74-b70a-a1160ecc07ce"), "/images/Products/sanabul-shin-guards/sanabul-shin-guards-2.png", new Guid("ac4146c2-58d8-40e7-9ad8-ea556962d5dd") },
                    { new Guid("bbb90119-be29-4724-8a55-237df88e8585"), "/images/Products/everlasr-pro-headgear/everlast-headgear-1.png", new Guid("ae8ac464-46e0-45b7-93b8-3b4f332e2c6e") },
                    { new Guid("bca1e44a-b3f1-426f-bd66-dfa77b5e412b"), "/images/Products/title-boxing-bag/title-boxing-bag-2.png", new Guid("9bf94695-68a6-4fde-8acd-20ea9f83db89") },
                    { new Guid("c304ed67-ddc4-4f4a-a742-d8a28ae9aee2"), "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-3.png", new Guid("76d76855-3bc1-4c37-81a8-f3e50ff806a1") },
                    { new Guid("c522b9be-714c-45be-8dac-18c8639af407"), "/images/Products/venum-challenger-gloves/venum-challenger-gloves-1.png", new Guid("0c352e41-43eb-4cab-baff-f226c5f96bc1") },
                    { new Guid("c7ce57e2-aa51-4a81-9661-33698cd170f9"), "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-2.png", new Guid("6b4e0e29-8962-403c-b8db-ee1493f57b92") },
                    { new Guid("d6383b20-7dec-40c5-bb84-fe5b371b6599"), "/images/Products/ringside-punching-bag/ringside-punching-bag-1.png", new Guid("c3e223c6-8b0f-475a-9333-2e67ffd08efd") },
                    { new Guid("e272bf8d-201f-49a5-8687-562adec8584c"), "/images/Products/sanabul-shin-guards/sanabul-shin-guards-1.png", new Guid("ac4146c2-58d8-40e7-9ad8-ea556962d5dd") },
                    { new Guid("e9a10b62-23bc-4698-999e-575efc861037"), "/images/Products/everlasr-pro-headgear/everlast-headgear-2.png", new Guid("ae8ac464-46e0-45b7-93b8-3b4f332e2c6e") },
                    { new Guid("ed5603a9-ab21-438f-b9ff-995fe568f71f"), "/images/Products/rdx-boxing-shoes/rdx-boxing-shoes-2.png", new Guid("58006584-f63a-4b03-8dc2-e2c0a8007578") },
                    { new Guid("ef13aeb8-dea4-4db7-8144-0c7e443cb749"), "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-3.png", new Guid("6c36b256-8cd6-40a8-a74a-cb9399b6e029") },
                    { new Guid("f2e30a0a-cd92-43a0-a53c-f0f7a9aed289"), "/images/Products/everlast-hand-wraps/everlast-hand-wraps-3.png", new Guid("e645da3d-8af0-411f-9bf0-7100476ba727") },
                    { new Guid("fbf15674-33ed-4a97-9d53-83023800aaad"), "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-3.png", new Guid("e4f7340c-8af7-47cb-92f7-b739b58585ed") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("250936ca-4c53-46f1-b434-1ba2f9eea517"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("479fbb1b-4abf-4dc9-a6c8-5a9cb91fa783"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("d5dca49b-ee6c-4a00-b4d4-b4139b1f32d0"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("16346e54-0a18-4322-8101-f4ca6f4ff416"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("1f9aa35c-37fb-4c1c-9870-f1d1959440fc"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("236b6813-aad4-4fe6-a7b8-c5dcc088a107"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("2e3775ec-9a85-49f1-bb73-cec0eab9c321"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("2e6ac40a-1136-4da4-a244-deb454eb7f19"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("3a186f5e-82f1-40d0-9e19-c87c9c184705"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("3b9dc145-cab1-41bf-b29b-869b50e30278"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("3d6e22b7-22e4-43f7-b5b8-af0944c616ca"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("48a42c81-24d4-4e9f-aaf6-62cc5fa96072"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("4dcfd955-bd43-4ec6-a0b1-edff8327246c"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("566919bd-f6b7-4234-afa6-020390425c28"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("5b5c069c-bf5b-4a9e-83cc-f184f54d483c"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("66f2a6d3-a07a-4527-89f8-048cb97904cb"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("6a7ef4e7-9537-4550-943e-6789a69ca95d"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("6d9d1468-6906-411f-9d98-c2fd92c8ac0e"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("70fb52a3-a4c6-4325-8e9e-a06d17fae776"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("71bae4ff-a1b3-4764-b193-3a86916a2e3a"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("738c4998-cca8-4dd2-8de6-7f85e90999b7"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("7a58c340-c965-4974-96b2-28bdfa4fc299"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("7a826c9b-e432-498e-ba42-4fa5625933e9"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("7c7f7d92-45d9-443f-b3a5-acffd9ae7775"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("8214822d-071e-47dd-b9ec-f3c2d975a4c6"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("8889c023-71fe-4b82-92d5-06996fbb5dd6"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("89c761f6-a150-4a89-b286-062fddcd6ce6"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("9533ccf2-1866-438b-9692-0083138a228a"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("9b1d8894-2197-4c75-bd16-515fd6dd021a"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("9b28fce3-8b6c-4141-905f-9ed58f499951"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("aab7aa3c-8b15-4a45-aaaa-02a9897b0ee5"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("ad06ddfb-1a89-4626-85c7-c276d47ddcd9"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("b53c38e3-d140-4c74-b70a-a1160ecc07ce"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("bbb90119-be29-4724-8a55-237df88e8585"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("bca1e44a-b3f1-426f-bd66-dfa77b5e412b"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("c304ed67-ddc4-4f4a-a742-d8a28ae9aee2"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("c522b9be-714c-45be-8dac-18c8639af407"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("c7ce57e2-aa51-4a81-9661-33698cd170f9"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("d6383b20-7dec-40c5-bb84-fe5b371b6599"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("e272bf8d-201f-49a5-8687-562adec8584c"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("e9a10b62-23bc-4698-999e-575efc861037"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("ed5603a9-ab21-438f-b9ff-995fe568f71f"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("ef13aeb8-dea4-4db7-8144-0c7e443cb749"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("f2e30a0a-cd92-43a0-a53c-f0f7a9aed289"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("fbf15674-33ed-4a97-9d53-83023800aaad"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("09eb5b51-9dff-4e58-8876-6fd1f02e5c98"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("0c352e41-43eb-4cab-baff-f226c5f96bc1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("23a4b2d9-bb00-4474-b563-5fa13806a622"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("58006584-f63a-4b03-8dc2-e2c0a8007578"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6b4e0e29-8962-403c-b8db-ee1493f57b92"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6c36b256-8cd6-40a8-a74a-cb9399b6e029"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("76d76855-3bc1-4c37-81a8-f3e50ff806a1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("9bf94695-68a6-4fde-8acd-20ea9f83db89"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("ac4146c2-58d8-40e7-9ad8-ea556962d5dd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("ae8ac464-46e0-45b7-93b8-3b4f332e2c6e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c3e223c6-8b0f-475a-9333-2e67ffd08efd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e4f7340c-8af7-47cb-92f7-b739b58585ed"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e645da3d-8af0-411f-9bf0-7100476ba727"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f73284b3-0e00-49bf-ace0-1743980be512"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("1d08b21a-b1cf-40a3-8405-1ca352848200"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("38199f38-a5bc-4d87-a169-0e188be11af8"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("56ba66cb-5834-4934-b837-d2b133bf24c5"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("60ac3437-c62d-43fc-a283-9a5e64876965"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("7964b8b3-5a31-498f-b309-325d600336f3"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("7b0145ed-f9f2-46b1-9f6d-975e514e5277"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("8c8ddec9-78c5-4317-8334-4761db90001a"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("94841e6c-ed71-4539-b668-1561225a32d5"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("bd0507ce-fa0d-4a77-ac4f-887bdf08091d"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("e80dee77-e1c8-4e99-bfff-4593e3a6c3bb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("2ec7c695-5dce-4a54-9bfd-ca712740676f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("34714b31-ac14-41e4-88d5-0048542bbdce"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("4ebbc604-f734-4a1c-89e6-65f2c5fd83df"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("53d50852-2065-4ddd-be05-9edfad07f74c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("6bf9a0c4-49a7-47e7-a716-6fcdf1731b0c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("90052465-516f-4789-9bd4-5566d5e49e61"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f5b3dee1-b256-45f5-8c6a-e7060db34c53"));

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Orders");

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
    }
}
