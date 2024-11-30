using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using KickShop.Services;
using KickShop.Models;
using KickShop.Data;
using KickShop.ViewModels;

namespace KickShop.Tests
{
    [TestFixture]
    public class OrderServiceTests
    {
        private DbContextOptions<KickShopDbContext> options;

        [SetUp]
        public void Setup()
        {
            options = new DbContextOptionsBuilder<KickShopDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;
        }

        [Test]
        public async Task GetOrderConfirmationAsync_ThrowsKeyNotFoundException_WhenOrderDoesNotExist()
        {
            using KickShopDbContext context = new KickShopDbContext(options);
            OrderService orderService = new OrderService(context);

            await context.SaveChangesAsync();

            KeyNotFoundException exception = Assert.ThrowsAsync<KeyNotFoundException>(() =>
                orderService.GetOrderConfirmationAsync(Guid.NewGuid()));

            Assert.AreEqual("Order not found!", exception.Message);
        }

        [Test]
        public async Task GetAllOrdersAsync_ReturnsAllOrders()
        {
            using KickShopDbContext context = new KickShopDbContext(options);
            OrderService orderService = new OrderService(context);

            Order order1 = new Order
            {
                OrderId = Guid.NewGuid(),
                TotalAmount = 100,
                BillingAddress = "Temp Address",
                BillingCity = "Kn",
                BillingName = "Luboslav",
                BillingPostalCode = "2500"
            };

            Order order2 = new Order
            {
                OrderId = Guid.NewGuid(),
                TotalAmount = 200,
                BillingAddress = "Temp Address",
                BillingCity = "Kn",
                BillingName = "Luboslav",
                BillingPostalCode = "2500"
            };

            context.Orders.Add(order1);
            context.Orders.Add(order2);
            await context.SaveChangesAsync();

            IEnumerable<OrderViewModel> orders = await orderService.GetAllOrdersAsync();
            orders = orders.Where(o => o.OrderId == order1.OrderId || o.OrderId == order2.OrderId).ToList();

            Assert.AreEqual(2, orders.Count());
        }

        [Test]
        public async Task DeleteOrderAsync_DeletesOrderSuccessfully()
        {
            using KickShopDbContext context = new KickShopDbContext(options);
            OrderService orderService = new OrderService(context);

            Order order = new Order
            {
                OrderId = Guid.NewGuid(),
                TotalAmount = 100,
                BillingAddress = "Temp Address",
                BillingCity = "Kn",
                BillingName = "Luboslav",
                BillingPostalCode = "2500"
            };

            context.Orders.Add(order);
            await context.SaveChangesAsync();

            await orderService.DeleteOrderAsync(order.OrderId);

            Order deletedOrder = await context.Orders.FirstOrDefaultAsync(o => o.OrderId == order.OrderId && !o.IsDeleted);
            Assert.Null(deletedOrder);
        }
    }
}
