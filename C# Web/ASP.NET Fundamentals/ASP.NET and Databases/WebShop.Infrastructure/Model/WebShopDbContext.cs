using Microsoft.EntityFrameworkCore;

namespace WebShop.Infrastructure.Model
{
    public class WebShopDbContext : DbContext
    {
        public WebShopDbContext(DbContextOptions<WebShopDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductNote> ProductNotes { get; set; }
    }
}