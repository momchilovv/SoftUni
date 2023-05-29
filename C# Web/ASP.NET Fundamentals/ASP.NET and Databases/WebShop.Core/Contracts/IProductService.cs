using WebShop.Core.Models;

namespace WebShop.Core.Contracts
{
    public interface IProductService
    {
        Task<List<ProductViewModel>> GetProductsAsync();

        ProductViewModel GetProductAsync(int id);

        Task AddProductAsync(ProductViewModel product);
        
        Task UpdateProductAsync(int id, ProductViewModel product);

        Task DeleteProductAsync(int id);
    }
}