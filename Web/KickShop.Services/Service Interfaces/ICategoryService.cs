using KickShop.Models;
using System.Web.Mvc;

namespace KickShop.Services.Service_Interfaces
{
    public interface ICategoryService
    {
        Task<List<Category>> GetAllCategoriesAsync();
        Task<SelectList> GetCategorySelectListAsync();
        Task<Category?> GetCategoryByIdAsync(Guid id);
        Task<Category> AddCategoryAsync(Category category);
        Task<bool> UpdateCategoryAsync(Category category);
    }
}
