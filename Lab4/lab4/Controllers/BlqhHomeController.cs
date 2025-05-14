using System.Diagnostics;
using lab4.Models;
using Microsoft.AspNetCore.Mvc;

namespace lab4.Controllers
{
    public class BlqhHomeController : Controller
    {
        private readonly ILogger<BlqhHomeController> _logger;

        public BlqhHomeController(ILogger<BlqhHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult BlqhIndex()
        {
            return View();
        }

        public IActionResult BLqhAbout()
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
