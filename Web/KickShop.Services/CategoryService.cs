using KickShop.Data;
using KickShop.Models;
using KickShop.Services.Service_Interfaces;
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
            return await context.Categories.ToListAsync();
        }

        public async Task<SelectList> GetCategorySelectListAsync()
        {
            List<Category> categories = await GetAllCategoriesAsync();
            return new SelectList(categories, "CategoryId", "Name");
        }

        public async Task<Category?> GetCategoryByIdAsync(Guid id)
        {
            return await context.Categories.FindAsync(id);
        }

        public async Task<Category> AddCategoryAsync(Category category)
        {
            await context.Categories.AddAsync(category);
            await context.SaveChangesAsync();
            return category;
        }

        public async Task<bool> UpdateCategoryAsync(Category category)
        {
            context.Categories.Update(category);
            return await context.SaveChangesAsync() > 0;
        }
    }
}
