#nullable disable
using ForumApp.Web.Migrations;
using ForumApp.Web.Model;
using ForumApp.Web.Models.Post;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ForumApp.Web.Controllers
{
    public class PostController : Controller
    {
        private readonly ForumDbContext context;

        public PostController(ForumDbContext context)
        {
            this.context = context;
        }

        public async Task<IActionResult> Index()
        {
            var posts = await context.Posts
                .Select(p => new PostViewModel()
                {
                    Id = p.Id,
                    Title = p.Title,
                    Content = p.Content
                })
                .ToListAsync();
            
            return View(posts);
        }

        public IActionResult Add() => View();

        [HttpPost]
        public async Task<IActionResult> Add(PostFormModel model)
        {
            var post = new Post()
            {
                Title = model.Title,
                Content = model.Content
            };

            await context.Posts.AddAsync(post);
            await context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(Guid id)
        {
            var post = await context.Posts.FindAsync(id);

            var model = new PostFormModel()
            {
                Title = post.Title,
                Content = post.Content
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Guid id, PostFormModel model)
        {
            var post = await context.Posts.FindAsync(id);

            post.Title = model.Title;
            post.Content = model.Content;

            await context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            var post = await context.Posts.FindAsync(id);

            context.Posts.Remove(post);
            await context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}