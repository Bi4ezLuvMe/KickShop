using KickShop.Models;
using KickShop.ViewModels;
using X.PagedList;

namespace KickShop.Services.Service_Interfaces
{
    public interface IProductService
    {
        Task<Product> AddProductAsync(ProductAddViewModel model);
        Task<ProductEditViewModel?> GetProductForEditAsync(string id);
        Task<bool> UpdateProductAsync(ProductEditViewModel model);
        Task<IPagedList<Product>> GetAllProductsPaginatedAsync(string? sortOrder,string? query,int pageNumber,int pageSize);
        Task<List<Product>> GetAllProductsAsync();
        Task<ProductDetailsViewModel?> GetProductDetailsAsync(string id);
        Task<bool> DeleteProductAsync(string id);
        Task<Product?> GetProductByIdAsync(string id);
        Task<List<Product>> GetProductsByCategoryAsync(string category,string? sortOrder,string? query);
        Task<List<Product>> GetProductsByBrandAsync(string brand, string? sortOrder, string? query);
        Task<IPagedList<Product>> GetProductsByCategoryPaginatedAsync(string category, string? sortOrder, string? query,int pageNumber,int pageSize);
        Task<IPagedList<Product>> GetProductsByBrandPaginatedAsync(string brand, string? sortOrder, string? query,int pageNumber,int pageSize);
        Task<bool> RemoveImageAsync(string imageUrl, Guid productId);
    }
}
