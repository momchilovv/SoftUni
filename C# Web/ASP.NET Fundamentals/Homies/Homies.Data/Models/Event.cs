#nullable disable
using Homies.Common;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Homies.Data.Models
{
    public class Event
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(DataValidations.Event.NameMaxLength)]
        public string Name { get; set; }

        [Required]
        [MaxLength(DataValidations.Event.DescriptionMaxLength)]
        public string Description { get; set; }

        [Required] 
        public string OrganiserId { get; set; }

        [Required]
        public IdentityUser Organiser { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "yyyy-MM-dd H:mm")]
        public DateTime CreatedOn { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "yyyy-MM-dd H:mm")]
        public DateTime Start { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "yyyy-MM-dd H:mm")]
        public DateTime End { get; set; }

        [Required]
        public int TypeId { get; set; }

        [Required]
        [ForeignKey(nameof(TypeId))]
        public Type Type { get; set; }

        public List<EventParticipant> EventsParticipants { get; set; } = new List<EventParticipant>();
    }
}