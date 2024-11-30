using KickShop.Models;
using KickShop.Models.Enums;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace KickShop.Data
{
    public class KickShopDbContext : IdentityDbContext<ApplicationUser>
    {
        public KickShopDbContext(DbContextOptions<KickShopDbContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<CartItem> CartsItems { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<CustomerOrder> CustomersOrders { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<ProductImage> ProductsImages { get; set; }
        public DbSet<ProductSize> ProductsSizes { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<CustomerOrder>().HasKey(co => new { co.OrderId, co.CustomerId });

            SeedDB(builder);
        }

        private void SeedDB(ModelBuilder builder)
        {

            List<Brand> brands = new List<Brand>()
            { new Brand
{
    Name = "Everlast",
    Country = "USA",
    Address = "123 Boxing Blvd, New York, NY",
    PhoneNumber = "123-456-7890",
    ImageUrl = "/images/Brands/everlast-logo.png",
    Description = "Known as one of the oldest and most reputable brands in the boxing world, Everlast is a staple in combat sports. From gloves to training equipment, Everlast provides high-quality gear trusted by professional fighters and trainers alike."
},new Brand
{
    Name = "RDX",
    Country = "UK",
    Address = "456 Sports Ave, London, UK",
    PhoneNumber = "456-789-0123",
    ImageUrl = "/images/Brands/rdx-logo.png",
    Description = "RDX is renowned for its innovative designs and durable equipment that cater to a wide range of combat sports, including kickboxing, MMA, and boxing. Its focus on affordability and quality makes it a favorite among beginners and professionals."
},new Brand
{
    Name = "Hayabusa",
    Country = "Canada",
    Address = "789 Fight St, Toronto, ON",
    PhoneNumber = "789-012-3456",
    ImageUrl = "/images/Brands/hayabusa-logo.png",
    Description = "Hayabusa is synonymous with premium quality and cutting-edge technology in combat sports. Their gloves and apparel are designed to provide exceptional protection, performance, and style for fighters at all levels."
},new Brand
{
    Name = "Venum",
    Country = "France",
    Address = "101 Martial Arts Way, Paris, FR",
    PhoneNumber = "321-654-0987",
    ImageUrl = "/images/Brands/venum-logo.png",
    Description = "Venum is a globally recognized brand known for its bold designs and top-tier combat sports equipment. From gloves to apparel, Venum caters to athletes who demand performance and style in the ring and beyond."
},new Brand
{
    Name = "Fairtex",
    Country = "Thailand",
    Address = "234 Fighter Rd, Bangkok, TH",
    PhoneNumber = "876-543-2109",
    ImageUrl = "/images/Brands/fairtex-logo.png",
    Description = "Fairtex is a legendary Thai brand specializing in Muay Thai and kickboxing gear. Renowned for its authenticity and quality, Fairtex is the choice of champions in traditional and modern combat sports."
},new Brand
{
    Name = "Title Boxing",
    Country = "USA",
    Address = "345 Punch Ln, Los Angeles, CA",
    PhoneNumber = "987-654-3210",
    ImageUrl = "/images/Brands/title-boxing-logo.png",
    Description = "Title Boxing is a leading brand offering an extensive range of boxing and kickboxing gear. Known for its reliability and innovation, Title Boxing supports athletes with training and competition essentials."
},new Brand
{
    Name = "Ringside",
    Country = "USA",
    Address = "456 Ring Rd, Chicago, IL",
    PhoneNumber = "234-567-8901",
    ImageUrl = "/images/Brands/ringside-logo.png",
    Description = "Ringside is a trusted name in boxing and kickboxing, providing high-performance equipment and apparel. Its focus on durability and craftsmanship has made it a favorite among gyms and professionals."
},new Brand
{
    Name = "Century",
    Country = "USA",
    Address = "567 Martial Arts Blvd, Oklahoma City, OK",
    PhoneNumber = "345-678-9012",
    ImageUrl = "/images/Brands/century-logo.png",
    Description = "Century is known for its innovative training gear, including punching bags and protective equipment. Widely used in martial arts and kickboxing, Century products are designed to enhance performance and safety."
},new Brand
{
    Name = "Sanabul",
    Country = "USA",
    Address = "678 Fighter Ave, Miami, FL",
    PhoneNumber = "456-789-0123",
    ImageUrl = "/images/Brands/sanabul-logo.png",
    Description = "Sanabul is a modern combat sports brand offering stylish and affordable gear. Its products are designed for both beginners and experienced athletes, with a focus on innovation and performance."
},new Brand
{
    Name = "Twins Special",
    Country = "Thailand",
    Address = "789 Kick Rd, Phuket, TH",
    PhoneNumber = "567-890-1234",
    ImageUrl = "/images/Brands/twins-special-logo.png",
    Description = "Twins Special is a renowned brand in Muay Thai and kickboxing, celebrated for its handcrafted gear. Their gloves and pads are known for their durability, quality, and traditional Thai craftsmanship."
}};
            List<Category> categories = new List<Category>()
            {
                new Category { Name = "Gloves", ImageUrl = "/images/Categegories/boxing-gloves.jfif" },
                new Category { Name = "Clothing", ImageUrl = "/images/Categories/clothing.png" },
                new Category { Name = "Shinguards", ImageUrl = "/images/Categories/shin-guards.png" },
                new Category { Name = "Hand Wraps", ImageUrl = "/images/Categories/hand-wraps.png" },
                new Category { Name = "Headgear", ImageUrl = "/images/Categories/head-gear.png" },
                new Category { Name = "Mouthguards", ImageUrl = "/images/Categories/mouth-guard.png" },
                new Category { Name = "Punching Bags", ImageUrl = "/images/Categories/punching-bag.png" },
                new Category { Name = "Training Equipment", ImageUrl = "/images/Categories/training-equipment.png" },
                new Category { Name = "Shoes", ImageUrl = "/images/Categories/boxing-shoes.png" },
                new Category { Name = "Protective Gear", ImageUrl = "/images/Categories/protective-equipment.jfif" }

            };
            List<Product> products = new List<Product>()
            {
                new Product { Name = "RDX Boxing Gloves", Description = "High-quality leather gloves for all training levels.", Price = 109.99m, StockQuantity = 100, BrandId = brands[1].BrandId, CategoryId = categories[0].CategoryId,MainImageUrl ="/images/Products/rdx-boxing-gloves/rdx-boxing-glove-3.png" },
                new Product { Name = "Hayabusa T3 Boxing Gloves", Description = "Top-notch gloves with exceptional durability.", Price = 189.99m, StockQuantity = 50, BrandId = brands[2].BrandId, CategoryId = categories[0].CategoryId,MainImageUrl ="/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-1.png" },
                new Product { Name = "Venum Challenger Gloves", Description = "Lightweight and designed for all skill levels.", Price = 89.99m, StockQuantity = 120, BrandId = brands[3].BrandId, CategoryId = categories[0].CategoryId,MainImageUrl ="/images/Products/venum-challenger-gloves/venum-challenger-gloves-2.png" },
                new Product { Name = "Title Boxing Leather Bag Gloves", Description = "Durable leather gloves for heavy bag workouts.", Price = 79.99m, StockQuantity = 80,  BrandId = brands[5].BrandId, CategoryId = categories[0].CategoryId,MainImageUrl ="/images/Products/title-boxing-bag/title-boxing-bag-1.png" },
                new Product { Name = "Century Martial Arts Kickboxing Shorts", Description = "Comfortable shorts designed for kickboxing.", Price = 79.99m, StockQuantity = 75,  BrandId = brands[7].BrandId, CategoryId = categories[1].CategoryId,MainImageUrl ="/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-1.png" },
                new Product { Name = "Sanabul Essential Shin Guards", Description = "High-quality shin guards for protection and mobility.", Price = 105.99m, StockQuantity = 90, BrandId = brands[8].BrandId, CategoryId = categories[2].CategoryId,MainImageUrl ="/images/Products/sanabul-shin-guards/sanabul-shin-guards-1.png" },
                new Product { Name = "Twins Special Headgear", Description = "Full-face protection with Twins quality.", Price = 89.99m, StockQuantity = 60,  BrandId = brands[9].BrandId, CategoryId = categories[4].CategoryId,MainImageUrl ="/images/Products/twins-special-headgear/twins-special-headgear-1.png" },
                new Product { Name = "Everlast Hand Wraps", Description = "Classic wraps for wrist and knuckle protection.", Price = 9.99m, StockQuantity = 200,  BrandId = brands[0].BrandId, CategoryId = categories[3].CategoryId,MainImageUrl ="/images/Products/everlast-hand-wraps/everlast-hand-wraps-3.png" },
                new Product { Name = "Ringside Punching Bag", Description = "Heavy-duty bag for all levels of training.", Price = 219.99m, StockQuantity = 40,  BrandId = brands[6].BrandId, CategoryId = categories[6].CategoryId,MainImageUrl="/images/Products/ringside-punching-bag/ringside-punching-bag-1.png" },
                new Product { Name = "RDX Pro Boxing Shoes", Description = "Lightweight and supportive for agility in the ring.", Price = 109.99m, StockQuantity = 65,  BrandId = brands[1].BrandId, CategoryId = categories[8].CategoryId,MainImageUrl ="/images/Products/rdx-boxing-shoes/rdx-boxing-shoes-1.png" },
                new Product { Name = "Venum Challenger Shin Guards", Description = "High-durability shin guards ideal for intense training.", Price = 105.99m, StockQuantity = 95,  BrandId = brands[3].BrandId, CategoryId = categories[2].CategoryId,MainImageUrl ="/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-1.png" },
                new Product { Name = "Fairtex Muay Thai Shorts", Description = "Premium Muay Thai shorts with authentic design.", Price = 84.99m, StockQuantity = 90,  BrandId = brands[4].BrandId, CategoryId = categories[1].CategoryId,MainImageUrl ="/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-1.png" },
                new Product { Name = "Title Boxing Double End Bag", Description = "Perfect for accuracy and reflex training.", Price = 99.99m, StockQuantity = 70,  BrandId = brands[5].BrandId, CategoryId = categories[6].CategoryId,MainImageUrl ="/images/Products/title-boxing-gloves/title-boxing-gloves-1.png" },
                new Product { Name = "Everlast Pro Headgear", Description = "Full-protection headgear with durable padding.", Price = 89.99m, StockQuantity = 50,  BrandId = brands[0].BrandId, CategoryId = categories[4].CategoryId,MainImageUrl ="/images/Products/everlast-pro-headgear/everlast-headgear-1.png" }
            };
            List<ProductImage> productsImages = new List<ProductImage>()
            {
            new ProductImage { ImageId = Guid.NewGuid(), ProductId = products[0].ProductId, ImageUrl = "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-1.png" },
            new ProductImage { ImageId = Guid.NewGuid(), ProductId = products[0].ProductId, ImageUrl = "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-2.png" },
            new ProductImage { ImageId = Guid.NewGuid(), ProductId = products[0].ProductId, ImageUrl = "/images/Products/rdx-boxing-gloves/rdx-boxing-glove-3.png" },
            new ProductImage { ImageId = Guid.NewGuid(), ProductId = products[1].ProductId, ImageUrl = "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-1.png" },
            new ProductImage { ImageId = Guid.NewGuid(), ProductId = products[1].ProductId, ImageUrl = "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-2.png" },
            new ProductImage { ImageId = Guid.NewGuid(), ProductId = products[1].ProductId, ImageUrl = "/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-3.png" },
            new ProductImage { ImageId = Guid.NewGuid(), ProductId = products[2].ProductId, ImageUrl = "/images/Products/venum-challenger-gloves/venum-challenger-gloves-1.png" },
            new ProductImage { ImageId = Guid.NewGuid(), ProductId = products[2].ProductId, ImageUrl = "/images/Products/venum-challenger-gloves/venum-challenger-gloves-2.png" },
            new ProductImage { ImageId = Guid.NewGuid(), ProductId = products[2].ProductId, ImageUrl = "/images/Products/venum-challenger-gloves/venum-challenger-gloves-3.png" },
            new ProductImage { ImageId = Guid.NewGuid(), ProductId = products[3].ProductId, ImageUrl = "/images/Products/title-boxing-bag/title-boxing-bag-1.png" },
            new ProductImage { ImageId = Guid.NewGuid(), ProductId = products[3].ProductId, ImageUrl = "/images/Products/title-boxing-bag/title-boxing-bag-2.png" },
            new ProductImage { ImageId = Guid.NewGuid(), ProductId = products[3].ProductId, ImageUrl = "/images/Products/title-boxing-bag/title-boxing-bag-3.png" },
            new ProductImage { ImageId = Guid.NewGuid(), ProductId = products[4].ProductId, ImageUrl = "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-1.png" },
            new ProductImage { ImageId = Guid.NewGuid(), ProductId = products[4].ProductId, ImageUrl = "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-2.png" },
            new ProductImage { ImageId = Guid.NewGuid(), ProductId = products[4].ProductId, ImageUrl = "/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-3.png" },
            new ProductImage { ImageId = Guid.NewGuid(), ProductId = products[5].ProductId, ImageUrl = "/images/Products/sanabul-shin-guards/sanabul-shin-guards-1.png" },
            new ProductImage { ImageId = Guid.NewGuid(), ProductId = products[5].ProductId, ImageUrl = "/images/Products/sanabul-shin-guards/sanabul-shin-guards-2.png" },
            new ProductImage { ImageId = Guid.NewGuid(), ProductId = products[5].ProductId, ImageUrl = "/images/Products/sanabul-shin-guards/sanabul-shin-guards-3.png" },
            new ProductImage { ImageId = Guid.NewGuid(), ProductId = products[6].ProductId, ImageUrl = "/images/Products/twins-special-headgear/twins-special-headgear-1.png" },
            new ProductImage { ImageId = Guid.NewGuid(), ProductId = products[6].ProductId, ImageUrl = "/images/Products/twins-special-headgear/twins-special-headgear-2.png" },
            new ProductImage { ImageId = Guid.NewGuid(), ProductId = products[6].ProductId, ImageUrl = "/images/Products/twins-special-headgear/twins-shin-headgear-3.png" },
            new ProductImage { ImageId = Guid.NewGuid(), ProductId = products[7].ProductId, ImageUrl = "/images/Products/everlast-hand-wraps/everlast-hand-wraps-1.png" },
            new ProductImage { ImageId = Guid.NewGuid(), ProductId = products[7].ProductId, ImageUrl = "/images/Products/everlast-hand-wraps/everlast-hand-wraps-2.png" },
            new ProductImage { ImageId = Guid.NewGuid(), ProductId = products[7].ProductId, ImageUrl = "/images/Products/everlast-hand-wraps/everlast-hand-wraps-3.png" },
            new ProductImage { ImageId = Guid.NewGuid(), ProductId = products[8].ProductId, ImageUrl = "/images/Products/ringside-punching-bag/ringside-punching-bag-1.png" },
            new ProductImage { ImageId = Guid.NewGuid(), ProductId = products[8].ProductId, ImageUrl = "/images/Products/ringside-punching-bag/ringside-punching-bag-2.png" },
            new ProductImage { ImageId = Guid.NewGuid(), ProductId = products[8].ProductId, ImageUrl = "/images/Products/ringside-punching-bag/ringside-punching-bag-3.png" },
            new ProductImage { ImageId = Guid.NewGuid(), ProductId = products[9].ProductId, ImageUrl = "/images/Products/rdx-boxing-shoes/rdx-boxing-shoes-1.png" },
            new ProductImage { ImageId = Guid.NewGuid(), ProductId = products[9].ProductId, ImageUrl = "/images/Products/rdx-boxing-shoes/rdx-boxing-shoes-2.png" },
            new ProductImage { ImageId = Guid.NewGuid(), ProductId = products[9].ProductId, ImageUrl = "/images/Products/rdx-boxing-shoes/rdx-boxing-shoes-3.png" },
            new ProductImage { ImageId = Guid.NewGuid(), ProductId = products[10].ProductId, ImageUrl = "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-1.png" },
            new ProductImage { ImageId = Guid.NewGuid(), ProductId = products[10].ProductId, ImageUrl = "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-2.png" },
            new ProductImage { ImageId = Guid.NewGuid(), ProductId = products[10].ProductId, ImageUrl = "/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-3.png" },
            new ProductImage { ImageId = Guid.NewGuid(), ProductId = products[11].ProductId, ImageUrl = "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-1.png" },
            new ProductImage { ImageId = Guid.NewGuid(), ProductId = products[11].ProductId, ImageUrl = "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-2.png" },
            new ProductImage { ImageId = Guid.NewGuid(), ProductId = products[11].ProductId, ImageUrl = "/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-3.png" },
            new ProductImage { ImageId = Guid.NewGuid(), ProductId = products[12].ProductId, ImageUrl = "/images/Products/title-boxing-gloves/title-boxing-gloves-1.png" },
            new ProductImage { ImageId = Guid.NewGuid(), ProductId = products[12].ProductId, ImageUrl = "/images/Products/title-boxing-gloves/title-boxing-gloves-2.png" },
            new ProductImage { ImageId = Guid.NewGuid(), ProductId = products[12].ProductId, ImageUrl = "/images/Products/title-boxing-gloves/title-boxing-gloves-3.png" },
            new ProductImage { ImageId = Guid.NewGuid(), ProductId = products[13].ProductId, ImageUrl = "/images/Products/everlasr-pro-headgear/everlast-headgear-1.png" },
            new ProductImage { ImageId = Guid.NewGuid(), ProductId = products[13].ProductId, ImageUrl = "/images/Products/everlasr-pro-headgear/everlast-headgear-2.png" },
            new ProductImage { ImageId = Guid.NewGuid(), ProductId = products[13].ProductId, ImageUrl = "/images/Products/everlasr-pro-headgear/everlast-headgear-3.png" },
            };
            List<ProductSize> productsSizes = new List<ProductSize>()
            {
    // RDX Boxing Gloves
    new ProductSize {  ProductId = products[0].ProductId, Size = Sizes.M, Quantity = 3 },
    new ProductSize {  ProductId = products[0].ProductId, Size = Sizes.L, Quantity = 2 },
    new ProductSize {  ProductId = products[0].ProductId, Size = Sizes.XS, Quantity = 5 },

    // Hayabusa T3 Boxing Gloves
    new ProductSize {  ProductId = products[1].ProductId, Size = Sizes.S, Quantity = 3 },
    new ProductSize {  ProductId = products[1].ProductId, Size = Sizes.L, Quantity = 2 },
    new ProductSize {  ProductId = products[1].ProductId, Size = Sizes.XS, Quantity = 5 },

    // Venum Challenger Gloves
    new ProductSize {  ProductId = products[2].ProductId, Size = Sizes.XL, Quantity = 3 },
    new ProductSize {  ProductId = products[2].ProductId, Size = Sizes.L, Quantity = 2 },
    new ProductSize {  ProductId = products[2].ProductId, Size = Sizes.XS, Quantity = 5 },

    // Title Boxing Leather Bag Gloves
    new ProductSize {  ProductId = products[3].ProductId, Size = Sizes.XXL, Quantity = 3 },
    new ProductSize {  ProductId = products[3].ProductId, Size = Sizes.L, Quantity = 2 },
    new ProductSize {  ProductId = products[3].ProductId, Size = Sizes.XS, Quantity = 5 },

    // Century Martial Arts Kickboxing Shorts
    new ProductSize {  ProductId = products[4].ProductId, Size = Sizes.M, Quantity = 3 },
    new ProductSize {  ProductId = products[4].ProductId, Size = Sizes.L, Quantity = 2 },
    new ProductSize {  ProductId = products[4].ProductId, Size = Sizes.XS, Quantity = 5 },

    // Sanabul Essential Shin Guards
    new ProductSize { ProductId = products[5].ProductId, Size = Sizes.XXXL, Quantity = 3 },
    new ProductSize { ProductId = products[5].ProductId, Size = Sizes.L, Quantity = 2 },
    new ProductSize { ProductId = products[5].ProductId, Size = Sizes.XS, Quantity = 5 },

    // Twins Special Headgear
    new ProductSize { ProductId = products[6].ProductId, Size = Sizes.M, Quantity = 3 },
    new ProductSize { ProductId = products[6].ProductId, Size = Sizes.L, Quantity = 2 },
    new ProductSize { ProductId = products[6].ProductId, Size = Sizes.XS, Quantity = 5 },

    // Everlast Hand Wraps
    new ProductSize { ProductId = products[7].ProductId, Size = Sizes.M, Quantity = 3 },
    new ProductSize { ProductId = products[7].ProductId, Size = Sizes.L, Quantity = 2 },
    new ProductSize { ProductId = products[7].ProductId, Size = Sizes.XS, Quantity = 5 },

    // Ringside Punching Bag
    new ProductSize { ProductId = products[8].ProductId, Size = Sizes.M, Quantity = 3 },
    new ProductSize { ProductId = products[8].ProductId, Size = Sizes.L, Quantity = 2 },
    new ProductSize { ProductId = products[8].ProductId, Size = Sizes.XS, Quantity = 5 },

    // RDX Pro Boxing Shoes
    new ProductSize { ProductId = products[9].ProductId, Size = Sizes.M, Quantity = 3 },
    new ProductSize { ProductId = products[9].ProductId, Size = Sizes.L, Quantity = 2 },
    new ProductSize { ProductId = products[9].ProductId, Size = Sizes.XS, Quantity = 5 },

    // Venum Challenger Shin Guards
    new ProductSize { ProductId = products[10].ProductId, Size = Sizes.M, Quantity = 3 },
    new ProductSize { ProductId = products[10].ProductId, Size = Sizes.L, Quantity = 2 },
    new ProductSize { ProductId = products[10].ProductId, Size = Sizes.XS, Quantity = 5 },

    // Fairtex Muay Thai Shorts
    new ProductSize {  ProductId = products[11].ProductId, Size = Sizes.M, Quantity = 3 },
    new ProductSize {  ProductId = products[11].ProductId, Size = Sizes.L, Quantity = 2 },
    new ProductSize {  ProductId = products[11].ProductId, Size = Sizes.XS, Quantity = 5 },

    // Title Boxing Double End Bag
    new ProductSize {  ProductId = products[12].ProductId, Size = Sizes.M, Quantity = 3 },
    new ProductSize {  ProductId = products[12].ProductId, Size = Sizes.L, Quantity = 2 },
    new ProductSize {  ProductId = products[12].ProductId, Size = Sizes.XS, Quantity = 5 },

    // Everlast Pro Headgear
    new ProductSize {  ProductId = products[13].ProductId, Size = Sizes.M, Quantity = 3 },
    new ProductSize {  ProductId = products[13].ProductId, Size = Sizes.L, Quantity = 2 },
    new ProductSize {  ProductId = products[13].ProductId, Size = Sizes.XS, Quantity = 5 }
        };

            builder.Entity<Brand>().HasData(brands);

            builder.Entity<Category>().HasData(categories);

            builder.Entity<Product>().HasData(products);

            builder.Entity<ProductImage>().HasData(productsImages);

            builder.Entity<ProductSize>().HasData(productsSizes);
        }
    }
}
