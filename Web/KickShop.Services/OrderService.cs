using KickShop.Data;
using KickShop.Models;
using KickShop.Services.Service_Interfaces;
using KickShop.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace KickShop.Services
{
    public class OrderService : IOrderService
    {
        private readonly KickShopDbContext context;

        public OrderService(KickShopDbContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<OrderViewModel>> GetAllOrdersAsync()
        {
            var orders = await context.Orders
                .Include(o => o.CustomerOrders)
                .ThenInclude(co => co.Customer)
                .ToListAsync();

            return orders.Select(order => new OrderViewModel
            {
                OrderId = order.OrderId,
                OrderDate = order.OrderDate,
                TotalAmount = order.TotalAmount,
                CustomerEmail = order.CustomerOrders.FirstOrDefault()?.Customer.Email,
                BillingName = order.BillingName,
                BillingAddress = order.BillingAddress,
                BillingCity = order.BillingCity,
                BillingPostalCode = order.BillingPostalCode,
            });
        }

        public async Task<OrderConfirmationViewModel> GetOrderConfirmationAsync(Guid orderId)
        {
            var order = await context.Orders.FindAsync(orderId);

            if (order == null)
                throw new KeyNotFoundException("Order not found!");

            return new OrderConfirmationViewModel
            {
                OrderId = order.OrderId,
                OrderDate = order.OrderDate,
                TotalAmount = order.TotalAmount
            };
        }

        public async Task DeleteOrderAsync(Guid id)
        {
            var order = await context.Orders.FindAsync(id);
            if (order == null)
                throw new KeyNotFoundException("Order not found!");

            var customerOrders = context.CustomersOrders.Where(co => co.OrderId == id);
            context.CustomersOrders.RemoveRange(customerOrders);

            context.Orders.Remove(order);
            await context.SaveChangesAsync();
        }
    }
}
