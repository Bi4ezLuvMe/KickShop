using KickShop.Data;
using KickShop.Models;
using KickShop.Models.Enums;
using KickShop.Services;
using KickShop.ViewModels;
using KickShop.ViewModels.Product;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KickShop.Tests
{
    [TestFixture]
    public class ProductServiceTests
    {
        private DbContextOptions<KickShopDbContext> options;

        [SetUp]
        public void Setup()
        {
            options = new DbContextOptionsBuilder<KickShopDbContext>()
                .UseInMemoryDatabase(databaseName: "KickShopTest")
                .Options;
        }

        [Test]
        public async Task GetProductForEditAsync_ReturnsProductForEdit()
        {
            using KickShopDbContext context = new KickShopDbContext(options);
            ProductService productService = new ProductService(context);
            Product product = new Product
            {
                ProductId = Guid.NewGuid(),
                Name = "Test Product",
                Description = "Test Description",
                Price = 100,
                StockQuantity = 10,
                CategoryId = Guid.NewGuid(),
                BrandId = Guid.NewGuid(),
            };
            ProductSize productSize = new ProductSize()
            {
                ProductId = product.ProductId,
                Size = Sizes.S,
                Quantity = 2
            };

            context.Products.Add(product);
            context.ProductsSizes.Add(productSize);
            await context.SaveChangesAsync();

            ProductEditViewModel result = await productService.GetProductForEditAsync(product.ProductId.ToString());

            Assert.NotNull(result);
            Assert.AreEqual("Test Product", result.Name);
        }

        [Test]
        public async Task AddProductAsync_AddsProductSuccessfully()
        {
            using KickShopDbContext context = new KickShopDbContext(options);
            ProductService productService = new ProductService(context);

            ProductAddViewModel productAddViewModel = new ProductAddViewModel
            {
                Name = "New Product",
                Description = "New Product Description",
                Price = 150,
                StockQuantity = 20,
                CategoryId = Guid.NewGuid(),
                BrandId = Guid.NewGuid(),
            };

            Product result = await productService.AddProductAsync(productAddViewModel);

            Assert.NotNull(result);
            Assert.AreEqual("New Product", result.Name);
        }

        [Test]
        public async Task UpdateProductAsync_UpdatesProductSuccessfully()
        {
            using KickShopDbContext context = new KickShopDbContext(options);
            ProductService productService = new ProductService(context);

            Product product = new Product
            {
                ProductId = Guid.NewGuid(),
                Name = "Test Product",
                Description = "Test Description",
                Price = 100,
                StockQuantity = 10,
                CategoryId = Guid.NewGuid(),
                BrandId = Guid.NewGuid(),
            };
            ProductSize productSize = new ProductSize()
            {
                ProductId = product.ProductId,
                Size = Sizes.S,
                Quantity = 2
            };
            context.Products.Add(product);
            context.ProductsSizes.Add(productSize);
            await context.SaveChangesAsync();

            ProductEditViewModel productEditModel = new ProductEditViewModel
            {
                ProductId = product.ProductId,
                Name = "Updated Product",
                Description = "Test Description",
                Price = 100,
                StockQuantity = 10,
                CategoryId = Guid.NewGuid(),
                BrandId = Guid.NewGuid(),
                Sizes = new List<ProductSizeViewModel>()
                {
                   new ProductSizeViewModel()
                   {
                       Size = "L",
                       Quantity =2
                   }
                }
            };

            bool updatedProduct = await productService.UpdateProductAsync(productEditModel);

            Assert.IsTrue(updatedProduct);
        }

        [Test]
        public async Task GetAllProductsAsync_ReturnsSortedAndFilteredProducts()
        {
            using KickShopDbContext context = new KickShopDbContext(options);
            ProductService productService = new ProductService(context);

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

            Product product1 = new Product
            {
                Name = "Product Query A",
                Description = "Description A",
                Price = 100,
                StockQuantity = 10,
                CategoryId = category.CategoryId,
                BrandId = brand.BrandId,
                IsDeleted = false
            };

            Product product2 = new Product
            {
                Name = "Product Query B",
                Description = "Description B",
                Price = 200,
                StockQuantity = 5,
                CategoryId = category.CategoryId,
                BrandId = brand.BrandId,
                IsDeleted = false
            };
            ProductSize productSize1 = new ProductSize()
            {
                ProductId = product1.ProductId,
                Size = Sizes.S,
                Quantity = 2
            };
            ProductSize productSize2 = new ProductSize()
            {
                ProductId = product2.ProductId,
                Size = Sizes.S,
                Quantity = 2
            };

            await context.Products.AddAsync(product1);
            await context.Products.AddAsync(product2);
            await context.ProductsSizes.AddAsync(productSize1);
            await context.ProductsSizes.AddAsync(productSize2);
            await context.Brands.AddAsync(brand);
            await context.Categories.AddAsync(category);
            await context.SaveChangesAsync();

            List<Product> products = await productService.GetAllProductsAsync(null, "Product Query");

            Assert.NotNull(products);
            Assert.AreEqual(2, products.Count());
            Assert.IsTrue(products.Any(p => p.Name == "Product Query A"));
            Assert.IsTrue(products.Any(p => p.Name == "Product Query B"));
        }

        [Test]
        public async Task DeleteProductAsync_DeletesProductSuccessfully()
        {
            using KickShopDbContext context = new KickShopDbContext(options);
            ProductService productService = new ProductService(context);

            Product product = new Product
            {
                ProductId = Guid.NewGuid(),
                Name = "Product to Delete",
                Description = "This product will be deleted",
                Price = 100,
                StockQuantity = 10,
                CategoryId = Guid.NewGuid(),
                BrandId = Guid.NewGuid(),
            };
            ProductSize productSize = new ProductSize()
            {
                ProductId = product.ProductId,
                Size = Sizes.S,
                Quantity = 2
            };

            await context.Products.AddAsync(product);
            await context.ProductsSizes.AddAsync(productSize);
            await context.SaveChangesAsync();

            await productService.DeleteProductAsync(product.ProductId.ToString());

            Product deletedProduct = await context.Products
                .FirstOrDefaultAsync(p => p.ProductId == product.ProductId && !p.IsDeleted);

            Assert.Null(deletedProduct);
        }
    }
}
