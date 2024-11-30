using KickShop.Data;
using KickShop.Models;
using KickShop.Services;
using KickShop.Services.Service_Interfaces;
using KickShop.ViewModels;
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
        private readonly IProductService productService;
        private readonly IOrderService orderService;
        private readonly UserManager<ApplicationUser> userManager;

        public CartController(ICartService cartService, UserManager<ApplicationUser> userManager,IOrderService orderService,IProductService productService)
        {
            this.cartService = cartService;
            this.userManager = userManager;
            this.orderService = orderService;
            this.productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var cartViewModel = await cartService.GetCartViewModelAsync(GetUserId());
            return View(cartViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> AddToCart(string productId, int quantity, string selectedSize)
        {
            if (string.IsNullOrEmpty(selectedSize))
            {
                TempData["SizeError"] = "Please Select A Size.";
            }

            if (!ModelState.IsValid || !string.IsNullOrEmpty(TempData["SizeError"]?.ToString()))
            {
                return RedirectToAction("Details", "Product", new { id = productId });
            }

            try
            {
                await cartService.AddToCartAsync(GetUserId(), productId, quantity, selectedSize);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction("Details", "Product", new { id = productId });
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RemoveFromCart(string id)
        {
            try
            {
                await cartService.RemoveFromCartAsync(GetUserId(), id);
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
            try
            {
                var checkoutViewModel = await cartService.GetCheckoutSummaryAsync(GetUserId());
                return View(checkoutViewModel);
            }
            catch (InvalidOperationException ex)
            {
                TempData["Message"] = ex.Message;
                return RedirectToAction("Index", "Cart");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PlaceOrder(CheckoutViewModel model)
        {
            if (!ModelState.IsValid)
                return View("Checkout", model);

            try
            {
                Guid orderId = await cartService.PlaceOrderAsync(GetUserId(), model);
                TempData["Message"] = "Order placed successfully!";
                return RedirectToAction("OrderConfirmation",new {orderId = orderId });
            }
            catch (InvalidOperationException ex)
            {
                TempData["Message"] = ex.Message;
                return RedirectToAction("Index", "Cart");
            }
        }
        [HttpGet]
        public async Task<IActionResult> OrderConfirmation(Guid orderId)
        {
            OrderConfirmationViewModel model = await orderService.GetOrderConfirmationAsync(orderId);
            return View(model);
        }
        private string GetUserId()
        {
            return userManager.GetUserId(User);
        }
    }
}
