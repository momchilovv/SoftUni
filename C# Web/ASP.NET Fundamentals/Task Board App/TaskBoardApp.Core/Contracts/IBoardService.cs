using TaskBoardApp.Core.Models.Board;

namespace TaskBoardApp.Core.Contracts
{
    public interface IBoardService
    {
        Task<IEnumerable<BoardViewModel>> GetAllBoardsAsync();
    }
}