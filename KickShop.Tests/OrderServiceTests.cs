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
using KickShop.Services.Service_Interfaces;
using Castle.Core.Resource;

namespace KickShop.Tests
{
    [TestFixture]
    public class OrderServiceTests
    {
        private DbContextOptions<KickShopDbContext> options;
        private KickShopDbContext context;
        private IOrderService orderService;

        [SetUp]
        public void Setup()
        {
            options = new DbContextOptionsBuilder<KickShopDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            context = new KickShopDbContext(options);

            orderService = new OrderService(context);
        }

        [TearDown]
        public void TearDown()
        {
            context.Database.EnsureDeleted();
            context.Dispose();
        }

        [Test]
        public async Task GetOrderConfirmationAsyncThrowsWhenOrderDoesNotExist()
        {
            KeyNotFoundException exception = Assert.ThrowsAsync<KeyNotFoundException>(() =>
                orderService.GetOrderConfirmationAsync(Guid.NewGuid()));

            Assert.AreEqual("Order not found!", exception.Message);
        }

        [Test]
        public async Task GetOrderConfirmationAsyncReturnsCorrectOrderDetails()
        {
            Order order = new Order
            {
                OrderId = Guid.NewGuid(),
                OrderDate = DateTime.Now.ToString(),
                TotalAmount = 250,
                BillingAddress = "asdfasdfasdf",
                BillingCity = "asdfasdfasdfa",
                BillingName = "ASDFF",
                BillingPostalCode = "2500",
                Status = "SENTTT"
            };

            context.Orders.Add(order);
            await context.SaveChangesAsync();

            OrderConfirmationViewModel result = await orderService.GetOrderConfirmationAsync(order.OrderId);

            Assert.NotNull(result);
            Assert.AreEqual(order.OrderId, result.OrderId);
            Assert.AreEqual(order.TotalAmount, result.TotalAmount);
        }

        [Test]
        public async Task GetOrderConfirmationAsyncThrowsForInvalidGuid()
        {
            Assert.ThrowsAsync<KeyNotFoundException>(async () =>
            {
                await orderService.GetOrderConfirmationAsync(Guid.Empty);
            });
        }

        [Test]
        public async Task GetAllOrdersAsyncReturnsAllOrders()
        {
            Order order1 = new Order
            {
                OrderId = Guid.NewGuid(),
                TotalAmount = 100,
                BillingAddress = "Temp Address",
                BillingCity = "Kn",
                BillingName = "Luboslav",
                BillingPostalCode = "2500",
                Status = "Sent"
            };

            Order order2 = new Order
            {
                OrderId = Guid.NewGuid(),
                TotalAmount = 200,
                BillingAddress = "Temp Address",
                BillingCity = "Kn",
                BillingName = "Luboslav",
                BillingPostalCode = "2500",
                Status = "Sent"
            };

            context.Orders.Add(order1);
            context.Orders.Add(order2);
            await context.SaveChangesAsync();

            IEnumerable<OrderViewModel> orders = await orderService.GetAllOrdersAsync();

            Assert.AreEqual(2, orders.Count());
        }

        [Test]
        public async Task GetAllOrdersAsyncReturnsEmptyWhenNoOrdersExist()
        {
            IEnumerable<OrderViewModel> orders = await orderService.GetAllOrdersAsync();

            Assert.IsEmpty(orders);
        }
        [Test]
        public async Task DeleteOrderAsyncDeletesOrderSuccessfully()
        {
            Order order = new Order
            {
                OrderId = Guid.NewGuid(),
                TotalAmount = 100,
                BillingAddress = "Temp Address",
                BillingCity = "Kn",
                BillingName = "Luboslav",
                BillingPostalCode = "2500",
                Status = "Sent"
            };

            context.Orders.Add(order);
            await context.SaveChangesAsync();

            await orderService.DeleteOrderAsync(order.OrderId);

            Order deletedOrder = await context.Orders.FirstOrDefaultAsync(o => o.OrderId == order.OrderId);
            Assert.Null(deletedOrder);
        }

        [Test]
        public void DeleteOrderAsyncThrowsWhenOrderNotFound()
        {
            Assert.ThrowsAsync<KeyNotFoundException>(async () =>
            {
                await orderService.DeleteOrderAsync(Guid.NewGuid());
            });
        }

        [Test]
        public async Task DeleteOrderAsyncRemovesAssociatedCustomerOrders()
        {
            Order order = new Order
            {
                OrderId = Guid.NewGuid(),
                TotalAmount = 150,
                BillingAddress = "Test Address",
                BillingCity = "Test City",
                BillingName = "Test Name",
                BillingPostalCode = "12345",
                Status = "Pending",
            };

            context.Orders.Add(order);
            await context.SaveChangesAsync();

            await orderService.DeleteOrderAsync(order.OrderId);

            bool hasCustomerOrders = context.CustomersOrders.Any(co => co.OrderId == order.OrderId);
            Assert.IsFalse(hasCustomerOrders);
        }
    }
}
