using ASP_NET_Core_Introduction.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text.Json;

namespace ASP_NET_Core_Introduction.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public ActionResult Numbers_1_N(int count = 3)
        {
            ViewBag.Count = count;
            return View();
        }
        public ActionResult Numbers1_50()
        {
            return View();
        }
        public IActionResult About()
        {
            ViewBag.Massage = "This is an ASP.NET Core MVC app.";
            return View();
        }
        public IActionResult Index()
        {
            ViewBag.Massage = "Hello World";
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