using ASP_NET_Core_Introduction.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace ASP_NET_Core_Introduction.Controllers
{
    public class ProductsController : Controller
    {
        private IEnumerable<ProductViewModel> products = new List<ProductViewModel>()
        {
            new ProductViewModel()
            {
                Id = 1,
                Name = "Cheese",
                Price = 7.00
            },

            new ProductViewModel()
            {
                Id = 2,
                Name = "Ham",
                Price = 5.50
            },

            new ProductViewModel()
            {
                Id = 3,
                Name = "Bread",
                Price = 1.50
            }
        };
        public IActionResult AllAsTextFile()
        {
            var text = string.Empty;

            foreach (var pr in products)
            {
                text += $"Product {pr.Id}: {pr.Name} - {pr.Price} lv.";
                text += "\r\n";
            }

            Response.Headers.Add(HeaderNames.ContentDisposition, @"attachment;filename=produts.text");

            return File(Encoding.UTF8.GetBytes(text), "text/plain");
        }

        public IActionResult AllAsText()
        {
            var text = string.Empty;

            foreach (var pr in products)
            {
                text += $"Product {pr.Id}: {pr.Name} - {pr.Price} lv.";
                text += "\r\n";
            }

            return Content(text);
        }

        public IActionResult AllAsJson()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };

            return Json(products, options);
        }

        public IActionResult ById(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);

            if (product == null)
            {
                return BadRequest();
            }

            return View(product);
        }

        [ActionName("My-Products")]
        public IActionResult All(string keyword)
        {
            if (keyword != null)
            {
                var foundProducts = products
                    .Where(pr => pr.Name.ToLower()
                        .Contains(keyword.ToLower()));

                return View(foundProducts);
            }
            return View(products);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
