using KickShop.Data;
using KickShop.Models;
using KickShop.Models.Enums;
using KickShop.Services;
using KickShop.Services.Service_Interfaces;
using KickShop.ViewModels;
using KickShop.ViewModels.Product;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechTalk.SpecFlow.Analytics.UserId;

namespace KickShop.Tests
{
    [TestFixture]
    public class ProductServiceTests
    {
        private DbContextOptions<KickShopDbContext> options;
        private KickShopDbContext context;
        private IProductService productService;

        [SetUp]
        public void Setup()
        {
            options = new DbContextOptionsBuilder<KickShopDbContext>()
                .UseInMemoryDatabase(databaseName: "KickShopTest")
                .Options;

            context = new KickShopDbContext(options);

            productService = new  ProductService(context);
        }
        [TearDown]
        public void TearDown()
        {
            context.Database.EnsureDeleted();
            context.Dispose();
        }
        [Test]
        public async Task GetProductForEditAsyncReturnsProductForEdit()
        {
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
        public async Task AddProductAsyncAddsProductSuccessfully()
        {
            Directory.CreateDirectory("wwwroot/images/products");

            ProductAddViewModel productAddViewModel = new ProductAddViewModel
            {
                Name = "New Product",
                Description = "New Product Description",
                Price = 150,
                StockQuantity = 20,
                CategoryId = Guid.NewGuid(),
                BrandId = Guid.NewGuid(),
                Images = new List<IFormFile>
        {
            new FormFile(
                new MemoryStream(new byte[] { 1, 2, 3 }),
                0,
                3,
                "Data",
                "kickboxing.png")
            {
                Headers = new HeaderDictionary(),
                ContentType = "image/png"
            }
        },
                Sizes = new List<ProductSizeViewModel>()
            };

            Product result = await productService.AddProductAsync(productAddViewModel);

            Assert.NotNull(result);
            Assert.AreEqual("New Product", result.Name);

            string savedFilePath = Path.Combine("wwwroot/images/products", result.MainImageUrl.Split('/').Last());
            Assert.IsTrue(File.Exists(savedFilePath));

            File.Delete(savedFilePath);
            Directory.Delete("wwwroot/images/products", true);
        }

        [Test]
        public async Task UpdateProductAsyncUpdatesProductSuccessfully()
        {
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
        public async Task GetAllProductsAsyncReturnsSortedAndFilteredProducts()
        {
            Category category = new Category
            {
                CategoryId = Guid.NewGuid(),
                Name = "temp Category",
                ImageUrl = "asdfasdf"
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
        public async Task DeleteProductAsyncDeletesProductSuccessfully()
        {
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
        [Test]
        public async Task GetProductDetailsAsyncReturnsProductDetailsWhenProductExists()
        {
            Guid productId = Guid.NewGuid();
            Guid categoryId = Guid.NewGuid();
            Product product = new Product
            {
                ProductId = productId,
                Name = "Product 1",
                Price = 100,
                Description = "Description 1",
                StockQuantity = 10,
                MainImageUrl = "main.jpg",
                CategoryId = categoryId,
                IsDeleted = false
            };

            context.Products.Add(product);
            context.ProductsImages.Add(new ProductImage { ProductId = productId, ImageUrl = "image1.jpg" });
            context.Categories.Add(new Category { CategoryId = categoryId, Name = "Category 1",ImageUrl= "asdfasdfasd" });
            await context.SaveChangesAsync();

            ProductDetailsViewModel result = await productService.GetProductDetailsAsync(productId.ToString());

            Assert.NotNull(result);
            Assert.AreEqual("Product 1", result.Name);
            Assert.AreEqual(1, result.Images.Count);
        }

        [Test]
        public async Task GetProductByIdAsyncReturnsProductWhenProductExists()
        {
            Guid productId = Guid.NewGuid();
            Category cat = new Category()
            {
                Name = "asdfasdfasdf",
                ImageUrl = "asdfasdfasdf"
            };
            Brand brand = new Brand()
            {
                Name = "asdfasdfasdf",
                Address = "asdfasdfasdf",
                Country = "asdfasdfasdfasdfasdf",
                Description = "asdfasdfasdfasdf",
                PhoneNumber = "asdfasdfasdf",
                ImageUrl = "asdfasdfasdfasdf"
            };
            Product product = new Product
            {
                ProductId = productId,
                Name = "Product 1",
                IsDeleted = false,
                Description = "asdfasdfasdfasdf",
                CategoryId = cat.CategoryId,
                BrandId =brand.BrandId
            };

            await context.Categories.AddAsync(cat);
            await context.Brands.AddAsync(brand);
            await context.Products.AddAsync(product);
            await context.SaveChangesAsync();

            Product result = await productService.GetProductByIdAsync(productId.ToString());

            Assert.NotNull(result);
            Assert.AreEqual("Product 1", result.Name);
        }

        [Test]
        public async Task GetProductsByCategoryAsyncReturnsProductsForCategory()
        {
            Guid categoryId = Guid.NewGuid();
            Category category = new Category { CategoryId = categoryId, Name = "Category 1",ImageUrl = "asdfasdfasd" };
            Product product1 = new Product { ProductId = Guid.NewGuid(), CategoryId = categoryId, IsDeleted = false, Description = "asdfasdfasdfasdf", Name = "asdfasdfasdfasdf" };
            Product product2 = new Product { ProductId = Guid.NewGuid(), CategoryId = categoryId, IsDeleted = false, Description = "asdfasdfasdfasdf", Name = "asdfasdfasdfasdf" };

            context.Categories.Add(category);
            context.Products.Add(product1);
            context.Products.Add(product2);
            await context.SaveChangesAsync();

            List<Product> result = await productService.GetProductsByCategoryAsync("Category 1", null, null);

            Assert.AreEqual(2, result.Count);
        }

        [Test]
        public async Task GetProductsByBrandAsyncReturnsProductsForBrand()
        {
            Guid brandId = Guid.NewGuid();
            Brand brand = new Brand { BrandId = brandId, Name = "Brand 1",Address="asdfasdfasdf",Country = "asdfasdfasdfasdf",PhoneNumber="asdfasdfasdfasdf" };
            Product product1 = new Product { ProductId = Guid.NewGuid(), BrandId = brandId, IsDeleted = false,Description="asdfasdfasdfasdf",Name = "asdfasdfasdfasdf" };
            Product product2 = new Product { ProductId = Guid.NewGuid(), BrandId = brandId, IsDeleted = false, Description = "asdfasdfasdfasdf", Name = "asdfasdfasdfasdf" };

            context.Brands.Add(brand);
            context.Products.Add(product1);
            context.Products.Add(product2);
            await context.SaveChangesAsync();

            List<Product> result = await productService.GetProductsByBrandAsync("Brand 1", null, null);

            Assert.AreEqual(2, result.Count);
        }

        [Test]
        public async Task RemoveImageAsyncRemovesImageSuccessfully()
        {
            Guid productId = Guid.NewGuid();
            string imageUrl = "images/image1.jpg";
            ProductImage productImage = new ProductImage { ProductId = productId, ImageUrl = imageUrl };

            Directory.CreateDirectory("wwwroot/images");
            File.WriteAllText(Path.Combine("wwwroot", imageUrl), "test");

            context.ProductsImages.Add(productImage);
            await context.SaveChangesAsync();

            bool result = await productService.RemoveImageAsync(imageUrl, productId);

            Assert.IsTrue(result);
            Assert.IsFalse(File.Exists(Path.Combine("wwwroot", imageUrl)));
        }
    }
}
