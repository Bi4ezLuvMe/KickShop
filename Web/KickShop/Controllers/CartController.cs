using KickShop.Data;
using KickShop.Models;
using KickShop.Services.Service_Interfaces;
using KickShop.ViewModels.Cart;
using KickShop.ViewModels.Order;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace KickShop.Controllers
{
    public class CartController : Controller
    {
        private readonly ICartService cartService;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly KickShopDbContext context;

        public CartController(ICartService cartService, UserManager<ApplicationUser> userManager,KickShopDbContext _context)
        {
            this.cartService = cartService;
            this.userManager = userManager;
            this.context = _context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var userId = userManager.GetUserId(User);
            var cartViewModel = await cartService.GetCartViewModelAsync(userId);
            return View(cartViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> AddToCart(string productId, int quantity, string selectedSize)
        {
            var userId = userManager.GetUserId(User);

            try
            {
                await cartService.AddToCartAsync(userId, productId, quantity, selectedSize);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View("~/Views/Product/Details.cshtml");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RemoveFromCart(string id)
        {
            var userId = userManager.GetUserId(User);

            try
            {
                await cartService.RemoveFromCartAsync(userId, id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction(nameof(Index));
            }
        }
        [HttpGet]
        public async Task<IActionResult> Checkout()
        {
            var userId = userManager.GetUserId(User);

            var cart = await GetUserCartAsync(userId);

            if (cart.CartItems.Count == 0)
            {
                TempData["Message"] = "Your cart is empty!";
                return RedirectToAction("Index", "Cart");
            }

            var checkoutViewModel = new CheckoutSummaryViewModel
            {
                ProductCount = cart.CartItems.Count,
                TotalPrice = cart.CartItems.Sum(ci => ci.Quantity * ci.Product.Price),
                BillingAddress = new BillingAddressViewModel()
            };

            return View(checkoutViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PlaceOrder(CheckoutViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("Checkout", model);
            }

            var userId = userManager.GetUserId(User);

            var cart = await GetUserCartAsync(userId);

            if (cart.CartItems.Count == 0)
            {
                TempData["Message"] = "Your cart is empty!";
                return RedirectToAction("Index", "Cart");
            }

            // Create Order
            var order = new Order
            {
                TotalAmount = cart.CartItems.Sum(ci => ci.Quantity * ci.Product.Price),
                BillingAddress = model.BillingAddress.Address,
                BillingCity = model.BillingAddress.City,
                BillingName = model.BillingAddress.FullName,
                BillingPostalCode = model.BillingAddress.ZipCode,
            };

            await context.Orders.AddAsync(order);

            // Link Order to Customer
            var customerOrder = new CustomerOrder
            {
                CustomerId = userId,
                OrderId = order.OrderId
            };

            await context.CustomersOrders.AddAsync(customerOrder);

            // Clear Cart
            context.CartsItems.RemoveRange(cart.CartItems);
            await context.SaveChangesAsync();

            TempData["Message"] = "Order placed successfully!";
            return RedirectToAction("OrderConfirmation", new { orderId = order.OrderId });
        }

        [HttpGet]
        public async Task<IActionResult> OrderConfirmation(Guid orderId)
        {
            var order = await context.Orders.FindAsync(orderId);

            if (order == null)
            {
                return NotFound("Order not found!");
            }

            var model = new OrderConfirmationViewModel
            {
                OrderId = order.OrderId,
                OrderDate = order.OrderDate,
                TotalAmount = order.TotalAmount
            };

            return View(model);
        }
        private async Task<ShoppingCart> GetUserCartAsync(string userId)
        {
            ShoppingCart? cart = await context.ShoppingCarts.Include(c => c.CartItems)
                              .ThenInclude(ci => ci.Product)
                              .FirstOrDefaultAsync(c => c.CustomerId == userId);

            if (cart == null)
            {
                cart = new ShoppingCart { CustomerId = userId };
                await context.ShoppingCarts.AddAsync(cart);
                await context.SaveChangesAsync();
            }

            return cart;
        }
    }
}
