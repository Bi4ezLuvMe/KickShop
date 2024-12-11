using KickShop.Data;
using KickShop.Models;
using KickShop.Models.Enums;
using KickShop.Services;
using KickShop.ViewModels;
using KickShop.ViewModels.Cart;
using KickShop.ViewModels.Order;
using Microsoft.EntityFrameworkCore;
using Moq;

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
        public async Task GetCartViewModelAsyncWithValidUserIdReturnsCartViewModel()
        {
            string userId = "valid-user-id";
            Product product = new Product
            {
                ProductId = Guid.NewGuid(),
                Name = "Test Product",
                Price = 100,
                MainImageUrl = "test.jpg",
                Description ="ASDFFFFFFFFFFFFFFFFFFFF"
            };

            ShoppingCart cart = new ShoppingCart
            {
                ShoppingCartId = Guid.NewGuid(),
                CustomerId = userId
            };

            CartItem cartItem = new CartItem
            {
                CartItemId = Guid.NewGuid(),
                ProductId = product.ProductId,
                Quantity = 2,
                Size = "M",
                Product = product,
                ShoppingCart = cart
            };

            cart.CartItems = new List<CartItem> { cartItem };

            context.ShoppingCarts.Add(cart);
            context.Products.Add(product);
            await context.SaveChangesAsync();

            CartViewModel result = await cartService.GetCartViewModelAsync(userId);

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.CartItems.Count);
            Assert.AreEqual("Test Product", result.CartItems[0].ProductName);
            Assert.AreEqual(200, result.CartTotal);
        }

        [Test]
        public async Task GetCartViewModelAsyncWithEmptyCartReturnsEmptyCartViewModel()
        {
            string userId = "valid-user-id";

            ShoppingCart cart = new ShoppingCart
            {
                ShoppingCartId = Guid.NewGuid(),
                CustomerId = userId
            };

            context.ShoppingCarts.Add(cart);
            await context.SaveChangesAsync();

            CartViewModel result = await cartService.GetCartViewModelAsync(userId);

            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.CartItems.Count);
            Assert.AreEqual(0, result.CartTotal);
        }

        [Test]
        public async Task GetCartViewModelAsyncWithUserHasNoCartReturnsEmptyCartViewModel()
        {
            string userId = "valid-user-id";

            CartViewModel result = await cartService.GetCartViewModelAsync(userId);

            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.CartItems.Count);
            Assert.AreEqual(0, result.CartTotal);
        }

        [Test]
        public async Task GetCartViewModelAsyncWithInvalidUserIdReturnsEmptyCartViewModel()
        {
            string userId = "invalid-user-id";

            CartViewModel result = await cartService.GetCartViewModelAsync(userId);

            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.CartItems.Count);
            Assert.AreEqual(0, result.CartTotal);
        }

        [Test]
        public async Task AddToCartAsyncAddsItemToCart()
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
        public async Task RemoveFromCartAsyncRemovesItemFromCart()
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
        public async Task GetCheckoutSummaryAsyncReturnsCorrectSummary()
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
        public async Task PlaceOrderAsyncPlacesOrderAndClearsCart()
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
        [Test]
        public void AddToCartAsyncThrowsExceptionForInvalidProductId()
        {
            string userId = "test-user";
            string invalidProductId = "invalid-guid";

            Assert.ThrowsAsync<ArgumentException>(() =>
                cartService.AddToCartAsync(userId, invalidProductId, 1, "M"));
        }
        [Test]
        public async Task GetUserCartAsyncCreatesCartForInvalidUserId()
        {
            string userId = "nonexistent-user";

            ShoppingCart cart = await cartService.GetUserCartAsync(userId);

            Assert.IsNotNull(cart);
            Assert.AreEqual(userId, cart.CustomerId);
        }
        [Test]
        public async Task RemoveFromCartAsyncDoesNotThrowForEmptyCart()
        {
            string userId = "test-user";
            string productId = Guid.NewGuid().ToString();

            Assert.DoesNotThrowAsync(() =>
                cartService.RemoveFromCartAsync(userId, productId));
        }
        [Test]
        public void RemoveFromCartAsync_ShouldThrowArgumentException_WhenProductIdIsInvalid()
        {
            string userId = "test-user";
            string invalidProductId = "invalid-guid";

            Assert.ThrowsAsync<ArgumentException>(async () =>
                await cartService.RemoveFromCartAsync(userId, invalidProductId));
        }

        [Test]
        public void PlaceOrderAsyncThrowsExceptionForEmptyCart()
        {
            string userId = "test-user";

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

            Assert.ThrowsAsync<InvalidOperationException>(() =>
                cartService.PlaceOrderAsync(userId, checkoutModel));
        }
        [Test]
        public async Task PlaceOrderAsyncSavesCorrectOrderDetails()
        {
            string userId = "test-user";
            string productId = Guid.NewGuid().ToString();

            Product product = new Product
            {
                ProductId = Guid.Parse(productId),
                Name = "Test Product",
                Price = 100,
                Sizes = new List<ProductSize>
        {
            new ProductSize { ProductId = Guid.Parse(productId), Size = Sizes.M, Quantity = 1 }
        },Description = "test DESCRIPTIOOOn"
            };

            await context.Products.AddAsync(product);
            await context.SaveChangesAsync();

            await cartService.AddToCartAsync(userId, productId, 2, "M");

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

            Guid orderId = await cartService.PlaceOrderAsync(userId, checkoutModel);

            Order order = await context.Orders.FindAsync(orderId);
            Assert.IsNotNull(order);
            Assert.AreEqual(200, order.TotalAmount);
            Assert.AreEqual("Test User", order.BillingName);

            ShoppingCart cart = await context.ShoppingCarts.Include(c => c.CartItems)
                                   .FirstOrDefaultAsync(c => c.CustomerId == userId);

            Assert.AreEqual(0, cart.CartItems.Count);
        }
        [Test]
        public async Task GetCheckoutSummaryAsyncShouldThrowInvalidOperationExceptionWhenCartIsEmpty()
        {
            string userId = Guid.NewGuid().ToString();

            ShoppingCart emptyCart = new ShoppingCart
            {
                CustomerId = userId,
                CartItems = new List<CartItem>()
            };

            var ex = Assert.ThrowsAsync<InvalidOperationException>(async () =>
                await cartService.GetCheckoutSummaryAsync(userId));

            Assert.That(ex.Message, Is.EqualTo("Cart is empty!"));
        }
    }
}
