#nullable disable
using System.ComponentModel.DataAnnotations;
using static ForumApp.Web.Constants.ValidationDbConstants.Post;

namespace ForumApp.Web.Models.Post
{
    public class PostFormModel
    {
        public Guid Id { get; set; }


        [Required]
        [StringLength(MaxTitleLength, MinimumLength = MinTitleLength)]
        public string Title { get; set; }

        [Required]
        [StringLength(MaxContentLength, MinimumLength = MinContentLength)]
        public string Content { get; set; }
    }
}