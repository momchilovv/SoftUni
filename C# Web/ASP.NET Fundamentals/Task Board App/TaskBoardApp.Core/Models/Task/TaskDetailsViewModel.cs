#nullable disable
namespace TaskBoardApp.Core.Models.Task
{
    public class TaskDetailsViewModel : TaskViewModel
    {
        public string CreatedOn { get; set; }

        public string Board { get; set; }

        public string OwnerId { get; set; }
    }
}