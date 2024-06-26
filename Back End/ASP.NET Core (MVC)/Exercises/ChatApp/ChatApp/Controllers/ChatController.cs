﻿using ChatApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChatApp.Controllers
{
    public class ChatController : Controller
    {
        private static List<KeyValuePair<string, string>> Messages = new List<KeyValuePair<string, string>>();

        [HttpPost]
        public IActionResult Send(ChatViewModel chat)
        {
            var newMessage = chat.CurrentMessage;

            Messages.Add(new KeyValuePair<string, string>(newMessage.Sender, newMessage.MessageText));

            return RedirectToAction("Show");
        }

        public IActionResult Show()
        {
            if (Messages.Count < 1)
            {
                return View(new ChatViewModel());
            }

            var chatModel = new ChatViewModel()
            {
                Messages = Messages
                .Select(mbox => new MessageViewModel()
                {
                    Sender = mbox.Key,
                    MessageText = mbox.Value
                })
                .ToList()
            };

            return View(chatModel);
        }
    }
}
