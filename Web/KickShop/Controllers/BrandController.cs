using KickShop.Models;
using KickShop.Services;
using KickShop.Services.Service_Interfaces;
using KickShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace KickShop.Controllers
{
    public class BrandController : Controller
    {
        private readonly IProductService productService;
        private readonly ICategoryService categoryService;
        private readonly IBrandService brandService;

        public BrandController(IProductService _productService, ICategoryService _categoryService, IBrandService _brandService)
        {
            this.productService = _productService;
            this.categoryService = _categoryService;
            this.brandService = _brandService;
        }

        [HttpGet]
        public async Task<IActionResult> Manage()
        {
            List<Brand> brands = await brandService.GetAllBrandsAsync();
            return View(brands);
        }
        //[HttpGet]
        //public async Task<IActionResult> Delete(string id)
        //{
        //    ProductDetailsViewModel? product = await productService.GetProductDetailsAsync(id);

        //    if (product == null)
        //    {
        //        return RedirectToAction(nameof(Manage));
        //    }

        //    return View(product);
        //}

        //[HttpGet]
        //public async Task<IActionResult> Details(string id)
        //{
        //    ProductDetailsViewModel? product = await productService.GetProductDetailsAsync(id);

        //    if (product == null)
        //    {
        //        return RedirectToAction(nameof(All));
        //    }

        //    return View(product);
        //}
        //[HttpPost]
        //public async Task<IActionResult> DeleteConfirmed(string id)
        //{
        //    await productService.DeleteProductAsync(id);
        //    return RedirectToAction(nameof(Manage));
        //}

        //[HttpGet]
        //public async Task<IActionResult> Edit(string id)
        //{
        //    ProductEditViewModel? model = await productService.GetProductForEditAsync(id);

        //    if (model == null)
        //    {
        //        return RedirectToAction(nameof(All));
        //    }

        //    await PopulateDropdowns();
        //    return View(model);
        //}

        //[HttpPost]
        //public async Task<IActionResult> Edit(ProductEditViewModel model)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        await PopulateDropdowns();
        //        return View(model);
        //    }

        //    bool updated = await productService.UpdateProductAsync(model);

        //    if (!updated)
        //    {
        //        return RedirectToAction(nameof(All));
        //    }

        //    return RedirectToAction(nameof(Details), new { id = model.ProductId });
        //}
    }
}
