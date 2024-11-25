using KickShop.Data;
using KickShop.Models;
using KickShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KickShop.Controllers
{
    public class OrderController : Controller
    {
        private readonly KickShopDbContext context;

        public OrderController(KickShopDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var orders = await context.Orders
                .Include(o => o.CustomerOrders)
                .ThenInclude(co => co.Customer)
                .ToListAsync();

            var orderList = orders.Select(order => new OrderViewModel
            {
                OrderId = order.OrderId,
                OrderDate = order.OrderDate,
                TotalAmount = order.TotalAmount,
                CustomerEmail = order.CustomerOrders.FirstOrDefault(co=>co.OrderId==order.OrderId).Customer.Email,
                BillingName = order.BillingName,
                BillingAddress = order.BillingAddress,
                BillingCity = order.BillingCity,
                BillingPostalCode = order.BillingPostalCode,
            }).ToList();

            return View(orderList);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(Guid id)
        {
            var order = await context.Orders.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }

            var customerOrders = context.CustomersOrders.Where(co => co.OrderId == id);
            foreach (CustomerOrder co in customerOrders)
            {
                co.IsDeleted = true;
            }

           order.IsDeleted = true;

            await context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

    }
}
