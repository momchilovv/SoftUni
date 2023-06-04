#nullable disable
using static ForumApp.Web.Constants.ValidationDbConstants.Post;
using System.ComponentModel.DataAnnotations;

namespace ForumApp.Web.Model
{
    public class Post
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(MaxTitleLength)]
        public string Title { get; set; }

        [Required]
        [MaxLength(MaxContentLength)]
        public string Content { get; set; }
    }
}