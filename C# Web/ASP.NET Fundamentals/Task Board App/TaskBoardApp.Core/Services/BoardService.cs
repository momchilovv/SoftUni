using Microsoft.EntityFrameworkCore;
using TaskBoardApp.Core.Contracts;
using TaskBoardApp.Core.Models.Board;
using TaskBoardApp.Core.Models.Task;
using TaskBoardApp.Data;

namespace TaskBoardApp.Core.Services
{
    public class BoardService : IBoardService
    {
        private readonly TaskBoardDbContext dbContext;

        public BoardService(TaskBoardDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<BoardViewModel>> GetAllBoardsAsync()
        {
            return await dbContext.Boards
                .Select(b => new BoardViewModel
                {
                    Id = b.Id,
                    Name = b.Name,
                    Tasks = b.Tasks
                        .Select(t => new TaskViewModel
                        {
                            Id = t.Id,
                            Title = t.Title,
                            Description = t.Description,
                            Owner = t.Owner.UserName
                        })
                })
                .ToListAsync();
        }
    }
}