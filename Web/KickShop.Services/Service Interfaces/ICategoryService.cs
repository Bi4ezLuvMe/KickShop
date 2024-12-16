using KickShop.Models;
using KickShop.ViewModels;
using System.Web.Mvc;
using X.PagedList;

namespace KickShop.Services.Service_Interfaces
{
    public interface ICategoryService
    {
        Task<IPagedList<Category>> GetAllCategoriesPagedAsync(string? query,int pageNumber,int pageSize);
        Task<List<Category>> GetAllCategoriesAsync();
        Task AddCategoryAsync(CategoryAddViewModel category);
        Task<bool> UpdateCategoryAsync(CategoryEditViewModel category);
        Task<CategoryViewModel?> GetCategoryDetailsAsync(string id);
        Task<bool> DeleteCategoryAsync(Guid id);
        Task<CategoryEditViewModel?> GetCategoryForEditAsync(string id);
    }
}
