using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace WebShop.Infrastructure.Model
{
    [Comment("Product table.")]
    public class Product
    {
        [Key]
        [Comment("Product id.")]
        public int Id { get; set; }

        [Required(ErrorMessage = "The product name cannot be empty or more than 50 characters.")]
        [MaxLength(50)]
        [Comment("Product name.")]
        public string ProductName { get; set; } = null!;

        [Required(ErrorMessage = "Quantity cannot be a negative or 0")]
        [Comment("Product quantity.")]
        public int Quantity { get; set; }

        [Comment("Product price.")]
        public decimal? Price { get; set; } 

        public List<ProductNote> ProductNotes { get; set; } = new List<ProductNote>();
    }
}