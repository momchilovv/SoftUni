#nullable disable
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static TaskBoardApp.Common.DataValidations.Board;

namespace TaskBoardApp.Data.Models
{
    [Comment("Board for tasks")]
    public class Board
    {
        [Key]
        [Comment("Primary key")]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        [Comment("Board name")]
        public string Name { get; set; }

        [Comment("List of tasks in this board")]
        public ICollection<Task> Tasks { get; set; } = new List<Task>();
    }
}