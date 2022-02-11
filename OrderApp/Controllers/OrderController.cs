using BusinessServices.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace OrderApp.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        public IActionResult Index()
        {
            var order = _orderService.GetAll();
            return View(order);
        }
    }
}
