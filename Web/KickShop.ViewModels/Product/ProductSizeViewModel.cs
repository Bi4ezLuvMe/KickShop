using KickShop.Models.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KickShop.ViewModels.Product
{
    public class ProductSizeViewModel
    {
        public string Size { get; set; } = null!;
        public int Quantity { get; set; }
        public bool IsSelected { get; set; }
        public bool IsValid()
        {
            return IsSelected && Quantity > 0;
        }
    }
}
