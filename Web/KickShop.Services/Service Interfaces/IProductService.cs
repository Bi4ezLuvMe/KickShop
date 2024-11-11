using KickShop.Models;
using KickShop.ViewModels;

namespace KickShop.Services.Service_Interfaces
{
    public interface IProductService
    {
        Task AddProductAsync(ProductAddViewModel model);
        Task<ProductEditViewModel?> GetProductForEditAsync(string id);
        Task<bool> UpdateProductAsync(ProductEditViewModel model);
        Task<List<Product>> GetAllProductsAsync(string sortOrder);
        Task<List<Product>> GetAllProductsAsync(string sortOrder,string categoryName);
        Task<ProductDetailsViewModel?> GetProductDetailsAsync(string id);
        Task<bool> DeleteProductAsync(string id);
    }
}
