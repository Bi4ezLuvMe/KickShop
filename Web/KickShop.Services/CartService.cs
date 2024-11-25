using KickShop.Data;
using KickShop.Models;
using KickShop.Services.Service_Interfaces;
using KickShop.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace KickShop.Services
{
    public class CartService : ICartService
    {
        private readonly KickShopDbContext context;

        public CartService(KickShopDbContext context)
        {
            this.context = context;
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
