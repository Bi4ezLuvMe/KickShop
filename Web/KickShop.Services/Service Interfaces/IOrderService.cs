using KickShop.ViewModels;
using X.PagedList;

namespace KickShop.Services.Service_Interfaces
{
    public interface IOrderService
    {
        Task<IPagedList<OrderViewModel>> GetAllOrdersAsync(int pageSize,int pageNumber);
        Task<List<OrderViewModel>> GetAllOrdersAsync();
        Task<OrderConfirmationViewModel> GetOrderConfirmationAsync(Guid orderId);
        Task DeleteOrderAsync(Guid id);
    }
}
