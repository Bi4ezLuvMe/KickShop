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
        public async Task<IActionResult> Details(string id)
        {
            BrandDetailsViewModel? brand = await brandService.GetBrandDetailsAsync(id);

            if (brand == null)
            {
                return View("NotFound");
            }

            return View(brand);
        }
    }
}
