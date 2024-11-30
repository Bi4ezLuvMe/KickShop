using System;
using System.Linq;
using System.Threading.Tasks;
using KickShop.Data;
using KickShop.Models;
using KickShop.Services;
using KickShop.ViewModels;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace KickShop.Tests.Services
{
    [TestFixture]
    public class BrandServiceTests
    {
        private KickShopDbContext context;
        private BrandService brandService;

        [SetUp]
        public void Setup()
        {
            DbContextOptions<KickShopDbContext> options = new DbContextOptionsBuilder<KickShopDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            context = new KickShopDbContext(options);
            brandService = new BrandService(context);
        }

        [TearDown]
        public void Teardown()
        {
            context.Dispose();
        }

        [Test]
        public async Task GetAllBrandsAsync_ReturnsAllNonDeletedBrands()
        {
            Brand brand1 = new Brand
            {
                BrandId = Guid.NewGuid(),
                Name = "Brand 1",
                Address = "Address 1",
                Country = "Country 1",
                PhoneNumber = "123456789",
                ImageUrl = "http://example.com/image1.jpg",
                IsDeleted = false
            };

            Brand brand2 = new Brand
            {
                BrandId = Guid.NewGuid(),
                Name = "Brand 2",
                Address = "Address 2",
                Country = "Country 2",
                PhoneNumber = "987654321",
                ImageUrl = "http://example.com/image2.jpg",
                IsDeleted = false
            };

            await context.Brands.AddRangeAsync(brand1, brand2);
            await context.SaveChangesAsync();

            System.Collections.Generic.List<Brand> result = await brandService.GetAllBrandsAsync(null);

            Assert.AreEqual(2, result.Count);
            Assert.IsTrue(result.Any(b => b.Name == "Brand 1"));
            Assert.IsTrue(result.Any(b => b.Name == "Brand 2"));
        }

        [Test]
        public async Task AddBrandAsync_AddsBrandToDatabase()
        {
            BrandAddViewModel model = new BrandAddViewModel
            {
                Name = "New Brand",
                Address = "123 Brand Street",
                PhoneNumber = "1234567890",
                Country = "USA"
            };

            await brandService.AddBrandAsync(model);

            Brand brand = await context.Brands.FirstOrDefaultAsync();
            Assert.NotNull(brand);
            Assert.AreEqual("New Brand", brand.Name);
        }

        [Test]
        public async Task UpdateBrandAsync_UpdatesBrandIfExists()
        {
            Brand brand = new Brand
            {
                BrandId = Guid.NewGuid(),
                Name = "Original Brand",
                Address = "Original Address",
                Country = "Original Country",
                PhoneNumber = "123456789",
                ImageUrl = "http://example.com/original.jpg",
                IsDeleted = false
            };

            await context.Brands.AddAsync(brand);
            await context.SaveChangesAsync();

            BrandEditViewModel editViewModel = new BrandEditViewModel
            {
                BrandId = brand.BrandId,
                Name = "Updated Brand",
                Address = "Updated Address",
                Country = "Updated Country",
                PhoneNumber = "987654321",
            };

            bool result = await brandService.UpdateBrandAsync(editViewModel);

            Assert.IsTrue(result);

            Brand updatedBrand = await context.Brands.FindAsync(brand.BrandId);
            Assert.AreEqual("Updated Brand", updatedBrand.Name);
            Assert.AreEqual("Updated Address", updatedBrand.Address);
            Assert.AreEqual("Updated Country", updatedBrand.Country);
            Assert.AreEqual("987654321", updatedBrand.PhoneNumber);
            Assert.AreEqual("http://example.com/updated.jpg", updatedBrand.ImageUrl);
        }

        [Test]
        public async Task UpdateBrandAsync_ReturnsFalseIfBrandDoesNotExist()
        {
            BrandEditViewModel model = new BrandEditViewModel
            {
                BrandId = Guid.NewGuid(),
                Name = "Nonexistent Brand"
            };

            bool result = await brandService.UpdateBrandAsync(model);

            Assert.IsFalse(result);
        }

        [Test]
        public async Task GetBrandDetailsAsync_ReturnsBrandDetailsIfExists()
        {
            Brand brand = new Brand
            {
                Name = "Brand Details",
                IsDeleted = false,
                Address = "123 Street",
                PhoneNumber = "1234567890",
                ImageUrl = "image.jpg",
                Country = "Country"
            };
            context.Brands.Add(brand);
            await context.SaveChangesAsync();

            BrandDetailsViewModel? result = await brandService.GetBrandDetailsAsync(brand.BrandId.ToString());

            Assert.NotNull(result);
            Assert.AreEqual("Brand Details", result.Name);
        }

        [Test]
        public async Task GetBrandDetailsAsync_ReturnsNullIfBrandDoesNotExist()
        {
            BrandDetailsViewModel? result = await brandService.GetBrandDetailsAsync(Guid.NewGuid().ToString());

            Assert.IsNull(result);
        }

        [Test]
        public async Task DeleteBrandAsync_SetsIsDeletedToTrueIfExists()
        {
            Brand brand = new Brand
            {
                BrandId = Guid.NewGuid(),
                Name = "Test Brand",
                Address = "Test Address",
                Country = "Test Country",
                PhoneNumber = "123456789",
                ImageUrl = "http://example.com/image.jpg",
            };

            await context.Brands.AddAsync(brand);
            await context.SaveChangesAsync();

            bool result = await brandService.DeleteBrandAsync(brand.BrandId.ToString());

            Brand deletedBrand = await context.Brands.FindAsync(brand.BrandId);
            Assert.IsTrue(result);
            Assert.IsTrue(deletedBrand.IsDeleted);
        }

        [Test]
        public async Task DeleteBrandAsync_ReturnsFalseIfBrandDoesNotExist()
        {
            bool result = await brandService.DeleteBrandAsync(Guid.NewGuid().ToString());

            Assert.IsFalse(result);
        }
    }
}
