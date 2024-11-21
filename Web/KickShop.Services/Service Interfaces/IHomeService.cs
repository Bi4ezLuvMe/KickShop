using KickShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KickShop.Services.Service_Interfaces
{
    public interface IHomeService
    {
        Task<List<Product>> GetFeaturedProducts();
    }
}
