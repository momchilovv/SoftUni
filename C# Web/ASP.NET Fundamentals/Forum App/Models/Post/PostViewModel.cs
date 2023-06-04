#nullable disable

namespace ForumApp.Web.Models.Post
{
    public class PostViewModel
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }
    }
}