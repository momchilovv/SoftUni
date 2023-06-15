using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TaskBoardApp.Core.Contracts;
using TaskBoardApp.Core.Models.Task;

namespace TaskBoardApp.Web.Controllers
{
    public class TaskController : BaseController
    {
        private readonly ITaskService taskService;

        public TaskController(ITaskService taskService)
        {
            this.taskService = taskService;
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var taskModel = new TaskFormModel
            {
                Boards = await taskService.GetBoardsAsync()
            };

            return View(taskModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TaskFormModel model)
        {
            var boards = await taskService.GetBoardsAsync();

            if (!ModelState.IsValid)
            {
                model.Boards = await taskService.GetBoardsAsync();

                return View(model);
            }

            if (!boards.Any(b => b.Id == model.BoardId))
            {
                ModelState.AddModelError(nameof(model.BoardId), "Board does not exist!");
            }

            model.OwnerId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            await taskService.CreateTaskAsync(model);

            return RedirectToAction("All", "Board");
        }

        [HttpGet]
        #pragma warning disable CS1998
        public async Task<IActionResult> Edit(int id)
        #pragma warning restore CS1998
        {
            var model = taskService.GetTaskFormModel(id);

            if (User.FindFirstValue(ClaimTypes.NameIdentifier) != model.OwnerId)
            {
                return Unauthorized();
            }

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, TaskFormModel model)
        {
            if (!taskService.GetBoardsAsync().Result.Any(b => b.Id == model.BoardId))
            {
                ModelState.AddModelError(nameof(model.BoardId), "Board does not exist!");
            }

            if (!ModelState.IsValid)
            {
                model.Boards = taskService.GetBoardsAsync().Result;

                return View(model);
            }

            await taskService.EditTaskAsync(id, model);

            return RedirectToAction("All", "Board");
        }

        public IActionResult Details(int id)
        {
            var task = taskService.GetTaskDetails(id);

            if (task == null)
            {
                return BadRequest();
            }

            return View(task);
        }

        [HttpGet]
        #pragma warning disable CS1998
        public async Task<IActionResult> Delete(int id)
        #pragma warning restore CS1998
        {
            var model = taskService.GetTaskDetails(id);

            if (model.OwnerId != User.FindFirstValue(ClaimTypes.NameIdentifier))
            {
                return Unauthorized();
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(TaskDetailsViewModel model)
        {
            await taskService.DeleteTaskAsync(model.Id);

            return RedirectToAction("All", "Board");
        }
    }
}