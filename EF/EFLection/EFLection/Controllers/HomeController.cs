using EFLection.Entities;
using EFLection.Models;
using EFLection.Service;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EFLection.Controllers
{
    public class HomeController : Controller
    {
        private readonly DbService _service;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, DbService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpPost("test")]
        public async Task<IActionResult> Index()
        {
            await _service.AddAsync(new User
            {
                FullName = "Fikus",
                Salary = 0
            });
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