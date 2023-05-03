using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvcApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MvcApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View("Login");
        }

        public IActionResult Sum(SumModel model)
        {
            model.result = model.num + model.num2;
            return View(model);
        }
        
        public IActionResult Login()
        {
            string username = this.Request.Form["username"];
            string password = this.Request.Form["Pass"];
            if (username == "user" && password == "1234")
            {
                return Redirect("https://google.com");
            }
            else
            {
                return Content("Login failed");
            }
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
