using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KickShop.Migrations
{
    /// <inheritdoc />
    public partial class AddedBrandDescription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Categories",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                comment: "Image For The Category",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true,
                oldComment: "Image For The Category");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Brands",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Brands");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Categories",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                comment: "Image For The Category",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldComment: "Image For The Category");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

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
    }
}
