using KickShop.Data;
using KickShop.Models;
using KickShop.ViewModels;
using KickShop.ViewModels.Product;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace KickShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly KickShopDbContext context;

        public HomeController(KickShopDbContext _context)
        {
            this.context = _context;
        }

        public async Task<IActionResult> Index()
        {
            List<Product> productModels = await context.Products.Take(3).ToListAsync();

            return View(productModels);
        }
    }
}
