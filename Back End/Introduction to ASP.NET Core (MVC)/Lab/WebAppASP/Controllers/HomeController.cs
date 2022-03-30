using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebAppASP.Models;

namespace WebAppASP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public ActionResult Files()
        {
            var path = @"C:\";
            var files = Directory
                .GetDirectories(path)
                .ToList();
            files.AddRange(Directory.GetFiles(path));

            return View(files);
        }

        public ActionResult NumbersN(int count = 5)
        {
            ViewBag.Count = count;
            return View();
        }

        public ActionResult Numbers()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Massage = "Your application description page.";
            return View();
        }

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
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
