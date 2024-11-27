using KickShop.Models;
using KickShop.ViewModels;

namespace KickShop.Services.Service_Interfaces
{
    public interface IProductService
    {
        Task<Product> AddProductAsync(ProductAddViewModel model);
        Task<ProductEditViewModel?> GetProductForEditAsync(string id);
        Task<bool> UpdateProductAsync(ProductEditViewModel model);
        Task<List<Product>> GetAllProductsAsync(string? sortOrder,string? query);
        Task<ProductDetailsViewModel?> GetProductDetailsAsync(string id);
        Task<bool> DeleteProductAsync(string id);
        Task<Product?> GetProductByIdAsync(string id);
        Task<List<Product>> GetProductsByCategoryAsync(string category,string? sortOrder,string? query);
        Task<List<Product>> GetProductsByBrandAsync(string brand, string? sortOrder, string? query);
    }
}
