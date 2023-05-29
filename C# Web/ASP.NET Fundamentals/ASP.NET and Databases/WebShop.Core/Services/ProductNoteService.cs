using WebShop.Core.Contracts;
using WebShop.Core.Models;
using WebShop.Infrastructure.Model;

namespace WebShop.Core.Services
{
    public class ProductNoteService : IProductNoteService
    {
        private readonly WebShopDbContext context;

        public ProductNoteService(WebShopDbContext context)
        {
            this.context = context;
        }

        public async Task AddProductNoteAsync(ProductNoteViewModel productNote, int productId)
        {
            var note = new ProductNote
            {
                Note = productNote.Note,
                NoteDate = productNote.NoteDate,
                ProductId = productId,
            };

            var product = context.Products.Find(note.ProductId);

            product!.ProductNotes.Add(note);

            await context.ProductNotes.AddAsync(note);
            await context.SaveChangesAsync();
        }

        public async Task DeleteProductNoteAsync(int productId)
        {
            var productNote = await context.ProductNotes.FindAsync(productId);
            context.ProductNotes.Remove(productNote!);

            await context.SaveChangesAsync();
        }
    }
}