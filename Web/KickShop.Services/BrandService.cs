using KickShop.Data;
using KickShop.Models;
using KickShop.Services.Service_Interfaces;
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

        public async Task<List<Brand>> GetAllBrandsAsync()
        {
            return await context.Brands.ToListAsync();
        }

        public async Task<SelectList> GetBrandSelectListAsync()
        {
            List<Brand> brands = await GetAllBrandsAsync();
            return new SelectList(brands, "BrandId", "Name");
        }

        public async Task<Brand?> GetBrandByIdAsync(Guid id)
        {
            return await context.Brands.FindAsync(id);
        }

        public async Task<Brand> AddBrandAsync(Brand brand)
        {
            await context.Brands.AddAsync(brand);
            await context.SaveChangesAsync();
            return brand;
        }

        public async Task<bool> UpdateBrandAsync(Brand brand)
        {
            context.Brands.Update(brand);
            return await context.SaveChangesAsync() > 0;
        }
    }
}
