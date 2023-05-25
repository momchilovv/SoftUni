using Microsoft.AspNetCore.Mvc;
using SimpleChat.Models.Message;

namespace SimpleChat.Controllers
{
    public class ChatController : Controller
    {
        // We'll store the message in this private field for the demo
        // This is considered bad practice and we should always store data in the database
        private static List<KeyValuePair<string, string>> messageStorage =
            new List<KeyValuePair<string, string>>();

        public IActionResult Show()
        {
            if (messageStorage.Count() < 1)
            {
                return View(new ChatViewModel());
            }

            var chatModel = new ChatViewModel()
            {
                Messages = messageStorage
                .Select(m => new MessageViewModel
                {
                    Sender = m.Key,
                    Message = m.Value
                })
                .ToList()
            };

            return View(chatModel);
        }

        [HttpPost]
        public IActionResult Send(ChatViewModel chat)
        {
            var newMessage = chat.CurrentMessage;

            messageStorage.Add(new KeyValuePair<string, string>(newMessage.Sender, newMessage.Message));

            return RedirectToAction("Show");
        }
    }
}