using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KickShop.Migrations
{
    /// <inheritdoc />
    public partial class AddedProductSizeModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "ProductsSizes",
                columns: table => new
                {
                    ProductSizeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "The Unique Identifier"),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Foreign Key To The Product Model"),
                    Size = table.Column<int>(type: "int", nullable: false, comment: "The Size"),
                    Quantity = table.Column<int>(type: "int", nullable: false, comment: "The Quantity Of The Sizes")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsSizes", x => x.ProductSizeId);
                    table.ForeignKey(
                        name: "FK_ProductsSizes_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandId", "Address", "Country", "Description", "ImageUrl", "IsDeleted", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("41fdcbdb-7af7-408c-865b-f2b477564d69"), "567 Martial Arts Blvd, Oklahoma City, OK", "USA", "Century is known for its innovative training gear, including punching bags and protective equipment. Widely used in martial arts and kickboxing, Century products are designed to enhance performance and safety.", "/images/Brands/century-logo.png", false, "Century", "345-678-9012" },
                    { new Guid("5d7ae267-d077-42df-826e-a4f207c1313b"), "456 Ring Rd, Chicago, IL", "USA", "Ringside is a trusted name in boxing and kickboxing, providing high-performance equipment and apparel. Its focus on durability and craftsmanship has made it a favorite among gyms and professionals.", "/images/Brands/ringside-logo.png", false, "Ringside", "234-567-8901" },
                    { new Guid("87210bf7-d293-4a64-af95-84956f70dfae"), "234 Fighter Rd, Bangkok, TH", "Thailand", "Fairtex is a legendary Thai brand specializing in Muay Thai and kickboxing gear. Renowned for its authenticity and quality, Fairtex is the choice of champions in traditional and modern combat sports.", "/images/Brands/fairtex-logo.png", false, "Fairtex", "876-543-2109" },
                    { new Guid("b3264ae4-0d56-47a0-9cd0-016d0423afd7"), "123 Boxing Blvd, New York, NY", "USA", "Known as one of the oldest and most reputable brands in the boxing world, Everlast is a staple in combat sports. From gloves to training equipment, Everlast provides high-quality gear trusted by professional fighters and trainers alike.", "/images/Brands/everlast-logo.png", false, "Everlast", "123-456-7890" },
                    { new Guid("bd258b07-bc9e-4fb4-86ea-c8dba4e664b8"), "789 Fight St, Toronto, ON", "Canada", "Hayabusa is synonymous with premium quality and cutting-edge technology in combat sports. Their gloves and apparel are designed to provide exceptional protection, performance, and style for fighters at all levels.", "/images/Brands/hayabusa-logo.png", false, "Hayabusa", "789-012-3456" },
                    { new Guid("c8aaba5e-4da9-421a-9502-821d5c6b9870"), "678 Fighter Ave, Miami, FL", "USA", "Sanabul is a modern combat sports brand offering stylish and affordable gear. Its products are designed for both beginners and experienced athletes, with a focus on innovation and performance.", "/images/Brands/sanabul-logo.png", false, "Sanabul", "456-789-0123" },
                    { new Guid("ce1d95f0-5c19-4a29-8e6d-d2efc9c25fff"), "456 Sports Ave, London, UK", "UK", "RDX is renowned for its innovative designs and durable equipment that cater to a wide range of combat sports, including kickboxing, MMA, and boxing. Its focus on affordability and quality makes it a favorite among beginners and professionals.", "/images/Brands/rdx-logo.png", false, "RDX", "456-789-0123" },
                    { new Guid("dc564a23-3ed0-489a-b761-3088744bea69"), "789 Kick Rd, Phuket, TH", "Thailand", "Twins Special is a renowned brand in Muay Thai and kickboxing, celebrated for its handcrafted gear. Their gloves and pads are known for their durability, quality, and traditional Thai craftsmanship.", "/images/Brands/twins-special-logo.png", false, "Twins Special", "567-890-1234" },
                    { new Guid("e0699947-e12e-45b5-a224-9351b5667657"), "101 Martial Arts Way, Paris, FR", "France", "Venum is a globally recognized brand known for its bold designs and top-tier combat sports equipment. From gloves to apparel, Venum caters to athletes who demand performance and style in the ring and beyond.", "/images/Brands/venum-logo.png", false, "Venum", "321-654-0987" },
                    { new Guid("f23f3ec9-afa7-4208-a434-810f463813f8"), "345 Punch Ln, Los Angeles, CA", "USA", "Title Boxing is a leading brand offering an extensive range of boxing and kickboxing gear. Known for its reliability and innovation, Title Boxing supports athletes with training and competition essentials.", "/images/Brands/title-boxing-logo.png", false, "Title Boxing", "987-654-3210" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "ImageUrl", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { new Guid("1cf9f2b4-0e64-4124-9cf8-4fd8fe538a0d"), "/images/Categories/training-equipment.png", false, "Training Equipment" },
                    { new Guid("363ae2d7-a678-49da-872a-4f4a9841923b"), "/images/Categories/protective-equipment.jfif", false, "Protective Gear" },
                    { new Guid("4e759408-2bb2-4b9f-ae3f-ab5f6fb386c6"), "/images/Categegories/boxing-gloves.jfif", false, "Gloves" },
                    { new Guid("7b20ae15-7263-4c5b-b9dd-faa437c8d315"), "/images/Categories/head-gear.png", false, "Headgear" },
                    { new Guid("81bb71bd-4675-4285-b0d2-4c55c88ab605"), "/images/Categories/punching-bag.png", false, "Punching Bags" },
                    { new Guid("8f7b013f-2dbb-4ab9-af7c-d701203f0819"), "/images/Categories/clothing.png", false, "Clothing" },
                    { new Guid("8fac897d-1c6a-4532-82cc-d5dbe3aa58d5"), "/images/Categories/hand-wraps.png", false, "Hand Wraps" },
                    { new Guid("ce7c29c0-3efa-4766-8e72-7bc59e68ead0"), "/images/Categories/boxing-shoes.png", false, "Shoes" },
                    { new Guid("f9b3cbac-43d3-4720-a790-e435b5cc33f5"), "/images/Categories/shin-guards.png", false, "Shinguards" },
                    { new Guid("fe0a538d-dad1-47c0-b3eb-a54d94c64562"), "/images/Categories/mouth-guard.png", false, "Mouthguards" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "BrandId", "CategoryId", "Description", "IsDeleted", "MainImageUrl", "Name", "Price", "StockQuantity" },
                values: new object[,]
                {
                    { new Guid("099661b9-b063-4519-bce7-82abb2820761"), new Guid("c8aaba5e-4da9-421a-9502-821d5c6b9870"), new Guid("f9b3cbac-43d3-4720-a790-e435b5cc33f5"), "High-quality shin guards for protection and mobility.", false, "/images/Products/sanabul-shin-guards/sanabul-shin-guards-1.png", "Sanabul Essential Shin Guards", 105.99m, 90 },
                    { new Guid("0c650eb0-67d8-42a1-bf25-980feb18c774"), new Guid("41fdcbdb-7af7-408c-865b-f2b477564d69"), new Guid("8f7b013f-2dbb-4ab9-af7c-d701203f0819"), "Comfortable shorts designed for kickboxing.", false, "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-1.png", "Century Martial Arts Kickboxing Shorts", 79.99m, 75 },
                    { new Guid("0fa30324-ecd7-486b-acc8-5448f5e24817"), new Guid("b3264ae4-0d56-47a0-9cd0-016d0423afd7"), new Guid("7b20ae15-7263-4c5b-b9dd-faa437c8d315"), "Full-protection headgear with durable padding.", false, "/images/Products/everlast-pro-headgear/everlast-headgear-1.png", "Everlast Pro Headgear", 89.99m, 50 },
                    { new Guid("1e45cd74-8414-40be-8718-24927f81b1a4"), new Guid("e0699947-e12e-45b5-a224-9351b5667657"), new Guid("4e759408-2bb2-4b9f-ae3f-ab5f6fb386c6"), "Lightweight and designed for all skill levels.", false, "/images/Products/venum-challenger-gloves/venum-challenger-gloves-2.png", "Venum Challenger Gloves", 89.99m, 120 },
                    { new Guid("4250b84c-9f30-4c03-93d4-92eb58d08e02"), new Guid("ce1d95f0-5c19-4a29-8e6d-d2efc9c25fff"), new Guid("4e759408-2bb2-4b9f-ae3f-ab5f6fb386c6"), "High-quality leather gloves for all training levels.", false, "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-3.png", "RDX Boxing Gloves", 109.99m, 100 },
                    { new Guid("5c57b250-a067-4be8-a3af-43c54cc35498"), new Guid("e0699947-e12e-45b5-a224-9351b5667657"), new Guid("f9b3cbac-43d3-4720-a790-e435b5cc33f5"), "High-durability shin guards ideal for intense training.", false, "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-1.png", "Venum Challenger Shin Guards", 105.99m, 95 },
                    { new Guid("78695d5e-e776-4580-aa0f-bcfdc113ae57"), new Guid("f23f3ec9-afa7-4208-a434-810f463813f8"), new Guid("81bb71bd-4675-4285-b0d2-4c55c88ab605"), "Perfect for accuracy and reflex training.", false, "/images/Products/title-boxing-gloves/title-boxing-gloves-1.png", "Title Boxing Double End Bag", 99.99m, 70 },
                    { new Guid("8940c59f-6466-4e0e-8945-486b7145d179"), new Guid("f23f3ec9-afa7-4208-a434-810f463813f8"), new Guid("4e759408-2bb2-4b9f-ae3f-ab5f6fb386c6"), "Durable leather gloves for heavy bag workouts.", false, "/images/Products/title-boxing-bag/title-boxing-bag-1.png", "Title Boxing Leather Bag Gloves", 79.99m, 80 },
                    { new Guid("adcc2ec4-d4f5-45c4-b386-5096508223e0"), new Guid("bd258b07-bc9e-4fb4-86ea-c8dba4e664b8"), new Guid("4e759408-2bb2-4b9f-ae3f-ab5f6fb386c6"), "Top-notch gloves with exceptional durability.", false, "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-1.png", "Hayabusa T3 Boxing Gloves", 189.99m, 50 },
                    { new Guid("b00cb628-a48b-4fb7-8249-56314c1331d4"), new Guid("dc564a23-3ed0-489a-b761-3088744bea69"), new Guid("7b20ae15-7263-4c5b-b9dd-faa437c8d315"), "Full-face protection with Twins quality.", false, "/images/Products/twins-special-headgear/twins-special-headgear-1.png", "Twins Special Headgear", 89.99m, 60 },
                    { new Guid("c8f80589-4602-4dc8-a6a8-9ed74ce130b3"), new Guid("ce1d95f0-5c19-4a29-8e6d-d2efc9c25fff"), new Guid("ce7c29c0-3efa-4766-8e72-7bc59e68ead0"), "Lightweight and supportive for agility in the ring.", false, "/images/Products/rdx-boxing-shoes/rdx-boxing-shoes-1.png", "RDX Pro Boxing Shoes", 109.99m, 65 },
                    { new Guid("e93fa539-a119-4d87-b082-2d3d6931400c"), new Guid("5d7ae267-d077-42df-826e-a4f207c1313b"), new Guid("81bb71bd-4675-4285-b0d2-4c55c88ab605"), "Heavy-duty bag for all levels of training.", false, "/images/Products/ringside-punching-bag/ringside-punching-bag-1.png", "Ringside Punching Bag", 219.99m, 40 },
                    { new Guid("f800af09-0788-45b6-98ac-ef6cb6dfc557"), new Guid("87210bf7-d293-4a64-af95-84956f70dfae"), new Guid("8f7b013f-2dbb-4ab9-af7c-d701203f0819"), "Premium Muay Thai shorts with authentic design.", false, "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-1.png", "Fairtex Muay Thai Shorts", 84.99m, 90 },
                    { new Guid("f858c8bd-435c-47c7-a043-a68b047ae167"), new Guid("b3264ae4-0d56-47a0-9cd0-016d0423afd7"), new Guid("8fac897d-1c6a-4532-82cc-d5dbe3aa58d5"), "Classic wraps for wrist and knuckle protection.", false, "/images/Products/everlast-hand-wraps/everlast-hand-wraps-3.png", "Everlast Hand Wraps", 9.99m, 200 }
                });

            migrationBuilder.InsertData(
                table: "ProductsImages",
                columns: new[] { "ImageId", "ImageUrl", "ProductId" },
                values: new object[,]
                {
                    { new Guid("01fcff3e-ddcf-4ba2-b8b9-bc7b03754158"), "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-2.png", new Guid("f800af09-0788-45b6-98ac-ef6cb6dfc557") },
                    { new Guid("05bdfe57-556a-4c35-a252-f5628586f678"), "/images/Products/venum-challenger-gloves/venum-challenger-gloves-3.png", new Guid("1e45cd74-8414-40be-8718-24927f81b1a4") },
                    { new Guid("05c15053-ec60-4081-9500-8c7b4971f89c"), "/images/Products/rdx-boxing-shoes/rdx-boxing-shoes-3.png", new Guid("c8f80589-4602-4dc8-a6a8-9ed74ce130b3") },
                    { new Guid("08d99d05-0945-4e51-a751-59d72978f089"), "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-1.png", new Guid("0c650eb0-67d8-42a1-bf25-980feb18c774") },
                    { new Guid("092a29b6-8f6e-446f-9e2a-9457b1294be9"), "/images/Products/twins-special-headgear/twins-special-headgear-1.png", new Guid("b00cb628-a48b-4fb7-8249-56314c1331d4") },
                    { new Guid("0a3a5138-da15-40bc-a2eb-8e410c49033e"), "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-2.png", new Guid("5c57b250-a067-4be8-a3af-43c54cc35498") },
                    { new Guid("0f935ee2-19fd-4c41-be9e-d9b8daaadc27"), "/images/Products/title-boxing-bag/title-boxing-bag-3.png", new Guid("8940c59f-6466-4e0e-8945-486b7145d179") },
                    { new Guid("1249ce56-063d-433a-b91a-83bf61600a82"), "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-2.png", new Guid("4250b84c-9f30-4c03-93d4-92eb58d08e02") },
                    { new Guid("1710e139-dc76-47bb-8ddb-48d91e3cc815"), "/images/Products/twins-special-headgear/twins-special-headgear-2.png", new Guid("b00cb628-a48b-4fb7-8249-56314c1331d4") },
                    { new Guid("21d7b796-28b3-46e6-923d-c222c114674d"), "/images/Products/title-boxing-gloves/title-boxing-gloves-1.png", new Guid("78695d5e-e776-4580-aa0f-bcfdc113ae57") },
                    { new Guid("31fea592-39a4-4c10-ad00-c9f19c82800a"), "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-3.png", new Guid("0c650eb0-67d8-42a1-bf25-980feb18c774") },
                    { new Guid("44ad5fc4-498c-40e9-b4d1-542af305b883"), "/images/Products/ringside-punching-bag/ringside-punching-bag-1.png", new Guid("e93fa539-a119-4d87-b082-2d3d6931400c") },
                    { new Guid("4520e4fe-d36e-4fc8-be52-9193bca83cb1"), "/images/Products/title-boxing-gloves/title-boxing-gloves-2.png", new Guid("78695d5e-e776-4580-aa0f-bcfdc113ae57") },
                    { new Guid("478c030c-3581-4fa9-8d1e-f7a6d719f63b"), "/images/Products/sanabul-shin-guards/sanabul-shin-guards-3.png", new Guid("099661b9-b063-4519-bce7-82abb2820761") },
                    { new Guid("4a4e7847-a702-4251-bf39-e958493c447c"), "/images/Products/everlasr-pro-headgear/everlast-headgear-1.png", new Guid("0fa30324-ecd7-486b-acc8-5448f5e24817") },
                    { new Guid("568560e8-44ee-4e36-a11c-4d3bb4dd075e"), "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-3.png", new Guid("f800af09-0788-45b6-98ac-ef6cb6dfc557") },
                    { new Guid("56c7b526-0e08-4eae-9b86-f436919d11ba"), "/images/Products/sanabul-shin-guards/sanabul-shin-guards-1.png", new Guid("099661b9-b063-4519-bce7-82abb2820761") },
                    { new Guid("5c8da350-bfdc-423b-81ab-ded14fc0a7ff"), "/images/Products/sanabul-shin-guards/sanabul-shin-guards-2.png", new Guid("099661b9-b063-4519-bce7-82abb2820761") },
                    { new Guid("65cd7419-91c5-4a04-9090-5be332451473"), "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-2.png", new Guid("0c650eb0-67d8-42a1-bf25-980feb18c774") },
                    { new Guid("68eff0bd-ecd9-4af3-90dc-4cf685211d39"), "/images/Products/ringside-punching-bag/ringside-punching-bag-3.png", new Guid("e93fa539-a119-4d87-b082-2d3d6931400c") },
                    { new Guid("6b4d5efa-52ba-46b7-8719-7f3b80c39fc8"), "/images/Products/rdx-boxing-shoes/rdx-boxing-shoes-1.png", new Guid("c8f80589-4602-4dc8-a6a8-9ed74ce130b3") },
                    { new Guid("6f8c6ad0-fa8a-4762-bde6-b87fbec2b83d"), "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-3.png", new Guid("4250b84c-9f30-4c03-93d4-92eb58d08e02") },
                    { new Guid("70509756-4e3e-4e1a-b17c-0546caa6fdde"), "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-3.png", new Guid("5c57b250-a067-4be8-a3af-43c54cc35498") },
                    { new Guid("7121476d-6a7f-4b1b-9003-99732c906ff0"), "/images/Products/rdx-boxing-shoes/rdx-boxing-shoes-2.png", new Guid("c8f80589-4602-4dc8-a6a8-9ed74ce130b3") },
                    { new Guid("73f3a3d5-61ff-4914-9f8b-8aa5d6bc0d72"), "/images/Products/venum-challenger-gloves/venum-challenger-gloves-2.png", new Guid("1e45cd74-8414-40be-8718-24927f81b1a4") },
                    { new Guid("763967fe-9591-4c3c-b33a-4d4f1d4c5453"), "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-1.png", new Guid("5c57b250-a067-4be8-a3af-43c54cc35498") },
                    { new Guid("84227c06-0bbc-4bc3-a435-2da1927915e2"), "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-1.png", new Guid("4250b84c-9f30-4c03-93d4-92eb58d08e02") },
                    { new Guid("8ca0acee-bcda-460a-9bab-8bdc2c5d926d"), "/images/Products/everlast-hand-wraps/everlast-hand-wraps-3.png", new Guid("f858c8bd-435c-47c7-a043-a68b047ae167") },
                    { new Guid("925cdf79-68b1-43a1-8ffd-89b3c9305188"), "/images/Products/title-boxing-bag/title-boxing-bag-2.png", new Guid("8940c59f-6466-4e0e-8945-486b7145d179") },
                    { new Guid("9a6ce95c-c0cf-4f8b-953a-30cb4c27c186"), "/images/Products/ringside-punching-bag/ringside-punching-bag-2.png", new Guid("e93fa539-a119-4d87-b082-2d3d6931400c") },
                    { new Guid("a134f408-2f64-4365-b521-c7da3eb067e6"), "/images/Products/venum-challenger-gloves/venum-challenger-gloves-1.png", new Guid("1e45cd74-8414-40be-8718-24927f81b1a4") },
                    { new Guid("a50a7f4b-8938-4b41-8742-a091cb1de909"), "/images/Products/everlasr-pro-headgear/everlast-headgear-2.png", new Guid("0fa30324-ecd7-486b-acc8-5448f5e24817") },
                    { new Guid("a54863e3-3f56-499f-a47d-ff1454c7ff6c"), "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-1.png", new Guid("f800af09-0788-45b6-98ac-ef6cb6dfc557") },
                    { new Guid("a8a627cb-30e2-4884-a3ac-bc9feb60448f"), "/images/Products/everlast-hand-wraps/everlast-hand-wraps-1.png", new Guid("f858c8bd-435c-47c7-a043-a68b047ae167") },
                    { new Guid("aa317113-eb02-4553-932f-0659afb672c7"), "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-1.png", new Guid("adcc2ec4-d4f5-45c4-b386-5096508223e0") },
                    { new Guid("aae97d3f-56d0-4377-90a9-c55245719fb8"), "/images/Products/twins-special-headgear/twins-shin-headgear-3.png", new Guid("b00cb628-a48b-4fb7-8249-56314c1331d4") },
                    { new Guid("c125731c-2674-48a5-ac13-3e791152c25d"), "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-3.png", new Guid("adcc2ec4-d4f5-45c4-b386-5096508223e0") },
                    { new Guid("c87256c5-effb-4ce8-a252-75a3dd22b8d4"), "/images/Products/title-boxing-gloves/title-boxing-gloves-3.png", new Guid("78695d5e-e776-4580-aa0f-bcfdc113ae57") },
                    { new Guid("d0628309-84a3-4582-898a-64afdc55d856"), "/images/Products/everlast-hand-wraps/everlast-hand-wraps-2.png", new Guid("f858c8bd-435c-47c7-a043-a68b047ae167") },
                    { new Guid("e2d7918c-f3ff-4b80-b2ee-91f96afe9f86"), "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-2.png", new Guid("adcc2ec4-d4f5-45c4-b386-5096508223e0") },
                    { new Guid("e833d14c-cdc6-4d4d-aa32-9eb630ac1e16"), "/images/Products/everlasr-pro-headgear/everlast-headgear-3.png", new Guid("0fa30324-ecd7-486b-acc8-5448f5e24817") },
                    { new Guid("f1c0d30e-a94d-4bc3-8422-d0efcf2a1c44"), "/images/Products/title-boxing-bag/title-boxing-bag-1.png", new Guid("8940c59f-6466-4e0e-8945-486b7145d179") }
                });

            migrationBuilder.InsertData(
                table: "ProductsSizes",
                columns: new[] { "ProductSizeId", "ProductId", "Quantity", "Size" },
                values: new object[,]
                {
                    { new Guid("0b06206b-ee51-4cab-a3d7-1f55ce493a64"), new Guid("5c57b250-a067-4be8-a3af-43c54cc35498"), 3, 2 },
                    { new Guid("0de6c0ab-1b32-4751-8b30-234a9f095552"), new Guid("1e45cd74-8414-40be-8718-24927f81b1a4"), 2, 3 },
                    { new Guid("17599914-941d-4ab9-a882-ae88600bc0af"), new Guid("0c650eb0-67d8-42a1-bf25-980feb18c774"), 5, 0 },
                    { new Guid("1e75e766-8075-478d-8be3-603a95077eb5"), new Guid("0c650eb0-67d8-42a1-bf25-980feb18c774"), 3, 2 },
                    { new Guid("2571d7bc-adf7-41f4-9adc-0255d95327b1"), new Guid("4250b84c-9f30-4c03-93d4-92eb58d08e02"), 5, 0 },
                    { new Guid("28230e5c-58dd-4803-9480-ed74db3053db"), new Guid("b00cb628-a48b-4fb7-8249-56314c1331d4"), 3, 2 },
                    { new Guid("2d49ee55-0d18-46cc-910c-5233c8989b29"), new Guid("78695d5e-e776-4580-aa0f-bcfdc113ae57"), 3, 2 },
                    { new Guid("3d8aef21-0dd5-4c6c-baba-84ee246ffabc"), new Guid("f800af09-0788-45b6-98ac-ef6cb6dfc557"), 5, 0 },
                    { new Guid("460d4dea-5d4c-48c9-953c-e713795a4057"), new Guid("1e45cd74-8414-40be-8718-24927f81b1a4"), 3, 4 },
                    { new Guid("4b035a0b-0771-4ffb-a2e0-c98ad97fd734"), new Guid("1e45cd74-8414-40be-8718-24927f81b1a4"), 5, 0 },
                    { new Guid("4e7ca050-b095-4be1-a6e6-93437aff4e64"), new Guid("e93fa539-a119-4d87-b082-2d3d6931400c"), 5, 0 },
                    { new Guid("53620d0b-53f2-4517-86b4-8768a00a018d"), new Guid("b00cb628-a48b-4fb7-8249-56314c1331d4"), 2, 3 },
                    { new Guid("56a7b37f-25fc-4a15-8ac9-4c7cc95b1639"), new Guid("f858c8bd-435c-47c7-a043-a68b047ae167"), 3, 2 },
                    { new Guid("5b745cc9-e386-4109-9027-e6cb1738ee20"), new Guid("099661b9-b063-4519-bce7-82abb2820761"), 3, 6 },
                    { new Guid("5ea6e6d0-fbd9-4f97-84fa-774ea64fabe1"), new Guid("099661b9-b063-4519-bce7-82abb2820761"), 5, 0 },
                    { new Guid("6243203f-a5c2-4e68-a019-eff936bd9114"), new Guid("099661b9-b063-4519-bce7-82abb2820761"), 2, 3 },
                    { new Guid("64608187-0fc3-49f0-9cab-e40dbfa84029"), new Guid("5c57b250-a067-4be8-a3af-43c54cc35498"), 2, 3 },
                    { new Guid("6c663281-b284-4438-a1a1-1fc1e9980743"), new Guid("e93fa539-a119-4d87-b082-2d3d6931400c"), 3, 2 },
                    { new Guid("6f3d7cfa-ef19-4877-bdf2-e1859f164f19"), new Guid("f858c8bd-435c-47c7-a043-a68b047ae167"), 2, 3 },
                    { new Guid("7143719d-9a61-4cbd-820d-c5482fab997d"), new Guid("8940c59f-6466-4e0e-8945-486b7145d179"), 3, 5 },
                    { new Guid("7466d3f2-2d2c-41d9-95b6-17b732105abb"), new Guid("c8f80589-4602-4dc8-a6a8-9ed74ce130b3"), 3, 2 },
                    { new Guid("7a4c7c0f-2f22-43d8-8622-4308c8383336"), new Guid("b00cb628-a48b-4fb7-8249-56314c1331d4"), 5, 0 },
                    { new Guid("7a8d744a-0784-432b-a6cb-b3ee3a7670b9"), new Guid("c8f80589-4602-4dc8-a6a8-9ed74ce130b3"), 2, 3 },
                    { new Guid("7eb590c8-4cbe-4636-a6c7-ee1d0916d827"), new Guid("0c650eb0-67d8-42a1-bf25-980feb18c774"), 2, 3 },
                    { new Guid("81525500-71a4-44b0-af95-e33dfba4b608"), new Guid("78695d5e-e776-4580-aa0f-bcfdc113ae57"), 2, 3 },
                    { new Guid("8a109324-7032-43fc-9479-1f039853c3ee"), new Guid("4250b84c-9f30-4c03-93d4-92eb58d08e02"), 2, 3 },
                    { new Guid("96632849-7dde-47b7-a4ce-ad741bc91bc6"), new Guid("e93fa539-a119-4d87-b082-2d3d6931400c"), 2, 3 },
                    { new Guid("98e1406f-98a9-40f0-b828-09a9154c0eeb"), new Guid("8940c59f-6466-4e0e-8945-486b7145d179"), 2, 3 },
                    { new Guid("ab3e5eb0-25ab-4a31-a4d4-c72446abefa7"), new Guid("c8f80589-4602-4dc8-a6a8-9ed74ce130b3"), 5, 0 },
                    { new Guid("b1754720-f319-4c19-81a0-adcfc13d6117"), new Guid("78695d5e-e776-4580-aa0f-bcfdc113ae57"), 5, 0 },
                    { new Guid("b680f09a-b11f-4de7-b0cf-e0ae1c62491e"), new Guid("f858c8bd-435c-47c7-a043-a68b047ae167"), 5, 0 },
                    { new Guid("ba124d2c-35fe-4a46-a864-6ef32bb9b2f9"), new Guid("adcc2ec4-d4f5-45c4-b386-5096508223e0"), 5, 0 },
                    { new Guid("bca5ec9a-2d13-4dbd-a458-0188e1e7ebcb"), new Guid("4250b84c-9f30-4c03-93d4-92eb58d08e02"), 5, 0 },
                    { new Guid("bee3110c-2c63-4b84-b41e-dfe089f62413"), new Guid("f800af09-0788-45b6-98ac-ef6cb6dfc557"), 2, 3 },
                    { new Guid("cca8819a-964b-41f7-86a0-dad1ec081569"), new Guid("adcc2ec4-d4f5-45c4-b386-5096508223e0"), 3, 1 },
                    { new Guid("cef46b75-9b43-4a90-940f-747d8fca986f"), new Guid("4250b84c-9f30-4c03-93d4-92eb58d08e02"), 3, 2 },
                    { new Guid("d063af2d-3635-4a7b-9606-75e1fb06e219"), new Guid("8940c59f-6466-4e0e-8945-486b7145d179"), 5, 0 },
                    { new Guid("e41dc0a8-c696-4cb0-9d51-92345b6a9d78"), new Guid("adcc2ec4-d4f5-45c4-b386-5096508223e0"), 2, 3 },
                    { new Guid("e909ff3d-0c91-4483-90dc-8e88fc78bb3d"), new Guid("4250b84c-9f30-4c03-93d4-92eb58d08e02"), 2, 3 },
                    { new Guid("f0f9ee45-0907-4143-b365-354522a798da"), new Guid("f800af09-0788-45b6-98ac-ef6cb6dfc557"), 3, 2 },
                    { new Guid("f1bc03c1-f186-4030-bddb-e326998d4004"), new Guid("4250b84c-9f30-4c03-93d4-92eb58d08e02"), 3, 2 },
                    { new Guid("fce6bd74-9290-457e-a901-0f0248e56f78"), new Guid("5c57b250-a067-4be8-a3af-43c54cc35498"), 5, 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductsSizes_ProductId",
                table: "ProductsSizes",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductsSizes");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("1cf9f2b4-0e64-4124-9cf8-4fd8fe538a0d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("363ae2d7-a678-49da-872a-4f4a9841923b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("fe0a538d-dad1-47c0-b3eb-a54d94c64562"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("01fcff3e-ddcf-4ba2-b8b9-bc7b03754158"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("05bdfe57-556a-4c35-a252-f5628586f678"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("05c15053-ec60-4081-9500-8c7b4971f89c"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("08d99d05-0945-4e51-a751-59d72978f089"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("092a29b6-8f6e-446f-9e2a-9457b1294be9"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("0a3a5138-da15-40bc-a2eb-8e410c49033e"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("0f935ee2-19fd-4c41-be9e-d9b8daaadc27"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("1249ce56-063d-433a-b91a-83bf61600a82"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("1710e139-dc76-47bb-8ddb-48d91e3cc815"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("21d7b796-28b3-46e6-923d-c222c114674d"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("31fea592-39a4-4c10-ad00-c9f19c82800a"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("44ad5fc4-498c-40e9-b4d1-542af305b883"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("4520e4fe-d36e-4fc8-be52-9193bca83cb1"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("478c030c-3581-4fa9-8d1e-f7a6d719f63b"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("4a4e7847-a702-4251-bf39-e958493c447c"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("568560e8-44ee-4e36-a11c-4d3bb4dd075e"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("56c7b526-0e08-4eae-9b86-f436919d11ba"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("5c8da350-bfdc-423b-81ab-ded14fc0a7ff"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("65cd7419-91c5-4a04-9090-5be332451473"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("68eff0bd-ecd9-4af3-90dc-4cf685211d39"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("6b4d5efa-52ba-46b7-8719-7f3b80c39fc8"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("6f8c6ad0-fa8a-4762-bde6-b87fbec2b83d"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("70509756-4e3e-4e1a-b17c-0546caa6fdde"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("7121476d-6a7f-4b1b-9003-99732c906ff0"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("73f3a3d5-61ff-4914-9f8b-8aa5d6bc0d72"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("763967fe-9591-4c3c-b33a-4d4f1d4c5453"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("84227c06-0bbc-4bc3-a435-2da1927915e2"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("8ca0acee-bcda-460a-9bab-8bdc2c5d926d"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("925cdf79-68b1-43a1-8ffd-89b3c9305188"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("9a6ce95c-c0cf-4f8b-953a-30cb4c27c186"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("a134f408-2f64-4365-b521-c7da3eb067e6"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("a50a7f4b-8938-4b41-8742-a091cb1de909"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("a54863e3-3f56-499f-a47d-ff1454c7ff6c"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("a8a627cb-30e2-4884-a3ac-bc9feb60448f"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("aa317113-eb02-4553-932f-0659afb672c7"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("aae97d3f-56d0-4377-90a9-c55245719fb8"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("c125731c-2674-48a5-ac13-3e791152c25d"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("c87256c5-effb-4ce8-a252-75a3dd22b8d4"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("d0628309-84a3-4582-898a-64afdc55d856"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("e2d7918c-f3ff-4b80-b2ee-91f96afe9f86"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("e833d14c-cdc6-4d4d-aa32-9eb630ac1e16"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("f1c0d30e-a94d-4bc3-8422-d0efcf2a1c44"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("099661b9-b063-4519-bce7-82abb2820761"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("0c650eb0-67d8-42a1-bf25-980feb18c774"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("0fa30324-ecd7-486b-acc8-5448f5e24817"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1e45cd74-8414-40be-8718-24927f81b1a4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4250b84c-9f30-4c03-93d4-92eb58d08e02"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("5c57b250-a067-4be8-a3af-43c54cc35498"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("78695d5e-e776-4580-aa0f-bcfdc113ae57"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("8940c59f-6466-4e0e-8945-486b7145d179"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("adcc2ec4-d4f5-45c4-b386-5096508223e0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b00cb628-a48b-4fb7-8249-56314c1331d4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c8f80589-4602-4dc8-a6a8-9ed74ce130b3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e93fa539-a119-4d87-b082-2d3d6931400c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f800af09-0788-45b6-98ac-ef6cb6dfc557"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f858c8bd-435c-47c7-a043-a68b047ae167"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("41fdcbdb-7af7-408c-865b-f2b477564d69"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("5d7ae267-d077-42df-826e-a4f207c1313b"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("87210bf7-d293-4a64-af95-84956f70dfae"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("b3264ae4-0d56-47a0-9cd0-016d0423afd7"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("bd258b07-bc9e-4fb4-86ea-c8dba4e664b8"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("c8aaba5e-4da9-421a-9502-821d5c6b9870"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("ce1d95f0-5c19-4a29-8e6d-d2efc9c25fff"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("dc564a23-3ed0-489a-b761-3088744bea69"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("e0699947-e12e-45b5-a224-9351b5667657"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("f23f3ec9-afa7-4208-a434-810f463813f8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("4e759408-2bb2-4b9f-ae3f-ab5f6fb386c6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("7b20ae15-7263-4c5b-b9dd-faa437c8d315"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("81bb71bd-4675-4285-b0d2-4c55c88ab605"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("8f7b013f-2dbb-4ab9-af7c-d701203f0819"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("8fac897d-1c6a-4532-82cc-d5dbe3aa58d5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ce7c29c0-3efa-4766-8e72-7bc59e68ead0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f9b3cbac-43d3-4720-a790-e435b5cc33f5"));

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
    }
}
