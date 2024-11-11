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

            
            var category1Id = Guid.NewGuid();
            var category2Id = Guid.NewGuid();
            var category3Id = Guid.NewGuid();

            builder.Entity<Category>().HasData(
                new Category { CategoryId = category1Id, Name = "Gloves", ImageUrl = "/images/gloves-category.jpg"},
                new Category { CategoryId = category2Id, Name = "Protective Gear", ImageUrl = "/images/protective-gear-category.jpg" },
                new Category { CategoryId = category3Id, Name = "Apparel", ImageUrl = "/images/apparel-category.jpg" }
            );

            
            var brand1Id = Guid.NewGuid();
            var brand2Id = Guid.NewGuid();
            var brand3Id = Guid.NewGuid();

            builder.Entity<Brand>().HasData(
                new Brand { BrandId = brand1Id, Name = "Everlast", Country = "USA",ImageUrl = "Everlast-Logo.png",Address = "Everlast Canada c/o ACI Brands Inc. 2616 Sheridan Garden Drive Oakville, ON L6J 7Z2", PhoneNumber = "1-800-668-5593" },
                new Brand { BrandId = brand2Id, Name = "Venum", Country = "France", ImageUrl = "Venum-Logo.png", Address = "Las Vegas,Nevada", PhoneNumber = "1-888-200-5032" },
                new Brand { BrandId = brand3Id, Name = "Adidas", Country = "Germany", ImageUrl = "Adidas-Logo.png", Address = "Adi-Dassler-Strasse 1 91074 Herzogenaurach, Germany", PhoneNumber = "+49 9132 84 0" }
            );

            
            builder.Entity<Product>().HasData(
                new Product() { Name = "Kickboxing Gloves", Description = "High-quality kickboxing gloves for training and competition.", Price = 49.99M, ImageUrl = "/images/gloves.jpg", BrandId = brand1Id, CategoryId = category1Id,StockQuantity =5,Sizes = new List<Sizes> {Sizes.XS, Sizes.S,Sizes.M,Sizes.L } },
                new Product() { Name = "Shin Guards", Description = "Durable shin guards for protection during sparring.", Price = 35.99M, ImageUrl = "/images/shin-guards.jpg", BrandId = brand2Id, CategoryId = category1Id, StockQuantity = 6, Sizes = new List<Sizes> { Sizes.XS, Sizes.S, Sizes.M, Sizes.L } },
                new Product() { Name = "Headgear", Description = "Protective headgear for safety during training.", Price = 59.99M, ImageUrl = "/images/headgear.jpg", BrandId = brand3Id, CategoryId = category2Id, StockQuantity = 2, Sizes = new List<Sizes> { Sizes.XS, Sizes.S, Sizes.M, Sizes.L } },
                new Product() { Name = "Kickboxing Shorts", Description = "Comfortable shorts designed for kickboxing training.", Price = 29.99M, ImageUrl = "/images/shorts.jpg", BrandId = brand1Id, CategoryId = category3Id, StockQuantity = 4, Sizes = new List<Sizes> { Sizes.XS, Sizes.S, Sizes.M, Sizes.L } },
                new Product() { Name = "Mouth Guard", Description = "Essential mouth guard for protecting your teeth.", Price = 12.99M, ImageUrl = "/images/mouth-guard.jpg", BrandId = brand2Id, CategoryId = category2Id, StockQuantity = 6 , Sizes = new List<Sizes> { Sizes.XS, Sizes.S, Sizes.M, Sizes.L } }
            );

        }
    }
}
