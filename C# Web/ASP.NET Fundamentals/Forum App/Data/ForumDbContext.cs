#nullable disable
using ForumApp.Web.Model;
using Microsoft.EntityFrameworkCore;

namespace ForumApp.Web
{
    public class ForumDbContext : DbContext
    {
        private Post FirstPost { get; set; }
        private Post SecondPost { get; set; }
        private Post ThirdPost { get; set; }

        public ForumDbContext(DbContextOptions<ForumDbContext> options) : base(options) { }

        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SeedDatabase();
            modelBuilder.Entity<Post>()
                .HasData(FirstPost, SecondPost, ThirdPost);

            base.OnModelCreating(modelBuilder);
        }

        private void SeedDatabase()
        {
            FirstPost = new Post()
            {
                Id = Guid.NewGuid(),
                Title = "This is the first post",
                Content = "Using this to seed the database can be really useful."
            };

            SecondPost = new Post()
            {
                Id = Guid.NewGuid(),
                Title = "This is the second post",
                Content = "Especially when you have large number of example data."
            };

            ThirdPost = new Post()
            {
                Id = Guid.NewGuid(),
                Title = "This is the third post",
                Content = "Adding data manually can be really boring and could take a lot of time!"
            };
        }
    }
}