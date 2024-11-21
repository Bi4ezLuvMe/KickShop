using KickShop.Services.Service_Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace KickShop.Controllers
{
    public class CartController : Controller
    {
        private readonly ICartService cartService;
        private readonly UserManager<ApplicationUser> userManager;

        public CartController(ICartService cartService, UserManager<ApplicationUser> userManager)
        {
            this.cartService = cartService;
            this.userManager = userManager;
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
    }
}
