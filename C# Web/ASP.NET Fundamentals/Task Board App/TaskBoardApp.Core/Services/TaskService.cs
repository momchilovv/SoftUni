using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskBoardApp.Core.Contracts;
using TaskBoardApp.Core.Models.Task;
using TaskBoardApp.Data;
using Task = TaskBoardApp.Data.Models.Task;

namespace TaskBoardApp.Core.Services
{
    public class TaskService : ITaskService
    {
        private readonly TaskBoardDbContext dbContext;

        public TaskService(TaskBoardDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public TaskDetailsViewModel GetTaskDetails(int id)
        {
            var task = dbContext.Tasks
                .Where(t => t.Id == id)
                .Select(t => new TaskDetailsViewModel()
                {
                    Id = t.Id,
                    Title = t.Title,
                    Description = t.Description,
                    CreatedOn = t.CreatedOn.ToString("dd/MM/yyyy HH:mm"),
                    Board = t.Board!.Name,
                    Owner = t.Owner.UserName,
                    OwnerId = t.Owner.Id
                })
                .FirstOrDefault();

            return task!;
        }

        public TaskFormModel GetTaskFormModel(int id)
        {
            return dbContext.Tasks
                .Where(t => t.Id == id)
                .Select(t => new TaskFormModel()
                {
                    Title = t.Title,
                    Description = t.Description,
                    OwnerId = t.OwnerId,
                    Boards = dbContext.Boards
                                .Select(b => new TaskBoardModel()
                                {
                                    Id = b.Id,
                                    Name = b.Name
                                }).ToList()
                })
                .First();
        }

        public async System.Threading.Tasks.Task CreateTaskAsync(TaskFormModel model)
        {
            var task = new Task()
            {
                Title = model.Title,
                Description = model.Description,
                CreatedOn = DateTime.Now,
                BoardId = model.BoardId,
                OwnerId = model.OwnerId
            };

            await dbContext.Tasks.AddAsync(task);
            await dbContext.SaveChangesAsync();
        }
        public async Task<IEnumerable<TaskBoardModel>> GetBoardsAsync()
        {
            return await dbContext.Boards
                .Select(b => new TaskBoardModel
                {
                    Id = b.Id,
                    Name = b.Name,
                })
                .ToListAsync();
        }

        public async System.Threading.Tasks.Task EditTaskAsync(int id, TaskFormModel model)
        {
            var task = await dbContext.Tasks.FindAsync(id);

            task!.Title = model.Title;
            task.Description = model.Description;
            task.BoardId = model.BoardId;

            await dbContext.SaveChangesAsync();
        }

        public async System.Threading.Tasks.Task DeleteTaskAsync(int id)
        {
            var task = await dbContext.Tasks.FindAsync(id);

            var model = new TaskViewModel
            {
                Id = task!.Id,
                Title = task.Title,
                Description = task.Description
            };

            dbContext.Tasks.Remove(task);
            await dbContext.SaveChangesAsync();
        }

        public async Task<Task> GetTaskOwnerAsync(int taskId)
        {
            return await dbContext.Tasks.FindAsync(taskId);
        }
    }
}