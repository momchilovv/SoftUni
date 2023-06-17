using Homies.Core.Contracts;
using Homies.Core.Models.Event;
using Homies.Core.Models.Type;
using Homies.Data;
using Homies.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Homies.Core.Services
{
    public class EventService : IEventService
    {
        private readonly HomiesDbContext context;

        public EventService(HomiesDbContext context)
        {
            this.context = context;
        }

        public async Task CreateTaskAsync(EventFormModel model)
        {
            var evnt = new Event()
            {
                Name = model.Name,
                Description = model.Description,
                CreatedOn = DateTime.UtcNow,
                Start = model.Start,
                End = model.End,
                TypeId = model.TypeId,
                OrganiserId = model.OrganiserId
            };

            await context.Events.AddAsync(evnt);
            await context.SaveChangesAsync();
        }

        public async Task EditEventAsync(int id, EventFormModel model)
        {
            var evnt = await context.Events.FindAsync(id);

            evnt!.Name = model.Name;
            evnt.Description = model.Description;
            evnt.Start = model.Start;
            evnt.End = model.End;
            evnt.TypeId = model.TypeId;

            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<EventAllViewModel>> GetAllEventsAsync()
        {
            return await context.Events
                .Select(e => new EventAllViewModel
                {
                    Id = e.Id,
                    Name = e.Name,
                    Start = e.Start,
                    Type = e.Type.Name,
                    Organiser = e.Organiser.UserName
                })
                .ToListAsync();
        }

        public EventFormModel GetEventFormModel(int id)
        {
            return context.Events
                .Where(e => e.Id == id)
                .Select(e => new EventFormModel()
                {
                    Name = e.Name,
                    Description = e.Description,
                    OrganiserId = e.OrganiserId,
                    Start = e.Start,
                    End = e.End,
                    TypeId = e.TypeId,
                    Types = context.Types
                                .Select(b => new TypeModel()
                                {
                                    Id = b.Id,
                                    Name = b.Name
                                }).ToList()
                })
                .First();
        }

        public EventDetailsViewModel GetEventDetails(int id)
        {
            var evnt = context.Events
                .Where(e => e.Id == id)
                .Select(e => new EventDetailsViewModel()
                {
                    Id = e.Id,
                    Name = e.Name,
                    Description = e.Description,
                    Start = e.Start,
                    End = e.End,
                    CreatedOn = e.CreatedOn,
                    Organiser = e.Organiser.UserName,
                    Type = e.Type.Name,
                })
                .First();

            return evnt;
        }

        async Task<List<TypeModel>> IEventService.GetAllTypesAsync()
        {
            return await context.Types
                .Select(t => new TypeModel
                {
                    Id = t.Id,
                    Name = t.Name,
                })
                .ToListAsync();
        }

        public async Task<List<JoinedEventsViewModel>> GetJoinedEventsAsync(string userId)
        {
            return await context.EventsParticipants
                .Where(e => e.HelperId == userId)
                .Select(e => new JoinedEventsViewModel
                {
                    Id = e.Event.Id,
                    Name = e.Event.Name,
                    Start = e.Event.Start,
                    Type = e.Event.Type.Name
                })
                .ToListAsync();
        }

        public async Task<EventViewModel> GetEventById(int id)
        {
            return await context.Events
                .Where(e => e.Id == id)
                .Select(e => new EventViewModel
                {
                    Id = e.Id,
                    Name = e.Name,
                    Start = e.Start,
                    Type = e.Type.Name
                })
                .FirstAsync();
        }

        public async Task JoinToEvent(string userId, EventViewModel model)
        {
            if (!await context.EventsParticipants.AnyAsync(e => e.HelperId == userId && e.EventId == model.Id))
            {
                await context.EventsParticipants.AddAsync(new EventParticipant
                {
                    HelperId = userId,
                    EventId = model.Id
                });

                await context.SaveChangesAsync();
            }
        }

        public async Task LeaveFromEvent(string userId, EventViewModel model)
        {
            var eventParticipant = await context.EventsParticipants
                .FirstOrDefaultAsync(e => e.HelperId == userId && e.EventId == model.Id);

            if (eventParticipant != null)
            {
                context.EventsParticipants.Remove(eventParticipant);

                await context.SaveChangesAsync();
            }
        }
    }
}