using KickShop.Services.Service_Interfaces;
using KickShop.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;
using X.PagedList;

namespace KickShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,Manager")]
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
        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> Add(BrandAddViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await brandService.AddBrandAsync(model);
            return RedirectToAction("ManageBrands", "Manage");
        }
        [HttpGet]
        public async Task<IActionResult> Delete(string id)
        {
            BrandDetailsViewModel? brand = await brandService.GetBrandDetailsAsync(id);

            if (brand == null)
            {
                return RedirectToAction("ManageBrands", "Manage");
            }

            return View(brand);
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> DeleteConfirmed(BrandDetailsViewModel model)
        {
            await brandService.DeleteBrandAsync(model.BrandId.ToString());
            return RedirectToAction("ManageBrands", "Manage");
        }
        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            BrandEditViewModel? model = await brandService.GetBrandForEditAsync(id);

            if (model == null)
            {
                return RedirectToAction("ManageBrands", "Manage");
            }

            return View(model);
        }
        [ValidateAntiForgeryToken]
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
                return RedirectToAction("ManageBrands", "Manage");
            }

            return RedirectToAction("ManageBrands", "Manage");
        }
    }
}
