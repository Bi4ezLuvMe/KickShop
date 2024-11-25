using KickShop.Services.Service_Interfaces;
using Microsoft.AspNetCore.Mvc;

public class OrderController : Controller
{
    private readonly IOrderService orderService;

    public OrderController(IOrderService orderService)
    {
        this.orderService = orderService;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var orders = await orderService.GetAllOrdersAsync();
        return View(orders);
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
