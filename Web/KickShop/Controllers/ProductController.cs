using KickShop.Data;
using KickShop.Models;
using KickShop.Models.Enums;
using KickShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        public async Task<IActionResult> Add()
        {
            ProductAddViewModel model = new ProductAddViewModel();

            ViewBag.Categories = new SelectList(context.Categories, "CategoryId", "Name");
            ViewBag.Brands = new SelectList(context.Brands, "BrandId", "Name");
            ViewBag.Sizes = new List<string> { Sizes.S.ToString(), Sizes.M.ToString(), Sizes.L.ToString(), Sizes.XL.ToString()};

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult>Add(ProductAddViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Categories = new SelectList(context.Categories, "CategoryId", "Name");
                ViewBag.Brands = new SelectList(context.Brands, "BrandId", "Name");
                ViewBag.Sizes = new List<string> { Sizes.S.ToString(), Sizes.M.ToString(), Sizes.L.ToString(), Sizes.XL.ToString() };

                return View(model);
            }
            Product product = new Product()
            {
                ProductId = model.ProductId,
                Name = model.Name,
                Description = model.Description,
                Price = model.Price,
                StockQuantity = model.StockQuantity,
                CategoryId = model.CategoryId,
                BrandId = model.BrandId,
                Sizes = model.Sizes
            };

            await context.Products.AddAsync(product);
            await context.SaveChangesAsync();

            return RedirectToAction(nameof(All));
        }
        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            Guid? guidId = IsIdValid(id);

            if(guidId is null)
            {
                return RedirectToAction(nameof(All));
            }

            Product? product = await context.Products.FindAsync(guidId);

            if(product is null)
            {
                return RedirectToAction(nameof(All));
            }

            ProductEditViewModel model = new ProductEditViewModel()
            {
                ProductId = product.ProductId,
                Name = product.Name,
                Description = product.Description,
                BrandId= product.BrandId,
                CategoryId = product.CategoryId,
                ImageUrl = product.ImageUrl,
                Price= product.Price,
                Sizes = product.Sizes,
                StockQuantity = product.StockQuantity,
            };

            ViewBag.Categories = new SelectList(context.Categories, "CategoryId", "Name");
            ViewBag.Brands = new SelectList(context.Brands, "BrandId", "Name");
            ViewBag.Sizes = ViewBag.Sizes = Enum.GetValues(typeof(KickShop.Models.Enums.Sizes)).Cast<KickShop.Models.Enums.Sizes>().ToList();

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult>Edit(ProductEditViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Categories = new SelectList(context.Categories, "CategoryId", "Name");
                ViewBag.Brands = new SelectList(context.Brands, "BrandId", "Name");
                ViewBag.Sizes = new List<string> { Sizes.S.ToString(), Sizes.M.ToString(), Sizes.L.ToString(), Sizes.XL.ToString() };

                return View(model);
            }

            Product? product = await context.Products.FindAsync(model.ProductId);

            if (product is null)
            {
                return RedirectToAction(nameof(All));
            }

            product.Name = model.Name;
            product.Description = model.Description;
            product.BrandId = model.BrandId;
            product.CategoryId = model.CategoryId;
            product.ImageUrl = model.ImageUrl;
            product.Price = model.Price;
            product.Sizes = model.Sizes;
            product.StockQuantity = model.StockQuantity;

            await context.SaveChangesAsync();

            return RedirectToAction(nameof(Details),new { id = model.ProductId.ToString() });
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
                CategoryId = p.CategoryId.ToString(),
            }).ToListAsync();

            productModels = SortOrder(productModels, sortOrder);

            ViewBag.Action = nameof(All);

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
                    CategoryId = p.CategoryId.ToString(),
                }).ToListAsync();

            productModels = SortOrder(productModels, sortOrder);

            ViewBag.Action = nameof(Clothing);

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
                   CategoryId = p.CategoryId.ToString(),
               }).ToListAsync();

            productModels = SortOrder(productModels, sortOrder);

            ViewBag.Action = nameof(Gloves);

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
                   CategoryId = p.CategoryId.ToString(),
               }).ToListAsync();

            productModels = SortOrder(productModels, sortOrder);

            ViewBag.Action = nameof(ProtectiveGear);
            

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
