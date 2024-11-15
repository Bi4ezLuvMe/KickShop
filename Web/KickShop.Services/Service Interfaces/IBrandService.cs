using KickShop.Models;
using KickShop.ViewModels;
using System.Web.Mvc;

namespace KickShop.Services.Service_Interfaces
{
    public interface IBrandService
    {
        Task<List<Brand>> GetAllBrandsAsync();
        Task AddBrandAsync(BrandAddViewModel brand);
        Task<bool> UpdateBrandAsync(BrandEditViewModel brand);
        Task<BrandDetailsViewModel?> GetBrandDetailsAsync(string id);
        Task<BrandEditViewModel?> GetBrandForEditAsync(string id);
        Task<bool> DeleteBrandAsync(string id);
    }
}
