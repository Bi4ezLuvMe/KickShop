using KickShop.Data;
using KickShop.Models;
using KickShop.Services.Service_Interfaces;
using KickShop.ViewModels;
using KickShop.ViewModels.Product;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace KickShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHomeService homeService;

        public HomeController(IHomeService _homeService)
        {
            this.homeService = _homeService;
        }

        public async Task<IActionResult> Index()
        {
            List<Product> productModels = await homeService.GetFeaturedProducts();

            return View(productModels);
        }
    }
}
