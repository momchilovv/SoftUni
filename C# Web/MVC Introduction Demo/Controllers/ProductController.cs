using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using MVCIntroDemo.Models;
using System.Collections;
using System.Text;
using System.Text.Json;

namespace MVCIntroDemo.Controllers
{
    public class ProductController : Controller
    {
        private ICollection<ProductViewModel> products =
            new List<ProductViewModel>()
        {
                new ProductViewModel()
                {
                    Id = 1,
                    Name = "Cheese",
                    Price = 7.00m
                },

                new ProductViewModel()
                {
                    Id = 2,
                    Name = "Ham",
                    Price = 5.50m
                },

                new ProductViewModel()
                {
                    Id = 3,
                    Name = "Bread",
                    Price = 1.50m
                }
        };

        public IActionResult ById(int id)
        {
            var product = products.
                FirstOrDefault(p => p.Id == id);

            if (product == null)
            {
                return RedirectToAction("All");
            }

            return View(product);
        }

        public IActionResult AllAsJson()
        {
            return Json(products, new JsonSerializerOptions{ WriteIndented = true });
        }

        public IActionResult AllAsText()
        {
            var sb = new StringBuilder();

            foreach (var product in products)
            {
                sb.AppendLine($"Product {product.Id}: {product.Name} - {product.Price} lv.");
            }

            return Content(sb.ToString().Trim());
        }

        public IActionResult AllAsTextFile()
        {
            var sb = new StringBuilder();

            foreach (var product in products)
            {
                sb.AppendLine($"Product {product.Id}: {product.Name} - {product.Price} lv.");
            }
            
            Response.Headers.Add(HeaderNames.ContentDisposition,
                @"attachment;filename=products.txt");

            return File(Encoding.UTF8.GetBytes(sb.ToString().Trim()), "text/plain");
        }

        public IActionResult All(string keyword)
        {
            if (keyword != null)
            {
                var searchResult = products.Where(p => p.Name.ToLower().Contains(keyword.ToLower())).ToList();
                
                return View(searchResult);
            }
            return View(products);
        }
    }
}
