using Microsoft.AspNetCore.Mvc;
using WebShop.Core.Contracts;
using WebShop.Core.Models;
using WebShop.Infrastructure.Model;

namespace WebShop.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }

        public async Task<IActionResult> Index()
        {
            var model = await productService.GetProductsAsync();

            return View(model);
        }

        public IActionResult Details(int id)
        {
            HttpContext.Session.SetInt32("ProductId", id);

            return View(productService.GetProductAsync(id));
        }

        public IActionResult Add() => View();

        [HttpPost]
        public async Task<IActionResult> Add(Product model)
        {
            var product = new ProductViewModel()
            {
                ProductName = model.ProductName,
                Quantity = model.Quantity,
                Price = model.Price
            };

            if (!ModelState.IsValid)
            {
                return View(product);
            }

            await productService.AddProductAsync(product);

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            var model = productService.GetProductAsync(id);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, ProductViewModel model)
        {
            await productService.UpdateProductAsync(id, model);

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            await productService.DeleteProductAsync(id);

            return RedirectToAction(nameof(Index));
        }
    }
}