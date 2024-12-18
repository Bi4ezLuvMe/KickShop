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
using KickShop.Services;
using X.PagedList.Extensions;
using X.PagedList;

namespace KickShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService productService;

        public ProductController(IProductService _productService)
        {
            this.productService = _productService;
        }
        [HttpGet]
        public async Task<IActionResult> All(string sortOrder,string query,int? page)
        {
            int pageSize = 6;
            int pageNumber = page ?? 1;
            IPagedList<Product> products = await productService.GetAllProductsPaginatedAsync(sortOrder,query,pageNumber,pageSize);
            ViewBag.Action = nameof(All);
            ViewBag.Query = query;
            return View(products);
        }
        [HttpGet]
        public async Task<IActionResult>ByCategory(string category,string sortOrder,string query, int? page)
        {
            int pageSize = 2;
            int pageNumber = page ?? 1;
            IPagedList<Product> productsByCategory = await productService.GetProductsByCategoryPaginatedAsync(category,sortOrder,query, pageNumber, pageSize);
            ViewBag.Action= category;
            ViewBag.Query = query;
            return View(productsByCategory);
        }
        [HttpGet]
        public async Task<IActionResult> ByBrand(string brand, string sortOrder, string query, int? page)
        {
            int pageSize = 1;
            int pageNumber = page ?? 1;
            IPagedList<Product> productsByBrand = await productService.GetProductsByBrandPaginatedAsync(brand, sortOrder,query, pageNumber, pageSize);
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
    }
}