#nullable disable
using System.ComponentModel.DataAnnotations;
using static TaskBoardApp.Common.DataValidations.Task;

namespace TaskBoardApp.Core.Models.Task
{
    public class TaskFormModel
    {
        [Required]
        [StringLength(TitleMaxLength, MinimumLength = TitleMinLength)]
        public string Title { get; set; }

        [Required]
        [StringLength(DescriptionMaxLength, MinimumLength = DescriptionMinLength)]
        public string Description { get; set; }

        [Display(Name = "Board")]
        public int BoardId { get; set; }

        public string OwnerId { get; set; }

        public IEnumerable<TaskBoardModel> Boards { get; set; } = new List<TaskBoardModel>();
    }
}