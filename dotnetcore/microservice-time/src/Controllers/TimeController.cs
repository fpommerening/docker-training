using System;
using Microsoft.AspNetCore.Mvc;

namespace FP.DockerTraining.Microservice.Time.Controllers
{
     [Route("api/[controller]")]
    [ApiController]
    public class TimeController : ControllerBase
    {
        [HttpGet("")]
        public ActionResult<TimeInfo> Index()
        {
            return new TimeInfo
            {
                Datetime = DateTime.UtcNow,
                Hostname = Environment.MachineName,
                Lang = "dotnetcore"
            };
        }
    }

    public class TimeInfo
    {
        public string Hostname { get; set; }
        public string Lang { get; set; }
        public DateTime Datetime { get; set; }
    }
}