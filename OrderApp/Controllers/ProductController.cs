using BusinessServices.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace OrderApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Index()
        {
            var Products = _productService.GetAll();
            return View(Products);
        }

    }
}
