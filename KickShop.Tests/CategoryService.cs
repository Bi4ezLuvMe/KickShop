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
        private KickShopDbContext context;
        private CategoryService categoryService;

        [SetUp]
        public void SetUp()
        {
            DbContextOptions<KickShopDbContext> options = new DbContextOptionsBuilder<KickShopDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            context = new KickShopDbContext(options);

            context.Categories.AddRange(
                new Category { CategoryId = Guid.NewGuid(), Name = "Boxing", IsDeleted = false },
                new Category { CategoryId = Guid.NewGuid(), Name = "MMA", IsDeleted = false },
                new Category { CategoryId = Guid.NewGuid(), Name = "Muay Thai", IsDeleted = true }
            );
            context.SaveChanges();

            categoryService = new CategoryService(context);
        }

        [TearDown]
        public void TearDown()
        {
            context.Database.EnsureDeleted();
            context.Dispose();
        }

        [Test]
        public async Task GetAllCategoriesAsync_ReturnsNonDeletedCategories()
        {
            List<Category> result = await categoryService.GetAllCategoriesAsync(null);
            Assert.AreEqual(2, result.Count);
            Assert.IsTrue(result.All(c => !c.IsDeleted));
        }

        [Test]
        public async Task GetAllCategoriesAsync_WithQuery_FiltersCategories()
        {
            List<Category> result = await categoryService.GetAllCategoriesAsync("Box");
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("Boxing", result.First().Name);
        }

        [Test]
        public async Task AddCategoryAsync_AddsNewCategory()
        {
            CategoryAddViewModel model = new CategoryAddViewModel { Name = "Kickboxing"};
            await categoryService.AddCategoryAsync(model);
            List<Category> categories = await context.Categories.ToListAsync();
            Assert.AreEqual(4, categories.Count);
            Assert.IsTrue(categories.Any(c => c.Name == "Kickboxing"));
        }

        [Test]
        public async Task UpdateCategoryAsync_UpdatesExistingCategory()
        {
            Guid categoryId = context.Categories.First().CategoryId;
            CategoryEditViewModel model = new CategoryEditViewModel { CategoryId = categoryId, Name = "Updated Boxing" };
            bool result = await categoryService.UpdateCategoryAsync(model);
            Category updatedCategory = await context.Categories.FindAsync(categoryId);
            Assert.IsTrue(result);
            Assert.AreEqual("Updated Boxing", updatedCategory.Name);
            Assert.AreEqual("updated-url", updatedCategory.ImageUrl);
        }

        [Test]
        public async Task UpdateCategoryAsync_ReturnsFalseIfCategoryNotFound()
        {
            CategoryEditViewModel model = new CategoryEditViewModel { CategoryId = Guid.NewGuid(), Name = "Non-existent"};
            bool result = await categoryService.UpdateCategoryAsync(model);
            Assert.IsFalse(result);
        }

        [Test]
        public async Task DeleteCategoryAsync_SoftDeletesCategory()
        {
            Guid categoryId = context.Categories.First().CategoryId;
            bool result = await categoryService.DeleteCategoryAsync(categoryId);
            Category deletedCategory = await context.Categories.FindAsync(categoryId);
            Assert.IsTrue(result);
            Assert.IsTrue(deletedCategory.IsDeleted);
        }

        [Test]
        public async Task DeleteCategoryAsync_ReturnsFalseIfCategoryNotFound()
        {
            bool result = await categoryService.DeleteCategoryAsync(Guid.NewGuid());
            Assert.IsFalse(result);
        }

        [Test]
        public async Task GetCategoryDetailsAsync_ReturnsCategoryViewModel()
        {
            Guid categoryId = context.Categories.First().CategoryId;
            CategoryViewModel result = await categoryService.GetCategoryDetailsAsync(categoryId.ToString());
            Assert.IsNotNull(result);
            Assert.AreEqual(categoryId, result.CategoryId);
        }
    }
}
