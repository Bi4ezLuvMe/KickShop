using KickShop.Models.Enums;
using KickShop.Services.Service_Interfaces;
using KickShop.ViewModels.Product;
using KickShop.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;
using KickShop.Services;
using KickShop.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace KickShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,Manager")]
    public class ProductController : Controller
    {
        private readonly IProductService productService;
        private readonly ICategoryService categoryService;
        private readonly IBrandService brandService;
        public ProductController(IProductService _productService, ICategoryService _categoryService, IBrandService _brandService)
        {
            this.productService = _productService;
            this.categoryService = _categoryService;
            this.brandService = _brandService;
        }
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            ProductAddViewModel model = new ProductAddViewModel();
            await PopulateDropdowns();
            model.Sizes = Enum.GetNames(typeof(Sizes))
                    .Select(size => new ProductSizeViewModel { Size = size })
                    .ToList();
            return View(model);
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> Add(ProductAddViewModel model)
        {
            if (!ModelState.IsValid)
            {
                await PopulateDropdowns();
                return View(model);
            }

            await productService.AddProductAsync(model);
            return RedirectToAction("ManageProducts","Manage");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            ProductEditViewModel? model = await productService.GetProductForEditAsync(id);

            if (model == null)
            {
                return RedirectToAction("ManageProducts", "Manage");
            }

            await PopulateDropdowns();
            return View(model);
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> Edit(ProductEditViewModel model)
        {
            if (!ModelState.IsValid)
            {
                await PopulateDropdowns();
                return View(model);
            }

            bool updated = await productService.UpdateProductAsync(model);

            if (!updated)
            {
                return RedirectToAction("ManageProducts", "Manage");
            }

            return RedirectToAction("ManageProducts","Manage");
        }
        [HttpGet]
        public async Task<IActionResult> Delete(string id)
        {
            Product? product = await productService.GetProductByIdAsync(id);

            if (product == null)
            {
                return RedirectToAction("ManageProducts", "Manage");
            }

            return View(product);
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> DeleteConfirmed(Product product)
        {
            await productService.DeleteProductAsync(product.ProductId.ToString());
            return RedirectToAction("ManageProducts", "Manage");
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> RemoveImage(string imageUrl, Guid productId)
        {
            if (!await productService.RemoveImageAsync(imageUrl, productId))
            {
                return RedirectToAction("Edit", new { id = productId });
            }

            return RedirectToAction("Edit", new { id = productId });
        }
        private async Task PopulateDropdowns()
        {
            ViewBag.Categories = new SelectList(await categoryService.GetAllCategoriesAsync(), "CategoryId", "Name");
            ViewBag.Brands = new SelectList(await brandService.GetAllBrandsAsync(), "BrandId", "Name");
            ViewBag.Sizes = Enum.GetNames(typeof(Sizes)).ToList();
        }
    }
}
