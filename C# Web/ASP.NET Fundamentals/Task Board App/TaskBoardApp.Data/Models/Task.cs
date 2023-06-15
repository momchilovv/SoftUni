using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static TaskBoardApp.Common.DataValidations.Task;

namespace TaskBoardApp.Data.Models
{
    [Comment("Task for users")]
    public class Task
    {
        [Key]
        [Comment("Primary key")]
        public int Id { get; set; }

        [Required]
        [MaxLength(TitleMaxLength)]
        [Comment("Task title")]
        public string Title { get; set; } = null!;

        [Required]
        [MaxLength(DescriptionMaxLength)]
        [Comment("Task description")]
        public string Description { get; set; } = null!;

        [Comment("Task creation date and time")]
        public DateTime CreatedOn { get; set; }

        [Comment("Board id")]
        public int BoardId { get; set; }

        [ForeignKey(nameof(BoardId))]
        [Comment("Task board")]
        public Board? Board { get; set; }

        [Required]
        [Comment("Owner id")]
        public string OwnerId { get; set; } = null!;

        [ForeignKey(nameof(OwnerId))]
        [Comment("Task owner")]
        public IdentityUser Owner { get; set; } = null!;
    }
}