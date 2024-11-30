using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KickShop.Migrations
{
    /// <inheritdoc />
    public partial class FixedProductImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("12f6bcd6-c132-44a4-b2e9-2ea4e4dd801b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("92ebddb4-d2f7-4ab2-8184-7cc5b914ee6e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("b2099065-84da-4598-816d-6820000e5ef5"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("00da48df-ae44-447b-b65a-ba81682ba872"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("01c27d60-30d6-4bbd-b505-db5974b75dc8"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("023ce6d6-836c-4c55-b526-656b73c652fb"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("0359ed64-ddff-4c77-8114-64b8bb156df0"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("04e77520-f5ac-429f-a277-2fe83732713e"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("06fcc56d-6345-4d29-8926-deb08c59bfc5"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("088ce089-5199-4c9d-8392-28f79f1d288e"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("11e7e8a1-a00a-4717-8e95-92695270cf09"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("1fdc5ef2-f140-4860-82b6-c18f2babf804"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("2cd66ddc-94dd-4da3-9706-ebfdb889805e"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("3124fef1-11a9-4a3f-a6a8-c553cc7ff36f"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("3372f2d2-1020-407f-b60e-de9a1f6cda95"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("48bb9f50-b7bd-484f-9614-281014f65811"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("49736e76-f343-406c-aeb1-98e00ee3cf28"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("4980fdf9-5313-432f-9d56-31f22f5e46ac"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("4c8accb3-ac6f-4340-8c31-dd976d068d67"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("5ed0944f-eed3-402b-909e-ffc93e2aacf4"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("637dfb3d-41ad-47e2-b2da-69329ea28823"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("6e614e8f-8904-4e66-b476-96f0c03c644c"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("75ae742d-201c-421f-8811-a09ddbd79075"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("7c4b67ca-fc0f-410b-99ae-58a073f29010"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("828ade31-7fae-4776-a16d-24f20355ea12"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("8cd2409f-936f-4e51-b31a-97f5e6c34025"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("92e7316e-cb60-4272-b479-f77066eb8fb3"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("96be1222-3c24-42b0-94e3-4ffbb2321407"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("a609a811-fc40-47ab-9f93-eac7c8ac8922"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("ab269797-cc6b-4947-b4e4-81560142ec05"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("b01e41b6-d569-49d1-ab8b-293c68a93604"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("b1bbf380-2958-4de0-aec0-76140dfcfc08"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("be6280da-63e0-4df5-a46d-37ccf71a7833"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("c9e0080b-594e-4f39-972c-3f3cb6d9341e"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("cb53850c-ad85-4ffb-952b-595adc025736"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("ccd6a712-8d3f-4c54-90bd-554c6e1ca63d"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("db17a92a-9f67-43fd-a993-c8af2566221d"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("dddc98d6-1ae4-4fca-8cb2-96ae6fac81df"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("e4b32ac3-38f8-430a-b13d-a8761992a1e6"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("e6eaf909-f650-42d2-ac1e-a5baf1aa4b97"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("e8fbed13-9b8e-4dde-b807-0ef965c42c0d"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("e96ded05-61fe-4f89-bafb-29fc3b6e4cde"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("ea0e456a-642e-4b64-89ca-d06be08655e4"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("ec0a8a7c-0135-46f2-8a53-4d5025cb0936"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("f04bbcd2-b0c8-4ed1-a6ae-05ae532312ee"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("01c35dc4-8b23-4fb3-9610-1c722b6d1d9b"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("04fdf50b-2e4a-460c-b6a5-6f7b51b9f12b"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("2597bcb3-407c-45d2-9abb-239485a8cae5"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("26d111af-9655-466e-802f-1d982a7473be"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("2b2e5afb-328b-4a40-b3e5-88c863a90952"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("2b4935de-ef98-4ba5-9e50-db7231313c61"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("2c0f3337-8091-4ffd-8b43-0234e56a5c19"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("2cdcf9ef-12b1-4c28-a8cf-b2f17c9b21c9"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("2d5d6567-c335-4213-96a2-6052d69e9f3f"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("328e2aaf-dd93-481f-a8a2-2b1c24189dd7"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("3406946a-397f-4db8-a433-ef2bcd74918b"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("3f113265-7cc9-4911-8e39-b12fe0e2f62c"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("4d66a864-6c4d-4145-ac37-628c71697155"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("5337aa1e-fb45-44d4-befc-53a404846f01"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("587cac19-91bd-4945-8789-850657b140e9"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("5ae53ab5-c77a-4e3f-b7f2-155e4f1b072b"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("5f7cda02-04f0-49dd-9ac9-80233fae5b28"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("6873509f-ee23-4cb4-828b-74f6b7e9e72c"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("68809631-4cd4-43c9-ac41-1e7ac130447a"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("6a37de0e-9a80-4cc3-b7e3-91cb9ea2f382"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("6fba5c0a-29f6-42ba-a1f8-9dd219f2f7c4"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("7f557209-ddf9-466e-8f6a-4944903bd710"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("891fb7a3-e8e1-46ba-8ec0-3a581d74c59e"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("8c7d84e0-d77e-4c2e-8cc0-3ee565a9961f"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("8e2c4720-7a85-4043-89b2-f232595f4455"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("9686436b-8a10-4bd6-a7b4-3c0e6b14d79d"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("97328485-a623-41fb-af51-0d7e8d470d77"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("9796696e-e39f-43fa-bc8b-99b575c88caf"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("a2fcf86a-3518-4b0a-9938-4e1df1c079e2"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("a46a22fe-662c-4bdc-b4c8-d225e76bd57b"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("a5f16a40-cd51-4c88-998c-42ab2b39f922"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("aefa8aee-71ee-429e-823b-18bca17eee6f"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("b15dc1d6-b2d2-4f91-a43f-bd11f7276bc8"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("b2c81973-b8c1-4694-bef0-7b4d4bf2c3d4"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("b72b64a3-1fbf-4ec5-886d-514242c86760"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("baceb27b-b530-4b55-a75e-eaaa53b5751a"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("e69233eb-0995-432a-944b-7e526e42a8df"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("e7ba3bac-d75d-416d-bbfb-b67fd34a071e"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("eaaa7b6d-6b40-45ad-bd22-d38652a1d3e1"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("ebc61b2d-92d8-4583-84c0-ef2ec5ad66e8"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("f9b067db-763d-4d93-9f79-2381d70ebfc8"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("fe7240c1-aa14-4010-bcd1-0109fad70305"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("166dcc51-a346-4607-8102-54e7e6ba48ab"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1e8851a0-2c59-4997-bf76-c5316ca76812"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("3e690f70-0989-46f7-82ac-45a15f80afb1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("414c35e9-bc13-4aaa-909f-502ef7bd5829"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("5110dda2-a6ae-472c-9f45-3dda1b7ce0ce"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("523a9aad-21f7-4aef-8d55-37a11f8a81e9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("74243aba-de23-4783-8d20-0f11151eea08"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("8310c25f-88a5-4c25-8586-31a737135336"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("90127731-f304-4cf1-a238-c4dd151f96ea"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a19a673a-be70-4967-aa88-979a4864e3e3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b50a1d20-f032-41aa-903d-ea56e9ac8e1f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c9443397-a67d-49a8-9140-d321b5ce6c1b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f02fc5a7-e275-41c4-937b-2242ff3811b4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("fbc86e42-74ba-4da8-bd63-00a6126a8f41"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("8dd18690-744f-41db-9188-17db973744ac"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("a2f70f2e-faea-4070-9059-f3bcc9baba3a"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("aaa2005b-aee5-476f-8d81-0f2778b7b541"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("b8bf5096-a6c7-4de9-90fb-28f11ce8cf9f"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("b92e5835-81bf-4b21-9334-d1f6f57d9326"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("dc1bdc6f-0b1c-4273-94d8-72e90adca6b8"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("e4e0bbc3-9032-4cdd-bd18-a560a551272b"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("e64cc050-5a8a-4166-8860-64c2561cc99c"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("e75b2bfa-2387-4358-9178-6a55961c308f"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("eb95471e-1a08-4f59-b339-d3776465c7ba"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("0da1de74-b5b6-4c11-b48c-736cc36fed1c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("1c23d6cd-494e-482f-977b-7e0424d452ec"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("20f235f4-493d-4c79-b885-e11caa02dc87"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("410af451-d9e6-4e12-b047-364aa44806fb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("79b2bbbf-45d5-4bc1-9f24-dc46aa28cc1f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("c410d212-9230-48bc-ad56-25afdbfad9cb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("dddaf511-15a3-4b3a-8a19-5b86e9ad2e37"));

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandId", "Address", "Country", "Description", "ImageUrl", "IsDeleted", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("0a457bdb-fae0-4d2f-b317-9ba0318032f9"), "456 Ring Rd, Chicago, IL", "USA", "Ringside is a trusted name in boxing and kickboxing, providing high-performance equipment and apparel. Its focus on durability and craftsmanship has made it a favorite among gyms and professionals.", "/images/Brands/ringside-logo.png", false, "Ringside", "234-567-8901" },
                    { new Guid("0fad9a37-6573-4a00-b97a-b7b51ad299ca"), "123 Boxing Blvd, New York, NY", "USA", "Known as one of the oldest and most reputable brands in the boxing world, Everlast is a staple in combat sports. From gloves to training equipment, Everlast provides high-quality gear trusted by professional fighters and trainers alike.", "/images/Brands/everlast-logo.png", false, "Everlast", "123-456-7890" },
                    { new Guid("1b81fe75-1c4e-4680-919e-89927cd65b45"), "234 Fighter Rd, Bangkok, TH", "Thailand", "Fairtex is a legendary Thai brand specializing in Muay Thai and kickboxing gear. Renowned for its authenticity and quality, Fairtex is the choice of champions in traditional and modern combat sports.", "/images/Brands/fairtex-logo.png", false, "Fairtex", "876-543-2109" },
                    { new Guid("1f3b6147-13b8-4847-899d-4af6cb76107c"), "101 Martial Arts Way, Paris, FR", "France", "Venum is a globally recognized brand known for its bold designs and top-tier combat sports equipment. From gloves to apparel, Venum caters to athletes who demand performance and style in the ring and beyond.", "/images/Brands/venum-logo.png", false, "Venum", "321-654-0987" },
                    { new Guid("265a7b81-e95d-47d6-8c54-ece57cfb7dd2"), "789 Fight St, Toronto, ON", "Canada", "Hayabusa is synonymous with premium quality and cutting-edge technology in combat sports. Their gloves and apparel are designed to provide exceptional protection, performance, and style for fighters at all levels.", "/images/Brands/hayabusa-logo.png", false, "Hayabusa", "789-012-3456" },
                    { new Guid("45e37b31-a2b7-45b4-a832-363cfbd40892"), "678 Fighter Ave, Miami, FL", "USA", "Sanabul is a modern combat sports brand offering stylish and affordable gear. Its products are designed for both beginners and experienced athletes, with a focus on innovation and performance.", "/images/Brands/sanabul-logo.png", false, "Sanabul", "456-789-0123" },
                    { new Guid("641da266-5f2b-4bdb-a747-f7376b9904e0"), "456 Sports Ave, London, UK", "UK", "RDX is renowned for its innovative designs and durable equipment that cater to a wide range of combat sports, including kickboxing, MMA, and boxing. Its focus on affordability and quality makes it a favorite among beginners and professionals.", "/images/Brands/rdx-logo.png", false, "RDX", "456-789-0123" },
                    { new Guid("80e01246-493b-4d12-bb49-777dd89129d7"), "789 Kick Rd, Phuket, TH", "Thailand", "Twins Special is a renowned brand in Muay Thai and kickboxing, celebrated for its handcrafted gear. Their gloves and pads are known for their durability, quality, and traditional Thai craftsmanship.", "/images/Brands/twins-special-logo.png", false, "Twins Special", "567-890-1234" },
                    { new Guid("9cb658b0-2fda-40ed-909c-ef275e5b419a"), "567 Martial Arts Blvd, Oklahoma City, OK", "USA", "Century is known for its innovative training gear, including punching bags and protective equipment. Widely used in martial arts and kickboxing, Century products are designed to enhance performance and safety.", "/images/Brands/century-logo.png", false, "Century", "345-678-9012" },
                    { new Guid("efc5fb88-4732-41ce-8e48-569142e2d619"), "345 Punch Ln, Los Angeles, CA", "USA", "Title Boxing is a leading brand offering an extensive range of boxing and kickboxing gear. Known for its reliability and innovation, Title Boxing supports athletes with training and competition essentials.", "/images/Brands/title-boxing-logo.png", false, "Title Boxing", "987-654-3210" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "ImageUrl", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { new Guid("04a9988c-bbf9-4c3f-8006-0a3c4ce0f7e2"), "/images/Categegories/boxing-gloves.jfif", false, "Gloves" },
                    { new Guid("16b710e0-ad6f-436b-bcd3-9363e40a8e92"), "/images/Categories/protective-equipment.jfif", false, "Protective Gear" },
                    { new Guid("18e924de-efbe-433d-a750-f66b189621ea"), "/images/Categories/clothing.png", false, "Clothing" },
                    { new Guid("57856a12-6d32-497e-b547-4c95c5097a1a"), "/images/Categories/hand-wraps.png", false, "Hand Wraps" },
                    { new Guid("7ee01dcc-113b-4275-9638-49d010f78fca"), "/images/Categories/shin-guards.png", false, "Shinguards" },
                    { new Guid("93f51c99-6ea7-4c19-92cd-17c1f9fccf15"), "/images/Categories/punching-bag.png", false, "Punching Bags" },
                    { new Guid("c4a87ea7-82ff-49ba-9048-8ecedee74a89"), "/images/Categories/mouth-guard.png", false, "Mouthguards" },
                    { new Guid("c9f23e98-2564-4147-892b-d92df694417f"), "/images/Categories/head-gear.png", false, "Headgear" },
                    { new Guid("cdcd2ab9-ee34-4f68-9a34-93ef830ea4a5"), "/images/Categories/training-equipment.png", false, "Training Equipment" },
                    { new Guid("f6147de2-7827-403a-9c96-caa5e284ec8d"), "/images/Categories/boxing-shoes.png", false, "Shoes" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "BrandId", "CategoryId", "Description", "IsDeleted", "MainImageUrl", "Name", "Price", "StockQuantity" },
                values: new object[,]
                {
                    { new Guid("01fac9c7-ec81-4eb2-99df-25836585baf7"), new Guid("efc5fb88-4732-41ce-8e48-569142e2d619"), new Guid("04a9988c-bbf9-4c3f-8006-0a3c4ce0f7e2"), "Durable leather gloves for heavy bag workouts.", false, "/images/Products/title-boxing-bag/title-boxing-bag-1.png", "Title Boxing Leather Bag Gloves", 79.99m, 80 },
                    { new Guid("0a7c4563-18be-41d6-88df-040e7aa14f93"), new Guid("1f3b6147-13b8-4847-899d-4af6cb76107c"), new Guid("7ee01dcc-113b-4275-9638-49d010f78fca"), "High-durability shin guards ideal for intense training.", false, "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-1.png", "Venum Challenger Shin Guards", 105.99m, 95 },
                    { new Guid("1247bdaf-9e7e-486b-aef7-cb681ed69f37"), new Guid("0fad9a37-6573-4a00-b97a-b7b51ad299ca"), new Guid("c9f23e98-2564-4147-892b-d92df694417f"), "Full-protection headgear with durable padding.", false, "/images/Products/everlast-pro-headgear/everlast-headgear-1.png", "Everlast Pro Headgear", 89.99m, 50 },
                    { new Guid("1e6ee021-4e96-4403-8fac-1e24bc264e74"), new Guid("45e37b31-a2b7-45b4-a832-363cfbd40892"), new Guid("7ee01dcc-113b-4275-9638-49d010f78fca"), "High-quality shin guards for protection and mobility.", false, "/images/Products/sanabul-shin-guards/sanabul-shin-guards-1.png", "Sanabul Essential Shin Guards", 105.99m, 90 },
                    { new Guid("420718bc-b26e-4951-89cc-cd4baa0d6a43"), new Guid("641da266-5f2b-4bdb-a747-f7376b9904e0"), new Guid("04a9988c-bbf9-4c3f-8006-0a3c4ce0f7e2"), "High-quality leather gloves for all training levels.", false, "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-3.png", "RDX Boxing Gloves", 109.99m, 100 },
                    { new Guid("433f4d59-70a8-4b1e-8e4a-584b71e86997"), new Guid("9cb658b0-2fda-40ed-909c-ef275e5b419a"), new Guid("18e924de-efbe-433d-a750-f66b189621ea"), "Comfortable shorts designed for kickboxing.", false, "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-1.png", "Century Martial Arts Kickboxing Shorts", 79.99m, 75 },
                    { new Guid("4b01f5a8-60fc-4e2a-97f3-079fa84fd218"), new Guid("efc5fb88-4732-41ce-8e48-569142e2d619"), new Guid("93f51c99-6ea7-4c19-92cd-17c1f9fccf15"), "Perfect for accuracy and reflex training.", false, "/images/Products/title-boxing-gloves/title-boxing-gloves-1.png", "Title Boxing Double End Bag", 99.99m, 70 },
                    { new Guid("57616035-f962-4293-a645-70cf30c1183f"), new Guid("1b81fe75-1c4e-4680-919e-89927cd65b45"), new Guid("18e924de-efbe-433d-a750-f66b189621ea"), "Premium Muay Thai shorts with authentic design.", false, "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-1.png", "Fairtex Muay Thai Shorts", 84.99m, 90 },
                    { new Guid("70a954a4-a4ca-41fa-bfd4-04faa0d30464"), new Guid("1f3b6147-13b8-4847-899d-4af6cb76107c"), new Guid("04a9988c-bbf9-4c3f-8006-0a3c4ce0f7e2"), "Lightweight and designed for all skill levels.", false, "/images/Products/venum-challenger-gloves/venum-challenger-gloves-2.png", "Venum Challenger Gloves", 89.99m, 120 },
                    { new Guid("8fec6f75-cbaf-432b-bf84-9ce3cae6e71e"), new Guid("641da266-5f2b-4bdb-a747-f7376b9904e0"), new Guid("f6147de2-7827-403a-9c96-caa5e284ec8d"), "Lightweight and supportive for agility in the ring.", false, "/images/Products/rdx-boxing-shoes/rdx-boxing-shoes-1.png", "RDX Pro Boxing Shoes", 109.99m, 65 },
                    { new Guid("a0e23902-34db-4e25-bfb6-1a66a6b14a28"), new Guid("80e01246-493b-4d12-bb49-777dd89129d7"), new Guid("c9f23e98-2564-4147-892b-d92df694417f"), "Full-face protection with Twins quality.", false, "/images/Products/twins-special-headgear/twins-special-headgear-1.png", "Twins Special Headgear", 89.99m, 60 },
                    { new Guid("c9f707b9-9808-4b2e-be68-82cd69ba313e"), new Guid("0fad9a37-6573-4a00-b97a-b7b51ad299ca"), new Guid("57856a12-6d32-497e-b547-4c95c5097a1a"), "Classic wraps for wrist and knuckle protection.", false, "/images/Products/everlast-hand-wraps/everlast-hand-wraps-3.png", "Everlast Hand Wraps", 9.99m, 200 },
                    { new Guid("cfebc903-48aa-41f4-a9bf-78d9b5cf8e5f"), new Guid("0a457bdb-fae0-4d2f-b317-9ba0318032f9"), new Guid("93f51c99-6ea7-4c19-92cd-17c1f9fccf15"), "Heavy-duty bag for all levels of training.", false, "/images/Products/ringside-punching-bag/ringside-punching-bag-1.png", "Ringside Punching Bag", 219.99m, 40 },
                    { new Guid("de9f4f15-1a08-4ea8-9015-9c17cb32bc35"), new Guid("265a7b81-e95d-47d6-8c54-ece57cfb7dd2"), new Guid("04a9988c-bbf9-4c3f-8006-0a3c4ce0f7e2"), "Top-notch gloves with exceptional durability.", false, "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-1.png", "Hayabusa T3 Boxing Gloves", 189.99m, 50 }
                });

            migrationBuilder.InsertData(
                table: "ProductsImages",
                columns: new[] { "ImageId", "ImageUrl", "ProductId" },
                values: new object[,]
                {
                    { new Guid("0378f98f-c384-4850-83cd-01b4c84f0d28"), "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-3.png", new Guid("420718bc-b26e-4951-89cc-cd4baa0d6a43") },
                    { new Guid("0a1ab9da-90f0-4757-ab34-3ad85079ba2d"), "/images/Products/everlasr-pro-headgear/everlast-headgear-1.png", new Guid("1247bdaf-9e7e-486b-aef7-cb681ed69f37") },
                    { new Guid("103381bf-07d4-4a7a-a45b-e67d3297297f"), "/images/Products/everlasr-pro-headgear/everlast-headgear-3.png", new Guid("1247bdaf-9e7e-486b-aef7-cb681ed69f37") },
                    { new Guid("1cb9a7c9-a46a-426b-a4d4-5522fe4df1e1"), "/images/Products/rdx-boxing-shoes/rdx-boxing-shoes-1.png", new Guid("8fec6f75-cbaf-432b-bf84-9ce3cae6e71e") },
                    { new Guid("204188f3-fe61-4874-a497-744c6332f606"), "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-1.png", new Guid("433f4d59-70a8-4b1e-8e4a-584b71e86997") },
                    { new Guid("309b2169-62dc-4199-ba8b-76c7e134b00d"), "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-2.png", new Guid("de9f4f15-1a08-4ea8-9015-9c17cb32bc35") },
                    { new Guid("3229d94d-0f26-41a7-bdb5-6439265a9512"), "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-1.png", new Guid("de9f4f15-1a08-4ea8-9015-9c17cb32bc35") },
                    { new Guid("3936e9d7-85f1-417d-859c-e311ab4d5212"), "/images/Products/title-boxing-bag/title-boxing-bag-2.png", new Guid("01fac9c7-ec81-4eb2-99df-25836585baf7") },
                    { new Guid("3a1d77bb-1462-459d-960d-512d5347a169"), "/images/Products/venum-challenger-gloves/venum-challenger-gloves-2.png", new Guid("70a954a4-a4ca-41fa-bfd4-04faa0d30464") },
                    { new Guid("3bfb9d33-8dc8-49f9-b979-85292864fb17"), "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-2.png", new Guid("420718bc-b26e-4951-89cc-cd4baa0d6a43") },
                    { new Guid("43ae2813-9e0f-42d0-9130-01982133e5a2"), "/images/Products/sanabul-shin-guards/sanabul-shin-guards-1.png", new Guid("1e6ee021-4e96-4403-8fac-1e24bc264e74") },
                    { new Guid("4ee5dc22-547c-4321-b434-5c9527443f14"), "/images/Products/title-boxing-bag/title-boxing-bag-1.png", new Guid("01fac9c7-ec81-4eb2-99df-25836585baf7") },
                    { new Guid("587228fe-faa6-476d-a823-d5c4ffbabdd6"), "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-3.png", new Guid("57616035-f962-4293-a645-70cf30c1183f") },
                    { new Guid("5d730ebd-abeb-49d6-8980-c5355c25f69e"), "/images/Products/sanabul-shin-guards/sanabul-shin-guards-2.png", new Guid("1e6ee021-4e96-4403-8fac-1e24bc264e74") },
                    { new Guid("61155500-fe9d-4a75-81ed-3267dd7cf126"), "/images/Products/title-boxing-gloves/title-boxing-gloves-3.png", new Guid("4b01f5a8-60fc-4e2a-97f3-079fa84fd218") },
                    { new Guid("63762a6f-ccf3-4c38-9f4d-64810e3bb6ec"), "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-2.png", new Guid("433f4d59-70a8-4b1e-8e4a-584b71e86997") },
                    { new Guid("694fabed-9d7e-49ee-9728-b12c3e7f81c5"), "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-2.png", new Guid("0a7c4563-18be-41d6-88df-040e7aa14f93") },
                    { new Guid("69a3d28f-a1bd-4f42-b41d-72c9218ae9fa"), "/images/Products/title-boxing-gloves/title-boxing-gloves-2.png", new Guid("4b01f5a8-60fc-4e2a-97f3-079fa84fd218") },
                    { new Guid("70174abf-7f29-4af3-91d0-4139385f3e71"), "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-3.png", new Guid("0a7c4563-18be-41d6-88df-040e7aa14f93") },
                    { new Guid("7133926d-52ff-432d-8874-0b7c95f23522"), "/images/Products/everlast-hand-wraps/everlast-hand-wraps-3.png", new Guid("c9f707b9-9808-4b2e-be68-82cd69ba313e") },
                    { new Guid("777f7be2-688c-4c83-be9e-25352d556ea4"), "/images/Products/everlast-hand-wraps/everlast-hand-wraps-1.png", new Guid("c9f707b9-9808-4b2e-be68-82cd69ba313e") },
                    { new Guid("78bbca5f-ce0a-4b0c-a876-eba03efd2db3"), "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-1.png", new Guid("420718bc-b26e-4951-89cc-cd4baa0d6a43") },
                    { new Guid("7b695cd1-916c-48a7-a925-7aa1f3003451"), "/images/Products/rdx-boxing-shoes/rdx-boxing-shoes-2.png", new Guid("8fec6f75-cbaf-432b-bf84-9ce3cae6e71e") },
                    { new Guid("7c3b8fcc-068d-4288-9355-7b9e9ba4f022"), "/images/Products/rdx-boxing-shoes/rdx-boxing-shoes-3.png", new Guid("8fec6f75-cbaf-432b-bf84-9ce3cae6e71e") },
                    { new Guid("7fe4e026-21fb-421a-b9ff-06e80a404da7"), "/images/Products/everlast-hand-wraps/everlast-hand-wraps-2.png", new Guid("c9f707b9-9808-4b2e-be68-82cd69ba313e") },
                    { new Guid("80d46aba-72b1-470d-8758-c3f76195a7ed"), "/images/Products/venum-challenger-gloves/venum-challenger-gloves-1.png", new Guid("70a954a4-a4ca-41fa-bfd4-04faa0d30464") },
                    { new Guid("911ba8ac-3b90-4de7-99a2-f7752dc05960"), "/images/Products/sanabul-shin-guards/sanabul-shin-guards-3.png", new Guid("1e6ee021-4e96-4403-8fac-1e24bc264e74") },
                    { new Guid("9c62c314-b5ff-42cd-b469-7d5d4c792767"), "/images/Products/everlasr-pro-headgear/everlast-headgear-2.png", new Guid("1247bdaf-9e7e-486b-aef7-cb681ed69f37") },
                    { new Guid("9d31a0b7-5a0f-48d0-843f-194b8422e422"), "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-3.png", new Guid("433f4d59-70a8-4b1e-8e4a-584b71e86997") },
                    { new Guid("a6bb325e-5551-4000-914f-4b78762d0691"), "/images/Products/venum-challenger-gloves/venum-challenger-gloves-3.png", new Guid("70a954a4-a4ca-41fa-bfd4-04faa0d30464") },
                    { new Guid("a815dafb-ace3-4ed2-aeea-0f79580243d7"), "/images/Products/twins-special-headgear/twins-shin-headgear-3.png", new Guid("a0e23902-34db-4e25-bfb6-1a66a6b14a28") },
                    { new Guid("a9c9d30a-524a-444d-b335-7f2d8aa5928f"), "/images/Products/ringside-punching-bag/ringside-punching-bag-3.png", new Guid("cfebc903-48aa-41f4-a9bf-78d9b5cf8e5f") },
                    { new Guid("abd93bc7-3fb9-4bdc-9083-512c14546f1d"), "/images/Products/title-boxing-bag/title-boxing-bag-3.png", new Guid("01fac9c7-ec81-4eb2-99df-25836585baf7") },
                    { new Guid("ae6f8e8e-d469-41ab-954b-fc6db48c0cd0"), "/images/Products/ringside-punching-bag/ringside-punching-bag-1.png", new Guid("cfebc903-48aa-41f4-a9bf-78d9b5cf8e5f") },
                    { new Guid("b29daa9e-8c73-421d-8120-c8dea7d3f44c"), "/images/Products/title-boxing-gloves/title-boxing-gloves-1.png", new Guid("4b01f5a8-60fc-4e2a-97f3-079fa84fd218") },
                    { new Guid("c64671da-ac45-4186-8376-3f2fcb4bd510"), "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-1.png", new Guid("57616035-f962-4293-a645-70cf30c1183f") },
                    { new Guid("cc702434-e7d8-410a-a2b8-cccb06113d86"), "/images/Products/twins-special-headgear/twins-special-headgear-2.png", new Guid("a0e23902-34db-4e25-bfb6-1a66a6b14a28") },
                    { new Guid("d3165999-3389-4168-a47e-1afff106e8a6"), "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-2.png", new Guid("57616035-f962-4293-a645-70cf30c1183f") },
                    { new Guid("d73c0d77-c70f-4dc9-8e40-caf9318f3d96"), "/images/Products/ringside-punching-bag/ringside-punching-bag-2.png", new Guid("cfebc903-48aa-41f4-a9bf-78d9b5cf8e5f") },
                    { new Guid("e93b73cc-e889-4fc4-91fc-55fa54c090e5"), "/images/Products/twins-special-headgear/twins-special-headgear-1.png", new Guid("a0e23902-34db-4e25-bfb6-1a66a6b14a28") },
                    { new Guid("eeeff871-e30d-4191-94b4-6e959644d214"), "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-3.png", new Guid("de9f4f15-1a08-4ea8-9015-9c17cb32bc35") },
                    { new Guid("efdc6553-b4e1-434a-a4e5-8c226373ac92"), "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-1.png", new Guid("0a7c4563-18be-41d6-88df-040e7aa14f93") }
                });

            migrationBuilder.InsertData(
                table: "ProductsSizes",
                columns: new[] { "ProductSizeId", "ProductId", "Quantity", "Size" },
                values: new object[,]
                {
                    { new Guid("0072d697-d183-4350-b1df-ddb41e1d4363"), new Guid("01fac9c7-ec81-4eb2-99df-25836585baf7"), 5, 0 },
                    { new Guid("0a84a930-98dd-407f-800a-1bb691c4e258"), new Guid("433f4d59-70a8-4b1e-8e4a-584b71e86997"), 3, 2 },
                    { new Guid("0e34741c-ec41-458a-a1d8-216aa801065f"), new Guid("0a7c4563-18be-41d6-88df-040e7aa14f93"), 3, 2 },
                    { new Guid("15c2488b-585d-42ec-be5d-65f3acc5394f"), new Guid("70a954a4-a4ca-41fa-bfd4-04faa0d30464"), 3, 4 },
                    { new Guid("16fe0db0-daea-44c7-840d-2e683da7c31f"), new Guid("c9f707b9-9808-4b2e-be68-82cd69ba313e"), 5, 0 },
                    { new Guid("26f1474d-213c-40ef-89b6-4faaef8fac84"), new Guid("70a954a4-a4ca-41fa-bfd4-04faa0d30464"), 2, 3 },
                    { new Guid("2be0ce7e-7d01-4127-9214-088ef1584386"), new Guid("8fec6f75-cbaf-432b-bf84-9ce3cae6e71e"), 3, 2 },
                    { new Guid("2c47d5fd-55cb-4e54-a742-7f5ec0ef0a60"), new Guid("1e6ee021-4e96-4403-8fac-1e24bc264e74"), 2, 3 },
                    { new Guid("2d8ae64d-8a72-4156-9043-f3139c206db6"), new Guid("8fec6f75-cbaf-432b-bf84-9ce3cae6e71e"), 2, 3 },
                    { new Guid("33dbe8b9-b674-4be1-ad59-de5479f6c2d4"), new Guid("1247bdaf-9e7e-486b-aef7-cb681ed69f37"), 2, 3 },
                    { new Guid("34dbc851-d0f8-4f6b-a09b-88ea6f6c4d55"), new Guid("0a7c4563-18be-41d6-88df-040e7aa14f93"), 5, 0 },
                    { new Guid("3d35b8dd-5941-4ea0-bd35-3e8126ae9d3f"), new Guid("0a7c4563-18be-41d6-88df-040e7aa14f93"), 2, 3 },
                    { new Guid("3f2152e3-7a9a-42ab-81b0-20085353c2ac"), new Guid("cfebc903-48aa-41f4-a9bf-78d9b5cf8e5f"), 2, 3 },
                    { new Guid("46c105be-a1f5-4792-962b-9ee42c826a17"), new Guid("420718bc-b26e-4951-89cc-cd4baa0d6a43"), 5, 0 },
                    { new Guid("5f524be9-895d-4777-b54e-ef6e55dc9b39"), new Guid("57616035-f962-4293-a645-70cf30c1183f"), 2, 3 },
                    { new Guid("68c99e32-f2f0-44d2-a53f-98aed48afb6b"), new Guid("1e6ee021-4e96-4403-8fac-1e24bc264e74"), 3, 6 },
                    { new Guid("70d5370d-55f6-4aba-a435-811cb4a5b7b1"), new Guid("c9f707b9-9808-4b2e-be68-82cd69ba313e"), 3, 2 },
                    { new Guid("7257ef04-ca35-4e0f-829e-5348c5929808"), new Guid("cfebc903-48aa-41f4-a9bf-78d9b5cf8e5f"), 3, 2 },
                    { new Guid("737f3735-695a-4e6b-81e0-084af556bcd9"), new Guid("a0e23902-34db-4e25-bfb6-1a66a6b14a28"), 3, 2 },
                    { new Guid("841899f8-a370-4f79-8b5f-c53d94d6576c"), new Guid("1247bdaf-9e7e-486b-aef7-cb681ed69f37"), 5, 0 },
                    { new Guid("849ee6ad-8adc-4fbf-af22-ef114716fe2b"), new Guid("01fac9c7-ec81-4eb2-99df-25836585baf7"), 2, 3 },
                    { new Guid("85412caa-44ba-4675-965b-ff633d2d3c62"), new Guid("de9f4f15-1a08-4ea8-9015-9c17cb32bc35"), 5, 0 },
                    { new Guid("89194aff-16e4-4646-9191-7feb78c99551"), new Guid("cfebc903-48aa-41f4-a9bf-78d9b5cf8e5f"), 5, 0 },
                    { new Guid("907539d2-b8f4-4830-b443-9d1c3dfe5624"), new Guid("1e6ee021-4e96-4403-8fac-1e24bc264e74"), 5, 0 },
                    { new Guid("96d6f208-b018-40d2-9e44-ed53a467bf41"), new Guid("433f4d59-70a8-4b1e-8e4a-584b71e86997"), 5, 0 },
                    { new Guid("9b349a37-1f22-40dd-b613-e0faa46dcb33"), new Guid("c9f707b9-9808-4b2e-be68-82cd69ba313e"), 2, 3 },
                    { new Guid("9c74dc55-7d2d-465e-9599-a54634ece658"), new Guid("4b01f5a8-60fc-4e2a-97f3-079fa84fd218"), 3, 2 },
                    { new Guid("a150272c-ffc0-487f-b219-ef6d20b92d46"), new Guid("8fec6f75-cbaf-432b-bf84-9ce3cae6e71e"), 5, 0 },
                    { new Guid("a27891f1-5c5e-4332-98f2-834bffa8121d"), new Guid("4b01f5a8-60fc-4e2a-97f3-079fa84fd218"), 2, 3 },
                    { new Guid("aaa938c8-4a84-4d61-b5af-7a3c84bc524a"), new Guid("433f4d59-70a8-4b1e-8e4a-584b71e86997"), 2, 3 },
                    { new Guid("b3b76293-993c-4fd8-8322-372668f03b31"), new Guid("a0e23902-34db-4e25-bfb6-1a66a6b14a28"), 2, 3 },
                    { new Guid("b4a10ce5-e5d6-43c5-803b-f7182ac077e5"), new Guid("4b01f5a8-60fc-4e2a-97f3-079fa84fd218"), 5, 0 },
                    { new Guid("b67e4d90-a9ab-4c50-8faf-c001965a2f8b"), new Guid("57616035-f962-4293-a645-70cf30c1183f"), 5, 0 },
                    { new Guid("bb67be5a-3808-4c59-b7f1-69344d30f663"), new Guid("57616035-f962-4293-a645-70cf30c1183f"), 3, 2 },
                    { new Guid("c3fc506c-479e-43db-acdc-b98fa2446b43"), new Guid("a0e23902-34db-4e25-bfb6-1a66a6b14a28"), 5, 0 },
                    { new Guid("c92015c9-5284-4fd2-ac6c-8019fae257ce"), new Guid("de9f4f15-1a08-4ea8-9015-9c17cb32bc35"), 3, 1 },
                    { new Guid("ce3f438c-6123-42e3-81f9-f3eb54226f41"), new Guid("1247bdaf-9e7e-486b-aef7-cb681ed69f37"), 3, 2 },
                    { new Guid("d14a059a-005c-4e68-878f-15410dd7ea9b"), new Guid("420718bc-b26e-4951-89cc-cd4baa0d6a43"), 3, 2 },
                    { new Guid("d5125a3f-e975-42d5-9093-5b5fcecd3df1"), new Guid("de9f4f15-1a08-4ea8-9015-9c17cb32bc35"), 2, 3 },
                    { new Guid("f65c326f-fcda-4962-bf89-ba366dfff7f5"), new Guid("01fac9c7-ec81-4eb2-99df-25836585baf7"), 3, 5 },
                    { new Guid("f6998a31-ebc4-48f3-91bc-75af27474ec9"), new Guid("70a954a4-a4ca-41fa-bfd4-04faa0d30464"), 5, 0 },
                    { new Guid("fef9527a-66b7-438c-a760-5a841372735c"), new Guid("420718bc-b26e-4951-89cc-cd4baa0d6a43"), 2, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("16b710e0-ad6f-436b-bcd3-9363e40a8e92"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("c4a87ea7-82ff-49ba-9048-8ecedee74a89"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("cdcd2ab9-ee34-4f68-9a34-93ef830ea4a5"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("0378f98f-c384-4850-83cd-01b4c84f0d28"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("0a1ab9da-90f0-4757-ab34-3ad85079ba2d"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("103381bf-07d4-4a7a-a45b-e67d3297297f"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("1cb9a7c9-a46a-426b-a4d4-5522fe4df1e1"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("204188f3-fe61-4874-a497-744c6332f606"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("309b2169-62dc-4199-ba8b-76c7e134b00d"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("3229d94d-0f26-41a7-bdb5-6439265a9512"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("3936e9d7-85f1-417d-859c-e311ab4d5212"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("3a1d77bb-1462-459d-960d-512d5347a169"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("3bfb9d33-8dc8-49f9-b979-85292864fb17"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("43ae2813-9e0f-42d0-9130-01982133e5a2"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("4ee5dc22-547c-4321-b434-5c9527443f14"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("587228fe-faa6-476d-a823-d5c4ffbabdd6"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("5d730ebd-abeb-49d6-8980-c5355c25f69e"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("61155500-fe9d-4a75-81ed-3267dd7cf126"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("63762a6f-ccf3-4c38-9f4d-64810e3bb6ec"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("694fabed-9d7e-49ee-9728-b12c3e7f81c5"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("69a3d28f-a1bd-4f42-b41d-72c9218ae9fa"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("70174abf-7f29-4af3-91d0-4139385f3e71"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("7133926d-52ff-432d-8874-0b7c95f23522"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("777f7be2-688c-4c83-be9e-25352d556ea4"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("78bbca5f-ce0a-4b0c-a876-eba03efd2db3"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("7b695cd1-916c-48a7-a925-7aa1f3003451"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("7c3b8fcc-068d-4288-9355-7b9e9ba4f022"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("7fe4e026-21fb-421a-b9ff-06e80a404da7"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("80d46aba-72b1-470d-8758-c3f76195a7ed"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("911ba8ac-3b90-4de7-99a2-f7752dc05960"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("9c62c314-b5ff-42cd-b469-7d5d4c792767"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("9d31a0b7-5a0f-48d0-843f-194b8422e422"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("a6bb325e-5551-4000-914f-4b78762d0691"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("a815dafb-ace3-4ed2-aeea-0f79580243d7"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("a9c9d30a-524a-444d-b335-7f2d8aa5928f"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("abd93bc7-3fb9-4bdc-9083-512c14546f1d"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("ae6f8e8e-d469-41ab-954b-fc6db48c0cd0"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("b29daa9e-8c73-421d-8120-c8dea7d3f44c"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("c64671da-ac45-4186-8376-3f2fcb4bd510"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("cc702434-e7d8-410a-a2b8-cccb06113d86"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("d3165999-3389-4168-a47e-1afff106e8a6"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("d73c0d77-c70f-4dc9-8e40-caf9318f3d96"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("e93b73cc-e889-4fc4-91fc-55fa54c090e5"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("eeeff871-e30d-4191-94b4-6e959644d214"));

            migrationBuilder.DeleteData(
                table: "ProductsImages",
                keyColumn: "ImageId",
                keyValue: new Guid("efdc6553-b4e1-434a-a4e5-8c226373ac92"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("0072d697-d183-4350-b1df-ddb41e1d4363"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("0a84a930-98dd-407f-800a-1bb691c4e258"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("0e34741c-ec41-458a-a1d8-216aa801065f"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("15c2488b-585d-42ec-be5d-65f3acc5394f"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("16fe0db0-daea-44c7-840d-2e683da7c31f"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("26f1474d-213c-40ef-89b6-4faaef8fac84"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("2be0ce7e-7d01-4127-9214-088ef1584386"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("2c47d5fd-55cb-4e54-a742-7f5ec0ef0a60"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("2d8ae64d-8a72-4156-9043-f3139c206db6"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("33dbe8b9-b674-4be1-ad59-de5479f6c2d4"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("34dbc851-d0f8-4f6b-a09b-88ea6f6c4d55"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("3d35b8dd-5941-4ea0-bd35-3e8126ae9d3f"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("3f2152e3-7a9a-42ab-81b0-20085353c2ac"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("46c105be-a1f5-4792-962b-9ee42c826a17"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("5f524be9-895d-4777-b54e-ef6e55dc9b39"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("68c99e32-f2f0-44d2-a53f-98aed48afb6b"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("70d5370d-55f6-4aba-a435-811cb4a5b7b1"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("7257ef04-ca35-4e0f-829e-5348c5929808"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("737f3735-695a-4e6b-81e0-084af556bcd9"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("841899f8-a370-4f79-8b5f-c53d94d6576c"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("849ee6ad-8adc-4fbf-af22-ef114716fe2b"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("85412caa-44ba-4675-965b-ff633d2d3c62"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("89194aff-16e4-4646-9191-7feb78c99551"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("907539d2-b8f4-4830-b443-9d1c3dfe5624"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("96d6f208-b018-40d2-9e44-ed53a467bf41"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("9b349a37-1f22-40dd-b613-e0faa46dcb33"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("9c74dc55-7d2d-465e-9599-a54634ece658"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("a150272c-ffc0-487f-b219-ef6d20b92d46"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("a27891f1-5c5e-4332-98f2-834bffa8121d"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("aaa938c8-4a84-4d61-b5af-7a3c84bc524a"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("b3b76293-993c-4fd8-8322-372668f03b31"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("b4a10ce5-e5d6-43c5-803b-f7182ac077e5"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("b67e4d90-a9ab-4c50-8faf-c001965a2f8b"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("bb67be5a-3808-4c59-b7f1-69344d30f663"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("c3fc506c-479e-43db-acdc-b98fa2446b43"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("c92015c9-5284-4fd2-ac6c-8019fae257ce"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("ce3f438c-6123-42e3-81f9-f3eb54226f41"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("d14a059a-005c-4e68-878f-15410dd7ea9b"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("d5125a3f-e975-42d5-9093-5b5fcecd3df1"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("f65c326f-fcda-4962-bf89-ba366dfff7f5"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("f6998a31-ebc4-48f3-91bc-75af27474ec9"));

            migrationBuilder.DeleteData(
                table: "ProductsSizes",
                keyColumn: "ProductSizeId",
                keyValue: new Guid("fef9527a-66b7-438c-a760-5a841372735c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("01fac9c7-ec81-4eb2-99df-25836585baf7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("0a7c4563-18be-41d6-88df-040e7aa14f93"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1247bdaf-9e7e-486b-aef7-cb681ed69f37"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1e6ee021-4e96-4403-8fac-1e24bc264e74"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("420718bc-b26e-4951-89cc-cd4baa0d6a43"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("433f4d59-70a8-4b1e-8e4a-584b71e86997"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4b01f5a8-60fc-4e2a-97f3-079fa84fd218"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("57616035-f962-4293-a645-70cf30c1183f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("70a954a4-a4ca-41fa-bfd4-04faa0d30464"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("8fec6f75-cbaf-432b-bf84-9ce3cae6e71e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a0e23902-34db-4e25-bfb6-1a66a6b14a28"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c9f707b9-9808-4b2e-be68-82cd69ba313e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("cfebc903-48aa-41f4-a9bf-78d9b5cf8e5f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("de9f4f15-1a08-4ea8-9015-9c17cb32bc35"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("0a457bdb-fae0-4d2f-b317-9ba0318032f9"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("0fad9a37-6573-4a00-b97a-b7b51ad299ca"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("1b81fe75-1c4e-4680-919e-89927cd65b45"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("1f3b6147-13b8-4847-899d-4af6cb76107c"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("265a7b81-e95d-47d6-8c54-ece57cfb7dd2"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("45e37b31-a2b7-45b4-a832-363cfbd40892"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("641da266-5f2b-4bdb-a747-f7376b9904e0"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("80e01246-493b-4d12-bb49-777dd89129d7"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("9cb658b0-2fda-40ed-909c-ef275e5b419a"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("efc5fb88-4732-41ce-8e48-569142e2d619"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("04a9988c-bbf9-4c3f-8006-0a3c4ce0f7e2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("18e924de-efbe-433d-a750-f66b189621ea"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("57856a12-6d32-497e-b547-4c95c5097a1a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("7ee01dcc-113b-4275-9638-49d010f78fca"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("93f51c99-6ea7-4c19-92cd-17c1f9fccf15"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("c9f23e98-2564-4147-892b-d92df694417f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f6147de2-7827-403a-9c96-caa5e284ec8d"));

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandId", "Address", "Country", "Description", "ImageUrl", "IsDeleted", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("8dd18690-744f-41db-9188-17db973744ac"), "567 Martial Arts Blvd, Oklahoma City, OK", "USA", "Century is known for its innovative training gear, including punching bags and protective equipment. Widely used in martial arts and kickboxing, Century products are designed to enhance performance and safety.", "/images/Brands/century-logo.png", false, "Century", "345-678-9012" },
                    { new Guid("a2f70f2e-faea-4070-9059-f3bcc9baba3a"), "456 Ring Rd, Chicago, IL", "USA", "Ringside is a trusted name in boxing and kickboxing, providing high-performance equipment and apparel. Its focus on durability and craftsmanship has made it a favorite among gyms and professionals.", "/images/Brands/ringside-logo.png", false, "Ringside", "234-567-8901" },
                    { new Guid("aaa2005b-aee5-476f-8d81-0f2778b7b541"), "123 Boxing Blvd, New York, NY", "USA", "Known as one of the oldest and most reputable brands in the boxing world, Everlast is a staple in combat sports. From gloves to training equipment, Everlast provides high-quality gear trusted by professional fighters and trainers alike.", "/images/Brands/everlast-logo.png", false, "Everlast", "123-456-7890" },
                    { new Guid("b8bf5096-a6c7-4de9-90fb-28f11ce8cf9f"), "678 Fighter Ave, Miami, FL", "USA", "Sanabul is a modern combat sports brand offering stylish and affordable gear. Its products are designed for both beginners and experienced athletes, with a focus on innovation and performance.", "/images/Brands/sanabul-logo.png", false, "Sanabul", "456-789-0123" },
                    { new Guid("b92e5835-81bf-4b21-9334-d1f6f57d9326"), "101 Martial Arts Way, Paris, FR", "France", "Venum is a globally recognized brand known for its bold designs and top-tier combat sports equipment. From gloves to apparel, Venum caters to athletes who demand performance and style in the ring and beyond.", "/images/Brands/venum-logo.png", false, "Venum", "321-654-0987" },
                    { new Guid("dc1bdc6f-0b1c-4273-94d8-72e90adca6b8"), "789 Kick Rd, Phuket, TH", "Thailand", "Twins Special is a renowned brand in Muay Thai and kickboxing, celebrated for its handcrafted gear. Their gloves and pads are known for their durability, quality, and traditional Thai craftsmanship.", "/images/Brands/twins-special-logo.png", false, "Twins Special", "567-890-1234" },
                    { new Guid("e4e0bbc3-9032-4cdd-bd18-a560a551272b"), "234 Fighter Rd, Bangkok, TH", "Thailand", "Fairtex is a legendary Thai brand specializing in Muay Thai and kickboxing gear. Renowned for its authenticity and quality, Fairtex is the choice of champions in traditional and modern combat sports.", "/images/Brands/fairtex-logo.png", false, "Fairtex", "876-543-2109" },
                    { new Guid("e64cc050-5a8a-4166-8860-64c2561cc99c"), "789 Fight St, Toronto, ON", "Canada", "Hayabusa is synonymous with premium quality and cutting-edge technology in combat sports. Their gloves and apparel are designed to provide exceptional protection, performance, and style for fighters at all levels.", "/images/Brands/hayabusa-logo.png", false, "Hayabusa", "789-012-3456" },
                    { new Guid("e75b2bfa-2387-4358-9178-6a55961c308f"), "345 Punch Ln, Los Angeles, CA", "USA", "Title Boxing is a leading brand offering an extensive range of boxing and kickboxing gear. Known for its reliability and innovation, Title Boxing supports athletes with training and competition essentials.", "/images/Brands/title-boxing-logo.png", false, "Title Boxing", "987-654-3210" },
                    { new Guid("eb95471e-1a08-4f59-b339-d3776465c7ba"), "456 Sports Ave, London, UK", "UK", "RDX is renowned for its innovative designs and durable equipment that cater to a wide range of combat sports, including kickboxing, MMA, and boxing. Its focus on affordability and quality makes it a favorite among beginners and professionals.", "/images/Brands/rdx-logo.png", false, "RDX", "456-789-0123" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "ImageUrl", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { new Guid("0da1de74-b5b6-4c11-b48c-736cc36fed1c"), "/images/Categories/head-gear.png", false, "Headgear" },
                    { new Guid("12f6bcd6-c132-44a4-b2e9-2ea4e4dd801b"), "/images/Categories/training-equipment.png", false, "Training Equipment" },
                    { new Guid("1c23d6cd-494e-482f-977b-7e0424d452ec"), "/images/Categories/shin-guards.png", false, "Shinguards" },
                    { new Guid("20f235f4-493d-4c79-b885-e11caa02dc87"), "/images/Categories/hand-wraps.png", false, "Hand Wraps" },
                    { new Guid("410af451-d9e6-4e12-b047-364aa44806fb"), "/images/Categories/punching-bag.png", false, "Punching Bags" },
                    { new Guid("79b2bbbf-45d5-4bc1-9f24-dc46aa28cc1f"), "/images/Categories/clothing.png", false, "Clothing" },
                    { new Guid("92ebddb4-d2f7-4ab2-8184-7cc5b914ee6e"), "/images/Categories/mouth-guard.png", false, "Mouthguards" },
                    { new Guid("b2099065-84da-4598-816d-6820000e5ef5"), "/images/Categories/protective-equipment.jfif", false, "Protective Gear" },
                    { new Guid("c410d212-9230-48bc-ad56-25afdbfad9cb"), "/images/Categories/boxing-shoes.png", false, "Shoes" },
                    { new Guid("dddaf511-15a3-4b3a-8a19-5b86e9ad2e37"), "/images/Categegories/boxing-gloves.jfif", false, "Gloves" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "BrandId", "CategoryId", "Description", "IsDeleted", "MainImageUrl", "Name", "Price", "StockQuantity" },
                values: new object[,]
                {
                    { new Guid("166dcc51-a346-4607-8102-54e7e6ba48ab"), new Guid("aaa2005b-aee5-476f-8d81-0f2778b7b541"), new Guid("20f235f4-493d-4c79-b885-e11caa02dc87"), "Classic wraps for wrist and knuckle protection.", false, "/images/Products/everlast-hand-wraps/everlast-hand-wraps-3.png", "Everlast Hand Wraps", 9.99m, 200 },
                    { new Guid("1e8851a0-2c59-4997-bf76-c5316ca76812"), new Guid("e4e0bbc3-9032-4cdd-bd18-a560a551272b"), new Guid("79b2bbbf-45d5-4bc1-9f24-dc46aa28cc1f"), "Premium Muay Thai shorts with authentic design.", false, "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-1.png", "Fairtex Muay Thai Shorts", 84.99m, 90 },
                    { new Guid("3e690f70-0989-46f7-82ac-45a15f80afb1"), new Guid("e75b2bfa-2387-4358-9178-6a55961c308f"), new Guid("dddaf511-15a3-4b3a-8a19-5b86e9ad2e37"), "Durable leather gloves for heavy bag workouts.", false, "/images/Products/title-boxing-bag/title-boxing-bag-1.png", "Title Boxing Leather Bag Gloves", 79.99m, 80 },
                    { new Guid("414c35e9-bc13-4aaa-909f-502ef7bd5829"), new Guid("aaa2005b-aee5-476f-8d81-0f2778b7b541"), new Guid("0da1de74-b5b6-4c11-b48c-736cc36fed1c"), "Full-protection headgear with durable padding.", false, "/images/Products/everlast-pro-headgear/everlast-headgear-1.png", "Everlast Pro Headgear", 89.99m, 50 },
                    { new Guid("5110dda2-a6ae-472c-9f45-3dda1b7ce0ce"), new Guid("eb95471e-1a08-4f59-b339-d3776465c7ba"), new Guid("c410d212-9230-48bc-ad56-25afdbfad9cb"), "Lightweight and supportive for agility in the ring.", false, "/images/Products/rdx-boxing-shoes/rdx-boxing-shoes-1.png", "RDX Pro Boxing Shoes", 109.99m, 65 },
                    { new Guid("523a9aad-21f7-4aef-8d55-37a11f8a81e9"), new Guid("e64cc050-5a8a-4166-8860-64c2561cc99c"), new Guid("dddaf511-15a3-4b3a-8a19-5b86e9ad2e37"), "Top-notch gloves with exceptional durability.", false, "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-1.png", "Hayabusa T3 Boxing Gloves", 189.99m, 50 },
                    { new Guid("74243aba-de23-4783-8d20-0f11151eea08"), new Guid("e75b2bfa-2387-4358-9178-6a55961c308f"), new Guid("410af451-d9e6-4e12-b047-364aa44806fb"), "Perfect for accuracy and reflex training.", false, "/images/Products/title-boxing-gloves/title-boxing-gloves-1.png", "Title Boxing Double End Bag", 99.99m, 70 },
                    { new Guid("8310c25f-88a5-4c25-8586-31a737135336"), new Guid("b92e5835-81bf-4b21-9334-d1f6f57d9326"), new Guid("1c23d6cd-494e-482f-977b-7e0424d452ec"), "High-durability shin guards ideal for intense training.", false, "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-1.png", "Venum Challenger Shin Guards", 105.99m, 95 },
                    { new Guid("90127731-f304-4cf1-a238-c4dd151f96ea"), new Guid("8dd18690-744f-41db-9188-17db973744ac"), new Guid("79b2bbbf-45d5-4bc1-9f24-dc46aa28cc1f"), "Comfortable shorts designed for kickboxing.", false, "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-1.png", "Century Martial Arts Kickboxing Shorts", 79.99m, 75 },
                    { new Guid("a19a673a-be70-4967-aa88-979a4864e3e3"), new Guid("b8bf5096-a6c7-4de9-90fb-28f11ce8cf9f"), new Guid("1c23d6cd-494e-482f-977b-7e0424d452ec"), "High-quality shin guards for protection and mobility.", false, "/images/Products/sanabul-shin-guards/sanabul-shin-guards-1.png", "Sanabul Essential Shin Guards", 105.99m, 90 },
                    { new Guid("b50a1d20-f032-41aa-903d-ea56e9ac8e1f"), new Guid("dc1bdc6f-0b1c-4273-94d8-72e90adca6b8"), new Guid("0da1de74-b5b6-4c11-b48c-736cc36fed1c"), "Full-face protection with Twins quality.", false, "/images/Products/twins-special-headgear/twins-special-headgear-1.png", "Twins Special Headgear", 89.99m, 60 },
                    { new Guid("c9443397-a67d-49a8-9140-d321b5ce6c1b"), new Guid("a2f70f2e-faea-4070-9059-f3bcc9baba3a"), new Guid("410af451-d9e6-4e12-b047-364aa44806fb"), "Heavy-duty bag for all levels of training.", false, "/images/Products/ringside-punching-bag/ringside-punching-bag-1.png", "Ringside Punching Bag", 219.99m, 40 },
                    { new Guid("f02fc5a7-e275-41c4-937b-2242ff3811b4"), new Guid("b92e5835-81bf-4b21-9334-d1f6f57d9326"), new Guid("dddaf511-15a3-4b3a-8a19-5b86e9ad2e37"), "Lightweight and designed for all skill levels.", false, "/images/Products/venum-challenger-gloves/venum-challenger-gloves-2.png", "Venum Challenger Gloves", 89.99m, 120 },
                    { new Guid("fbc86e42-74ba-4da8-bd63-00a6126a8f41"), new Guid("eb95471e-1a08-4f59-b339-d3776465c7ba"), new Guid("dddaf511-15a3-4b3a-8a19-5b86e9ad2e37"), "High-quality leather gloves for all training levels.", false, "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-3.png", "RDX Boxing Gloves", 109.99m, 100 }
                });

            migrationBuilder.InsertData(
                table: "ProductsImages",
                columns: new[] { "ImageId", "ImageUrl", "ProductId" },
                values: new object[,]
                {
                    { new Guid("00da48df-ae44-447b-b65a-ba81682ba872"), "/images/Products/title-boxing-bag/title-boxing-bag-2.png", new Guid("3e690f70-0989-46f7-82ac-45a15f80afb1") },
                    { new Guid("01c27d60-30d6-4bbd-b505-db5974b75dc8"), "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-2.png", new Guid("fbc86e42-74ba-4da8-bd63-00a6126a8f41") },
                    { new Guid("023ce6d6-836c-4c55-b526-656b73c652fb"), "/images/Products/title-boxing-gloves/title-boxing-gloves-2.png", new Guid("74243aba-de23-4783-8d20-0f11151eea08") },
                    { new Guid("0359ed64-ddff-4c77-8114-64b8bb156df0"), "/images/Products/sanabul-shin-guards/sanabul-shin-guards-1.png", new Guid("a19a673a-be70-4967-aa88-979a4864e3e3") },
                    { new Guid("04e77520-f5ac-429f-a277-2fe83732713e"), "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-2.png", new Guid("90127731-f304-4cf1-a238-c4dd151f96ea") },
                    { new Guid("06fcc56d-6345-4d29-8926-deb08c59bfc5"), "/images/Products/ringside-punching-bag/ringside-punching-bag-2.png", new Guid("c9443397-a67d-49a8-9140-d321b5ce6c1b") },
                    { new Guid("088ce089-5199-4c9d-8392-28f79f1d288e"), "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-3.png", new Guid("fbc86e42-74ba-4da8-bd63-00a6126a8f41") },
                    { new Guid("11e7e8a1-a00a-4717-8e95-92695270cf09"), "/images/Products/title-boxing-bag/title-boxing-bag-3.png", new Guid("3e690f70-0989-46f7-82ac-45a15f80afb1") },
                    { new Guid("1fdc5ef2-f140-4860-82b6-c18f2babf804"), "/images/Products/title-boxing-gloves/title-boxing-gloves-3.png", new Guid("74243aba-de23-4783-8d20-0f11151eea08") },
                    { new Guid("2cd66ddc-94dd-4da3-9706-ebfdb889805e"), "/images/Products/everlast-hand-wraps/everlast-hand-wraps-2.png", new Guid("166dcc51-a346-4607-8102-54e7e6ba48ab") },
                    { new Guid("3124fef1-11a9-4a3f-a6a8-c553cc7ff36f"), "/images/Products/ringside-punching-bag/ringside-punching-bag-3.png", new Guid("c9443397-a67d-49a8-9140-d321b5ce6c1b") },
                    { new Guid("3372f2d2-1020-407f-b60e-de9a1f6cda95"), "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-1.png", new Guid("8310c25f-88a5-4c25-8586-31a737135336") },
                    { new Guid("48bb9f50-b7bd-484f-9614-281014f65811"), "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-3.png", new Guid("8310c25f-88a5-4c25-8586-31a737135336") },
                    { new Guid("49736e76-f343-406c-aeb1-98e00ee3cf28"), "/images/Products/venum-challenger-gloves/venum-challenger-gloves-3.png", new Guid("f02fc5a7-e275-41c4-937b-2242ff3811b4") },
                    { new Guid("4980fdf9-5313-432f-9d56-31f22f5e46ac"), "/images/Products/venum-challenger-gloves/venum-challenger-gloves-2.png", new Guid("f02fc5a7-e275-41c4-937b-2242ff3811b4") },
                    { new Guid("4c8accb3-ac6f-4340-8c31-dd976d068d67"), "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-2.png", new Guid("1e8851a0-2c59-4997-bf76-c5316ca76812") },
                    { new Guid("5ed0944f-eed3-402b-909e-ffc93e2aacf4"), "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-3.png", new Guid("523a9aad-21f7-4aef-8d55-37a11f8a81e9") },
                    { new Guid("637dfb3d-41ad-47e2-b2da-69329ea28823"), "/images/Products/rdx-boxing-shoes/rdx-boxing-shoes-2.png", new Guid("5110dda2-a6ae-472c-9f45-3dda1b7ce0ce") },
                    { new Guid("6e614e8f-8904-4e66-b476-96f0c03c644c"), "/images/Products/twins-special-headgear/twins-special-headgear-2.png", new Guid("b50a1d20-f032-41aa-903d-ea56e9ac8e1f") },
                    { new Guid("75ae742d-201c-421f-8811-a09ddbd79075"), "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-2.png", new Guid("8310c25f-88a5-4c25-8586-31a737135336") },
                    { new Guid("7c4b67ca-fc0f-410b-99ae-58a073f29010"), "/images/Products/title-boxing-gloves/title-boxing-gloves-1.png", new Guid("74243aba-de23-4783-8d20-0f11151eea08") },
                    { new Guid("828ade31-7fae-4776-a16d-24f20355ea12"), "/images/Products/everlasr-pro-headgear/everlast-headgear-2.png", new Guid("414c35e9-bc13-4aaa-909f-502ef7bd5829") },
                    { new Guid("8cd2409f-936f-4e51-b31a-97f5e6c34025"), "/images/Products/title-boxing-bag/title-boxing-bag-1.png", new Guid("3e690f70-0989-46f7-82ac-45a15f80afb1") },
                    { new Guid("92e7316e-cb60-4272-b479-f77066eb8fb3"), "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-2.png", new Guid("523a9aad-21f7-4aef-8d55-37a11f8a81e9") },
                    { new Guid("96be1222-3c24-42b0-94e3-4ffbb2321407"), "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-3.png", new Guid("90127731-f304-4cf1-a238-c4dd151f96ea") },
                    { new Guid("a609a811-fc40-47ab-9f93-eac7c8ac8922"), "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-1.png", new Guid("523a9aad-21f7-4aef-8d55-37a11f8a81e9") },
                    { new Guid("ab269797-cc6b-4947-b4e4-81560142ec05"), "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-3.png", new Guid("1e8851a0-2c59-4997-bf76-c5316ca76812") },
                    { new Guid("b01e41b6-d569-49d1-ab8b-293c68a93604"), "/images/Products/rdx-boxing-shoes/rdx-boxing-shoes-3.png", new Guid("5110dda2-a6ae-472c-9f45-3dda1b7ce0ce") },
                    { new Guid("b1bbf380-2958-4de0-aec0-76140dfcfc08"), "/images/Products/twins-special-headgear/twins-special-headgear-1.png", new Guid("b50a1d20-f032-41aa-903d-ea56e9ac8e1f") },
                    { new Guid("be6280da-63e0-4df5-a46d-37ccf71a7833"), "/images/Products/ringside-punching-bag/ringside-punching-bag-1.png", new Guid("c9443397-a67d-49a8-9140-d321b5ce6c1b") },
                    { new Guid("c9e0080b-594e-4f39-972c-3f3cb6d9341e"), "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-1.png", new Guid("90127731-f304-4cf1-a238-c4dd151f96ea") },
                    { new Guid("cb53850c-ad85-4ffb-952b-595adc025736"), "/images/Products/everlasr-pro-headgear/everlast-headgear-3.png", new Guid("414c35e9-bc13-4aaa-909f-502ef7bd5829") },
                    { new Guid("ccd6a712-8d3f-4c54-90bd-554c6e1ca63d"), "/images/Products/everlast-hand-wraps/everlast-hand-wraps-1.png", new Guid("166dcc51-a346-4607-8102-54e7e6ba48ab") },
                    { new Guid("db17a92a-9f67-43fd-a993-c8af2566221d"), "/images/Products/sanabul-shin-guards/sanabul-shin-guards-2.png", new Guid("a19a673a-be70-4967-aa88-979a4864e3e3") },
                    { new Guid("dddc98d6-1ae4-4fca-8cb2-96ae6fac81df"), "/images/Products/everlast-hand-wraps/everlast-hand-wraps-3.png", new Guid("166dcc51-a346-4607-8102-54e7e6ba48ab") },
                    { new Guid("e4b32ac3-38f8-430a-b13d-a8761992a1e6"), "/images/Products/rdx-boxing-shoes/rdx-boxing-shoes-1.png", new Guid("5110dda2-a6ae-472c-9f45-3dda1b7ce0ce") },
                    { new Guid("e6eaf909-f650-42d2-ac1e-a5baf1aa4b97"), "/images/Products/venum-challenger-gloves/venum-challenger-gloves-1.png", new Guid("f02fc5a7-e275-41c4-937b-2242ff3811b4") },
                    { new Guid("e8fbed13-9b8e-4dde-b807-0ef965c42c0d"), "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-1.png", new Guid("1e8851a0-2c59-4997-bf76-c5316ca76812") },
                    { new Guid("e96ded05-61fe-4f89-bafb-29fc3b6e4cde"), "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-1.png", new Guid("fbc86e42-74ba-4da8-bd63-00a6126a8f41") },
                    { new Guid("ea0e456a-642e-4b64-89ca-d06be08655e4"), "/images/Products/twins-special-headgear/twins-shin-headgear-3.png", new Guid("b50a1d20-f032-41aa-903d-ea56e9ac8e1f") },
                    { new Guid("ec0a8a7c-0135-46f2-8a53-4d5025cb0936"), "/images/Products/everlasr-pro-headgear/everlast-headgear-1.png", new Guid("414c35e9-bc13-4aaa-909f-502ef7bd5829") },
                    { new Guid("f04bbcd2-b0c8-4ed1-a6ae-05ae532312ee"), "/images/Products/sanabul-shin-guards/sanabul-shin-guards-3.png", new Guid("a19a673a-be70-4967-aa88-979a4864e3e3") }
                });

            migrationBuilder.InsertData(
                table: "ProductsSizes",
                columns: new[] { "ProductSizeId", "ProductId", "Quantity", "Size" },
                values: new object[,]
                {
                    { new Guid("01c35dc4-8b23-4fb3-9610-1c722b6d1d9b"), new Guid("5110dda2-a6ae-472c-9f45-3dda1b7ce0ce"), 5, 0 },
                    { new Guid("04fdf50b-2e4a-460c-b6a5-6f7b51b9f12b"), new Guid("5110dda2-a6ae-472c-9f45-3dda1b7ce0ce"), 3, 2 },
                    { new Guid("2597bcb3-407c-45d2-9abb-239485a8cae5"), new Guid("a19a673a-be70-4967-aa88-979a4864e3e3"), 5, 0 },
                    { new Guid("26d111af-9655-466e-802f-1d982a7473be"), new Guid("166dcc51-a346-4607-8102-54e7e6ba48ab"), 3, 2 },
                    { new Guid("2b2e5afb-328b-4a40-b3e5-88c863a90952"), new Guid("5110dda2-a6ae-472c-9f45-3dda1b7ce0ce"), 2, 3 },
                    { new Guid("2b4935de-ef98-4ba5-9e50-db7231313c61"), new Guid("74243aba-de23-4783-8d20-0f11151eea08"), 2, 3 },
                    { new Guid("2c0f3337-8091-4ffd-8b43-0234e56a5c19"), new Guid("523a9aad-21f7-4aef-8d55-37a11f8a81e9"), 3, 1 },
                    { new Guid("2cdcf9ef-12b1-4c28-a8cf-b2f17c9b21c9"), new Guid("fbc86e42-74ba-4da8-bd63-00a6126a8f41"), 3, 2 },
                    { new Guid("2d5d6567-c335-4213-96a2-6052d69e9f3f"), new Guid("a19a673a-be70-4967-aa88-979a4864e3e3"), 3, 6 },
                    { new Guid("328e2aaf-dd93-481f-a8a2-2b1c24189dd7"), new Guid("523a9aad-21f7-4aef-8d55-37a11f8a81e9"), 2, 3 },
                    { new Guid("3406946a-397f-4db8-a433-ef2bcd74918b"), new Guid("fbc86e42-74ba-4da8-bd63-00a6126a8f41"), 3, 2 },
                    { new Guid("3f113265-7cc9-4911-8e39-b12fe0e2f62c"), new Guid("90127731-f304-4cf1-a238-c4dd151f96ea"), 2, 3 },
                    { new Guid("4d66a864-6c4d-4145-ac37-628c71697155"), new Guid("f02fc5a7-e275-41c4-937b-2242ff3811b4"), 5, 0 },
                    { new Guid("5337aa1e-fb45-44d4-befc-53a404846f01"), new Guid("b50a1d20-f032-41aa-903d-ea56e9ac8e1f"), 2, 3 },
                    { new Guid("587cac19-91bd-4945-8789-850657b140e9"), new Guid("fbc86e42-74ba-4da8-bd63-00a6126a8f41"), 5, 0 },
                    { new Guid("5ae53ab5-c77a-4e3f-b7f2-155e4f1b072b"), new Guid("3e690f70-0989-46f7-82ac-45a15f80afb1"), 3, 5 },
                    { new Guid("5f7cda02-04f0-49dd-9ac9-80233fae5b28"), new Guid("74243aba-de23-4783-8d20-0f11151eea08"), 5, 0 },
                    { new Guid("6873509f-ee23-4cb4-828b-74f6b7e9e72c"), new Guid("90127731-f304-4cf1-a238-c4dd151f96ea"), 3, 2 },
                    { new Guid("68809631-4cd4-43c9-ac41-1e7ac130447a"), new Guid("1e8851a0-2c59-4997-bf76-c5316ca76812"), 3, 2 },
                    { new Guid("6a37de0e-9a80-4cc3-b7e3-91cb9ea2f382"), new Guid("3e690f70-0989-46f7-82ac-45a15f80afb1"), 2, 3 },
                    { new Guid("6fba5c0a-29f6-42ba-a1f8-9dd219f2f7c4"), new Guid("166dcc51-a346-4607-8102-54e7e6ba48ab"), 5, 0 },
                    { new Guid("7f557209-ddf9-466e-8f6a-4944903bd710"), new Guid("b50a1d20-f032-41aa-903d-ea56e9ac8e1f"), 5, 0 },
                    { new Guid("891fb7a3-e8e1-46ba-8ec0-3a581d74c59e"), new Guid("8310c25f-88a5-4c25-8586-31a737135336"), 5, 0 },
                    { new Guid("8c7d84e0-d77e-4c2e-8cc0-3ee565a9961f"), new Guid("fbc86e42-74ba-4da8-bd63-00a6126a8f41"), 2, 3 },
                    { new Guid("8e2c4720-7a85-4043-89b2-f232595f4455"), new Guid("1e8851a0-2c59-4997-bf76-c5316ca76812"), 5, 0 },
                    { new Guid("9686436b-8a10-4bd6-a7b4-3c0e6b14d79d"), new Guid("c9443397-a67d-49a8-9140-d321b5ce6c1b"), 3, 2 },
                    { new Guid("97328485-a623-41fb-af51-0d7e8d470d77"), new Guid("fbc86e42-74ba-4da8-bd63-00a6126a8f41"), 5, 0 },
                    { new Guid("9796696e-e39f-43fa-bc8b-99b575c88caf"), new Guid("c9443397-a67d-49a8-9140-d321b5ce6c1b"), 2, 3 },
                    { new Guid("a2fcf86a-3518-4b0a-9938-4e1df1c079e2"), new Guid("f02fc5a7-e275-41c4-937b-2242ff3811b4"), 3, 4 },
                    { new Guid("a46a22fe-662c-4bdc-b4c8-d225e76bd57b"), new Guid("f02fc5a7-e275-41c4-937b-2242ff3811b4"), 2, 3 },
                    { new Guid("a5f16a40-cd51-4c88-998c-42ab2b39f922"), new Guid("74243aba-de23-4783-8d20-0f11151eea08"), 3, 2 },
                    { new Guid("aefa8aee-71ee-429e-823b-18bca17eee6f"), new Guid("3e690f70-0989-46f7-82ac-45a15f80afb1"), 5, 0 },
                    { new Guid("b15dc1d6-b2d2-4f91-a43f-bd11f7276bc8"), new Guid("1e8851a0-2c59-4997-bf76-c5316ca76812"), 2, 3 },
                    { new Guid("b2c81973-b8c1-4694-bef0-7b4d4bf2c3d4"), new Guid("fbc86e42-74ba-4da8-bd63-00a6126a8f41"), 2, 3 },
                    { new Guid("b72b64a3-1fbf-4ec5-886d-514242c86760"), new Guid("90127731-f304-4cf1-a238-c4dd151f96ea"), 5, 0 },
                    { new Guid("baceb27b-b530-4b55-a75e-eaaa53b5751a"), new Guid("8310c25f-88a5-4c25-8586-31a737135336"), 2, 3 },
                    { new Guid("e69233eb-0995-432a-944b-7e526e42a8df"), new Guid("166dcc51-a346-4607-8102-54e7e6ba48ab"), 2, 3 },
                    { new Guid("e7ba3bac-d75d-416d-bbfb-b67fd34a071e"), new Guid("a19a673a-be70-4967-aa88-979a4864e3e3"), 2, 3 },
                    { new Guid("eaaa7b6d-6b40-45ad-bd22-d38652a1d3e1"), new Guid("b50a1d20-f032-41aa-903d-ea56e9ac8e1f"), 3, 2 },
                    { new Guid("ebc61b2d-92d8-4583-84c0-ef2ec5ad66e8"), new Guid("8310c25f-88a5-4c25-8586-31a737135336"), 3, 2 },
                    { new Guid("f9b067db-763d-4d93-9f79-2381d70ebfc8"), new Guid("c9443397-a67d-49a8-9140-d321b5ce6c1b"), 5, 0 },
                    { new Guid("fe7240c1-aa14-4010-bcd1-0109fad70305"), new Guid("523a9aad-21f7-4aef-8d55-37a11f8a81e9"), 5, 0 }
                });
        }
    }
}
