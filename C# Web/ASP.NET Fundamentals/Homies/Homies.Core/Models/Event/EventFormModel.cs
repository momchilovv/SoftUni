#nullable disable
using Homies.Common;
using Homies.Core.Models.Type;
using System.ComponentModel.DataAnnotations;
using Type = Homies.Data.Models.Type;

namespace Homies.Core.Models.Event
{
    public class EventFormModel
    {
        [Required]
        [StringLength(DataValidations.Event.NameMaxLength, MinimumLength = DataValidations.Event.NameMinLength)]
        public string Name { get; set; }

        [Required]
        [StringLength(DataValidations.Event.DescriptionMaxLength, MinimumLength = DataValidations.Event.DescriptionMinLength)]
        public string Description { get; set; }

        [Required]
        public DateTime Start { get; set; }

        [Required]
        public DateTime End { get; set; }

        [Display(Name = "Type of event")]
        public int TypeId { get; set; }

        public string OrganiserId { get; set; }

        public List<TypeModel> Types { get; set; } = new List<TypeModel>();
    }
}