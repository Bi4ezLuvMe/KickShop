using KickShop.Data;
using KickShop.Models;
using KickShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KickShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly KickShopDbContext context;
        public ProductController(KickShopDbContext _context)
        {
            this.context = _context;
        }
        [HttpGet]
        public async Task<IActionResult> All(string sortOrder)
        {
            List<ProductViewModel> productModels = await context.Products.Select(p => new ProductViewModel()
            {
                ProductId = p.ProductId,
                Name = p.Name,
                Description = p.Description,
                ImageUrl = p.ImageUrl,
                Price = p.Price,
                Action = nameof(All),
            }).ToListAsync();

            productModels = SortOrder(productModels, sortOrder);

            return View(productModels);  
        }
        [HttpGet]
        public async Task<IActionResult> Clothing(string sortOrder)
        {
            List<ProductViewModel> productModels = await context.Products
                .Include(p=>p.Category)
                .Where(p=>p.Category.Name == "Apparel")
                .Select(p => new ProductViewModel()
            {
                ProductId = p.ProductId,
                Name = p.Name,
                Description = p.Description,
                ImageUrl = p.ImageUrl,
                Price = p.Price,
                Action = nameof(Clothing),
                }).ToListAsync();

            productModels = SortOrder(productModels, sortOrder);

            return View(nameof(All),productModels);
        }
        [HttpGet]
        public async Task<IActionResult> Gloves(string sortOrder)
        {
            List<ProductViewModel> productModels = await context.Products
               .Include(p => p.Category)
               .Where(p => p.Category.Name == "Gloves")
               .Select(p => new ProductViewModel()
               {
                   ProductId = p.ProductId,
                   Name = p.Name,
                   Description = p.Description,
                   ImageUrl = p.ImageUrl,
                   Price = p.Price,
                   Action = nameof(Gloves),
               }).ToListAsync();

            productModels = SortOrder(productModels, sortOrder);

            return View(nameof(All), productModels);
        }
        [HttpGet]
        public async Task<IActionResult> ProtectiveGear(string sortOrder)
        {
            List<ProductViewModel> productModels = await context.Products
               .Include(p => p.Category)
               .Where(p => p.Category.Name == "Protective Gear")
               .Select(p => new ProductViewModel()
               {
                   ProductId = p.ProductId,
                   Name = p.Name,
                   Description = p.Description,
                   ImageUrl = p.ImageUrl,
                   Price = p.Price,
                   Action = nameof(ProtectiveGear),
               }).ToListAsync();

            productModels = SortOrder(productModels, sortOrder);

            return View(nameof(All), productModels);
        }
        public async Task<IActionResult>Details(string id)
        {
            Guid? guidId = IsIdValid(id);

            if(guidId is null)
            {
                return RedirectToAction(nameof(Index));
            }

            Product? product = await context.Products.FirstOrDefaultAsync(x => x.ProductId == guidId);

            if(product is null)
            {
                return RedirectToAction(nameof(Index));
            }

            ProductDetailsViewModel model = new ProductDetailsViewModel()
            {
                ProductId = (Guid)guidId,
                Name = product.Name,
                Price = product.Price,
                Description = product.Description,
                ImageUrl = product.ImageUrl,
                Quantity = product.StockQuantity,
                RelatedProducts = await context.Products.Where(p => p.CategoryId == product.CategoryId&&p.ProductId!=guidId).ToListAsync()
            };

            return View(model);
        }
        private Guid? IsIdValid(string id)
        {
            if (String.IsNullOrEmpty(id))
            {
                return null;
            }

            Guid guidId;

            if (!Guid.TryParse(id, out guidId))
            {
                return null;
            }

            return guidId;
        }
        private List<ProductViewModel> SortOrder(List<ProductViewModel>productModels,string sortOrder)
        {
            switch (sortOrder)
            {
                case "asc":
                    productModels = productModels.OrderBy(pm => pm.Price).ToList();
                    break;
                case "desc":
                    productModels = productModels.OrderByDescending(pm => pm.Price).ToList();
                    break;
            }
            return productModels;
        }
    }
}
