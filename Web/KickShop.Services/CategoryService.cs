using KickShop.Data;
using KickShop.Models;
using KickShop.Services.Service_Interfaces;
using KickShop.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.Web.Mvc;

namespace KickShop.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly KickShopDbContext context;

        public CategoryService(KickShopDbContext _context)
        {
            this.context = _context;
        }

        public async Task<List<Category>> GetAllCategoriesAsync()
        {
            return await context.Categories
                .Where(c=>!c.IsDeleted)
                .ToListAsync();
        }

        public async Task AddCategoryAsync(CategoryAddViewModel model)
        {
            Category category = new Category()
            {
                Name = model.Name,
                ImageUrl = model.ImageUrl,
            };

            await context.Categories.AddAsync(category);
            await context.SaveChangesAsync();
        }

        public async Task<bool> UpdateCategoryAsync(CategoryEditViewModel model)
        {
            Category? cateogry = await context.Categories.FindAsync(model.CategoryId);

            if (cateogry is null||cateogry.IsDeleted) 
            { 
                return false;
            }

            cateogry.Name = model.Name;
            cateogry.ImageUrl = model.ImageUrl;

            await context.SaveChangesAsync();
            return true;
        }

        public async Task<CategoryViewModel?> GetCategoryDetailsAsync(string id)
        {
            Guid? guidId = IsIdValid(id);

            if (guidId is null)
            {
                return null;
            }

            Category? category = await context.Categories
                .FirstOrDefaultAsync(c => c.CategoryId == guidId && !c.IsDeleted);

            if (category == null)
            {
                return null;
            }

            return new CategoryViewModel()
            {
                CategoryId = category.CategoryId,
                Name = category.Name,
                ImageUrl = category.ImageUrl,
            };
        }

        public async Task<bool> DeleteCategoryAsync(Guid id)
        {
            Category? category = await context.Categories.FindAsync(id);

            if (category is null || category.IsDeleted)
            {
                return false;
            }

            category.IsDeleted = true;
            await context.SaveChangesAsync();

            return true;
        }

        public async Task<CategoryEditViewModel?> GetCategoryForEditAsync(string id)
        {
            Guid? guidId = IsIdValid(id);

            if (guidId is null)
            {
                return null;
            }

            Category? category = await context.Categories.FindAsync(guidId);

            if (category is null || category.IsDeleted)
            {
                return null;
            }

            return new CategoryEditViewModel
            {
                CategoryId= category.CategoryId,
                Name = category.Name,
                ImageUrl = category.ImageUrl,
            };
        }

        private Guid? IsIdValid(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return null;
            }
            return Guid.TryParse(id, out var guidId) ? guidId : null;
        }
    }
}
