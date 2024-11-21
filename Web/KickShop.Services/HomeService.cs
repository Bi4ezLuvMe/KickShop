using KickShop.Data;
using KickShop.Models;
using KickShop.Services.Service_Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KickShop.Services
{
    public class HomeService : IHomeService
    {
        private readonly KickShopDbContext context;
        public HomeService(KickShopDbContext _context)
        {
            this.context = _context;
        }
        public async Task<List<Product>> GetFeaturedProducts()
        {
            return await context.Products.Take(3).ToListAsync();
        }
    }
}
