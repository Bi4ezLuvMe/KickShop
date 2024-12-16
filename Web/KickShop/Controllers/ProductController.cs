using KickShop.Models.Enums;
using KickShop.ViewModels;
using KickShop.Services.Service_Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using KickShop.Models;
using Microsoft.AspNetCore.Authorization;
using System.Drawing;
using KickShop.ViewModels.Product;
using Microsoft.EntityFrameworkCore;
using KickShop.Data;
using KickShop.Services;
using X.PagedList.Extensions;
using X.PagedList;

namespace KickShop.Controllers
{
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
        [Authorize(Roles = "Admin,Manager")]
        public async Task<IActionResult> Add()
        {
            ProductAddViewModel model = new ProductAddViewModel();
            await PopulateDropdowns();
            model.Sizes = Enum.GetNames(typeof(Sizes))
                    .Select(size => new ProductSizeViewModel { Size = size })
                    .ToList();
            return View(model);
        }

        [HttpPost]
        [Authorize(Roles = "Admin,Manager")]
        public async Task<IActionResult> Add(ProductAddViewModel model)
        {
            if (!ModelState.IsValid)
            {
                await PopulateDropdowns();
                return View(model);
            }

            await productService.AddProductAsync(model);
            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        [Authorize(Roles = "Admin,Manager")]
        public async Task<IActionResult> Edit(string id)
        {
            ProductEditViewModel? model = await productService.GetProductForEditAsync(id);

            if (model == null)
            {
                return RedirectToAction(nameof(All));
            }

            await PopulateDropdowns();
            return View(model);
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        [Authorize(Roles = "Admin,Manager")]
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
                return RedirectToAction(nameof(All));
            }

            return RedirectToAction(nameof(Details), new { id = model.ProductId });
        }

        [HttpGet]
        public async Task<IActionResult> All(string sortOrder,string query,int? page)
        {
            int pageSize = 6;
            int pageNumber = page ?? 1;
            IPagedList<Product> products = await productService.GetAllProductsPaginatedAsync(sortOrder,query,pageNumber,pageSize);
            ViewBag.Action = nameof(All);
            ViewBag.Query = query;
            return View(products);
        }
        [HttpGet]
        public async Task<IActionResult>ByCategory(string category,string sortOrder,string query, int? page)
        {
            int pageSize = 2;
            int pageNumber = page ?? 1;
            IPagedList<Product> productsByCategory = await productService.GetProductsByCategoryPaginatedAsync(category,sortOrder,query, pageNumber, pageSize);
            ViewBag.Action= category;
            ViewBag.Query = query;
            return View(productsByCategory);
        }
        [HttpGet]
        public async Task<IActionResult> ByBrand(string brand, string sortOrder, string query, int? page)
        {
            int pageSize = 1;
            int pageNumber = page ?? 1;
            IPagedList<Product> productsByBrand = await productService.GetProductsByBrandPaginatedAsync(brand, sortOrder,query, pageNumber, pageSize);
            ViewBag.Action = brand;
            ViewBag.Query = query;
            return View(productsByBrand);
        }
        [HttpGet]
        public async Task<IActionResult> Details(string id)
        {
            ProductDetailsViewModel? product = await productService.GetProductDetailsAsync(id);

            if (product == null)
            {
                return RedirectToAction(nameof(All));
            }

            if (TempData.ContainsKey("SizeError"))
            {
                ModelState.AddModelError("SelectedSize", TempData["SizeError"].ToString());
            }

            return View(product);
        }

        [HttpGet]
        [Authorize(Roles = "Admin,Manager")]
        public async Task<IActionResult> Manage(string query,int? page)
        {
            int pageSize = 10;
            int pageNumber = page ?? 1;
            IPagedList<Product> products = await productService.GetAllProductsPaginatedAsync(null,query,pageNumber,pageSize);
            ViewBag.Query = query;
            return View(products);
        }

        [HttpGet]
        [Authorize(Roles = "Admin,Manager")]
        public async Task<IActionResult> Delete(string id)
        {
            Product? product = await productService.GetProductByIdAsync(id);

            if (product == null)
            {
                return RedirectToAction(nameof(Manage));
            }

            return View(product);
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        [Authorize(Roles = "Admin,Manager")]
        public async Task<IActionResult> DeleteConfirmed(Product product)
        {
            await productService.DeleteProductAsync(product.ProductId.ToString());
            return RedirectToAction(nameof(Manage));
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        [Authorize(Roles = "Admin,Manager")]
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