using WebShop.Core.Models;

namespace WebShop.Core.Contracts
{
    public interface IProductNoteService
    {
        Task AddProductNoteAsync(ProductNoteViewModel productNote, int productId);

        Task DeleteProductNoteAsync(int productId);
    }
}