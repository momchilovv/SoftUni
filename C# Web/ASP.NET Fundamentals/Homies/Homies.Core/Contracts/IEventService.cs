using Homies.Core.Models.Event;
using Homies.Core.Models.Type;

namespace Homies.Core.Contracts
{
    public interface IEventService
    {
        Task<List<TypeModel>> GetAllTypesAsync();

        Task<List<JoinedEventsViewModel>> GetJoinedEventsAsync(string userId);

        Task<EventViewModel> GetEventById(int id);

        Task JoinToEvent(string userId, EventViewModel model);

        Task LeaveFromEvent(string userId, EventViewModel model);

        Task<IEnumerable<EventAllViewModel>> GetAllEventsAsync();

        Task CreateTaskAsync(EventFormModel model);

        Task EditEventAsync(int id, EventFormModel model);

        EventFormModel GetEventFormModel(int id);

        EventDetailsViewModel GetEventDetails(int id);
    }
}