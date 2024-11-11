using KickShop.Data;
using KickShop.Models;
using KickShop.Services.Service_Interfaces;
using KickShop.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KickShop.Services
{
    public class ProductService:IProductService
    {
        private readonly KickShopDbContext context;

        public ProductService(KickShopDbContext _context)
        {
            this.context = _context;
        }

        public async Task AddProductAsync(ProductAddViewModel model)
        {
            Product product = new Product
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
        }

        public async Task<ProductEditViewModel?> GetProductForEditAsync(string id)
        {
            var guidId = IsIdValid(id);
            if (guidId is null) return null;

            Product? product = await context.Products.FindAsync(guidId);
            if (product is null || product.IsDeleted) return null;

            return new ProductEditViewModel
            {
                ProductId = product.ProductId,
                Name = product.Name,
                Description = product.Description,
                BrandId = product.BrandId,
                CategoryId = product.CategoryId,
                ImageUrl = product.ImageUrl,
                Price = product.Price,
                Sizes = product.Sizes,
                StockQuantity = product.StockQuantity,
            };
        }

        public async Task<bool> UpdateProductAsync(ProductEditViewModel model)
        {
            var product = await context.Products.FindAsync(model.ProductId);
            if (product is null) return false;

            product.Name = model.Name;
            product.Description = model.Description;
            product.BrandId = model.BrandId;
            product.CategoryId = model.CategoryId;
            product.ImageUrl = model.ImageUrl;
            product.Price = model.Price;
            product.Sizes = model.Sizes;
            product.StockQuantity = model.StockQuantity;

            await context.SaveChangesAsync();
            return true;
        }

        public async Task<List<Product>> GetAllProductsAsync(string sortOrder)
        {
            var products = await context.Products.Include(p => p.Brand).Include(p=>p.Category)
                .Where(p => !p.IsDeleted)
               .ToListAsync();

            return SortOrder(products, sortOrder);
        }

        public async Task<ProductDetailsViewModel?> GetProductDetailsAsync(string id)
        {
            var guidId = IsIdValid(id);
            if (guidId is null) return null;

            var product = await context.Products
                .Include(p => p.Category)
                .FirstOrDefaultAsync(p => p.ProductId == guidId && !p.IsDeleted);

            if (product == null) return null;

            return new ProductDetailsViewModel
            {
                ProductId = product.ProductId,
                Name = product.Name,
                Price = product.Price,
                Description = product.Description,
                ImageUrl = product.ImageUrl,
                Quantity = product.StockQuantity,
                RelatedProducts = await context.Products
                    .Where(p => p.CategoryId == product.CategoryId && p.ProductId != product.ProductId)
                    .ToListAsync()
            };
        }

        public async Task<bool> DeleteProductAsync(string id)
        {
            var guid = IsIdValid(id);
            if (guid is null) return false;

            var product = await context.Products.FindAsync(guid);
            if (product is null || product.IsDeleted) return false;

            product.IsDeleted = true;
            await context.SaveChangesAsync();
            return true;
        }

        private Guid? IsIdValid(string id)
        {
            if (string.IsNullOrEmpty(id)) return null;
            return Guid.TryParse(id, out var guidId) ? guidId : null;
        }

        private List<Product> SortOrder(List<Product> productModels, string sortOrder)
        {
            return sortOrder switch
            {
                "asc" => productModels.OrderBy(pm => pm.Price).ToList(),
                "desc" => productModels.OrderByDescending(pm => pm.Price).ToList(),
                null => productModels
            };
        }

        public async Task<List<Product>> GetAllProductsAsync(string sortOrder, string categoryName)
        {
            var products = await context.Products
                .Include(p=>p.Category)
                .Where(p => !p.IsDeleted&&p.Category.Name == categoryName)
               .ToListAsync();

            return SortOrder(products, sortOrder);
        }

        public async Task<Product?> GetProductByIdAsync(string id)
        {
            Guid? guid = IsIdValid(id);

            if(guid is null)
            {
                return null;
            }

            return await context.Products.Include(p=>p.Brand).Include(p=>p.Category).FirstOrDefaultAsync(p=>!p.IsDeleted&&p.ProductId==guid);
        }
    }
}
