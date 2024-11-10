using KickShop.Models;
using System.Web.Mvc;

namespace KickShop.Services.Service_Interfaces
{
    public interface IBrandService
    {
        Task<List<Brand>> GetAllBrandsAsync();
        Task<SelectList> GetBrandSelectListAsync();
        Task<Brand?> GetBrandByIdAsync(Guid id);
        Task<Brand> AddBrandAsync(Brand brand);
        Task<bool> UpdateBrandAsync(Brand brand);
    }
}
