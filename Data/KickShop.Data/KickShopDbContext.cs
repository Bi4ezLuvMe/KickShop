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
                new Brand { Name = "Everlast", Country = "USA", Address = "123 Boxing Blvd, New York, NY", PhoneNumber = "123-456-7890", ImageUrl = "https://example.com/everlast.jpg" },
                new Brand { Name = "RDX", Country = "UK", Address = "456 Sports Ave, London, UK", PhoneNumber = "456-789-0123", ImageUrl = "https://example.com/rdx.jpg" },
                new Brand { Name = "Hayabusa", Country = "Canada", Address = "789 Fight St, Toronto, ON", PhoneNumber = "789-012-3456", ImageUrl = "https://example.com/hayabusa.jpg" },
                new Brand { Name = "Venum", Country = "France", Address = "101 Martial Arts Way, Paris, FR", PhoneNumber = "321-654-0987", ImageUrl = "https://example.com/venum.jpg" },
                new Brand { Name = "Fairtex", Country = "Thailand", Address = "234 Fighter Rd, Bangkok, TH", PhoneNumber = "876-543-2109", ImageUrl = "https://example.com/fairtex.jpg" },
                new Brand { Name = "Title Boxing", Country = "USA", Address = "345 Punch Ln, Los Angeles, CA", PhoneNumber = "987-654-3210", ImageUrl = "https://example.com/titleboxing.jpg" },
                new Brand { Name = "Ringside", Country = "USA", Address = "456 Ring Rd, Chicago, IL", PhoneNumber = "234-567-8901", ImageUrl = "https://example.com/ringside.jpg" },
                new Brand { Name = "Century", Country = "USA", Address = "567 Martial Arts Blvd, Oklahoma City, OK", PhoneNumber = "345-678-9012", ImageUrl = "https://example.com/century.jpg" },
                new Brand { Name = "Sanabul", Country = "USA", Address = "678 Fighter Ave, Miami, FL", PhoneNumber = "456-789-0123", ImageUrl = "https://example.com/sanabul.jpg" },
                new Brand { Name = "Twins Special", Country = "Thailand", Address = "789 Kick Rd, Phuket, TH", PhoneNumber = "567-890-1234", ImageUrl = "https://example.com/twinsspecial.jpg" }
                };
            List<Category> categories = new List<Category>()
            {
                new Category { Name = "Gloves", ImageUrl = "https://example.com/gloves.jpg" },
                new Category { Name = "Clothing", ImageUrl = "https://example.com/clothing.jpg" },
                new Category { Name = "Shinguards", ImageUrl = "https://example.com/shinguards.jpg" },
                new Category { Name = "Hand Wraps", ImageUrl = "https://example.com/handwraps.jpg" },
                new Category { Name = "Headgear", ImageUrl = "https://example.com/headgear.jpg" },
                new Category { Name = "Mouthguards", ImageUrl = "https://example.com/mouthguards.jpg" },
                new Category { Name = "Punching Bags", ImageUrl = "https://example.com/punchingbags.jpg" },
                new Category { Name = "Training Equipment", ImageUrl = "https://example.com/trainingequipment.jpg" },
                new Category { Name = "Shoes", ImageUrl = "https://example.com/shoes.jpg" },
                new Category { Name = "Protective Gear", ImageUrl = "https://example.com/protectivegear.jpg" }

            };
            //List<Product> products = new List<Product>()
            //{
            //     new Product { Name = "RDX Boxing Gloves", Description = "High-quality leather gloves for all training levels.", Price = 49.99m, StockQuantity = 100, ImageUrl = "https://example.com/rdx-gloves.jpg", BrandId = brands[1].BrandId, CategoryId = categories[0].CategoryId, Sizes = new List<Sizes> { Sizes.S, Sizes.M, Sizes.L } },
            //    new Product { Name = "Hayabusa T3 Boxing Gloves", Description = "Top-notch gloves with exceptional durability.", Price = 89.99m, StockQuantity = 50, ImageUrl = "https://example.com/hayabusa-t3.jpg", BrandId = brands[2].BrandId, CategoryId = categories[0].CategoryId, Sizes = new List<Sizes> { Sizes.M, Sizes.L, Sizes.XL } },
            //    new Product { Name = "Venum Challenger Gloves", Description = "Lightweight and designed for all skill levels.", Price = 39.99m, StockQuantity = 120, ImageUrl = "https://example.com/venum-challenger.jpg", BrandId = brands[3].BrandId, CategoryId = categories[0].CategoryId, Sizes = new List<Sizes> { Sizes.S, Sizes.M, Sizes.L } },
            //    new Product { Name = "Title Boxing Leather Bag Gloves", Description = "Durable leather gloves for heavy bag workouts.", Price = 59.99m, StockQuantity = 80, ImageUrl = "https://example.com/title-leather.jpg", BrandId = brands[5].BrandId, CategoryId = categories[0].CategoryId, Sizes = new List<Sizes> { Sizes.M, Sizes.L } },
            //    new Product { Name = "Century Martial Arts Kickboxing Shorts", Description = "Comfortable shorts designed for kickboxing.", Price = 29.99m, StockQuantity = 75, ImageUrl = "https://example.com/century-shorts.jpg", BrandId = brands[7].BrandId, CategoryId = categories[1].CategoryId, Sizes = new List<Sizes> { Sizes.M, Sizes.L, Sizes.XL } },
            //    new Product { Name = "Sanabul Essential Shin Guards", Description = "High-quality shin guards for protection and mobility.", Price = 35.99m, StockQuantity = 90, ImageUrl = "https://example.com/sanabul-shin.jpg", BrandId = brands[8].BrandId, CategoryId = categories[2].CategoryId, Sizes = new List<Sizes> { Sizes.M, Sizes.L, Sizes.XL } },
            //    new Product { Name = "Twins Special Headgear", Description = "Full-face protection with Twins quality.", Price = 89.99m, StockQuantity = 60, ImageUrl = "https://example.com/twins-headgear.jpg", BrandId = brands[9].BrandId, CategoryId = categories[4].CategoryId, Sizes = new List<Sizes> { Sizes.S, Sizes.M, Sizes.L } },
            //    new Product { Name = "Everlast Hand Wraps", Description = "Classic wraps for wrist and knuckle protection.", Price = 9.99m, StockQuantity = 200, ImageUrl = "https://example.com/everlast-wraps.jpg", BrandId = brands[0].BrandId, CategoryId = categories[3].CategoryId, Sizes = new List<Sizes> { Sizes.M, Sizes.L } },
            //    new Product { Name = "Ringside Punching Bag", Description = "Heavy-duty bag for all levels of training.", Price = 119.99m, StockQuantity = 40, ImageUrl = "https://example.com/ringside-bag.jpg", BrandId = brands[6].BrandId, CategoryId = categories[6].CategoryId, Sizes = new List<Sizes> { Sizes.L } },
            //    new Product { Name = "RDX Pro Boxing Shoes", Description = "Lightweight and supportive for agility in the ring.", Price = 69.99m, StockQuantity = 65, ImageUrl = "https://example.com/rdx-shoes.jpg", BrandId = brands[1].BrandId, CategoryId = categories[8].CategoryId, Sizes = new List<Sizes> { Sizes.M, Sizes.L, Sizes.XL } },
            //    new Product { Name = "Venum Challenger Shin Guards", Description = "High-durability shin guards ideal for intense training.", Price = 45.99m, StockQuantity = 95, ImageUrl = "https://example.com/venum-shin.jpg", BrandId = brands[3].BrandId, CategoryId = categories[2].CategoryId, Sizes = new List<Sizes> { Sizes.S, Sizes.M, Sizes.L } },
            //    new Product { Name = "Fairtex Muay Thai Shorts", Description = "Premium Muay Thai shorts with authentic design.", Price = 34.99m, StockQuantity = 90, ImageUrl = "https://example.com/fairtex-shorts.jpg", BrandId = brands[4].BrandId, CategoryId = categories[1].CategoryId, Sizes = new List<Sizes> { Sizes.M, Sizes.L, Sizes.XL } },
            //    new Product { Name = "Title Boxing Double End Bag", Description = "Perfect for accuracy and reflex training.", Price = 44.99m, StockQuantity = 70, ImageUrl = "https://example.com/title-double.jpg", BrandId = brands[5].BrandId, CategoryId = categories[6].CategoryId, Sizes = new List<Sizes> { Sizes.L } },
            //    new Product { Name = "Everlast Pro Headgear", Description = "Full-protection headgear with durable padding.", Price = 69.99m, StockQuantity = 50, ImageUrl = "https://example.com/everlast-headgear.jpg", BrandId = brands[0].BrandId, CategoryId = categories[4].CategoryId, Sizes = new List<Sizes> { Sizes.M, Sizes.L } }
            //};

            builder.Entity<Brand>().HasData(brands);

            builder.Entity<Category>().HasData(categories);

            //builder.Entity<Product>().HasData(products);
        }
    }
}
