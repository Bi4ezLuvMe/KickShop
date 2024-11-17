using KickShop.Models;
using KickShop.ViewModels;
using System.Web.Mvc;

namespace KickShop.Services.Service_Interfaces
{
    public interface ICategoryService
    {
        Task<List<Category>> GetAllCategoriesAsync(string? query);
        Task AddCategoryAsync(CategoryAddViewModel category);
        Task<bool> UpdateCategoryAsync(CategoryEditViewModel category);
        Task<CategoryViewModel?> GetCategoryDetailsAsync(string id);
        Task<bool> DeleteCategoryAsync(Guid id);
        Task<CategoryEditViewModel?> GetCategoryForEditAsync(string id);
    }
}
