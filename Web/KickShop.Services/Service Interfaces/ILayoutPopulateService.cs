using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KickShop.Services.Service_Interfaces
{
    public interface ILayoutPopulateService
    {
        Task<List<string>> GetCategoriesAsync();
        Task<List<string>> GetBrandsAsync();
    }
}
