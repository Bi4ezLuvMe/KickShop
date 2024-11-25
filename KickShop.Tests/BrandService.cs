using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KickShop.Data;
using KickShop.Models;
using KickShop.Services;
using KickShop.ViewModels;
using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;

namespace KickShop.Tests.Services
{
    [TestFixture]
    public class BrandServiceTests
    {
        private KickShopDbContext _dbContext;
        private BrandService _brandService;

        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<KickShopDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            _dbContext = new KickShopDbContext(options);
            _brandService = new BrandService(_dbContext);
        }

        [TearDown]
        public void Teardown()
        {
            _dbContext.Dispose();
        }

        [Test]
        public async Task GetAllBrandsAsync_ReturnsAllNonDeletedBrands()
        {        
            var brand1 = new Brand
            {
                BrandId = Guid.NewGuid(),
                Name = "Brand 1",
                Address = "Address 1",
                Country = "Country 1",
                PhoneNumber = "123456789", 
                ImageUrl = "http://example.com/image1.jpg",
                IsDeleted = false
            };

            var brand2 = new Brand
            {
                BrandId = Guid.NewGuid(),
                Name = "Brand 2",
                Address = "Address 2", 
                Country = "Country 2", 
                PhoneNumber = "987654321",
                ImageUrl = "http://example.com/image2.jpg",
                IsDeleted = false
            };

            await _dbContext.Brands.AddRangeAsync(brand1, brand2);
            await _dbContext.SaveChangesAsync();
           
            var result = await _brandService.GetAllBrandsAsync(null);
  
            Assert.AreEqual(2, result.Count);
            Assert.IsTrue(result.Any(b => b.Name == "Brand 1"));
            Assert.IsTrue(result.Any(b => b.Name == "Brand 2"));
        }

        [Test]
        public async Task AddBrandAsync_AddsBrandToDatabase()
        {          
            var model = new BrandAddViewModel
            {
                Name = "New Brand",
                Address = "123 Brand Street",
                PhoneNumber = "1234567890",
                ImageUrl = "image.jpg",
                Country = "USA"
            };
            
            await _brandService.AddBrandAsync(model);
  
            var brand = await _dbContext.Brands.FirstOrDefaultAsync();
            Assert.NotNull(brand);
            Assert.AreEqual("New Brand", brand.Name);
        }

        [Test]
        public async Task UpdateBrandAsync_UpdatesBrandIfExists()
        {            
            var brand = new Brand
            {
                BrandId = Guid.NewGuid(),
                Name = "Original Brand",
                Address = "Original Address", 
                Country = "Original Country", 
                PhoneNumber = "123456789",
                ImageUrl = "http://example.com/original.jpg",
                IsDeleted = false
            };

            await _dbContext.Brands.AddAsync(brand);
            await _dbContext.SaveChangesAsync();

            var editViewModel = new BrandEditViewModel
            {
                BrandId = brand.BrandId,
                Name = "Updated Brand",
                Address = "Updated Address", 
                Country = "Updated Country", 
                PhoneNumber = "987654321",
                ImageUrl = "http://example.com/updated.jpg",
            };
           
            var result = await _brandService.UpdateBrandAsync(editViewModel);
   
            Assert.IsTrue(result);

            var updatedBrand = await _dbContext.Brands.FindAsync(brand.BrandId);
            Assert.AreEqual("Updated Brand", updatedBrand.Name);
            Assert.AreEqual("Updated Address", updatedBrand.Address);
            Assert.AreEqual("Updated Country", updatedBrand.Country);
            Assert.AreEqual("987654321", updatedBrand.PhoneNumber);
            Assert.AreEqual("http://example.com/updated.jpg", updatedBrand.ImageUrl);
        }


        [Test]
        public async Task UpdateBrandAsync_ReturnsFalseIfBrandDoesNotExist()
        {           
            var model = new BrandEditViewModel
            {
                BrandId = Guid.NewGuid(),
                Name = "Nonexistent Brand"
            };
           
            var result = await _brandService.UpdateBrandAsync(model);
  
            Assert.IsFalse(result);
        }

        [Test]
        public async Task GetBrandDetailsAsync_ReturnsBrandDetailsIfExists()
        {           
            var brand = new Brand
            {
                Name = "Brand Details",
                IsDeleted = false,
                Address = "123 Street",
                PhoneNumber = "1234567890",
                ImageUrl = "image.jpg",
                Country = "Country"
            };
            _dbContext.Brands.Add(brand);
            await _dbContext.SaveChangesAsync();
           
            var result = await _brandService.GetBrandDetailsAsync(brand.BrandId.ToString());
  
            Assert.NotNull(result);
            Assert.AreEqual("Brand Details", result.Name);
        }

        [Test]
        public async Task GetBrandDetailsAsync_ReturnsNullIfBrandDoesNotExist()
        {           
            var result = await _brandService.GetBrandDetailsAsync(Guid.NewGuid().ToString());
 
            Assert.IsNull(result);
        }

        [Test]
        public async Task DeleteBrandAsync_SetsIsDeletedToTrueIfExists()
        {            
            var brand = new Brand
            {
                BrandId = Guid.NewGuid(),
                Name = "Test Brand",
                Address = "Test Address", 
                Country = "Test Country", 
                PhoneNumber = "123456789",
                ImageUrl = "http://example.com/image.jpg",
            };

            await _dbContext.Brands.AddAsync(brand);
            await _dbContext.SaveChangesAsync();

            var result = await _brandService.DeleteBrandAsync(brand.BrandId.ToString());
 
            var deletedBrand = await _dbContext.Brands.FindAsync(brand.BrandId);
            Assert.IsTrue(result); 
            Assert.IsTrue(deletedBrand.IsDeleted); 
        }


        [Test]
        public async Task DeleteBrandAsync_ReturnsFalseIfBrandDoesNotExist()
        {
            var result = await _brandService.DeleteBrandAsync(Guid.NewGuid().ToString());

            Assert.IsFalse(result);
        }
    }
}
