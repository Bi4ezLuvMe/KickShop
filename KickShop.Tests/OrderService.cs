using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using Microsoft.EntityFrameworkCore;
using KickShop.Services;
using KickShop.Models;
using KickShop.Data;
using KickShop.ViewModels;

namespace KickShop.Tests
{
    [TestFixture]
    public class OrderServiceTests
    {
        private DbContextOptions<KickShopDbContext> _options;

        [SetUp]
        public void Setup()
        {
            _options = new DbContextOptionsBuilder<KickShopDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;
        }

        [Test]
        public async Task GetOrderConfirmationAsync_ThrowsKeyNotFoundException_WhenOrderDoesNotExist()
        {
            using var context = new KickShopDbContext(_options);
            var orderService = new OrderService(context);

            await context.SaveChangesAsync();

            var exception = Assert.ThrowsAsync<KeyNotFoundException>(() =>
                orderService.GetOrderConfirmationAsync(Guid.NewGuid()));

            Assert.AreEqual("Order not found!", exception.Message);
        }

        [Test]
        public async Task GetAllOrdersAsync_ReturnsAllOrders()
        {
            using var context = new KickShopDbContext(_options);
            var orderService = new OrderService(context);

            var order1 = new Order { OrderId = Guid.NewGuid(), TotalAmount = 100,BillingAddress="Temp Address",BillingCity="Kn",BillingName="Luboslav",BillingPostalCode="2500" };
            var order2 = new Order { OrderId = Guid.NewGuid(), TotalAmount = 200, BillingAddress = "Temp Address", BillingCity = "Kn", BillingName = "Luboslav", BillingPostalCode = "2500" };

            context.Orders.Add(order1);
            context.Orders.Add(order2);
            await context.SaveChangesAsync();

            var orders = await orderService.GetAllOrdersAsync();
            orders = orders.Where(o => o.OrderId == order1.OrderId || o.OrderId == order2.OrderId);

            Assert.AreEqual(2, orders.Count());
        }

        [Test]
        public async Task DeleteOrderAsync_DeletesOrderSuccessfully()
        {
            using var context = new KickShopDbContext(_options);
            var orderService = new OrderService(context);

            var order = new Order
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

            var deletedOrder = await context.Orders.FirstOrDefaultAsync(o => o.OrderId == order.OrderId&&!o.IsDeleted);
            Assert.Null(deletedOrder);
        }
    }
}
