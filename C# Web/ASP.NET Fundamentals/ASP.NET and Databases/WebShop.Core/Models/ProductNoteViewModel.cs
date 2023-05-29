using System.ComponentModel.DataAnnotations;

namespace WebShop.Core.Models
{
    public class ProductNoteViewModel
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(500)]
        public string Note { get; set; } = null!;

        [Required]
        public DateTime NoteDate { get; set; }

        [Required]
        public int ProductId { get; set; }
    }
}