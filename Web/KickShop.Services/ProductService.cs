using KickShop.Data;
using KickShop.Models;
using KickShop.Models.Enums;
using KickShop.Services.Service_Interfaces;
using KickShop.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Drawing;
using KickShop.ViewModels.Product;
using System.Security.Policy;
using X.PagedList.Extensions;
using X.PagedList;
namespace KickShop.Services
{
    public class ProductService:IProductService
    {
        private readonly KickShopDbContext context;

        public ProductService(KickShopDbContext _context)
        {
            this.context = _context;
        }

        public async Task<Product> AddProductAsync(ProductAddViewModel model)
        {
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
       .Where(s => s.IsSelected) 
       .Select(ps => new ProductSize
       {
           ProductSizeId = Guid.NewGuid(),
           Size = Enum.Parse<Sizes>(ps.Size), 
           ProductId = model.ProductId,
           Quantity = ps.Quantity
       })
       .ToList() 
            };

            if (model.Images != null && model.Images.Any())
            {
                foreach (var image in model.Images)
                {
                    await Console.Out.WriteLineAsync(image.FileName);
                    if (image.Length > 0)
                    {
                        string fileName = Guid.NewGuid() + Path.GetExtension(image.FileName);
                        string filePath = Path.Combine("wwwroot/images/products", fileName);

                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            await image.CopyToAsync(stream);
                        }
                        ProductImage productImage = new ProductImage()
                        {
                            ProductId = product.ProductId,
                            ImageUrl = "/images/products/" + fileName
                        };
                        context.ProductsImages.Add(productImage);
                        product.Images.Add(productImage);
                    }
                }
            }
          
            product.MainImageUrl = product.Images.First().ImageUrl;

            await context.Products.AddAsync(product);
            await context.ProductsSizes.AddRangeAsync(product.Sizes);
            await context.SaveChangesAsync();

            return product;
        }

        public async Task<ProductEditViewModel?> GetProductForEditAsync(string id)
        {
            Guid? guidId = IsIdValid(id);

            if (guidId is null)
            {
                return null;
            }

            Product? product = await context.Products.Include(p=>p.Sizes).Include(p=>p.Images).FirstOrDefaultAsync(p=>p.ProductId==guidId);

            if (product is null || product.IsDeleted)
            {
                return null;
            }
            var sizes = Enum.GetValues(typeof(Sizes)).Cast<Sizes>();
            return new ProductEditViewModel
            {
                ProductId = product.ProductId,
                Name = product.Name,
                Description = product.Description,
                BrandId = product.BrandId,
                CategoryId = product.CategoryId,
                Price = product.Price,
                Sizes  =sizes.Select(size => new ProductSizeViewModel
                {
                    Size = size.ToString(),
                    IsSelected = product.Sizes.Any(ps => ps.Size == size),
                    Quantity = product.Sizes.FirstOrDefault(ps => ps.Size == size)?.Quantity ?? 0
                }).ToList(),
                StockQuantity = product.StockQuantity,
                ExistingImages = product.Images.Select(pi=>pi.ImageUrl).ToList()
            };
        }

        public async Task<bool> UpdateProductAsync(ProductEditViewModel model)
        {
            Product? product = await context.Products.Include(p=>p.Images).Include(p=>p.Sizes)
                .FirstOrDefaultAsync(p=>p.ProductId==model.ProductId);


            if (product is null||product.IsDeleted)
            {
                return false;
            }

            product.Name = model.Name;
            product.Description = model.Description;
            product.BrandId = model.BrandId;
            product.CategoryId = model.CategoryId;
            product.Price = model.Price;
            product.StockQuantity = model.StockQuantity;
            if (model.Images != null && model.Images.Any())
            {
                foreach (var image in model.Images)
                {
                    if (image.Length > 0)
                    {
                        string fileName = Guid.NewGuid() + Path.GetExtension(image.FileName);
                        string filePath = Path.Combine("wwwroot/images/products", fileName);

                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            await image.CopyToAsync(stream);
                        }
                        ProductImage productImage = new ProductImage()
                        {
                            ProductId = product.ProductId,
                            ImageUrl = "/images/products/" + fileName
                        };
                        context.ProductsImages.Add(productImage);
                        product.Images.Add(productImage);
                    }
                }
            }
            var selectedSizes = model.Sizes.Where(s => s.IsSelected).ToList();

            var sizesToRemove = product.Sizes
                .Where(ps => !selectedSizes.Any(s => Enum.Parse<Sizes>(s.Size) == ps.Size))
                .ToList();

            context.ProductsSizes.RemoveRange(sizesToRemove);

            foreach (var selectedSize in selectedSizes)
            {
                var existingSize = product.Sizes
                    .FirstOrDefault(ps => ps.Size == Enum.Parse<Sizes>(selectedSize.Size));

                if (existingSize != null)
                {
                    existingSize.Quantity = selectedSize.Quantity;
                }
                else
                {
                    ProductSize ps = new ProductSize()
                    {
                        ProductSizeId = Guid.NewGuid(),
                        Size = Enum.Parse<Sizes>(selectedSize.Size),
                        Quantity = selectedSize.Quantity,
                        ProductId = product.ProductId
                    };
                    product.Sizes.Add(ps);
                    context.ProductsSizes.Add(ps);
                }
            }

            if (product.Images.Count>0)
            {
                product.MainImageUrl = product.Images[0].ImageUrl;
            }

            await context.SaveChangesAsync();
            return true;
        }

        public async Task<IPagedList<Product>> GetAllProductsPaginatedAsync(string? sortOrder,string? query,int pageNumber = 1,int pageSize = 5)
        {
            List<Product> products = await context.Products
                .Include(p => p.Brand)
                .Include(p=>p.Category)
                .Include(p=>p.Sizes)
                .Where(p => !p.IsDeleted)
               .ToListAsync();

            products = QuerySearch(products, query);

            products = SortOrder(products, sortOrder);

            IPagedList<Product> pagedProducts = products.ToPagedList(pageNumber, pageSize);

            return pagedProducts;
        }

        public async Task<ProductDetailsViewModel?> GetProductDetailsAsync(string id)
        {
            Guid? guidId = IsIdValid(id);

            if (guidId is null)
            {
                return null;
            }

            Product? product = await context.Products
                .AsNoTracking()
                .Include(p => p.Category)
                .Include(p=>p.Sizes)
                .FirstOrDefaultAsync(p => p.ProductId == guidId && !p.IsDeleted);

            if (product == null)
            {
                return null;
            }

            List<ProductImage> images = await context.ProductsImages
                .AsNoTracking()
                .Where(pi => pi.ProductId == guidId)
                .ToListAsync();

            List<SelectListItem> sizesList = product.Sizes
                .Where(s=>s.Quantity>0)
                        .Select(s => new SelectListItem
                        {
                            Text = s.Size.ToString(),  
                            Value = s.Size.ToString() 
                        }).ToList();

            return new ProductDetailsViewModel
            {
                ProductId = product.ProductId,
                Name = product.Name,
                Price = product.Price,
                Description = product.Description,
                Images = images,
                MainImageUrl = product.MainImageUrl,
                Quantity = product.StockQuantity,
                Sizes = sizesList,
                BrandId = product.BrandId,
                RelatedProducts = await context.Products
                    .Where(p => p.CategoryId == product.CategoryId && p.ProductId != product.ProductId&& !p.IsDeleted)
                    .ToListAsync()
            };
        }

        public async Task<bool> DeleteProductAsync(string id)
        {
            Guid? guid = IsIdValid(id);
            if (guid is null)
            {
                return false;
            }

            Product? product = await context.Products.FindAsync(guid);

            if (product is null || product.IsDeleted)
            {
                return false;
            }

            product.IsDeleted = true;
            await context.SaveChangesAsync();

            return true;
        }

        public async Task<Product?> GetProductByIdAsync(string id)
        {
            Guid? guid = IsIdValid(id);

            if (guid is null)
            {
                return null;
            }

            return await context.Products
                .Include(p=>p.Brand)
                .Include(p=>p.Category)
                .FirstOrDefaultAsync(p => !p.IsDeleted && p.ProductId == guid);
        }

        public async Task<List<Product>> GetProductsByCategoryAsync(string category,string? sortOrder,string? query)
        {
            List<Product> productsByCategory = await context.Products
                .Include(p => p.Category)
                .Where(p => !p.IsDeleted && p.Category.Name == category)
                .ToListAsync();

            productsByCategory = QuerySearch(productsByCategory, query);

            return SortOrder(productsByCategory, sortOrder);
        }

        public async Task<List<Product>> GetProductsByBrandAsync(string brand, string? sortOrder,string? query)
        {
            List<Product> productsByBrand = await context.Products
                .Include(p => p.Brand)
                .Where(p => !p.IsDeleted && p.Brand.Name == brand)
                .ToListAsync();

            productsByBrand = QuerySearch(productsByBrand, query);

            return SortOrder(productsByBrand, sortOrder);
        }
        public async Task<IPagedList<Product>> GetProductsByCategoryPaginatedAsync(string category, string? sortOrder, string? query, int pageNumber,int pageSize)
        {
            List<Product> productsByCategory = await context.Products
                .Include(p => p.Category)
                .Where(p => !p.IsDeleted && p.Category.Name == category)
                .ToListAsync();

            productsByCategory = QuerySearch(productsByCategory, query);

            productsByCategory = SortOrder(productsByCategory, sortOrder);

            IPagedList<Product> productsByCategoryPaged = productsByCategory.ToPagedList(pageNumber, pageSize); 

            return productsByCategoryPaged;
        }

        public async Task<IPagedList<Product>> GetProductsByBrandPaginatedAsync(string brand, string? sortOrder, string? query, int pageNumber, int pageSize)
        {
            List<Product> productsByBrand = await context.Products
                .Include(p => p.Brand)
                .Where(p => !p.IsDeleted && p.Brand.Name == brand)
                .ToListAsync();

            productsByBrand = QuerySearch(productsByBrand, query);

            productsByBrand = SortOrder(productsByBrand, sortOrder);

            IPagedList<Product> productsByBrandPaged = productsByBrand.ToPagedList(pageNumber,pageSize);

            return productsByBrandPaged;
        }
        public async Task<bool> RemoveImageAsync(string imageUrl, Guid productId)
        {
            if (string.IsNullOrEmpty(imageUrl))
            {
                return false;
            }

            var filePath = Path.Combine("wwwroot", imageUrl.TrimStart('/'));
            if (System.IO.File.Exists(filePath))
            {
                System.IO.File.Delete(filePath);
            }

            var productImage = await context.ProductsImages
                .FirstOrDefaultAsync(pi => pi.ImageUrl == imageUrl && pi.ProductId == productId);

            if (productImage != null)
            {
                context.ProductsImages.Remove(productImage);
                await context.SaveChangesAsync();
            }

            return true;
        }

        public async Task<List<Product>> GetAllProductsAsync()
        {
           return await context.Products
                .Include(p => p.Brand)
                .Include(p => p.Category)
                .Include(p => p.Sizes)
                .Where(p => !p.IsDeleted)
               .ToListAsync();
        }
        private Guid? IsIdValid(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return null;
            }
            return Guid.TryParse(id, out var guidId) ? guidId : null;
        }

        protected List<Product> SortOrder(List<Product> productModels, string? sortOrder)
        {
            return sortOrder switch
            {
                "asc" => productModels.OrderBy(pm => pm.Price).ToList(),
                "desc" => productModels.OrderByDescending(pm => pm.Price).ToList(),
                null => productModels
            };
        }
        protected List<Product> QuerySearch(List<Product>productModels,string? query)
        {
            if(query is null)
            {
                return productModels;
            }
            return productModels.Where(p => p.Name.ToLower().Contains(query.ToLower())).ToList();
        }

    }
}
