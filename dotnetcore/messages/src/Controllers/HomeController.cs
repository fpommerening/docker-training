using System.Linq;
using System.Threading.Tasks;
using FP.DockerTraining.Messages.Data;
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
            var model = await _messageRepository.GetMessages();
            var viewModel = model.Select(x => new Modells.Message
            {
                Content = x.Content,
                Timestamp = x.Timestamp,
                UserName = x.User
            }).ToList();
            return View(viewModel);
        }
    }
}