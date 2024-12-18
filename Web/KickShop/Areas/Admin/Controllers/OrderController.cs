using KickShop.Services.Service_Interfaces;
using KickShop.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace KickShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,Manager")]
    public class OrderController : Controller
    {
        private readonly IOrderService orderService;

        public OrderController(IOrderService orderService)
        {
            this.orderService = orderService;
        }

        [HttpGet]
        public async Task<IActionResult> Index(int? page)
        {
            int pageSize = 5;
            int pageNumber = page ?? 1;
            IPagedList<OrderViewModel> paginatedOrders = await orderService.GetAllOrdersAsync(pageSize, pageNumber);
            return View(paginatedOrders);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                await orderService.DeleteOrderAsync(id);
                TempData["Message"] = "Order deleted successfully!";
            }
            catch (KeyNotFoundException ex)
            {
                TempData["Message"] = ex.Message;
            }

            return RedirectToAction(nameof(Index));
        }
    }

}
