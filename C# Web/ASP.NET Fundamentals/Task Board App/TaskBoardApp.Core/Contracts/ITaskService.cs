using TaskBoardApp.Core.Models.Task;
using Task = System.Threading.Tasks.Task;

namespace TaskBoardApp.Core.Contracts
{
    public interface ITaskService
    {
        Task CreateTaskAsync(TaskFormModel model);

        Task<IEnumerable<TaskBoardModel>> GetBoardsAsync();

        TaskDetailsViewModel GetTaskDetails(int id);

        TaskFormModel GetTaskFormModel(int id);

        Task EditTaskAsync(int id, TaskFormModel model);

        Task DeleteTaskAsync(int id);

        Task<Data.Models.Task> GetTaskOwnerAsync(int taskId);
    }
}