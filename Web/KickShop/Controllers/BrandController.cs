using KickShop.Models;
using KickShop.Services;
using KickShop.Services.Service_Interfaces;
using KickShop.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

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
        [Authorize(Roles = "Admin,Manager")]
        public async Task<IActionResult> Add()
        {
            BrandAddViewModel model = new BrandAddViewModel();
            
            return View(model);
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        [Authorize(Roles = "Admin,Manager")]
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
        [Authorize(Roles ="Admin,Manager")]
        public async Task<IActionResult> Manage(string query,int? page)
        {
            int pageSize = 5;
            int pageNumber = page ?? 1;
            IPagedList<Brand> brands = await brandService.GetAllBrandsPaginatedAsync(query,pageNumber,pageSize);
            return View(brands);
        }
        [HttpGet]
        [Authorize(Roles = "Admin,Manager")]
        public async Task<IActionResult> Delete(string id)
        {
            BrandDetailsViewModel? brand = await brandService.GetBrandDetailsAsync(id);

            if (brand == null)
            {
                return RedirectToAction(nameof(Manage));
            }

            return View(brand);
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        [Authorize(Roles = "Admin,Manager")]
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
        [Authorize(Roles = "Admin,Manager")]
        public async Task<IActionResult> Edit(string id)
        {
            BrandEditViewModel? model = await brandService.GetBrandForEditAsync(id);

            if (model == null)
            {
                return RedirectToAction(nameof(Manage));
            }

            return View(model);
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        [Authorize(Roles = "Admin,Manager")]
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
