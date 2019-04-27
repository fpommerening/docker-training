using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FP.DockerTraining.Messages.Data;
using FP.DockerTraining.Messages.Models;
using Microsoft.AspNetCore.Mvc;

namespace FP.DockerTraining.Messages.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMessageRepository _messageRepository;

        public HomeController(IMessageRepository messageRepository)
        {
            
            _messageRepository = messageRepository;
        }


        public async Task<IActionResult> Index()
        {
            var messages = await _messageRepository.GetMessages();
            var viewModel = MapMessages(messages);
            return View(viewModel);
        }

        public ActionResult<Message> Create()
        {
            return View("Edit", new Message());
        }

        public async Task<IActionResult> Edit(Message message)
        {
            var id = await _messageRepository.SaveMessage(message.UserName, message.Content);
            var messages = await _messageRepository.GetMessages();
            var viewModel = MapMessages(messages);
            return View("index", viewModel);
        }

        private IEnumerable<Message> MapMessages(IEnumerable<DtoMessage> messages)
        {
            return messages.Select(x => new Message
            {
                Content = x.Content,
                Timestamp = x.Timestamp,
                UserName = x.User
            }).ToList();
        }

    }
}