using KickShop.Data;
using KickShop.Models;
using KickShop.Services.Service_Interfaces;
using KickShop.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using X.PagedList;
using X.PagedList.Extensions;
using static KickShop.Common.ModelConstants;

namespace KickShop.Services
{
    public class OrderService : IOrderService
    {
        private readonly KickShopDbContext context;

        public OrderService(KickShopDbContext context)
        {
            this.context = context;
        }

        public async Task<IPagedList<OrderViewModel>> GetAllOrdersAsync(int pageSize = 10,int pageNumber = 1)
        {
            List<OrderViewModel> orders = await context.Orders
                .Include(o => o.CustomerOrders)
                .ThenInclude(co => co.Customer)
                .Select(order => new OrderViewModel
                {
                    OrderId = order.OrderId,
                    OrderDate = order.OrderDate,
                    TotalAmount = order.TotalAmount,
                    CustomerEmail = order.CustomerOrders.FirstOrDefault().Customer.Email,
                    BillingName = order.BillingName,
                    BillingAddress = order.BillingAddress,
                    BillingCity = order.BillingCity,
                    BillingPostalCode = order.BillingPostalCode,
                })
                .ToListAsync();

            IPagedList<OrderViewModel> paginatedOrders = orders.ToPagedList(pageNumber,pageSize);

            return paginatedOrders;
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

        public async Task<List<OrderViewModel>> GetAllOrdersAsync()
        {
            return await context.Orders
                 .Include(o => o.CustomerOrders)
                 .ThenInclude(co => co.Customer)
                 .Select(order => new OrderViewModel
                 {
                     OrderId = order.OrderId,
                     OrderDate = order.OrderDate,
                     TotalAmount = order.TotalAmount,
                     CustomerEmail = order.CustomerOrders.FirstOrDefault().Customer.Email,
                     BillingName = order.BillingName,
                     BillingAddress = order.BillingAddress,
                     BillingCity = order.BillingCity,
                     BillingPostalCode = order.BillingPostalCode,
                 })
                 .ToListAsync();
        }
    }
}
