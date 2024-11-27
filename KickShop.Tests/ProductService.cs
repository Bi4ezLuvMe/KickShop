using KickShop.Data;
using KickShop.Models;
using KickShop.Models.Enums;
using KickShop.Services;
using KickShop.ViewModels;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace KickShop.Tests
{
    [TestFixture]
    public class ProductServiceTests
    {
        private DbContextOptions<KickShopDbContext> _options;

        [SetUp]
        public void Setup()
        {
            // Set up an in-memory database for testing
            _options = new DbContextOptionsBuilder<KickShopDbContext>()
                .UseInMemoryDatabase(databaseName: "KickShopTest")
                .Options;
        }

        [Test]
        public async Task GetProductForEditAsync_ReturnsProductForEdit()
        {
            // Arrange
            using var context = new KickShopDbContext(_options);
            var productService = new ProductService(context);

            var product = new Product
            {
                ProductId = Guid.NewGuid(),
                Name = "Test Product",
                Description = "Test Description",
                Price = 100,
                StockQuantity = 10,
                CategoryId = Guid.NewGuid(),
                BrandId = Guid.NewGuid(),
                Sizes = new List<Sizes> {Sizes.S }
            };

            context.Products.Add(product);
            await context.SaveChangesAsync();

            // Act
            var result = await productService.GetProductForEditAsync(product.ProductId.ToString());

            // Assert
            Assert.NotNull(result);
            Assert.AreEqual("Test Product", result.Name);
        }

        [Test]
        public async Task AddProductAsync_AddsProductSuccessfully()
        {
            // Arrange
            using var context = new KickShopDbContext(_options);
            var productService = new ProductService(context);

            var productAddViewModel = new ProductAddViewModel
            {
                Name = "New Product",
                Description = "New Product Description",
                Price = 150,
                StockQuantity = 20,
                CategoryId = Guid.NewGuid(),
                BrandId = Guid.NewGuid(),
                Sizes = new List<Sizes> { Sizes.S }
            };

            // Act
            var result = await productService.AddProductAsync(productAddViewModel);

            // Assert
            Assert.NotNull(result);
            Assert.AreEqual("New Product", result.Name);
        }

        [Test]
        public async Task UpdateProductAsync_UpdatesProductSuccessfully()
        {
            // Arrange
            using var context = new KickShopDbContext(_options);
            var productService = new ProductService(context);

            var product = new Product
            {
                ProductId = Guid.NewGuid(),
                Name = "Test Product",
                Description = "Test Description",
                Price = 100,
                StockQuantity = 10,
                CategoryId = Guid.NewGuid(),
                BrandId = Guid.NewGuid(),
                Sizes = new List<Sizes> { Sizes.S }
            };

            context.Products.Add(product);
            await context.SaveChangesAsync();

            var productEditModel = new ProductEditViewModel
            {
                ProductId = product.ProductId,
                Name = "Updated Product",
                Description = "Test Description",
                Price = 100,
                StockQuantity = 10,
                CategoryId = Guid.NewGuid(),
                BrandId = Guid.NewGuid(),
                Sizes = new List<Sizes> {Sizes.L }
            };
            var updatedProduct = await productService.UpdateProductAsync(productEditModel);

            // Assert
            Assert.IsTrue(updatedProduct);
        }

        [Test]
        public async Task GetAllProductsAsync_ReturnsSortedAndFilteredProducts()
        {
            // Arrange
            using var context = new KickShopDbContext(_options);
            var productService = new ProductService(context);

            Category category = new Category
            {
                CategoryId = Guid.NewGuid(),
                Name = "temp Category",
            };

            Brand brand = new Brand
            {
                BrandId = Guid.NewGuid(),
                Name = "temp Brand",
                Country = "asdfasdf",
                Address = "asdfasdfasdf",
                PhoneNumber = "asdfasdfasdf",
            };

            var product1 = new Product
            {
                Name = "Product Query A",
                Description = "Description A",
                Price = 100,
                StockQuantity = 10,
                CategoryId =category.CategoryId,
                BrandId = brand.BrandId,
                Sizes = new List<Sizes> { Sizes.S },
                IsDeleted = false
            };

            var product2 = new Product
            {
                Name = "Product Query B",
                Description = "Description B",
                Price = 200,
                StockQuantity = 5,
                CategoryId = category.CategoryId,
                BrandId = brand.BrandId,
                Sizes = new List<Sizes> { Sizes.S },
                IsDeleted = false
            };

            await context.Products.AddAsync(product1);
            await context.Products.AddAsync(product2);
            await context.Brands.AddAsync(brand);
            await context.Categories.AddAsync(category);
            await context.SaveChangesAsync();

            // Act
            var products = await productService.GetAllProductsAsync(null,"Product Query");

            // Assert
            Assert.NotNull(products);
            Assert.AreEqual(2, products.Count());
            Assert.IsTrue(products.Any(p => p.Name == "Product Query A"));
            Assert.IsTrue(products.Any(p => p.Name == "Product Query B"));
        }

        [Test]
        public async Task DeleteProductAsync_DeletesProductSuccessfully()
        {
            // Arrange
            using var context = new KickShopDbContext(_options);
            var productService = new ProductService(context);

            var product = new Product
            {
                ProductId = Guid.NewGuid(),
                Name = "Product to Delete",
                Description = "This product will be deleted",
                Price = 100,
                StockQuantity = 10,
                CategoryId = Guid.NewGuid(),
                BrandId = Guid.NewGuid(),
                Sizes = new List<Sizes> { Sizes.S }
            };

            context.Products.Add(product);
            await context.SaveChangesAsync();

            // Act
            await productService.DeleteProductAsync(product.ProductId.ToString());

            // Assert
            var deletedProduct = await context.Products
                                               .FirstOrDefaultAsync(p => p.ProductId == product.ProductId&&!p.IsDeleted);
            Assert.Null(deletedProduct);
        }
    }
}