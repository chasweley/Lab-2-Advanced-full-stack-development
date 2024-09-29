using Labb_2_Avancerad_fullstackutveckling.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Labb_2_Avancerad_fullstackutveckling.Controllers
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
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Menu()
        {
            return View();
        }
        public IActionResult Admin()
        {
            return View();
        }
    }
}
