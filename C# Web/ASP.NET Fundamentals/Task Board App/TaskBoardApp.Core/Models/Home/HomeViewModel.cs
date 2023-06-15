namespace TaskBoardApp.Core.Models.Home
{
    public class HomeViewModel
    {
        public int AllTasksCount { get; set; }

        public List<HomeBoardModel> BoardsTasksCount { get; set; } = null!;

        public int UserTasksCount { get; set; }
    }
}