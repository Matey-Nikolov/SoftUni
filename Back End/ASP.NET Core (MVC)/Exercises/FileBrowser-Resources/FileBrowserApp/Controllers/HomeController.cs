using FileBrowserApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FileBrowserApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public FileResult DownLoadFile(string path)
        {
            byte[] bytes = System.IO.File.ReadAllBytes(path);
            FileInfo fileInfo = new FileInfo(path);

            return File(bytes, "application/octet-stream", fileInfo.Name;
        }
        public IActionResult Files(string path = @"C:\")
        {
            var parentDir = Directory.GetParent(path);

            var model = new FilesFolderModel()
            {
                ParentFolder = parentDir?.FullName,
                Folders = Directory.GetDirectories(path).ToArray(),
                Files = Directory.GetFiles(path).ToArray()
            };

            return View(model);
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
