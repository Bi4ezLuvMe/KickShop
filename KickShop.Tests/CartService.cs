using KickShop.Data;
using KickShop.Models;
using KickShop.Models.Enums;
using KickShop.Services;
using KickShop.ViewModels.Cart;
using KickShop.ViewModels.Order;
using Microsoft.EntityFrameworkCore;

namespace KickShop.Tests.Services
{
    [TestFixture]
    public class CartServiceTests
    {
        private KickShopDbContext context;
        private CartService cartService;

        [SetUp]
        public void Setup()
        {
            DbContextOptions<KickShopDbContext> options = new DbContextOptionsBuilder<KickShopDbContext>()
                .UseInMemoryDatabase("KickShopDb")
                .Options;

            context = new KickShopDbContext(options);
            cartService = new CartService(context, null);
        }

        [TearDown]
        public async Task TearDown()
        {
            context.RemoveRange(context.Products);
            context.RemoveRange(context.ShoppingCarts);
            await context.SaveChangesAsync();
            await context.DisposeAsync();
        }

        [Test]
        public async Task AddToCartAsync_AddsItemToCart()
        {
            string userId = "test-user";
            string productId = Guid.NewGuid().ToString();

            List<ProductSize> productSizes = new List<ProductSize>()
            {

            };   

            Product product = new Product
            {
                ProductId = Guid.Parse(productId),
                Name = "Test Product",
                Price = 100,
                Description = "A test product description",
                MainImageUrl = "http://example.com/image.jpg",
                Sizes =new List<ProductSize>()
                {
                    new ProductSize()
                    {
                        ProductId = Guid.Parse(productId),
                        Size = Sizes.M,
                        Quantity =1
                    }
                }
            };

            await context.Products.AddAsync(product);
            await context.SaveChangesAsync();

            await cartService.AddToCartAsync(userId, productId, 2, "M");

            ShoppingCart cart = await context.ShoppingCarts.Include(c => c.CartItems)
                                    .FirstOrDefaultAsync(c => c.CustomerId == userId);

            Assert.IsNotNull(cart);
            Assert.AreEqual(1, cart.CartItems.Count);
            Assert.AreEqual(2, cart.CartItems.First().Quantity);
            Assert.That(cart.CartItems.First().Size, Is.EqualTo(KickShop.Models.Enums.Sizes.M.ToString()));
        }

        [Test]
        public async Task RemoveFromCartAsync_RemovesItemFromCart()
        {
            string userId = "test-user";
            string productId = Guid.NewGuid().ToString();

            Product product = new Product
            {
                ProductId = Guid.Parse(productId),
                Name = "Test Product",
                Price = 100,
                Description = "A test product description",
                MainImageUrl = "http://example.com/image.jpg",
                Sizes = new List<ProductSize>()
                {
                    new ProductSize()
                    {
                        ProductId = Guid.Parse(productId),
                        Size = Sizes.M,
                        Quantity =1
                    }
                }
            };

            await context.Products.AddAsync(product);
            await context.SaveChangesAsync();

            await cartService.AddToCartAsync(userId, productId, 2, "M");

            ShoppingCart cart = await context.ShoppingCarts.Include(c => c.CartItems)
                                    .FirstOrDefaultAsync(c => c.CustomerId == userId);

            Assert.IsNotNull(cart);
            Assert.AreEqual(1, cart.CartItems.Count);

            await cartService.RemoveFromCartAsync(userId, productId);

            ShoppingCart updatedCart = await context.ShoppingCarts.Include(c => c.CartItems)
                                             .FirstOrDefaultAsync(c => c.CustomerId == userId);

            Assert.AreEqual(0, updatedCart.CartItems.Count);
        }

        [Test]
        public async Task GetCheckoutSummaryAsync_ReturnsCorrectSummary()
        {
            string userId = "test-user";
            string productId = Guid.NewGuid().ToString();

            Product product = new Product
            {
                ProductId = Guid.Parse(productId),
                Name = "Test Product",
                Price = 100,
                Description = "A test product description",
                MainImageUrl = "http://example.com/image.jpg",
                Sizes = new List<ProductSize>()
                {
                    new ProductSize()
                    {
                        ProductId = Guid.Parse(productId),
                        Size = Sizes.M,
                        Quantity =1
                    }
                }
            };

            await context.Products.AddAsync(product);
            await context.SaveChangesAsync();

            await cartService.AddToCartAsync(userId, productId, 1, "M");
            await cartService.AddToCartAsync(userId, productId, 1, "M");

            ShoppingCart cart = await context.ShoppingCarts.Include(c => c.CartItems)
                                    .FirstOrDefaultAsync(c => c.CustomerId == userId);

            Assert.IsNotNull(cart);
            Assert.AreEqual(2, cart.CartItems.First().Quantity);

            await context.SaveChangesAsync();

            CheckoutSummaryViewModel checkoutSummary = await cartService.GetCheckoutSummaryAsync(userId);

            Assert.IsNotNull(checkoutSummary);
            Assert.AreEqual(1, checkoutSummary.ProductCount);
            Assert.AreEqual(200, checkoutSummary.TotalPrice);
        }

        [Test]
        public async Task PlaceOrderAsync_PlacesOrderAndClearsCart()
        {
            string userId = "test-user";
            string productId = Guid.NewGuid().ToString();

            Product product = new Product
            {
                ProductId = Guid.Parse(productId),
                Name = "Test Product",
                Price = 100,
                Description = "A test product description",
                MainImageUrl = "http://example.com/image.jpg",
                Sizes = new List<ProductSize>()
                {
                    new ProductSize()
                    {
                        ProductId = Guid.Parse(productId),
                        Size = Sizes.M,
                        Quantity =1
                    }
                }
            };

            await context.Products.AddAsync(product);
            await context.SaveChangesAsync();

            await cartService.AddToCartAsync(userId, productId, 2, "M");

            ShoppingCart cart = await context.ShoppingCarts.Include(c => c.CartItems)
                                    .FirstOrDefaultAsync(c => c.CustomerId == userId);

            Assert.IsNotNull(cart);
            Assert.AreEqual(1, cart.CartItems.Count);

            CheckoutViewModel checkoutModel = new CheckoutViewModel
            {
                BillingAddress = new BillingAddressViewModel
                {
                    Address = "123 Test St",
                    City = "Test City",
                    FullName = "Test User",
                    ZipCode = "12345"
                }
            };

            await cartService.PlaceOrderAsync(userId, checkoutModel);

            Order order = await context.Orders.FirstOrDefaultAsync();
            Assert.IsNotNull(order);
            Assert.AreEqual(200, order.TotalAmount);

            ShoppingCart updatedCart = await context.ShoppingCarts.Include(c => c.CartItems)
                                             .FirstOrDefaultAsync(c => c.CustomerId == userId);

            Assert.AreEqual(0, updatedCart.CartItems.Count);
        }
    }
}
