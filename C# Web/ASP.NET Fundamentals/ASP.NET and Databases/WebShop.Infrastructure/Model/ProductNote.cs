using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebShop.Infrastructure.Model
{
    [Comment("Product note.")]
    public class ProductNote
    {
        [Key]
        [Comment("Product note id.")]
        public int Id { get; set; }

        [Required]
        [MaxLength(500)]
        [Comment("Product note text.")]
        public string Note { get; set; } = null!;

        [Required]
        [Comment("Product note date.")]
        public DateTime NoteDate { get; set; }

        [Required]
        [Comment("Product id of the product note.")]
        public int ProductId { get; set; }

        [ForeignKey(nameof(ProductId))]
        [Comment("Product of the product note.")]
        public Product Product { get; set; } = null!;
    }
}