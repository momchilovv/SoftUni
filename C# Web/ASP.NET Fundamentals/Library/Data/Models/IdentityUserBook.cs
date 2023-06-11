#nullable disable
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Data.Models
{
    [Comment("User books")]
    public class IdentityUserBook
    {
        [Key]
        [Comment("User Id")]
        public string CollectorId { get; set; }

        [ForeignKey(nameof(CollectorId))]
        [Comment("User")]
        public IdentityUser Collector { get; set; }

        [Key]
        [Comment("Book Id")]
        public int BookId { get; set; }

        [ForeignKey(nameof(BookId))]
        [Comment("Book")]
        public Book Book { get; set; }
    }
}