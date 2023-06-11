#nullable disable
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static Library.Common.DataValidations.Book;

namespace Library.Data.Models
{
    [Comment("Available books for users")]
    public class Book
    {
        [Key]
        [Comment("Primary key")]
        public int Id { get; set; }

        [Required]
        [MaxLength(TitleMaxLength)]
        [Comment("Book title")]
        public string Title { get; set; }

        [Required]
        [MaxLength(AuthorMaxLength)]
        [Comment("Author of book")]
        public string Author { get; set; }

        [Required]
        [MaxLength(DescriptionMaxLength)]
        [Comment("Description of a book")]
        public string Description { get; set; }

        [Required]
        [Comment("Url of book's image")]
        public string ImageUrl { get; set; }

        [Required]
        [Range(RatingMinValue, RatingMaxValue)]
        [Comment("Book's rating")]
        public decimal Rating { get; set; }

        [Required]
        [Comment("Category Id")]
        public int CategoryId { get; set; }

        [Required]
        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; }

        public ICollection<IdentityUser> UsersBooks = new List<IdentityUser>();
    }
}