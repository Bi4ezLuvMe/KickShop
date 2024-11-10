using KickShop.Models.Enums;
using KickShop.ViewModels;
using KickShop.Services.Service_Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using KickShop.Models;

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
        public async Task<IActionResult> Add()
        {
            ProductAddViewModel model = new ProductAddViewModel();
            await PopulateDropdowns();
            return View(model);
        }

        [HttpPost]
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
                return RedirectToAction(nameof(All));
            }

            return RedirectToAction(nameof(Details), new { id = model.ProductId });
        }

        [HttpGet]
        public async Task<IActionResult> All(string sortOrder)
        {
            List<Product> products = await productService.GetAllProductsAsync(sortOrder);
            ViewBag.Action = nameof(All);
            return View(products);
        }

        [HttpGet]
        public async Task<IActionResult> Clothing(string sortOrder)
        {
            List<Product> products = await productService.GetAllProductsAsync(sortOrder, "Apparel");
            ViewBag.Action = nameof(Clothing);
            return View(nameof(All), products);
        }

        [HttpGet]
        public async Task<IActionResult> Gloves(string sortOrder)
        {
            List<Product> products = await productService.GetAllProductsAsync(sortOrder, "Gloves");
            ViewBag.Action = nameof(Gloves);
            return View(nameof(All), products);
        }

        [HttpGet]
        public async Task<IActionResult> ProtectiveGear(string sortOrder)
        {
            List<Product> products = await productService.GetAllProductsAsync(sortOrder, "Protective Gear");
            ViewBag.Action = nameof(ProtectiveGear);
            return View(nameof(All), products);
        }

        [HttpGet]
        public async Task<IActionResult> Details(string id)
        {
            ProductDetailsViewModel? product = await productService.GetProductDetailsAsync(id);

            if (product == null)
            {
                return RedirectToAction(nameof(All));
            }

            return View(product);
        }

        [HttpGet]
        public async Task<IActionResult> Manage()
        {
            List<Product> products = await productService.GetAllProductsAsync(null);
            return View(products);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(string id)
        {
            ProductDetailsViewModel? product = await productService.GetProductDetailsAsync(id);

            if (product == null)
            {
                return RedirectToAction(nameof(Manage));
            }

            return View(product);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            await productService.DeleteProductAsync(id);
            return RedirectToAction(nameof(Manage));
        }

        private async Task PopulateDropdowns()
        {
            ViewBag.Categories = new SelectList(await categoryService.GetAllCategoriesAsync(), "CategoryId", "Name");
            ViewBag.Brands = new SelectList(await brandService.GetAllBrandsAsync(), "BrandId", "Name");
            ViewBag.Sizes = Enum.GetNames(typeof(Sizes)).ToList();
        }
    }
}