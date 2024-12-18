using KickShop.Models;
using KickShop.Services;
using KickShop.Services.Service_Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace KickShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,Manager")]
    public class ManageController : Controller
    {
        private readonly IProductService productService;
        private readonly IBrandService brandService;
        private readonly ICategoryService categoryService;
        public ManageController(IProductService productService, IBrandService brandService,ICategoryService categoryService)
        {
            this.productService = productService;
            this.brandService = brandService;
            this.categoryService = categoryService;
        }
        [HttpGet]
        public async Task<IActionResult> ManageProducts(string query, int? page)
        {
            int pageSize = 10;
            int pageNumber = page ?? 1;
            IPagedList<Product> products = await productService.GetAllProductsPaginatedAsync(null, query, pageNumber, pageSize);
            ViewBag.Query = query;
            return View(products);
        }
        [HttpGet]
        public async Task<IActionResult> ManageBrands(string query, int? page)
        {
            int pageSize = 5;
            int pageNumber = page ?? 1;
            IPagedList<Brand> brands = await brandService.GetAllBrandsPaginatedAsync(query, pageNumber, pageSize);
            return View(brands);
        }
        [HttpGet]
        public async Task<IActionResult> ManageCategories(string query, int? page)
        {
            int pageSize = 5;
            int pageNumber = page ?? 1;
            IPagedList<Category> pagedCategories = await categoryService.GetAllCategoriesPagedAsync(query, pageNumber, pageSize);
            return View(pagedCategories);
        }
    }
}
