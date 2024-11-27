using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Linq;
using System.Threading.Tasks;
using KickShop.Data;
using KickShop.Models;
using KickShop.Services;
using KickShop.ViewModels;

namespace KickShop.Tests.Services
{
    [TestFixture]
    public class CategoryServiceTests
    {
        private KickShopDbContext dbContext;
        private CategoryService categoryService;

        [SetUp]
        public void SetUp()
        {
            var options = new DbContextOptionsBuilder<KickShopDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            dbContext = new KickShopDbContext(options);

            dbContext.Categories.AddRange(
                new Category { CategoryId = Guid.NewGuid(), Name = "Boxing", IsDeleted = false },
                new Category { CategoryId = Guid.NewGuid(), Name = "MMA", IsDeleted = false },
                new Category { CategoryId = Guid.NewGuid(), Name = "Muay Thai", IsDeleted = true }
            );
            dbContext.SaveChanges();

            categoryService = new CategoryService(dbContext);
        }

        [TearDown]
        public void TearDown()
        {
            dbContext.Database.EnsureDeleted();
            dbContext.Dispose();
        }

        [Test]
        public async Task GetAllCategoriesAsync_ReturnsNonDeletedCategories()
        {
            var result = await categoryService.GetAllCategoriesAsync(null);
            Assert.AreEqual(2, result.Count);
            Assert.IsTrue(result.All(c => !c.IsDeleted));
        }

        [Test]
        public async Task GetAllCategoriesAsync_WithQuery_FiltersCategories()
        {
            var result = await categoryService.GetAllCategoriesAsync("Box");
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("Boxing", result.First().Name);
        }

        [Test]
        public async Task AddCategoryAsync_AddsNewCategory()
        {
            var model = new CategoryAddViewModel { Name = "Kickboxing", ImageUrl = "url" };
            await categoryService.AddCategoryAsync(model);
            var categories = await dbContext.Categories.ToListAsync();
            Assert.AreEqual(4, categories.Count);
            Assert.IsTrue(categories.Any(c => c.Name == "Kickboxing"));
        }

        [Test]
        public async Task UpdateCategoryAsync_UpdatesExistingCategory()
        {
            var categoryId = dbContext.Categories.First().CategoryId;
            var model = new CategoryEditViewModel { CategoryId = categoryId, Name = "Updated Boxing", ImageUrl = "updated-url" };
            var result = await categoryService.UpdateCategoryAsync(model);
            var updatedCategory = await dbContext.Categories.FindAsync(categoryId);
            Assert.IsTrue(result);
            Assert.AreEqual("Updated Boxing", updatedCategory.Name);
            Assert.AreEqual("updated-url", updatedCategory.ImageUrl);
        }

        [Test]
        public async Task UpdateCategoryAsync_ReturnsFalseIfCategoryNotFound()
        {
            var model = new CategoryEditViewModel { CategoryId = Guid.NewGuid(), Name = "Non-existent", ImageUrl = "url" };
            var result = await categoryService.UpdateCategoryAsync(model);
            Assert.IsFalse(result);
        }

        [Test]
        public async Task DeleteCategoryAsync_SoftDeletesCategory()
        {
            var categoryId = dbContext.Categories.First().CategoryId;
            var result = await categoryService.DeleteCategoryAsync(categoryId);
            var deletedCategory = await dbContext.Categories.FindAsync(categoryId);
            Assert.IsTrue(result);
            Assert.IsTrue(deletedCategory.IsDeleted);
        }

        [Test]
        public async Task DeleteCategoryAsync_ReturnsFalseIfCategoryNotFound()
        {
            var result = await categoryService.DeleteCategoryAsync(Guid.NewGuid());
            Assert.IsFalse(result);
        }

        [Test]
        public async Task GetCategoryDetailsAsync_ReturnsCategoryViewModel()
        {
            var categoryId = dbContext.Categories.First().CategoryId;
            var result = await categoryService.GetCategoryDetailsAsync(categoryId.ToString());
            Assert.IsNotNull(result);
            Assert.AreEqual(categoryId, result.CategoryId);
        }
    }
}
