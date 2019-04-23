using Microsoft.AspNetCore.Mvc;

namespace FP.DockerTraining.Microservice.PingMe.Controllers
{
    public class PingController : ControllerBase
    {
        private readonly IRepository _repository;

        public PingController(IRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("/")]
        public ActionResult<PingMeInfo> Index()
        {
            return new PingMeInfo
            {
                Last = _repository.Last,
                Kind = _repository.Kind,
                Lang = "dotnetcore"
            };
        }

        [HttpGet("/ping")]
        public IActionResult Ping()
        {
           _repository.Ping();
           return Ok();
        }
    }
}
