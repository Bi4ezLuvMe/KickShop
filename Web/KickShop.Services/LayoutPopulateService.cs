using KickShop.Data;
using KickShop.Services.Service_Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return await context.Brands.Where(b => !b.IsDeleted).Select(b=>b.Name).ToListAsync();
        }

        public async Task<List<string>> GetCategoriesAsync()
        {
            return await context.Categories.Where(c => !c.IsDeleted).Select(c => c.Name).ToListAsync();
        }
    }
}
