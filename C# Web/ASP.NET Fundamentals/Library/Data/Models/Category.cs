#nullable disable
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static Library.Common.DataValidations.Category;

namespace Library.Data.Models
{
    [Comment("Book categories")]
    public class Category
    {
        [Key]
        [Comment("Primary key")]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        [Comment("Category name")]
        public string Name { get; set; }

        public ICollection<Book> Books = new List<Book>();
    }
}