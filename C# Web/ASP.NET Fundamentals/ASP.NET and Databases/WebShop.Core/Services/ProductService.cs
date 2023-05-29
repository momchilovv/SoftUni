using Microsoft.EntityFrameworkCore;
using WebShop.Core.Contracts;
using WebShop.Core.Models;
using WebShop.Infrastructure.Model;

namespace WebShop.Core.Services
{
    public class ProductService : IProductService
    {
        private readonly WebShopDbContext context;

        public ProductService(WebShopDbContext context)
        {
            this.context = context;
        }

        public ProductViewModel GetProductAsync(int id)
        {
            return context.Products
                .Include(pn => pn.ProductNotes)
                .Where(p => p.Id == id)
                .Select(p => new ProductViewModel
                {
                    Id = p.Id,
                    ProductName = p.ProductName,
                    Quantity = p.Quantity,
                    Price = p.Price,
                    ProductNotes = p.ProductNotes
                })
                .First();
        }

        public async Task<List<ProductViewModel>> GetProductsAsync()
        {
            return await context.Products
                .Select(p => new ProductViewModel
                {
                    Id = p.Id,
                    ProductName = p.ProductName,
                    Quantity = p.Quantity,
                    Price = p.Price
                })
                .ToListAsync();
        }

        public async Task AddProductAsync(ProductViewModel model)
        {
            var product = new Product()
            {
                Id = model.Id,
                ProductName = model.ProductName,
                Quantity = model.Quantity,
                Price = model.Price,
                ProductNotes = model.ProductNotes
            };

            await context.Products.AddAsync(product);
            await context.SaveChangesAsync();
        }
      
        public async Task UpdateProductAsync(int id, ProductViewModel model)
        {
            var product = await context.Products.FindAsync(id);

            product!.ProductName = model.ProductName;
            product.Quantity = model.Quantity;
            product.Price = model.Price;

            await context.SaveChangesAsync();
        }

        public async Task DeleteProductAsync(int id)
        {
            var product = await context.Products.FindAsync(id);
            context.Products.Remove(product!);

            await context.SaveChangesAsync();
        }
    }
}