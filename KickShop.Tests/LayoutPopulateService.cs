using KickShop.Data;
using KickShop.Models;
using KickShop.Services;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KickShop.Tests.Services
{
    [TestFixture]
    public class LayoutPopulateServiceTests
    {
        private KickShopDbContext dbContext;
        private LayoutPopulateService layoutPopulateService;

        [SetUp]
        public void SetUp()
        {
            var options = new DbContextOptionsBuilder<KickShopDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            dbContext = new KickShopDbContext(options);

            dbContext.Brands.AddRange(
                new Brand { BrandId = Guid.NewGuid(), Name = "Brand1", Country = "USA", Address = "Address1", PhoneNumber = "1234567890", IsDeleted = false },
                new Brand { BrandId = Guid.NewGuid(), Name = "Brand2", Country = "UK", Address = "Address2", PhoneNumber = "0987654321", IsDeleted = false },
                new Brand { BrandId = Guid.NewGuid(), Name = "Brand3", Country = "Germany", Address = "Address3", PhoneNumber = "1122334455", IsDeleted = true }
            );

            dbContext.Categories.AddRange(
                new Category { CategoryId = Guid.NewGuid(), Name = "Category1", IsDeleted = false },
                new Category { CategoryId = Guid.NewGuid(), Name = "Category2", IsDeleted = false },
                new Category { CategoryId = Guid.NewGuid(), Name = "Category3", IsDeleted = true }
            );

            dbContext.SaveChanges();

            layoutPopulateService = new LayoutPopulateService(dbContext);
        }

        [TearDown]
        public void TearDown()
        {
            dbContext.Database.EnsureDeleted();
            dbContext.Dispose();
        }

        [Test]
        public async Task GetBrandsAsync_ReturnsNonDeletedBrandNames()
        {
            var result = await layoutPopulateService.GetBrandsAsync();

            Assert.AreEqual(2, result.Count);
            Assert.Contains("Brand1", result);
            Assert.Contains("Brand2", result);
            Assert.IsFalse(result.Contains("Brand3"));
        }

        [Test]
        public async Task GetBrandsAsync_ReturnsEmptyList_WhenNoBrandsAvailable()
        {
            dbContext.Brands.RemoveRange(dbContext.Brands);
            await dbContext.SaveChangesAsync();

            var result = await layoutPopulateService.GetBrandsAsync();

            Assert.IsEmpty(result);
        }

        [Test]
        public async Task GetCategoriesAsync_ReturnsNonDeletedCategoryNames()
        {
            var result = await layoutPopulateService.GetCategoriesAsync();

            Assert.AreEqual(2, result.Count);
            Assert.Contains("Category1", result);
            Assert.Contains("Category2", result);
            Assert.IsFalse(result.Contains("Category3"));
        }

        [Test]
        public async Task GetCategoriesAsync_ReturnsEmptyList_WhenNoCategoriesAvailable()
        {
            dbContext.Categories.RemoveRange(dbContext.Categories);
            await dbContext.SaveChangesAsync();

            var result = await layoutPopulateService.GetCategoriesAsync();

            Assert.IsEmpty(result);
        }
    }
}
