using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P03_SalesDatabase.Data.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [MaxLength(50)]
        [Unicode(true)]
        public string Name { get; set; } = null!;
    
        public double Quantity { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        public ICollection<Sale> Sales { get; set; } = null!;
    }
}