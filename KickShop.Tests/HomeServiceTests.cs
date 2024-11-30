using KickShop.Data;
using KickShop.Models;
using KickShop.Models.Enums;
using KickShop.Services;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KickShop.Tests.Services
{
    [TestFixture]
    public class HomeServiceTests
    {
        private KickShopDbContext context;
        private HomeService homeService;

        [SetUp]
        public void SetUp()
        {
            DbContextOptions<KickShopDbContext> options = new DbContextOptionsBuilder<KickShopDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            context = new KickShopDbContext(options);

            List<Product> products = new List<Product>
            {
                new Product
                {
                    Name = "Product 1",
                    Description = "Description 1",
                    Price = 100.50m,
                    StockQuantity = 10,
                    MainImageUrl = "https://example.com/image1.jpg",
                    CategoryId = Guid.NewGuid(),
                    BrandId = Guid.NewGuid(),
                    IsDeleted = false
                },
                new Product
                {
                    Name = "Product 2",
                    Description = "Description 2",
                    Price = 150.75m,
                    StockQuantity = 5,
                    MainImageUrl = "https://example.com/image2.jpg",
                    CategoryId = Guid.NewGuid(),
                    BrandId = Guid.NewGuid(),
                    IsDeleted = false
                },
                new Product
                {
                    Name = "Product 3",
                    Description = "Description 3",
                    Price = 200.99m,
                    StockQuantity = 3,
                    MainImageUrl = "https://example.com/image3.jpg",
                    CategoryId = Guid.NewGuid(),
                    BrandId = Guid.NewGuid(),
                    IsDeleted = false
                },
                new Product
                {
                    Name = "Product 4",
                    Description = "Description 4",
                    Price = 300.00m,
                    StockQuantity = 7,
                    MainImageUrl = "https://example.com/image4.jpg",
                    CategoryId = Guid.NewGuid(),
                    BrandId = Guid.NewGuid(),
                    IsDeleted = false
                }
            };
            List<ProductSize> productsSizes = new List<ProductSize>()
            {
                new ProductSize
                {
                    ProductId = products[0].ProductId,
                    Size = Sizes.S,
                    Quantity =1,
                },
                  new ProductSize
                {
                    ProductId = products[1].ProductId,
                    Size = Sizes.S,
                    Quantity =1,
                },
                    new ProductSize
                {
                    ProductId = products[2].ProductId,
                    Size = Sizes.S,
                    Quantity =1,
                },
                      new ProductSize
                {
                    ProductId = products[3].ProductId,
                    Size = Sizes.S,
                    Quantity =1,
                }
            };
            context.ProductsSizes.AddRange(productsSizes);
            context.Products.AddRange(products);
            context.SaveChanges();

            homeService = new HomeService(context);
        }

        [TearDown]
        public void TearDown()
        {
            context.Database.EnsureDeleted();
            context.Dispose();
        }

        [Test]
        public async Task GetFeaturedProductsReturnsFirstThreeProducts()
        {
            List<Product> result = await homeService.GetFeaturedProducts();

            Assert.AreEqual(3, result.Count);
            Assert.AreEqual("Product 1", result[0].Name);
            Assert.AreEqual("Product 2", result[1].Name);
            Assert.AreEqual("Product 3", result[2].Name);
        }

        [Test]
        public async Task GetFeaturedProductsReturnsEmptyListIfNoProducts()
        {
            context.Products.RemoveRange(context.Products);
            await context.SaveChangesAsync();

            List<Product> result = await homeService.GetFeaturedProducts();

            Assert.IsEmpty(result);
        }
    }
}
