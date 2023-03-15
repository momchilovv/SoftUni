using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace P03_SalesDatabase.Data.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [MaxLength(100)]
        [Unicode(true)]
        public string Name { get; set; } = null!;

        [MaxLength(80)]
        [Unicode(false)]
        public string Email { get; set; } = null!;

        public string CreditCardNumber { get; set; } = null!;

        public ICollection<Sale> Sales { get; set; } = null!;
    }
}