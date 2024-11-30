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
        private KickShopDbContext context;
        private LayoutPopulateService layoutPopulateService;

        [SetUp]
        public void SetUp()
        {
            DbContextOptions<KickShopDbContext> options = new DbContextOptionsBuilder<KickShopDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            context = new KickShopDbContext(options);

            List<Brand> brands = new List<Brand>
            {
                new Brand { BrandId = Guid.NewGuid(), Name = "Brand1", Country = "USA", Address = "Address1", PhoneNumber = "1234567890", IsDeleted = false },
                new Brand { BrandId = Guid.NewGuid(), Name = "Brand2", Country = "UK", Address = "Address2", PhoneNumber = "0987654321", IsDeleted = false },
                new Brand { BrandId = Guid.NewGuid(), Name = "Brand3", Country = "Germany", Address = "Address3", PhoneNumber = "1122334455", IsDeleted = true }
            };

            List<Category> categories = new List<Category>
            {
                new Category { CategoryId = Guid.NewGuid(), Name = "Category1", IsDeleted = false,ImageUrl ="asdfasd" },
                new Category { CategoryId = Guid.NewGuid(), Name = "Category2", IsDeleted = false,ImageUrl ="asdfasd" },
                new Category { CategoryId = Guid.NewGuid(), Name = "Category3", IsDeleted = true,ImageUrl ="asdfasd" }
            };

            context.Brands.AddRange(brands);
            context.Categories.AddRange(categories);
            context.SaveChanges();

            layoutPopulateService = new LayoutPopulateService(context);
        }

        [TearDown]
        public void TearDown()
        {
            context.Database.EnsureDeleted();
            context.Dispose();
        }

        [Test]
        public async Task GetBrandsAsyncReturnsAllNonDeletedBrandNames()
        {
            List<string> result = await layoutPopulateService.GetBrandsAsync();

            Assert.AreEqual(2, result.Count);
            Assert.Contains("Brand1", result);
            Assert.Contains("Brand2", result);
            Assert.IsFalse(result.Contains("Brand3"));
        }

        [Test]
        public async Task GetBrandsAsyncReturnsEmptyListWhenNoBrandsAvailable()
        {
            context.Brands.RemoveRange(context.Brands);
            await context.SaveChangesAsync();

            List<string> result = await layoutPopulateService.GetBrandsAsync();

            Assert.IsEmpty(result);
        }

        [Test]
        public async Task GetCategoriesAsyncReturnsAllNonDeletedCategoryNames()
        {
            List<string> result = await layoutPopulateService.GetCategoriesAsync();

            Assert.AreEqual(2, result.Count);
            Assert.Contains("Category1", result);
            Assert.Contains("Category2", result);
            Assert.IsFalse(result.Contains("Category3"));
        }

        [Test]
        public async Task GetCategoriesAsyncReturnsEmptyListWhenNoCategoriesAvailable()
        {
            context.Categories.RemoveRange(context.Categories);
            await context.SaveChangesAsync();

            List<string> result = await layoutPopulateService.GetCategoriesAsync();

            Assert.IsEmpty(result);
        }
    }
}
