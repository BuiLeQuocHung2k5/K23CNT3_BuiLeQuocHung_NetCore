using System.Diagnostics;
using BlqhLesson05.Models;
using BlqhLesson05.Models.DataModels;
using Microsoft.AspNetCore.Mvc;

namespace BlqhLesson05.Controllers
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
            BlqhMember blqhMember = new BlqhMember();
            blqhMember.BlqhMemberId = Guid.NewGuid().ToString();
            blqhMember.BlqhUserName = "BLQHung";
            blqhMember.BlqhPassword = "12345";
            blqhMember.BlqhFullname = "Bui Le Quoc Hung";
            blqhMember.BlqhEmail = "quochungb3@gmail.com";
            return View(blqhMember);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
