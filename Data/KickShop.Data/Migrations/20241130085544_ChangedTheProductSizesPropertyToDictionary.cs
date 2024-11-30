using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KickShop.Migrations
{
    /// <inheritdoc />
    public partial class ChangedTheProductSizesPropertyToDictionary : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "Sizes",
                table: "Products");

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandId", "Address", "Country", "Description", "ImageUrl", "IsDeleted", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("07d7cc18-51ac-4af6-b7dc-57d4e866db8e"), "101 Martial Arts Way, Paris, FR", "France", "Venum is a globally recognized brand known for its bold designs and top-tier combat sports equipment. From gloves to apparel, Venum caters to athletes who demand performance and style in the ring and beyond.", "/images/Brands/venum-logo.png", false, "Venum", "321-654-0987" },
                    { new Guid("1e856569-f4bf-4b6e-bf9f-60dcfeda2128"), "456 Sports Ave, London, UK", "UK", "RDX is renowned for its innovative designs and durable equipment that cater to a wide range of combat sports, including kickboxing, MMA, and boxing. Its focus on affordability and quality makes it a favorite among beginners and professionals.", "/images/Brands/rdx-logo.png", false, "RDX", "456-789-0123" },
                    { new Guid("40a9fe49-d6e4-4fc3-b8d2-e7558f51edbd"), "456 Ring Rd, Chicago, IL", "USA", "Ringside is a trusted name in boxing and kickboxing, providing high-performance equipment and apparel. Its focus on durability and craftsmanship has made it a favorite among gyms and professionals.", "/images/Brands/ringside-logo.png", false, "Ringside", "234-567-8901" },
                    { new Guid("51ef4706-3d2f-4cfd-adfb-a74a372c9bc7"), "789 Kick Rd, Phuket, TH", "Thailand", "Twins Special is a renowned brand in Muay Thai and kickboxing, celebrated for its handcrafted gear. Their gloves and pads are known for their durability, quality, and traditional Thai craftsmanship.", "/images/Brands/twins-special-logo.png", false, "Twins Special", "567-890-1234" },
                    { new Guid("7b07b813-715c-4f32-aaf7-5998a9ef9fea"), "123 Boxing Blvd, New York, NY", "USA", "Known as one of the oldest and most reputable brands in the boxing world, Everlast is a staple in combat sports. From gloves to training equipment, Everlast provides high-quality gear trusted by professional fighters and trainers alike.", "/images/Brands/everlast-logo.png", false, "Everlast", "123-456-7890" },
                    { new Guid("7c7fc24a-7aa9-4f1d-b740-3e1a352db473"), "234 Fighter Rd, Bangkok, TH", "Thailand", "Fairtex is a legendary Thai brand specializing in Muay Thai and kickboxing gear. Renowned for its authenticity and quality, Fairtex is the choice of champions in traditional and modern combat sports.", "/images/Brands/fairtex-logo.png", false, "Fairtex", "876-543-2109" },
                    { new Guid("7f813c1c-1ac0-4585-855e-06c34b87606d"), "345 Punch Ln, Los Angeles, CA", "USA", "Title Boxing is a leading brand offering an extensive range of boxing and kickboxing gear. Known for its reliability and innovation, Title Boxing supports athletes with training and competition essentials.", "/images/Brands/title-boxing-logo.png", false, "Title Boxing", "987-654-3210" },
                    { new Guid("84ab32db-7d9e-4771-910b-65054289f10a"), "678 Fighter Ave, Miami, FL", "USA", "Sanabul is a modern combat sports brand offering stylish and affordable gear. Its products are designed for both beginners and experienced athletes, with a focus on innovation and performance.", "/images/Brands/sanabul-logo.png", false, "Sanabul", "456-789-0123" },
                    { new Guid("8f76a962-b423-4430-b95c-2d3552811aea"), "567 Martial Arts Blvd, Oklahoma City, OK", "USA", "Century is known for its innovative training gear, including punching bags and protective equipment. Widely used in martial arts and kickboxing, Century products are designed to enhance performance and safety.", "/images/Brands/century-logo.png", false, "Century", "345-678-9012" },
                    { new Guid("dff59b10-133b-4359-b6ad-7a320badfcfd"), "789 Fight St, Toronto, ON", "Canada", "Hayabusa is synonymous with premium quality and cutting-edge technology in combat sports. Their gloves and apparel are designed to provide exceptional protection, performance, and style for fighters at all levels.", "/images/Brands/hayabusa-logo.png", false, "Hayabusa", "789-012-3456" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "ImageUrl", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { new Guid("02d33169-816b-4124-b19b-1ab460aead11"), "/images/Categories/head-gear.png", false, "Headgear" },
                    { new Guid("2b7b6cde-11be-45a4-99b3-bcffad661dde"), "/images/Categegories/boxing-gloves.jfif", false, "Gloves" },
                    { new Guid("2f25bc4b-87b7-4b47-9126-a30332fbe397"), "/images/Categories/hand-wraps.png", false, "Hand Wraps" },
                    { new Guid("2f8a9cbd-e546-459e-959f-c6ad91e0ac9d"), "/images/Categories/training-equipment.png", false, "Training Equipment" },
                    { new Guid("596c958d-e148-4535-92fa-25d245876e92"), "/images/Categories/shin-guards.png", false, "Shinguards" },
                    { new Guid("938f77ae-15bc-46b2-a10e-15a6af5a33d8"), "/images/Categories/boxing-shoes.png", false, "Shoes" },
                    { new Guid("accd75a9-5ef3-4313-8e8b-8a34410ac4e4"), "/images/Categories/clothing.png", false, "Clothing" },
                    { new Guid("bcb29901-22c1-4f57-8372-ef46a2bca510"), "/images/Categories/punching-bag.png", false, "Punching Bags" },
                    { new Guid("d45719cf-3e1f-4308-8ab5-adc19f9a9eef"), "/images/Categories/protective-equipment.jfif", false, "Protective Gear" },
                    { new Guid("d8fc6540-4ca6-4119-9dd4-239d79e24126"), "/images/Categories/mouth-guard.png", false, "Mouthguards" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "BrandId", "CategoryId", "Description", "IsDeleted", "MainImageUrl", "Name", "Price", "StockQuantity" },
                values: new object[,]
                {
                    { new Guid("0fd07c67-fad8-46a7-b579-9683b6b1c15e"), new Guid("1e856569-f4bf-4b6e-bf9f-60dcfeda2128"), new Guid("2b7b6cde-11be-45a4-99b3-bcffad661dde"), "High-quality leather gloves for all training levels.", false, "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-3.png", "RDX Boxing Gloves", 109.99m, 100 },
                    { new Guid("149df23c-f0b7-4bfc-bc34-b54bf02a7273"), new Guid("07d7cc18-51ac-4af6-b7dc-57d4e866db8e"), new Guid("2b7b6cde-11be-45a4-99b3-bcffad661dde"), "Lightweight and designed for all skill levels.", false, "/images/Products/venum-challenger-gloves/venum-challenger-gloves-2.png", "Venum Challenger Gloves", 89.99m, 120 },
                    { new Guid("179fc071-2879-4577-b497-1e8c432dbeec"), new Guid("7b07b813-715c-4f32-aaf7-5998a9ef9fea"), new Guid("2f25bc4b-87b7-4b47-9126-a30332fbe397"), "Classic wraps for wrist and knuckle protection.", false, "/images/Products/everlast-hand-wraps/everlast-hand-wraps-3.png", "Everlast Hand Wraps", 9.99m, 200 },
                    { new Guid("1fef6e18-9c47-4a74-b2a2-9d3c4c22cb4e"), new Guid("84ab32db-7d9e-4771-910b-65054289f10a"), new Guid("596c958d-e148-4535-92fa-25d245876e92"), "High-quality shin guards for protection and mobility.", false, "/images/Products/sanabul-shin-guards/sanabul-shin-guards-1.png", "Sanabul Essential Shin Guards", 105.99m, 90 },
                    { new Guid("4f72823b-5662-4921-9378-704711e39e86"), new Guid("8f76a962-b423-4430-b95c-2d3552811aea"), new Guid("accd75a9-5ef3-4313-8e8b-8a34410ac4e4"), "Comfortable shorts designed for kickboxing.", false, "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-1.png", "Century Martial Arts Kickboxing Shorts", 79.99m, 75 },
                    { new Guid("8c9ce9ae-d539-4a36-ace8-f897db14a321"), new Guid("7c7fc24a-7aa9-4f1d-b740-3e1a352db473"), new Guid("accd75a9-5ef3-4313-8e8b-8a34410ac4e4"), "Premium Muay Thai shorts with authentic design.", false, "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-1.png", "Fairtex Muay Thai Shorts", 84.99m, 90 },
                    { new Guid("948e533c-0a9f-4958-92b6-2564dcb2ada9"), new Guid("7f813c1c-1ac0-4585-855e-06c34b87606d"), new Guid("2b7b6cde-11be-45a4-99b3-bcffad661dde"), "Durable leather gloves for heavy bag workouts.", false, "/images/Products/title-boxing-bag/title-boxing-bag-1.png", "Title Boxing Leather Bag Gloves", 79.99m, 80 },
                    { new Guid("a00e221c-ae77-42c3-8811-f07361c55902"), new Guid("07d7cc18-51ac-4af6-b7dc-57d4e866db8e"), new Guid("596c958d-e148-4535-92fa-25d245876e92"), "High-durability shin guards ideal for intense training.", false, "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-1.png", "Venum Challenger Shin Guards", 105.99m, 95 },
                    { new Guid("bdddadb7-f13b-4867-bb1c-cc933232b392"), new Guid("51ef4706-3d2f-4cfd-adfb-a74a372c9bc7"), new Guid("02d33169-816b-4124-b19b-1ab460aead11"), "Full-face protection with Twins quality.", false, "/images/Products/twins-special-headgear/twins-special-headgear-1.png", "Twins Special Headgear", 89.99m, 60 },
                    { new Guid("c3e50f89-3446-4a29-bed1-3b4606298583"), new Guid("7f813c1c-1ac0-4585-855e-06c34b87606d"), new Guid("bcb29901-22c1-4f57-8372-ef46a2bca510"), "Perfect for accuracy and reflex training.", false, "/images/Products/title-boxing-gloves/title-boxing-gloves-1.png", "Title Boxing Double End Bag", 99.99m, 70 },
                    { new Guid("cbde7c61-88b4-4ecc-82f8-3efa6aa46c3f"), new Guid("1e856569-f4bf-4b6e-bf9f-60dcfeda2128"), new Guid("938f77ae-15bc-46b2-a10e-15a6af5a33d8"), "Lightweight and supportive for agility in the ring.", false, "/images/Products/rdx-boxing-shoes/rdx-boxing-shoes-1.png", "RDX Pro Boxing Shoes", 109.99m, 65 },
                    { new Guid("d3f5c99c-1284-436a-bede-72d49ded85ca"), new Guid("40a9fe49-d6e4-4fc3-b8d2-e7558f51edbd"), new Guid("bcb29901-22c1-4f57-8372-ef46a2bca510"), "Heavy-duty bag for all levels of training.", false, "/images/Products/ringside-punching-bag/ringside-punching-bag-1.png", "Ringside Punching Bag", 219.99m, 40 },
                    { new Guid("d80db6a3-d70d-48d0-9986-7779c351e0b1"), new Guid("dff59b10-133b-4359-b6ad-7a320badfcfd"), new Guid("2b7b6cde-11be-45a4-99b3-bcffad661dde"), "Top-notch gloves with exceptional durability.", false, "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-1.png", "Hayabusa T3 Boxing Gloves", 189.99m, 50 },
                    { new Guid("fecc0ec5-451d-4637-bd40-e4fdc7af64f7"), new Guid("7b07b813-715c-4f32-aaf7-5998a9ef9fea"), new Guid("02d33169-816b-4124-b19b-1ab460aead11"), "Full-protection headgear with durable padding.", false, "/images/Products/everlast-pro-headgear/everlast-headgear-1.png", "Everlast Pro Headgear", 89.99m, 50 }
                });

            migrationBuilder.InsertData(
                table: "ProductsImages",
                columns: new[] { "ImageId", "ImageUrl", "ProductId" },
                values: new object[,]
                {
                    { new Guid("005ec700-6a99-4cb4-850f-30c1748ef997"), "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-3.png", new Guid("4f72823b-5662-4921-9378-704711e39e86") },
                    { new Guid("01686f6d-b85e-4036-a299-7b002eec017d"), "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-1.png", new Guid("a00e221c-ae77-42c3-8811-f07361c55902") },
                    { new Guid("14a575db-a50e-48cd-83d0-fa8dbd9bec64"), "/images/Products/venum-challenger-gloves/venum-challenger-gloves-2.png", new Guid("149df23c-f0b7-4bfc-bc34-b54bf02a7273") },
                    { new Guid("1a1779bc-0597-4c5a-b9b7-5a3e7342f183"), "/images/Products/sanabul-shin-guards/sanabul-shin-guards-2.png", new Guid("1fef6e18-9c47-4a74-b2a2-9d3c4c22cb4e") },
                    { new Guid("2111ba1d-ee99-4e81-ad5f-f15aedc95954"), "/images/Products/title-boxing-bag/title-boxing-bag-1.png", new Guid("948e533c-0a9f-4958-92b6-2564dcb2ada9") },
                    { new Guid("2d1b510c-e349-4334-9b7b-fed0d010a7ce"), "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-1.png", new Guid("0fd07c67-fad8-46a7-b579-9683b6b1c15e") },
                    { new Guid("2f8cee97-8d5b-41e8-aa14-9311278e1f7b"), "/images/Products/sanabul-shin-guards/sanabul-shin-guards-1.png", new Guid("1fef6e18-9c47-4a74-b2a2-9d3c4c22cb4e") },
                    { new Guid("312494b7-82fc-43fe-9f9e-242fc979e752"), "/images/Products/everlasr-pro-headgear/everlast-headgear-3.png", new Guid("fecc0ec5-451d-4637-bd40-e4fdc7af64f7") },
                    { new Guid("385029b6-1eea-4cdd-ab87-e93772ed708f"), "/images/Products/everlast-hand-wraps/everlast-hand-wraps-3.png", new Guid("179fc071-2879-4577-b497-1e8c432dbeec") },
                    { new Guid("39c59192-aff8-4586-86fa-23cddc5f0d16"), "/images/Products/twins-special-headgear/twins-special-headgear-2.png", new Guid("bdddadb7-f13b-4867-bb1c-cc933232b392") },
                    { new Guid("4e3a87f5-1e3e-49a7-8a88-fa1b33cfb248"), "/images/Products/title-boxing-gloves/title-boxing-gloves-1.png", new Guid("c3e50f89-3446-4a29-bed1-3b4606298583") },
                    { new Guid("57fb654d-8dee-4470-84f9-7eeb27da2caa"), "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-2.png", new Guid("d80db6a3-d70d-48d0-9986-7779c351e0b1") },
                    { new Guid("5c11450b-4e15-4f27-8554-f5d31bdcaec3"), "/images/Products/rdx-boxing-shoes/rdx-boxing-shoes-1.png", new Guid("cbde7c61-88b4-4ecc-82f8-3efa6aa46c3f") },
                    { new Guid("60e7a723-20c8-410f-a405-f187f33dcb9d"), "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-3.png", new Guid("d80db6a3-d70d-48d0-9986-7779c351e0b1") },
                    { new Guid("6725bf7c-5725-4484-aa73-1422c152cebf"), "/images/Products/rdx-boxing-shoes/rdx-boxing-shoes-3.png", new Guid("cbde7c61-88b4-4ecc-82f8-3efa6aa46c3f") },
                    { new Guid("735e987f-15ec-43c1-9184-b2afa844ccf2"), "/images/Products/title-boxing-gloves/title-boxing-gloves-2.png", new Guid("c3e50f89-3446-4a29-bed1-3b4606298583") },
                    { new Guid("7b658e2a-adb5-4e40-a5f0-3de365ab6b74"), "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-1.png", new Guid("4f72823b-5662-4921-9378-704711e39e86") },
                    { new Guid("7d693338-84e6-44df-8753-c3b2848422ed"), "/images/Products/venum-challenger-gloves/venum-challenger-gloves-1.png", new Guid("149df23c-f0b7-4bfc-bc34-b54bf02a7273") },
                    { new Guid("820d3cbf-5504-4112-841e-32183f3b0e75"), "/images/Products/ringside-punching-bag/ringside-punching-bag-3.png", new Guid("d3f5c99c-1284-436a-bede-72d49ded85ca") },
                    { new Guid("8ae294b3-3bce-4591-932a-9da232cd4b6e"), "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-2.png", new Guid("0fd07c67-fad8-46a7-b579-9683b6b1c15e") },
                    { new Guid("8c8d4807-9672-4a7c-94ef-5c56a9432f9b"), "/images/Products/rdx-boxing-shoes/rdx-boxing-shoes-2.png", new Guid("cbde7c61-88b4-4ecc-82f8-3efa6aa46c3f") },
                    { new Guid("8f8c8d1f-b825-40f1-bf77-560478f1ee5c"), "/images/Products/everlasr-pro-headgear/everlast-headgear-1.png", new Guid("fecc0ec5-451d-4637-bd40-e4fdc7af64f7") },
                    { new Guid("9697c5c0-b0ca-420e-8e45-98f151c42024"), "/images/Products/everlasr-pro-headgear/everlast-headgear-2.png", new Guid("fecc0ec5-451d-4637-bd40-e4fdc7af64f7") },
                    { new Guid("9abcbbce-0489-41b4-ad29-35255a9ae225"), "/images/Products/everlast-hand-wraps/everlast-hand-wraps-2.png", new Guid("179fc071-2879-4577-b497-1e8c432dbeec") },
                    { new Guid("a6940803-5e35-46c7-93f3-cb33d84e27d0"), "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-1.png", new Guid("d80db6a3-d70d-48d0-9986-7779c351e0b1") },
                    { new Guid("b133564d-b858-47b3-9397-403121bb5a15"), "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-3.png", new Guid("8c9ce9ae-d539-4a36-ace8-f897db14a321") },
                    { new Guid("b3af7319-c03c-4c3f-abdc-6d9a98514836"), "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-3.png", new Guid("0fd07c67-fad8-46a7-b579-9683b6b1c15e") },
                    { new Guid("b3d065f1-5c2b-48f5-815a-14eef164e079"), "/images/Products/sanabul-shin-guards/sanabul-shin-guards-3.png", new Guid("1fef6e18-9c47-4a74-b2a2-9d3c4c22cb4e") },
                    { new Guid("ba39309e-cafe-4cd9-984b-155479094da5"), "/images/Products/ringside-punching-bag/ringside-punching-bag-2.png", new Guid("d3f5c99c-1284-436a-bede-72d49ded85ca") },
                    { new Guid("bafb6b7d-a197-4a2a-8471-3aad80f25ebc"), "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-3.png", new Guid("a00e221c-ae77-42c3-8811-f07361c55902") },
                    { new Guid("bb259f42-41f0-4c3b-88bf-4a397b254e73"), "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-2.png", new Guid("a00e221c-ae77-42c3-8811-f07361c55902") },
                    { new Guid("bc484af5-5222-4f1d-8254-1b422630a8a9"), "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-2.png", new Guid("4f72823b-5662-4921-9378-704711e39e86") },
                    { new Guid("bddaadfd-1adb-49a8-ab05-bf3476411ab4"), "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-2.png", new Guid("8c9ce9ae-d539-4a36-ace8-f897db14a321") },
                    { new Guid("bf51d164-a6bc-4913-b5e6-18933a31ddae"), "/images/Products/title-boxing-gloves/title-boxing-gloves-3.png", new Guid("c3e50f89-3446-4a29-bed1-3b4606298583") },
                    { new Guid("ce2cf9f9-5390-4795-925c-20546202fa81"), "/images/Products/venum-challenger-gloves/venum-challenger-gloves-3.png", new Guid("149df23c-f0b7-4bfc-bc34-b54bf02a7273") },
                    { new Guid("d64db329-01b5-4fd8-ba49-af6e7e4ba624"), "/images/Products/ringside-punching-bag/ringside-punching-bag-1.png", new Guid("d3f5c99c-1284-436a-bede-72d49ded85ca") },
                    { new Guid("dbe8ae4f-3fd1-41cb-bb88-1aeb7e39be6f"), "/images/Products/everlast-hand-wraps/everlast-hand-wraps-1.png", new Guid("179fc071-2879-4577-b497-1e8c432dbeec") },
                    { new Guid("df46aeb9-e043-4dd0-be71-3673b18ef8fe"), "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-1.png", new Guid("8c9ce9ae-d539-4a36-ace8-f897db14a321") },
                    { new Guid("e2638174-a6e7-447a-aa4b-dcb1b528f776"), "/images/Products/title-boxing-bag/title-boxing-bag-3.png", new Guid("948e533c-0a9f-4958-92b6-2564dcb2ada9") },
                    { new Guid("ebcd3246-560a-4741-ad93-c2a607883f0d"), "/images/Products/twins-special-headgear/twins-special-headgear-1.png", new Guid("bdddadb7-f13b-4867-bb1c-cc933232b392") },
                    { new Guid("f1cee1cc-2116-4970-8e0d-f2694a611b4d"), "/images/Products/title-boxing-bag/title-boxing-bag-2.png", new Guid("948e533c-0a9f-4958-92b6-2564dcb2ada9") },
                    { new Guid("fa4fe644-d954-40f7-8d6a-b6e10d7ce60f"), "/images/Products/twins-special-headgear/twins-shin-headgear-3.png", new Guid("bdddadb7-f13b-4867-bb1c-cc933232b392") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("2f8a9cbd-e546-459e-959f-c6ad91e0ac9d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("d45719cf-3e1f-4308-8ab5-adc19f9a9eef"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("d8fc6540-4ca6-4119-9dd4-239d79e24126"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("005ec700-6a99-4cb4-850f-30c1748ef997"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("01686f6d-b85e-4036-a299-7b002eec017d"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("14a575db-a50e-48cd-83d0-fa8dbd9bec64"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("1a1779bc-0597-4c5a-b9b7-5a3e7342f183"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("2111ba1d-ee99-4e81-ad5f-f15aedc95954"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("2d1b510c-e349-4334-9b7b-fed0d010a7ce"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("2f8cee97-8d5b-41e8-aa14-9311278e1f7b"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("312494b7-82fc-43fe-9f9e-242fc979e752"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("385029b6-1eea-4cdd-ab87-e93772ed708f"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("39c59192-aff8-4586-86fa-23cddc5f0d16"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("4e3a87f5-1e3e-49a7-8a88-fa1b33cfb248"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("57fb654d-8dee-4470-84f9-7eeb27da2caa"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("5c11450b-4e15-4f27-8554-f5d31bdcaec3"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("60e7a723-20c8-410f-a405-f187f33dcb9d"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("6725bf7c-5725-4484-aa73-1422c152cebf"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("735e987f-15ec-43c1-9184-b2afa844ccf2"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("7b658e2a-adb5-4e40-a5f0-3de365ab6b74"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("7d693338-84e6-44df-8753-c3b2848422ed"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("820d3cbf-5504-4112-841e-32183f3b0e75"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("8ae294b3-3bce-4591-932a-9da232cd4b6e"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("8c8d4807-9672-4a7c-94ef-5c56a9432f9b"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("8f8c8d1f-b825-40f1-bf77-560478f1ee5c"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("9697c5c0-b0ca-420e-8e45-98f151c42024"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("9abcbbce-0489-41b4-ad29-35255a9ae225"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("a6940803-5e35-46c7-93f3-cb33d84e27d0"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("b133564d-b858-47b3-9397-403121bb5a15"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("b3af7319-c03c-4c3f-abdc-6d9a98514836"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("b3d065f1-5c2b-48f5-815a-14eef164e079"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("ba39309e-cafe-4cd9-984b-155479094da5"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("bafb6b7d-a197-4a2a-8471-3aad80f25ebc"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("bb259f42-41f0-4c3b-88bf-4a397b254e73"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("bc484af5-5222-4f1d-8254-1b422630a8a9"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("bddaadfd-1adb-49a8-ab05-bf3476411ab4"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("bf51d164-a6bc-4913-b5e6-18933a31ddae"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("ce2cf9f9-5390-4795-925c-20546202fa81"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("d64db329-01b5-4fd8-ba49-af6e7e4ba624"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("dbe8ae4f-3fd1-41cb-bb88-1aeb7e39be6f"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("df46aeb9-e043-4dd0-be71-3673b18ef8fe"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("e2638174-a6e7-447a-aa4b-dcb1b528f776"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("ebcd3246-560a-4741-ad93-c2a607883f0d"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("f1cee1cc-2116-4970-8e0d-f2694a611b4d"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("fa4fe644-d954-40f7-8d6a-b6e10d7ce60f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("0fd07c67-fad8-46a7-b579-9683b6b1c15e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("149df23c-f0b7-4bfc-bc34-b54bf02a7273"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("179fc071-2879-4577-b497-1e8c432dbeec"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1fef6e18-9c47-4a74-b2a2-9d3c4c22cb4e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4f72823b-5662-4921-9378-704711e39e86"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("8c9ce9ae-d539-4a36-ace8-f897db14a321"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("948e533c-0a9f-4958-92b6-2564dcb2ada9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a00e221c-ae77-42c3-8811-f07361c55902"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("bdddadb7-f13b-4867-bb1c-cc933232b392"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c3e50f89-3446-4a29-bed1-3b4606298583"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("cbde7c61-88b4-4ecc-82f8-3efa6aa46c3f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d3f5c99c-1284-436a-bede-72d49ded85ca"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d80db6a3-d70d-48d0-9986-7779c351e0b1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("fecc0ec5-451d-4637-bd40-e4fdc7af64f7"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("07d7cc18-51ac-4af6-b7dc-57d4e866db8e"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("1e856569-f4bf-4b6e-bf9f-60dcfeda2128"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("40a9fe49-d6e4-4fc3-b8d2-e7558f51edbd"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("51ef4706-3d2f-4cfd-adfb-a74a372c9bc7"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("7b07b813-715c-4f32-aaf7-5998a9ef9fea"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("7c7fc24a-7aa9-4f1d-b740-3e1a352db473"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("7f813c1c-1ac0-4585-855e-06c34b87606d"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("84ab32db-7d9e-4771-910b-65054289f10a"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("8f76a962-b423-4430-b95c-2d3552811aea"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("dff59b10-133b-4359-b6ad-7a320badfcfd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("02d33169-816b-4124-b19b-1ab460aead11"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("2b7b6cde-11be-45a4-99b3-bcffad661dde"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("2f25bc4b-87b7-4b47-9126-a30332fbe397"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("596c958d-e148-4535-92fa-25d245876e92"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("938f77ae-15bc-46b2-a10e-15a6af5a33d8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("accd75a9-5ef3-4313-8e8b-8a34410ac4e4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("bcb29901-22c1-4f57-8372-ef46a2bca510"));

            migrationBuilder.AddColumn<string>(
                name: "Sizes",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                comment: "The Size Of The Product");

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
    }
}
