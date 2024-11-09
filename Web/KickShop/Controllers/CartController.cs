using KickShop.Data;
using KickShop.Models;
using KickShop.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KickShop.Controllers
{
    public class CartController : Controller
    {
        private readonly KickShopDbContext context;
        private readonly UserManager<ApplicationUser> userManager;
        public CartController(KickShopDbContext _context,UserManager<ApplicationUser>_userManager)
        {
            this.context = _context;
            this.userManager = _userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var cart = await GetUserCart();  

            var cartItemsViewModel = cart.CartItems.Select(item => new CartItemViewModel()
            {
                ProductId = item.ProductId,
                ProductName = item.Product.Name,
                Quantity = item.Quantity,
                Price = item.Product.Price,
                TotalPrice = item.Product.Price * item.Quantity,
                ImageUrl = item.Product.ImageUrl
            }).ToList();

            var cartViewModel = new CartViewModel
            {
                CartItems = cartItemsViewModel,
                CartTotal = cartItemsViewModel.Sum(ci => ci.TotalPrice)
            };

            return View(cartViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> AddToCart(string productId, int quantity)
        {
            Guid? productGuid = IsIdValid(productId);

            if(productGuid is null)
            {
                return RedirectToAction(nameof(Index));
            }
            var cart = await GetUserCart();
            var product = await context.Products.FirstOrDefaultAsync(p => p.ProductId == productGuid);

            if (product == null)
            {
                return NotFound("Product not found");
            }

            var cartItem = cart.CartItems.FirstOrDefault(ci => ci.ProductId == productGuid);

            if (cartItem != null)
            {
                cartItem.Quantity += quantity;
            }
            else
            {
                var newCartItem = new CartItem()
                {
                    ProductId = (Guid)productGuid,
                    Quantity = quantity,
                    ShoppingCartId = cart.ShoppingCartId
                };

                cart.CartItems.Add(newCartItem);

                await context.CartsItems.AddAsync(newCartItem);
            }

            await context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        public async Task<IActionResult>RemoveFromCart(string id)
        {
            Guid? guidId = IsIdValid(id);

            if (guidId is null) 
            {
                return RedirectToAction(nameof(Index));
            }

            ShoppingCart? cart = await GetUserCart();
            CartItem? cartItem = cart.CartItems.FirstOrDefault(ci => ci.ProductId == guidId);

            if (cartItem is null)
            {
                return RedirectToAction(nameof(Index));
            }

            context.CartsItems.Remove(cartItem);
            await context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        private async Task<ShoppingCart> GetUserCart()
        {
            var userId = userManager.GetUserId(User); 

            var cart = await context.ShoppingCarts.Include(c => c.CartItems)
                                      .ThenInclude(ci => ci.Product)
                                      .FirstOrDefaultAsync(c => c.CustomerId == userId);

            if (cart is null)
            {
                cart = new ShoppingCart()
                { 
                    CustomerId = userId 
                };

                 await context.ShoppingCarts.AddAsync(cart);
                 await context.SaveChangesAsync();
            }

            return cart;
        }
        private Guid? IsIdValid(string id)
        {
            if (String.IsNullOrEmpty(id))
            {
                return null;
            }

            Guid guidId;

            if(!Guid.TryParse(id,out guidId))
            {
                return null;
            }

            return guidId;
        }
    }
}
