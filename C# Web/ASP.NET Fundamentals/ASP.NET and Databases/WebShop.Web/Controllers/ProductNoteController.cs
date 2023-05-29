using Microsoft.AspNetCore.Mvc;
using WebShop.Core.Contracts;
using WebShop.Core.Models;
using WebShop.Core.Services;
using WebShop.Infrastructure.Model;

namespace WebShop.Web.Controllers
{
    [Route("Product/ProductNote")]
    public class ProductNoteController : Controller
    {
        private readonly IProductNoteService productNoteService;

        public ProductNoteController(IProductNoteService productNoteService)
        {
            this.productNoteService = productNoteService;
        }

        [HttpGet]
        public IActionResult Index() => View();

        [HttpPost]
        public async Task<IActionResult> Index(ProductNoteViewModel productNote)
        {
            int productId = (int)HttpContext.Session.GetInt32("ProductId")!;

            var note = new ProductNoteViewModel()
            {
                Note = productNote.Note,
                NoteDate = productNote.NoteDate,
                ProductId = productId
            };

            if (!ModelState.IsValid)
            {
                return View(note);
            }

            await productNoteService.AddProductNoteAsync(note, productId);

            return Redirect($"/Product/Details/{productId}");
        }

        [HttpPost("Delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            int productId = (int)HttpContext.Session.GetInt32("ProductId")!;

            await productNoteService.DeleteProductNoteAsync(id);

            return Redirect($"/Product/Details/{productId}");
        }
    }
}