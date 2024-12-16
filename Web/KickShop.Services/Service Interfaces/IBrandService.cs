using KickShop.Models;
using KickShop.ViewModels;
using System.Web.Mvc;
using X.PagedList;

namespace KickShop.Services.Service_Interfaces
{
    public interface IBrandService
    {
        Task<IPagedList<Brand>> GetAllBrandsPaginatedAsync(string? query,int pageNumber,int pageSize);
        Task<List<Brand>> GetAllBrandsAsync();
        Task AddBrandAsync(BrandAddViewModel brand);
        Task<bool> UpdateBrandAsync(BrandEditViewModel brand);
        Task<BrandDetailsViewModel?> GetBrandDetailsAsync(string id);
        Task<BrandEditViewModel?> GetBrandForEditAsync(string id);
        Task<bool> DeleteBrandAsync(string id);
    }
}
