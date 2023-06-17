#nullable disable
using Homies.Common;
using System.ComponentModel.DataAnnotations;

namespace Homies.Data.Models
{
    public class Type
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(DataValidations.Type.NameMaxLength)]
        public string Name { get; set; }

        public List<Event> Events { get; set; } = new List<Event>();
    }
}