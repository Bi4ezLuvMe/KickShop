using KickShop.Data;
using KickShop.Models;
using KickShop.Services.Service_Interfaces;
using KickShop.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.Web.Mvc;

namespace KickShop.Services
{
    public class BrandService : IBrandService
    {
        private readonly KickShopDbContext context;

        public BrandService(KickShopDbContext _context)
        {
            this.context = _context;
        }

        public async Task<List<Brand>> GetAllBrandsAsync(string? query)
        {
            List<Brand> brands = await context.Brands
                .Where(b => !b.IsDeleted)
                .ToListAsync();

            return QuerySearch(brands,query);
        }

        public async Task AddBrandAsync(BrandAddViewModel model)
        {
            Brand brand = new Brand()
            {
                Name = model.Name,
                Address = model.Address,
                PhoneNumber = model.PhoneNumber,
                ImageUrl = model.ImageUrl,
                Country = model.Country,
            };

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
            brand.ImageUrl = model.ImageUrl;
            brand.Country = model.Country;

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
            };
        }

        public async Task<BrandEditViewModel?> GetBrandForEditAsync(string id)
        {
            Guid? guidId = IsIdValid(id);

            if (guidId is null)
            {
                return null;
            }

            Brand? brand = await context.Brands.FindAsync(guidId);

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
                ImageUrl = brand.ImageUrl,
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
