using KickShop.Models;
using KickShop.Services;
using KickShop.Services.Service_Interfaces;
using KickShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace KickShop.Controllers
{
    public class BrandController : Controller
    {
        private readonly IBrandService brandService;

        public BrandController(IBrandService _brandService)
        {
            this.brandService = _brandService;
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            BrandAddViewModel model = new BrandAddViewModel();
            
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(BrandAddViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await brandService.AddBrandAsync(model);
            return RedirectToAction(nameof(Manage));
        }
        [HttpGet]
        public async Task<IActionResult> Manage()
        {
            List<Brand> brands = await brandService.GetAllBrandsAsync();
            return View(brands);
        }
        [HttpGet]
        public async Task<IActionResult> Delete(string id)
        {
            BrandDetailsViewModel? brand = await brandService.GetBrandDetailsAsync(id);

            if (brand == null)
            {
                return RedirectToAction(nameof(Manage));
            }

            return View(brand);
        }
        [HttpPost]
        public async Task<IActionResult> DeleteConfirmed(BrandDetailsViewModel model)
        {
            await brandService.DeleteBrandAsync(model.BrandId.ToString());
            return RedirectToAction(nameof(Manage));
        }
        [HttpGet]
        public async Task<IActionResult> Details(string id)
        {
            BrandDetailsViewModel? brand = await brandService.GetBrandDetailsAsync(id);

            if (brand == null)
            {
                return RedirectToAction(nameof(Manage));
            }

            return View(brand);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            BrandEditViewModel? model = await brandService.GetBrandForEditAsync(id);

            if (model == null)
            {
                return RedirectToAction(nameof(Manage));
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(BrandEditViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            bool updated = await brandService.UpdateBrandAsync(model);

            if (!updated)
            {
                return RedirectToAction(nameof(Manage));
            }

            return RedirectToAction(nameof(Details), new { id = model.BrandId });
        }
    }
}
