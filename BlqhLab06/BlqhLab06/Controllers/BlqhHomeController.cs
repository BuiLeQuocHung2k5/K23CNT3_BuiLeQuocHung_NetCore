using System.Diagnostics;
using BlqhLab06.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlqhLab06.Controllers
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

        public IActionResult BlqhAbout()
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
