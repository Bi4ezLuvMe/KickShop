using KickShop.Models;
using KickShop.ViewModels;
using System;
using System.Threading.Tasks;

namespace KickShop.Services.Service_Interfaces
{
    public interface ICartService
    {
        Task<CartViewModel> GetCartViewModelAsync(string userId);
        Task AddToCartAsync(string userId, string productId, int quantity, string selectedSize);
        Task RemoveFromCartAsync(string userId, string productId);
    }
}
