using KickShop.Models;
using KickShop.Services.Service_Interfaces;
using KickShop.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace KickShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,Manager")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService categoryService;

        public CategoryController(ICategoryService _categoryService)
        {
            this.categoryService = _categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            CategoryAddViewModel model = new CategoryAddViewModel();

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(CategoryAddViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await categoryService.AddCategoryAsync(model);
            return RedirectToAction("ManageCategories","Manage");
        }
        [HttpGet]
        public async Task<IActionResult> Manage(string query, int? page)
        {
            int pageSize = 5;
            int pageNumber = page ?? 1;
            IPagedList<Category> pagedCategories = await categoryService.GetAllCategoriesPagedAsync(query, pageNumber, pageSize);
            return View(pagedCategories);
        }
        [HttpGet]
        public async Task<IActionResult> Delete(string id)
        {
            CategoryViewModel? category = await categoryService.GetCategoryDetailsAsync(id);

            if (category == null)
            {
                return RedirectToAction("ManageCategories", "Manage");
            }

            return View(category);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(CategoryViewModel model)
        {
            await categoryService.DeleteCategoryAsync(model.CategoryId);
            return RedirectToAction("ManageCategories", "Manage");
        }

            [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            CategoryEditViewModel? model = await categoryService.GetCategoryForEditAsync(id);

            if (model == null)
            {
                return RedirectToAction("ManageCategories", "Manage");
            }

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(CategoryEditViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            bool updated = await categoryService.UpdateCategoryAsync(model);

            if (!updated)
            {
                return RedirectToAction("ManageCategories", "Manage");
            }

            return RedirectToAction("ManageCategories", "Manage");
        }
    }
}
