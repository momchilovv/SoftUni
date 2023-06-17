using Homies.Core.Contracts;
using Homies.Core.Models.Event;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Homies.Web.Controllers
{
    public class EventController : BaseController
    {
        private readonly IEventService eventService;

        private string GetUserId() => User.FindFirstValue(ClaimTypes.NameIdentifier);

        public EventController(IEventService eventService)
        {
            this.eventService = eventService;
        }

        public async Task<IActionResult> All()
        {
            var model = await eventService.GetAllEventsAsync();

            return View(model);
        }

        public async Task<IActionResult> Joined()
        {
            var model = await eventService.GetJoinedEventsAsync(GetUserId());

            return View(model);
        }

        public async Task<IActionResult> Join(int id)
        {
            var evnt = await eventService.GetEventById(id);

            var model = await eventService.GetJoinedEventsAsync(GetUserId());

            if (model.Any(m => m.Id == id))
            {
                return RedirectToAction(nameof(All));
            }

            await eventService.JoinToEvent(GetUserId(), evnt);

            return RedirectToAction(nameof(Joined));
        }

        public async Task<IActionResult> Leave(int id)
        {
            var evnt = await eventService.GetEventById(id);

            await eventService.LeaveFromEvent(GetUserId(), evnt);

            return RedirectToAction(nameof(Joined));
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new EventFormModel()
            {
                Types = await eventService.GetAllTypesAsync()
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(EventFormModel model)
        {
            var types = await eventService.GetAllTypesAsync();

            if (!ModelState.IsValid)
            {
                model.Types = await eventService.GetAllTypesAsync();

                return View(model);
            }

            if (!types.Any(t => t.Id == model.TypeId))
            {
                ModelState.AddModelError(nameof(model.TypeId), "Type does not exist!");
            }

            model.OrganiserId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            await eventService.CreateTaskAsync(model);

            return RedirectToAction(nameof(All));
        }

        public IActionResult Details(int id)
        {
            var model = eventService.GetEventDetails(id);

            return View(model);
        }

        [HttpGet]
        #pragma warning disable CS1998
        public async Task<IActionResult> Edit(int id)
        #pragma warning restore CS1998
        {
            var model = eventService.GetEventFormModel(id);

            if (User.FindFirstValue(ClaimTypes.NameIdentifier) != model.OrganiserId)
            {
                return Unauthorized();
            }

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, EventFormModel model)
        {
            if (!eventService.GetAllTypesAsync().Result.Any(b => b.Id == model.TypeId))
            {
                ModelState.AddModelError(nameof(model.TypeId), "Type does not exist!");
            }

            if (!ModelState.IsValid)
            {
                model.Types = eventService.GetAllTypesAsync().Result;

                return View(model);
            }

            await eventService.EditEventAsync(id, model);

            return RedirectToAction(nameof(All));
        }
    }
}