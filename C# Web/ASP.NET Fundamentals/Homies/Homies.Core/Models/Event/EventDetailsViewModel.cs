#nullable disable
namespace Homies.Core.Models.Event
{
    public class EventDetailsViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        public string Organiser { get; set; }

        public string Type { get; set; }
    }
}