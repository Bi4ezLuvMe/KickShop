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
        private KickShopDbContext dbContext;
        private HomeService homeService;

        [SetUp]
        public void SetUp()
        {
            var options = new DbContextOptionsBuilder<KickShopDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            dbContext = new KickShopDbContext(options);

            dbContext.Products.AddRange(
                new Product
                {
                    ProductId = Guid.NewGuid(),
                    Name = "Product 1",
                    Description = "Description 1",
                    Price = 100.50m,
                    StockQuantity = 10,
                    MainImageUrl = "https://example.com/image1.jpg",
                    CategoryId = Guid.NewGuid(),
                    BrandId = Guid.NewGuid(),
                    Sizes = new List<Sizes> { Sizes.S },
                    IsDeleted = false
                },
                new Product
                {
                    ProductId = Guid.NewGuid(),
                    Name = "Product 2",
                    Description = "Description 2",
                    Price = 150.75m,
                    StockQuantity = 5,
                    MainImageUrl = "https://example.com/image2.jpg",
                    CategoryId = Guid.NewGuid(),
                    BrandId = Guid.NewGuid(),
                    Sizes = new List<Sizes> { Sizes.M },
                    IsDeleted = false
                },
                new Product
                {
                    ProductId = Guid.NewGuid(),
                    Name = "Product 3",
                    Description = "Description 3",
                    Price = 200.99m,
                    StockQuantity = 3,
                    MainImageUrl = "https://example.com/image3.jpg",
                    CategoryId = Guid.NewGuid(),
                    BrandId = Guid.NewGuid(),
                    Sizes = new List<Sizes> { Sizes.L },
                    IsDeleted = false
                },
                new Product
                {
                    ProductId = Guid.NewGuid(),
                    Name = "Product 4",
                    Description = "Description 4",
                    Price = 300.00m,
                    StockQuantity = 7,
                    MainImageUrl = "https://example.com/image4.jpg",
                    CategoryId = Guid.NewGuid(),
                    BrandId = Guid.NewGuid(),
                    Sizes = new List<Sizes> { Sizes.XL },
                    IsDeleted = false
                }
            );

            dbContext.SaveChanges();

            homeService = new HomeService(dbContext);
        }

        [TearDown]
        public void TearDown()
        {
            dbContext.Database.EnsureDeleted();
            dbContext.Dispose();
        }

        [Test]
        public async Task GetFeaturedProducts_ReturnsFirstThreeProducts()
        {
            var result = await homeService.GetFeaturedProducts();

            Assert.AreEqual(3, result.Count);
            Assert.AreEqual("Product 1", result[0].Name);
            Assert.AreEqual("Product 2", result[1].Name);
            Assert.AreEqual("Product 3", result[2].Name);
        }

        [Test]
        public async Task GetFeaturedProducts_ReturnsEmptyListIfNoProducts()
        {
            dbContext.Products.RemoveRange(dbContext.Products);
            await dbContext.SaveChangesAsync();

            var result = await homeService.GetFeaturedProducts();

            Assert.IsEmpty(result);
        }
    }
}
