using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using TaskBoardApp.Core.Models.Home;
using TaskBoardApp.Data;

namespace TaskBoardApp.Web.Controllers
{
    public class HomeController : BaseController
    {
        private readonly TaskBoardDbContext dbContext;

        public HomeController(TaskBoardDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var tasks = new List<HomeBoardModel>();

            var boards = await dbContext.Boards
                .Select(b => b.Name)
                .Distinct()
                .ToListAsync();

            foreach (var board in boards)
            {
                var taskInBoard = dbContext.Tasks.Where(t => t.Board!.Name == board).Count();
                
                tasks.Add(new HomeBoardModel()
                {
                    BoardName = board,
                    TasksCount = taskInBoard
                });
            }

            var userTaskCount = -1;

            if (User.Identity!.IsAuthenticated)
            {
                userTaskCount = dbContext.Tasks.Where(t => t.OwnerId == User.FindFirstValue(ClaimTypes.NameIdentifier)).Count();
            }

            var model = new HomeViewModel()
            {
                AllTasksCount = dbContext.Tasks.Count(),
                BoardsTasksCount = tasks,
                UserTasksCount = userTaskCount
            };

            return View(model);
        }
    }
}