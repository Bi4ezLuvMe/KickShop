using KickShop.Data;
using KickShop.Models;
using KickShop.Services;
using KickShop.ViewModels.Cart;
using KickShop.ViewModels.Order;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KickShop.Tests.Services
{
    [TestFixture]
    public class CartServiceTests
    {
        private KickShopDbContext _dbContext;
        private CartService _cartService;

        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<KickShopDbContext>()
                .UseInMemoryDatabase("KickShopDb")
                .Options;
            _dbContext = new KickShopDbContext(options);
            _cartService = new CartService(_dbContext, null); // Replace with your actual UserManager<ApplicationUser> mock if needed
        }

        [TearDown]
        public async Task TearDown()
        {
            _dbContext.RemoveRange(_dbContext.Products);
            _dbContext.RemoveRange(_dbContext.ShoppingCarts);
            await _dbContext.SaveChangesAsync();
            await _dbContext.DisposeAsync(); // Dispose the context here
        }

        [Test]
        public async Task AddToCartAsync_AddsItemToCart()
        {
            var userId = "test-user";
            var productId = Guid.NewGuid().ToString();

            var product = new Product
            {
                ProductId = Guid.Parse(productId),
                Name = "Test Product",
                Price = 100,
                Description = "A test product description", // Set the missing Description
                MainImageUrl = "http://example.com/image.jpg",
                Sizes = new List<KickShop.Models.Enums.Sizes>
                {
                    KickShop.Models.Enums.Sizes.S,
                    KickShop.Models.Enums.Sizes.M,
                    KickShop.Models.Enums.Sizes.L
                }
            };

            await _dbContext.Products.AddAsync(product);
            await _dbContext.SaveChangesAsync();

            await _cartService.AddToCartAsync(userId, productId, 2, "M");

            var cart = await _dbContext.ShoppingCarts.Include(c => c.CartItems)
                             .FirstOrDefaultAsync(c => c.CustomerId == userId);

            Assert.IsNotNull(cart);
            Assert.AreEqual(1, cart.CartItems.Count);
            Assert.AreEqual(2, cart.CartItems.First().Quantity);
            Assert.That(cart.CartItems.First().Size, Is.EqualTo(KickShop.Models.Enums.Sizes.M.ToString())); // Use the enum here
        }

        [Test]
        public async Task RemoveFromCartAsync_RemovesItemFromCart()
        {
            var userId = "test-user";
            var productId = Guid.NewGuid().ToString();

            var product = new Product
            {
                ProductId = Guid.Parse(productId),
                Name = "Test Product",
                Price = 100,
                Description = "A test product description", // Set the missing Description
                MainImageUrl = "http://example.com/image.jpg",
                Sizes = new List<KickShop.Models.Enums.Sizes>
                {
                    KickShop.Models.Enums.Sizes.S,
                    KickShop.Models.Enums.Sizes.M,
                    KickShop.Models.Enums.Sizes.L
                }
            };

            await _dbContext.Products.AddAsync(product);
            await _dbContext.SaveChangesAsync();

            await _cartService.AddToCartAsync(userId, productId, 2, "M");

            var cart = await _dbContext.ShoppingCarts.Include(c => c.CartItems)
                             .FirstOrDefaultAsync(c => c.CustomerId == userId);

            Assert.IsNotNull(cart);
            Assert.AreEqual(1, cart.CartItems.Count);

            await _cartService.RemoveFromCartAsync(userId, productId);

            var updatedCart = await _dbContext.ShoppingCarts.Include(c => c.CartItems)
                               .FirstOrDefaultAsync(c => c.CustomerId == userId);

            Assert.AreEqual(0, updatedCart.CartItems.Count); // Item should be removed
        }

        [Test]
        public async Task GetCheckoutSummaryAsync_ReturnsCorrectSummary()
        {
            var userId = "test-user";
            var productId = Guid.NewGuid().ToString();

            var product = new Product
            {
                ProductId = Guid.Parse(productId),
                Name = "Test Product",
                Price = 100,
                Description = "A test product description",
                MainImageUrl = "http://example.com/image.jpg",
                Sizes = new List<KickShop.Models.Enums.Sizes>
        {
            KickShop.Models.Enums.Sizes.S,
            KickShop.Models.Enums.Sizes.M,
            KickShop.Models.Enums.Sizes.L
        }
            };

            await _dbContext.Products.AddAsync(product);
            await _dbContext.SaveChangesAsync();

            await _cartService.AddToCartAsync(userId, productId, 1, "M");
            await _cartService.AddToCartAsync(userId, productId, 1, "M");

            var cart = await _dbContext.ShoppingCarts.Include(c => c.CartItems)
                                     .FirstOrDefaultAsync(c => c.CustomerId == userId);

            Assert.IsNotNull(cart);
            Assert.AreEqual(2, cart.CartItems.Count);

            await _dbContext.SaveChangesAsync();

            var checkoutSummary = await _cartService.GetCheckoutSummaryAsync(userId);

            Assert.IsNotNull(checkoutSummary);
            Assert.AreEqual(2, checkoutSummary.ProductCount);
            Assert.AreEqual(200, checkoutSummary.TotalPrice);
        }



        [Test]
        public async Task PlaceOrderAsync_PlacesOrderAndClearsCart()
        {
            var userId = "test-user";
            var productId = Guid.NewGuid().ToString();

            var product = new Product
            {
                ProductId = Guid.Parse(productId),
                Name = "Test Product",
                Price = 100,
                Description = "A test product description", // Set the missing Description
                MainImageUrl = "http://example.com/image.jpg",
                Sizes = new List<KickShop.Models.Enums.Sizes>
                {
                    KickShop.Models.Enums.Sizes.S,
                    KickShop.Models.Enums.Sizes.M,
                    KickShop.Models.Enums.Sizes.L
                }
            };

            await _dbContext.Products.AddAsync(product);
            await _dbContext.SaveChangesAsync();

            await _cartService.AddToCartAsync(userId, productId, 2, "M");

            var cart = await _dbContext.ShoppingCarts.Include(c => c.CartItems)
                             .FirstOrDefaultAsync(c => c.CustomerId == userId);

            Assert.IsNotNull(cart);
            Assert.AreEqual(1, cart.CartItems.Count);

            var checkoutModel = new CheckoutViewModel
            {
                BillingAddress = new BillingAddressViewModel
                {
                    Address = "123 Test St",
                    City = "Test City",
                    FullName = "Test User",
                    ZipCode = "12345"
                }
            };

            await _cartService.PlaceOrderAsync(userId, checkoutModel);

            var order = await _dbContext.Orders.FirstOrDefaultAsync();
            Assert.IsNotNull(order);
            Assert.AreEqual(200, order.TotalAmount); // 2 * 100

            var updatedCart = await _dbContext.ShoppingCarts.Include(c => c.CartItems)
                               .FirstOrDefaultAsync(c => c.CustomerId == userId);

            Assert.AreEqual(0, updatedCart.CartItems.Count); // Cart should be empty after placing order
        }
    }
}
