using KickShop.Data;
using KickShop.Models;
using KickShop.Services.Service_Interfaces;
using KickShop.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.Web.Mvc;
using X.PagedList;
using X.PagedList.Extensions;

namespace KickShop.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly KickShopDbContext context;

        public CategoryService(KickShopDbContext _context)
        {
            this.context = _context;
        }

        public async Task<IPagedList<Category>> GetAllCategoriesPagedAsync(string? query,int pageNumber,int pageSize)
        {
            List<Category> categories = await context.Categories
                .AsNoTracking()
                .Where(c => !c.IsDeleted)
                .ToListAsync();

            categories = QuerySearch(categories, query);

            IPagedList<Category> pagedCategories = categories.ToPagedList(pageNumber,pageSize);

            return pagedCategories;
        }
        public async Task<List<Category>> GetAllCategoriesAsync()
        {
            return await context.Categories.Where(c => !c.IsDeleted).ToListAsync();
        }

        public async Task AddCategoryAsync(CategoryAddViewModel model)
        {
            Category category = new Category()
            {
                Name = model.Name,
            };
            if (model.Image != null && model.Image.Length > 0)
            {
                string fileName = Guid.NewGuid() + Path.GetExtension(model.Image.FileName);
                string filePath = Path.Combine("wwwroot/images/Categories", fileName);

                Directory.CreateDirectory(Path.GetDirectoryName(filePath));

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await model.Image.CopyToAsync(stream);
                }

                category.ImageUrl = "/images/Categories/" + fileName;
            }
            await context.Categories.AddAsync(category);
            await context.SaveChangesAsync();
        }

        public async Task<bool> UpdateCategoryAsync(CategoryEditViewModel model)
        {
            Category? category = await context.Categories.FindAsync(model.CategoryId);

            if (category is null||category.IsDeleted) 
            { 
                return false;
            }

            category.Name = model.Name;
            if (model.Image != null && model.Image.Length > 0)
            {
                if (!string.IsNullOrEmpty(category.ImageUrl))
                {
                    string oldFilePath = Path.Combine("wwwroot", category.ImageUrl.TrimStart('/'));
                    if (File.Exists(oldFilePath))
                    {
                        File.Delete(oldFilePath);
                    }
                }

                string fileName = Guid.NewGuid() + Path.GetExtension(model.Image.FileName);
                string filePath = Path.Combine("wwwroot/images/Categories", fileName);

                Directory.CreateDirectory(Path.GetDirectoryName(filePath));

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await model.Image.CopyToAsync(stream);
                }

                category.ImageUrl = "/images/Categories/" + fileName;
            }

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
                .AsNoTracking()
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

            Category? category = await context.Categories.FirstOrDefaultAsync(c=>c.CategoryId==guidId);

            if (category is null || category.IsDeleted)
            {
                return null;
            }

            return new CategoryEditViewModel
            {
                CategoryId= category.CategoryId,
                Name = category.Name,
            };
        }

        public Guid? IsIdValid(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return null;
            }
            return Guid.TryParse(id, out var guidId) ? guidId : null;
        }
        private List<Category> QuerySearch(List<Category> categoryModels, string? query)
        {
            if (query is null)
            {
                return categoryModels;
            }
            return categoryModels.Where(p => p.Name.ToLower().Contains(query.ToLower())).ToList();
        }

    }
}
