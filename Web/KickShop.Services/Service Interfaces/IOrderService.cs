using KickShop.ViewModels;

namespace KickShop.Services.Service_Interfaces
{
    public interface IOrderService
    {
        Task<IEnumerable<OrderViewModel>> GetAllOrdersAsync();
        Task<OrderConfirmationViewModel> GetOrderConfirmationAsync(Guid orderId);
        Task DeleteOrderAsync(Guid id);
    }
}
