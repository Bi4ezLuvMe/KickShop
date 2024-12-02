using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KickShop.ViewModels.Order;

namespace KickShop.ViewModels.Cart
{
    public class CheckoutViewModel
    {
        public int ProductCount { get; set; }
        public decimal TotalPrice { get; set; }
        public BillingAddressViewModel BillingAddress { get; set; } = null!;
    }
}
