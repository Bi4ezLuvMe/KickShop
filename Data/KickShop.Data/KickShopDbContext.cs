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
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<CustomerOrder>().HasKey(co => new { co.OrderId, co.CustomerId });

            SeedDB(builder);
        }

        private void SeedDB(ModelBuilder builder)
        {

            List<Brand> brands = new List<Brand>()
                {
                new Brand { Name = "Everlast", Country = "USA", Address = "123 Boxing Blvd, New York, NY", PhoneNumber = "123-456-7890", ImageUrl = "/images/Brands/everlast-logo.png" },
                new Brand { Name = "RDX", Country = "UK", Address = "456 Sports Ave, London, UK", PhoneNumber = "456-789-0123", ImageUrl = "/images/Brands/rdx-logo.png" },
                new Brand { Name = "Hayabusa", Country = "Canada", Address = "789 Fight St, Toronto, ON", PhoneNumber = "789-012-3456", ImageUrl = "/images/Brands/hayabusa-logo.png" },
                new Brand { Name = "Venum", Country = "France", Address = "101 Martial Arts Way, Paris, FR", PhoneNumber = "321-654-0987", ImageUrl = "/images/Brands/venum-logo.png" },
                new Brand { Name = "Fairtex", Country = "Thailand", Address = "234 Fighter Rd, Bangkok, TH", PhoneNumber = "876-543-2109", ImageUrl = "/images/Brands/fairtex-logo.png" },
                new Brand { Name = "Title Boxing", Country = "USA", Address = "345 Punch Ln, Los Angeles, CA", PhoneNumber = "987-654-3210", ImageUrl = "/images/Brands/title-boxing-logo.png" },
                new Brand { Name = "Ringside", Country = "USA", Address = "456 Ring Rd, Chicago, IL", PhoneNumber = "234-567-8901", ImageUrl = "/images/Brands/ringside-logo.png" },
                new Brand { Name = "Century", Country = "USA", Address = "567 Martial Arts Blvd, Oklahoma City, OK", PhoneNumber = "345-678-9012", ImageUrl = "/images/Brands/century-logo.png" },
                new Brand { Name = "Sanabul", Country = "USA", Address = "678 Fighter Ave, Miami, FL", PhoneNumber = "456-789-0123", ImageUrl = "/images/Brands/sanabul-logo.png" },
                new Brand { Name = "Twins Special", Country = "Thailand", Address = "789 Kick Rd, Phuket, TH", PhoneNumber = "567-890-1234", ImageUrl = "/images/Brands/twins-special-logo.png" }
                };
            List<Category> categories = new List<Category>()
            {
                new Category { Name = "Gloves", ImageUrl = "/images/Categegories/boxing-gloves.png" },
                new Category { Name = "Clothing", ImageUrl = "/images/Categories/clothing.png" },
                new Category { Name = "Shinguards", ImageUrl = "/images/Categories/shin-guards.png" },
                new Category { Name = "Hand Wraps", ImageUrl = "/images/Categories/hand-wraps.png" },
                new Category { Name = "Headgear", ImageUrl = "/images/Categories/head-gear.png" },
                new Category { Name = "Mouthguards", ImageUrl = "/images/Categories/mouth-guard.png" },
                new Category { Name = "Punching Bags", ImageUrl = "/images/Categories/punching-bag.png" },
                new Category { Name = "Training Equipment", ImageUrl = "/images/Categories/training-equipment.png" },
                new Category { Name = "Shoes", ImageUrl = "/images/Categories/boxing-shoes.png" },
                new Category { Name = "Protective Gear", ImageUrl = "/images/Categories/protective-equipment.png" }

            };
            List<Product> products = new List<Product>()
            {
                new Product { Name = "RDX Boxing Gloves", Description = "High-quality leather gloves for all training levels.", Price = 49.99m, StockQuantity = 100, BrandId = brands[1].BrandId, CategoryId = categories[0].CategoryId, Sizes = new List<Sizes> { Sizes.S, Sizes.M, Sizes.L },MainImageUrl ="/images/Products/rdx-boxing-gloves/rdx-boxing-glove-3.png" },
                new Product { Name = "Hayabusa T3 Boxing Gloves", Description = "Top-notch gloves with exceptional durability.", Price = 89.99m, StockQuantity = 50, BrandId = brands[2].BrandId, CategoryId = categories[0].CategoryId, Sizes = new List<Sizes> { Sizes.M, Sizes.L, Sizes.XL },MainImageUrl ="/images/Products/hayabusa-boxing-gloves/hayabusa-boxing-gloves-1.png" },
                new Product { Name = "Venum Challenger Gloves", Description = "Lightweight and designed for all skill levels.", Price = 39.99m, StockQuantity = 120, BrandId = brands[3].BrandId, CategoryId = categories[0].CategoryId, Sizes = new List<Sizes> { Sizes.S, Sizes.M, Sizes.L },MainImageUrl ="/images/Products/venum-challenger-gloves/venum-challenger-gloves-2.png" },
                new Product { Name = "Title Boxing Leather Bag Gloves", Description = "Durable leather gloves for heavy bag workouts.", Price = 59.99m, StockQuantity = 80,  BrandId = brands[5].BrandId, CategoryId = categories[0].CategoryId, Sizes = new List<Sizes> { Sizes.M, Sizes.L },MainImageUrl ="/images/Products/title-boxing-bag/title-boxing-bag-1.png" },
                new Product { Name = "Century Martial Arts Kickboxing Shorts", Description = "Comfortable shorts designed for kickboxing.", Price = 29.99m, StockQuantity = 75,  BrandId = brands[7].BrandId, CategoryId = categories[1].CategoryId, Sizes = new List<Sizes> { Sizes.M, Sizes.L, Sizes.XL },MainImageUrl ="/images/Products/century-kickboxing-shorts/century-kickboxing-shorts-1.png" },
                new Product { Name = "Sanabul Essential Shin Guards", Description = "High-quality shin guards for protection and mobility.", Price = 35.99m, StockQuantity = 90, BrandId = brands[8].BrandId, CategoryId = categories[2].CategoryId, Sizes = new List<Sizes> { Sizes.M, Sizes.L, Sizes.XL },MainImageUrl ="/images/Products/sanabul-shin-guards/sanabul-shin-guards-1.png" },
                new Product { Name = "Twins Special Headgear", Description = "Full-face protection with Twins quality.", Price = 89.99m, StockQuantity = 60,  BrandId = brands[9].BrandId, CategoryId = categories[4].CategoryId, Sizes = new List<Sizes> { Sizes.S, Sizes.M, Sizes.L },MainImageUrl ="/images/Products/twins-special-headgear/twins-special-headgear-1.png" },
                new Product { Name = "Everlast Hand Wraps", Description = "Classic wraps for wrist and knuckle protection.", Price = 9.99m, StockQuantity = 200,  BrandId = brands[0].BrandId, CategoryId = categories[3].CategoryId, Sizes = new List<Sizes> { Sizes.M, Sizes.L },MainImageUrl ="/images/Products/everlast-hand-wraps/everlast-hand-wraps-3.png" },
                new Product { Name = "Ringside Punching Bag", Description = "Heavy-duty bag for all levels of training.", Price = 119.99m, StockQuantity = 40,  BrandId = brands[6].BrandId, CategoryId = categories[6].CategoryId, Sizes = new List<Sizes> { Sizes.L },MainImageUrl="/images/Products/ringside-punching-bag/ringside-punching-bag-1.png" },
                new Product { Name = "RDX Pro Boxing Shoes", Description = "Lightweight and supportive for agility in the ring.", Price = 69.99m, StockQuantity = 65,  BrandId = brands[1].BrandId, CategoryId = categories[8].CategoryId, Sizes = new List<Sizes> { Sizes.M, Sizes.L, Sizes.XL },MainImageUrl ="/images/Products/rdx-boxing-shoes/rdx-boxing-shoes-1.png" },
                new Product { Name = "Venum Challenger Shin Guards", Description = "High-durability shin guards ideal for intense training.", Price = 45.99m, StockQuantity = 95,  BrandId = brands[3].BrandId, CategoryId = categories[2].CategoryId, Sizes = new List<Sizes> { Sizes.S, Sizes.M, Sizes.L },MainImageUrl ="/images/Products/venum-challenger-shin-guards/venum-challenger-shin-guards-1.png" },
                new Product { Name = "Fairtex Muay Thai Shorts", Description = "Premium Muay Thai shorts with authentic design.", Price = 34.99m, StockQuantity = 90,  BrandId = brands[4].BrandId, CategoryId = categories[1].CategoryId, Sizes = new List<Sizes> { Sizes.M, Sizes.L, Sizes.XL },MainImageUrl ="/images/Products/fairtex-muay-thai-shorts/fairtex-muay-thai-shorts-1.png" },
                new Product { Name = "Title Boxing Double End Bag", Description = "Perfect for accuracy and reflex training.", Price = 44.99m, StockQuantity = 70,  BrandId = brands[5].BrandId, CategoryId = categories[6].CategoryId, Sizes = new List<Sizes> { Sizes.L },MainImageUrl ="/images/Products/title-boxing-gloves/title-boxing-gloves-1.png" },
                new Product { Name = "Everlast Pro Headgear", Description = "Full-protection headgear with durable padding.", Price = 69.99m, StockQuantity = 50,  BrandId = brands[0].BrandId, CategoryId = categories[4].CategoryId, Sizes = new List<Sizes> { Sizes.M, Sizes.L },MainImageUrl ="/images/Products/everlast-pro-headgear/everlast-headgear-1.png" }
            };
            List<ProductImage> productsImages = new List<ProductImage>()
            {
                ///images/site/logo.png
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

            builder.Entity<Brand>().HasData(brands);

            builder.Entity<Category>().HasData(categories);

            builder.Entity<Product>().HasData(products);

            builder.Entity<ProductImage>().HasData(productsImages);
        }
    }
}
