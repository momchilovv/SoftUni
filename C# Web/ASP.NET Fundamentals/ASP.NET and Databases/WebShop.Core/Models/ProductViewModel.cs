using System.ComponentModel.DataAnnotations;
using WebShop.Infrastructure.Model;

namespace WebShop.Core.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The product name cannot be empty or more than 50 characters!")]
        public string ProductName { get; set; } = null!;

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Quantity cannot be a negative or 0!")]
        public int Quantity { get; set; }

        public decimal? Price { get; set; }

        public List<ProductNote> ProductNotes { get; set; } = new List<ProductNote>();
    }
}