using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KickShop.Data;
using KickShop.Models;
using KickShop.Services;
using KickShop.ViewModels;
using Microsoft.AspNetCore.Http;
using Moq;

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
                new Category { CategoryId = Guid.NewGuid(), Name = "Boxing", IsDeleted = false, ImageUrl = "image1.png" },
                new Category { CategoryId = Guid.NewGuid(), Name = "MMA", IsDeleted = false, ImageUrl = "image2.png" },
                new Category { CategoryId = Guid.NewGuid(), Name = "Muay Thai", IsDeleted = true, ImageUrl = "image3.png" }
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
        public async Task GetAllCategoriesAsyncReturnsNonDeletedCategories()
        {
            List<Category> result = await categoryService.GetAllCategoriesAsync();
            Assert.AreEqual(2, result.Count);
            Assert.IsTrue(result.All(c => !c.IsDeleted));
        }

        [Test]
        public async Task GetAllCategoriesAsynWithQueryFiltersCategories()
        {
            List<Category> result = await categoryService.GetAllCategoriesAsync();
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual("Boxing", result.First().Name);
        }

        [Test]
        public async Task AddCategoryAsyncAddsNewCategory()
        {
            CategoryAddViewModel model = new CategoryAddViewModel
            {
                Name = "Kickboxing",
                Image = Mock.Of<IFormFile>(file =>
                    file.Length == 1 &&
                    file.FileName == "kickboxing.png" &&
                    file.OpenReadStream() == new System.IO.MemoryStream(new byte[] { 1, 2, 3 }))
            };
            await categoryService.AddCategoryAsync(model);
            List<Category> categories = await context.Categories.ToListAsync();
            Assert.AreEqual(4, categories.Count);
            Assert.IsTrue(categories.Any(c => c.Name == "Kickboxing"));
        }
        [Test]
        public async Task UpdateCategoryAsyncUpdatesExistingCategory()
        {
            Guid categoryId = context.Categories.First().CategoryId;
            CategoryEditViewModel model = new CategoryEditViewModel
            {
                CategoryId = categoryId,
                Name = "Updated Boxing",
                Image = Mock.Of<IFormFile>(file =>
                    file.Length == 1 &&
                    file.FileName == "kickboxing.png" &&
                    file.OpenReadStream() == new System.IO.MemoryStream(new byte[] { 1, 2, 3 }))
            };
            bool result = await categoryService.UpdateCategoryAsync(model);
            Category updatedCategory = await context.Categories.FindAsync(categoryId);
            Assert.IsTrue(result);
            Assert.AreEqual("Updated Boxing", updatedCategory.Name);
        }

        [Test]
        public async Task UpdateCategoryAsyncReturnsFalseIfCategoryNotFound()
        {
            CategoryEditViewModel model = new CategoryEditViewModel { CategoryId = Guid.NewGuid(), Name = "Non-existent" };
            bool result = await categoryService.UpdateCategoryAsync(model);
            Assert.IsFalse(result);
        }

        [Test]
        public async Task DeleteCategoryAsyncSoftDeletesCategory()
        {
            Guid categoryId = context.Categories.First().CategoryId;
            bool result = await categoryService.DeleteCategoryAsync(categoryId);
            Category deletedCategory = await context.Categories.FindAsync(categoryId);
            Assert.IsTrue(result);
            Assert.IsTrue(deletedCategory.IsDeleted);
        }

        [Test]
        public async Task DeleteCategoryAsyncFailsIfAlreadyDeleted()
        {
            Guid categoryId = context.Categories.First(c => c.IsDeleted).CategoryId;
            bool result = await categoryService.DeleteCategoryAsync(categoryId);
            Assert.IsFalse(result);
        }

        [Test]
        public async Task DeleteCategoryAsyncReturnsFalseIfCategoryNotFound()
        {
            bool result = await categoryService.DeleteCategoryAsync(Guid.NewGuid());
            Assert.IsFalse(result);
        }

        [Test]
        public async Task GetCategoryDetailsAsyncReturnsCategoryViewModel()
        {
            Guid categoryId = context.Categories.First().CategoryId;
            CategoryViewModel result = await categoryService.GetCategoryDetailsAsync(categoryId.ToString());
            Assert.IsNotNull(result);
            Assert.AreEqual(categoryId, result.CategoryId);
        }

        [Test]
        public async Task GetCategoryDetailsAsyncReturnsNullForInvalidId()
        {
            CategoryViewModel result = await categoryService.GetCategoryDetailsAsync("invalid-id");
            Assert.IsNull(result);
        }

        [Test]
        public async Task GetCategoryForEditAsyncReturnsCategoryWhenCategoryExists()
        {
            Guid validCategoryId = Guid.NewGuid();
            Category category = new Category
            {
                CategoryId = validCategoryId,
                Name = "Kickboxing",
                IsDeleted = false,
                ImageUrl = "image4.png"
            };

            context.Categories.Add(category);
            await context.SaveChangesAsync();

            CategoryEditViewModel? result = await categoryService.GetCategoryForEditAsync(validCategoryId.ToString());

            Assert.IsNotNull(result);
            Assert.AreEqual(validCategoryId, result?.CategoryId);
            Assert.AreEqual("Kickboxing", result?.Name);
        }

        [Test]
        public async Task GetCategoryForEditAsyncReturnsNullWhenCategoryDoesNotExist()
        {
            string invalidCategoryId = Guid.NewGuid().ToString();

            CategoryEditViewModel? result = await categoryService.GetCategoryForEditAsync(invalidCategoryId);

            Assert.IsNull(result);
        }

        [Test]
        public async Task GetCategoryForEditAsyncReturnsNullWhenCategoryIsDeleted()
        {
            Guid deletedCategoryId = Guid.NewGuid();
            Category deletedCategory = new Category
            {
                CategoryId = deletedCategoryId,
                Name = "Deleted Category",
                IsDeleted = true,
                ImageUrl = "image5.png"
            };

            context.Categories.Add(deletedCategory);
            await context.SaveChangesAsync();

            CategoryEditViewModel? result = await categoryService.GetCategoryForEditAsync(deletedCategoryId.ToString());

            Assert.IsNull(result);
        }

        [Test]
        public async Task GetCategoryForEditAsyncReturnsNullWhenIdIsInvalid()
        {
            string invalidGuid = "invalid-guid";

            CategoryEditViewModel? result = await categoryService.GetCategoryForEditAsync(invalidGuid);

            Assert.IsNull(result);
        }

        [Test]
        public void IsIdValidHandlesNull()
        {
            Assert.IsNull(categoryService.IsIdValid(null));
        }

        [Test]
        public void IsIdValidHandlesEmptyString()
        {
            Assert.IsNull(categoryService.IsIdValid(string.Empty));
        }

        [Test]
        public void IsIdValidHandlesValidGuid()
        {
            Guid guid = Guid.NewGuid();
            Assert.IsTrue(categoryService.IsIdValid(guid.ToString()) == guid);
        }

        [Test]
        public async Task GetAllCategoriesAsyncHandlesEmptyDatabase()
        {
            await context.Database.EnsureDeletedAsync();
            List<Category> result = await categoryService.GetAllCategoriesAsync();
            Assert.AreEqual(0, result.Count);
        }

        [Test]
        public async Task GetAllCategoriesAsyncHandlesLargeDataset()
        {
            for (int i = 0; i < 1000; i++)
            {
                context.Categories.Add(new Category { CategoryId = Guid.NewGuid(), Name = $"Category {i}", IsDeleted = false,ImageUrl ="IMAGEURL.COM" });
            }
            await context.SaveChangesAsync();

            List<Category> result = await categoryService.GetAllCategoriesAsync();
            Assert.AreEqual(1002, result.Count); 
        }
    }
}
