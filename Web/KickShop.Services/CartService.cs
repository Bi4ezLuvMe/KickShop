using KickShop.Data;
using KickShop.Models;
using KickShop.Services.Service_Interfaces;
using KickShop.ViewModels;
using KickShop.ViewModels.Cart;
using KickShop.ViewModels.Order;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace KickShop.Services
{
    public class CartService : ICartService
    {
        private readonly KickShopDbContext context;
        private readonly UserManager<ApplicationUser> userManager;

        public CartService(KickShopDbContext _context, UserManager<ApplicationUser> _userManager)
        {
            this.context = _context;
            this.userManager = _userManager;
        }

        public async Task<CartViewModel> GetCartViewModelAsync(string userId)
        {
            ShoppingCart cart = await GetUserCartAsync(userId);

            List<CartItemViewModel> cartItemsViewModel = cart.CartItems.Select(item => new CartItemViewModel
            {
                ProductId = item.ProductId,
                ProductName = item.Product.Name,
                Quantity = item.Quantity,
                Price = item.Product.Price,
                Size = item.Size,
                TotalPrice = item.Product.Price * item.Quantity,
                MainImageUrl = item.Product.MainImageUrl
            }).ToList();

            return new CartViewModel
            {
                CartItems = cartItemsViewModel,
                CartTotal = cartItemsViewModel.Sum(ci => ci.TotalPrice)
            };
        }

        public async Task AddToCartAsync(string userId, string productId, int quantity, string selectedSize)
        {
            Guid? productGuid = IsGuidValid(productId);
            if (productGuid == null)
            {
                throw new ArgumentException("Invalid product ID");
            }

            ShoppingCart cart = await GetUserCartAsync(userId);
            Product? product = await context.Products.AsNoTracking().FirstOrDefaultAsync(p => p.ProductId == productGuid);

            if (product == null)
            {
                throw new ArgumentException("Product not found");
            }

            CartItem? cartItem = cart.CartItems.FirstOrDefault(ci => ci.ProductId == productGuid);
            if (cartItem != null)
            {
                cartItem.Quantity += quantity;
            }
            else
            {
                CartItem newCartItem = new CartItem
                {
                    ProductId = productGuid.Value,
                    Quantity = quantity,
                    Size = selectedSize,
                    ShoppingCartId = cart.ShoppingCartId
                };
                cart.CartItems.Add(newCartItem);
                await context.CartsItems.AddAsync(newCartItem);
            }

            await context.SaveChangesAsync();
        }

        public async Task RemoveFromCartAsync(string userId, string productId)
        {
            Guid? productGuid = IsGuidValid(productId);
            if (productGuid == null)
            {
                throw new ArgumentException("Invalid product ID");
            }
            ShoppingCart cart = await GetUserCartAsync(userId);
            CartItem? cartItem = cart.CartItems.FirstOrDefault(ci => ci.ProductId == productGuid);

            if (cartItem != null)
            {
                context.CartsItems.Remove(cartItem);
                await context.SaveChangesAsync();
            }
        }

        public async Task<CheckoutSummaryViewModel> GetCheckoutSummaryAsync(string userId)
        {
            var cart = await GetUserCartAsync(userId);

            if (!cart.CartItems.Any())
                throw new InvalidOperationException("Cart is empty!");

            return new CheckoutSummaryViewModel
            {
                ProductCount = cart.CartItems.Count,
                TotalPrice = cart.CartItems.Sum(ci => ci.Quantity * ci.Product.Price),
                BillingAddress = new BillingAddressViewModel()
            };
        }

        public async Task PlaceOrderAsync(string userId, CheckoutViewModel model)
        {
            var cart = await GetUserCartAsync(userId);

            if (!cart.CartItems.Any())
                throw new InvalidOperationException("Cart is empty!");

            var order = new Order
            {
                TotalAmount = cart.CartItems.Sum(ci => ci.Quantity * ci.Product.Price),
                BillingAddress = model.BillingAddress.Address,
                BillingCity = model.BillingAddress.City,
                BillingName = model.BillingAddress.FullName,
                BillingPostalCode = model.BillingAddress.ZipCode,
            };

            await context.Orders.AddAsync(order);

            var customerOrder = new CustomerOrder
            {
                CustomerId = userId,
                OrderId = order.OrderId
            };

            await context.CustomersOrders.AddAsync(customerOrder);

            context.CartsItems.RemoveRange(cart.CartItems);
            await context.SaveChangesAsync();
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

        private Guid? IsGuidValid(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return null;
            }
            return Guid.TryParse(id, out var guid) ? guid : null;
        }
    }
}
