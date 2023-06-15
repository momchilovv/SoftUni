using Microsoft.AspNetCore.Mvc;
using TaskBoardApp.Core.Contracts;

namespace TaskBoardApp.Web.Controllers
{
    public class BoardController : BaseController
    {
        private readonly IBoardService boardService;

        public BoardController(IBoardService boardService)
        {
            this.boardService = boardService;
        }

        public async Task<IActionResult> All()
        {
            var model = await boardService.GetAllBoardsAsync();

            return View(model);
        }
    }
}