using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Abc.Northwind.Mvc.WebUI.Models;
using Abc.Northwind.Buisiness.Abstract;

namespace Abc.Northwind.Mvc.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IProductService _productService;

        public HomeController(ILogger<HomeController> logger,IProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }

        public IActionResult Index(int page=1,int category=0)
        {
            int pageSize = 10;

            var products=_productService.GetByCategory(category);
            ProductListViewModel model = new ProductListViewModel
            {
                Products = products.Skip(pageSize*(page-1)).Take(pageSize).ToList(),
            };
            return View(model);
        }
        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
