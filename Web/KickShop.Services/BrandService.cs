using Azure;
using KickShop.Data;
using KickShop.Models;
using KickShop.Services.Service_Interfaces;
using KickShop.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.Web.Mvc;
using X.PagedList;
using X.PagedList.Extensions;

namespace KickShop.Services
{
    public class BrandService : IBrandService
    {
        private readonly KickShopDbContext context;

        public BrandService(KickShopDbContext _context)
        {
            this.context = _context;
        }

        public async Task<IPagedList<Brand>> GetAllBrandsPaginatedAsync(string? query,int pageNumber = 1,int pageSize =10)
        {
            List<Brand> brands = await context.Brands
                .AsNoTracking()
                .Where(b => !b.IsDeleted)
                .ToListAsync();

            brands = QuerySearch(brands, query);

            IPagedList<Brand> paginatedBrands = brands.ToPagedList(pageNumber, pageSize);

            return paginatedBrands;
        }
        public async Task<List<Brand>> GetAllBrandsAsync()
        {
            return context.Brands.Where(b => !b.IsDeleted).ToList();
        }

        public async Task AddBrandAsync(BrandAddViewModel model)
        {
            Brand brand = new Brand()
            {
                Name = model.Name,
                Address = model.Address,
                PhoneNumber = model.PhoneNumber,
                Country = model.Country,
            };
            if (model.Image != null && model.Image.Length > 0)
            {
                string fileName = Guid.NewGuid() + Path.GetExtension(model.Image.FileName);
                string filePath = Path.Combine("wwwroot/images/Categories", fileName);

                Directory.CreateDirectory(Path.GetDirectoryName(filePath));

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await model.Image.CopyToAsync(stream);
                }

                brand.ImageUrl = "/images/Categories/" + fileName;
            }
            await context.Brands.AddAsync(brand);
            await context.SaveChangesAsync();
        }

        public async Task<bool> UpdateBrandAsync(BrandEditViewModel model)
        {
            Brand? brand = await context.Brands.FindAsync(model.BrandId);

            if (brand is null||brand.IsDeleted)
            {
                return false;
            }

            brand.Name = model.Name;
            brand.Address = model.Address;
            brand.BrandId = model.BrandId;
            brand.PhoneNumber = model.PhoneNumber;
            brand.Country = model.Country;

            if (model.Image != null && model.Image.Length > 0)
            {
                if (!string.IsNullOrEmpty(brand.ImageUrl))
                {
                    string oldFilePath = Path.Combine("wwwroot", brand.ImageUrl.TrimStart('/'));
                    if (File.Exists(oldFilePath))
                    {
                        File.Delete(oldFilePath);
                    }
                }

                string fileName = Guid.NewGuid() + Path.GetExtension(model.Image.FileName);
                string filePath = Path.Combine("wwwroot/images/Categories", fileName);

                Directory.CreateDirectory(Path.GetDirectoryName(filePath));

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await model.Image.CopyToAsync(stream);
                }

                brand.ImageUrl = "/images/Categories/" + fileName;
            }
            await context.SaveChangesAsync();
            return true;
        }

        public async Task<BrandDetailsViewModel?> GetBrandDetailsAsync(string id)
        {
            Guid? guidId = IsIdValid(id);

            if (guidId is null)
            {
                return null;
            }

            Brand? brand = await context.Brands
                .AsNoTracking()
                .FirstOrDefaultAsync(b => b.BrandId == guidId && !b.IsDeleted);

            if (brand == null)
            {
                return null;
            }

            return new BrandDetailsViewModel()
            {
                BrandId = brand.BrandId,
                Name = brand.Name,
                Country = brand.Country,
                Address = brand.Address,
                ImageUrl = brand.ImageUrl,
                PhoneNumber = brand.PhoneNumber,
                Description = brand.Description
            };
        }

        public async Task<BrandEditViewModel?> GetBrandForEditAsync(string id)
        {
            Guid? guidId = IsIdValid(id);

            if (guidId is null)
            {
                return null;
            }

            Brand? brand = await context.Brands
                .AsNoTracking().FirstOrDefaultAsync(b=>b.BrandId==guidId);

            if (brand is null || brand.IsDeleted)
            {
                return null;
            }

            return new BrandEditViewModel
            {
                BrandId = brand.BrandId,
                Name = brand.Name,
                Address = brand.Address,
                PhoneNumber = brand.PhoneNumber,
                OldImageUrl = brand.ImageUrl,
                Country = brand.Country,
            };
        }

        public async Task<bool> DeleteBrandAsync(string id)
        {
            Guid? guid = IsIdValid(id);

            if (guid is null)
            {
                return false;
            }

            Brand? brand = await context.Brands.FindAsync(guid);

            if (brand is null || brand.IsDeleted)
            {
                return false;
            }

            brand.IsDeleted = true;
            await context.SaveChangesAsync();

            return true;
        }

        private Guid? IsIdValid(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return null;
            }

            return Guid.TryParse(id, out var guidId) ? guidId : null;
        }
        private List<Brand> QuerySearch(List<Brand> brandModels, string? query)
        {
            if (query is null)
            {
                return brandModels;
            }
            return brandModels.Where(p => p.Name.ToLower().Contains(query.ToLower())).ToList();
        }

    }
}
