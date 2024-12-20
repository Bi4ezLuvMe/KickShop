﻿using KickShop.Data;
using KickShop.Services.Service_Interfaces;
using Microsoft.EntityFrameworkCore;

namespace KickShop.Services
{
    public class LayoutPopulateService : ILayoutPopulateService
    {
        private readonly KickShopDbContext context;
        public LayoutPopulateService(KickShopDbContext _context)
        {
            this.context = _context;
        }
        public async Task<List<string>> GetBrandsAsync()
        {
            return await context.Brands
                .AsNoTracking()
                .Where(b => !b.IsDeleted)
                .Select(b => b.Name)
                .ToListAsync();
        }

        public async Task<List<string>> GetCategoriesAsync()
        {
            return await context.Categories
                .AsNoTracking()
                .Where(c => !c.IsDeleted)
                .Select(c => c.Name)
                .ToListAsync();
        }
    }
}
