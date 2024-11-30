using KickShop.Models.Enums;
using KickShop.ViewModels;
using KickShop.Services.Service_Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using KickShop.Models;
using Microsoft.AspNetCore.Authorization;
using System.Drawing;
using KickShop.ViewModels.Product;
using Microsoft.EntityFrameworkCore;
using KickShop.Data;

namespace KickShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService productService;
        private readonly ICategoryService categoryService;
        private readonly IBrandService brandService;
        private readonly KickShopDbContext context;

        public ProductController(IProductService _productService, ICategoryService _categoryService, IBrandService _brandService,KickShopDbContext context)
        {
            this.productService = _productService;
            this.categoryService = _categoryService;
            this.brandService = _brandService;
            this.context = context;
        }

        [HttpGet]
        [Authorize(Roles = "Admin,Manager")]
        public async Task<IActionResult> Add()
        {
            ProductAddViewModel model = new ProductAddViewModel();
            await PopulateDropdowns();
            model.Sizes = Enum.GetNames(typeof(Sizes))
                    .Select(size => new ProductSizeViewModel { Size = size })
                    .ToList();
            return View(model);
        }

        [HttpPost]
        [Authorize(Roles = "Admin,Manager")]
        public async Task<IActionResult> Add(ProductAddViewModel model)
        {
            if (!ModelState.IsValid)
            {
                await PopulateDropdowns();
                return View(model);
            }

            await productService.AddProductAsync(model);
            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        [Authorize(Roles = "Admin,Manager")]
        public async Task<IActionResult> Edit(string id)
        {
            ProductEditViewModel? model = await productService.GetProductForEditAsync(id);

            if (model == null)
            {
                return RedirectToAction(nameof(All));
            }

            await PopulateDropdowns();
            return View(model);
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        [Authorize(Roles = "Admin,Manager")]
        public async Task<IActionResult> Edit(ProductEditViewModel model)
        {
            if (!ModelState.IsValid)
            {
                await PopulateDropdowns();
                return View(model);
            }

            bool updated = await productService.UpdateProductAsync(model);

            if (!updated)
            {
                return RedirectToAction(nameof(All));
            }

            return RedirectToAction(nameof(Details), new { id = model.ProductId });
        }

        [HttpGet]
        public async Task<IActionResult> All(string sortOrder,string query)
        {
            List<Product> products = await productService.GetAllProductsAsync(sortOrder,query);
            ViewBag.Action = nameof(All);
            ViewBag.Query = query;
            return View(products);
        }
        [HttpGet]
        public async Task<IActionResult>ByCategory(string category,string sortOrder,string query)
        {
            List<Product> productsByCategory = await productService.GetProductsByCategoryAsync(category,sortOrder,query);
            ViewBag.Action= category;
            ViewBag.Query = query;
            return View(productsByCategory);
        }
        [HttpGet]
        public async Task<IActionResult> ByBrand(string brand, string sortOrder, string query)
        {
            List<Product> productsByBrand = await productService.GetProductsByBrandAsync(brand, sortOrder,query);
            ViewBag.Action = brand;
            ViewBag.Query = query;
            return View(productsByBrand);
        }
        [HttpGet]
        public async Task<IActionResult> Details(string id)
        {
            ProductDetailsViewModel? product = await productService.GetProductDetailsAsync(id);

            if (product == null)
            {
                return RedirectToAction(nameof(All));
            }

            if (TempData.ContainsKey("SizeError"))
            {
                ModelState.AddModelError("SelectedSize", TempData["SizeError"].ToString());
            }

            return View(product);
        }

        [HttpGet]
        [Authorize(Roles = "Admin,Manager")]
        public async Task<IActionResult> Manage(string query)
        {
            List<Product> products = await productService.GetAllProductsAsync(null,query);
            return View(products);
        }

        [HttpGet]
        [Authorize(Roles = "Admin,Manager")]
        public async Task<IActionResult> Delete(string id)
        {
            Product? product = await productService.GetProductByIdAsync(id);

            if (product == null)
            {
                return RedirectToAction(nameof(Manage));
            }

            return View(product);
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        [Authorize(Roles = "Admin,Manager")]
        public async Task<IActionResult> DeleteConfirmed(Product product)
        {
            await productService.DeleteProductAsync(product.ProductId.ToString());
            return RedirectToAction(nameof(Manage));
        }
        [HttpPost]
        public async Task<IActionResult> RemoveImage(string imageUrl, Guid productId)
        {
            if (string.IsNullOrEmpty(imageUrl))
            {
                return RedirectToAction("Edit", new { id = productId });
            }

            // Remove the image from the file system
            var filePath = Path.Combine("wwwroot", imageUrl.TrimStart('/'));
            if (System.IO.File.Exists(filePath))
            {
                System.IO.File.Delete(filePath);
            }

            // Remove the image from the database
            var productImage = await context.ProductsImages
                .FirstOrDefaultAsync(pi => pi.ImageUrl == imageUrl && pi.ProductId == productId);

            if (productImage != null)
            {
                context.ProductsImages.Remove(productImage);
                await context.SaveChangesAsync();
            }

            // Fetch the product with updated images
            var product = await context.Products
                .Include(p => p.Images)
                .FirstOrDefaultAsync(p => p.ProductId == productId);

            if (product == null)
            {
                return NotFound();
            }

            // Update the product's existing images
            var existingImages = product.Images.Select(pi => pi.ImageUrl).ToList();

            // Pass the updated images list to the view
            var model = new ProductEditViewModel
            {
                ProductId = product.ProductId,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                StockQuantity = product.StockQuantity,
                CategoryId = product.CategoryId,
                BrandId = product.BrandId,
                ExistingImages = existingImages, // Updated images list
                Sizes = product.Sizes.Select(s => new ProductSizeViewModel
                {
                    Size = s.Size.ToString(),
                    Quantity = s.Quantity
                }).ToList()
            };

            if (!ModelState.IsValid)
            {
                return View("Edit", model);
            }

            return RedirectToAction("Edit", new { id = product.ProductId });
        }

            private async Task PopulateDropdowns()
        {
            ViewBag.Categories = new SelectList(await categoryService.GetAllCategoriesAsync(null), "CategoryId", "Name");
            ViewBag.Brands = new SelectList(await brandService.GetAllBrandsAsync(null), "BrandId", "Name");
            ViewBag.Sizes = Enum.GetNames(typeof(Sizes)).ToList();
        }
    }
}