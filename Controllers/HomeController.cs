using KickShop.Data;
using KickShop.Models;
using KickShop.ViewModels;
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
            List<ProductViewModel> productModels = await context.Products.Take(3).Select(p=>new ProductViewModel() 
            {
                ProductId = p.ProductId,
                Name = p.Name,
                Description = p.Description,
                Price = p.Price,
                ImageUrl = p.ImageUrl,
            }).ToListAsync();

            return View(productModels);
        }
    }
}
