using KickShop.Data;
using KickShop.Models;
using KickShop.Services.Service_Interfaces;
using KickShop.ViewModels;
using KickShop.ViewModels.Product;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace KickShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHomeService homeService;

        public HomeController(IHomeService _homeService, SignInManager<ApplicationUser> signInManager)
        {
            this.homeService = _homeService;
        }

        public async Task<IActionResult> Index()
        {
            List<Product> productModels = await homeService.GetFeaturedProducts();
         
            return View(productModels);
        }
        [HttpGet]
        public IActionResult StatusCode(int code)
        {
            if (code == 404)
            {
                return View("~/Views/Shared/Errors/NotFound.cshtml");
            }
            if(code == 500)
            {
                return View("~/Views/Shared/Errors/InternalServerError.cshtml");
            }
            return View("Error");
        }
    }
}
