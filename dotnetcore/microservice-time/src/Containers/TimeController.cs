using System;
using Microsoft.AspNetCore.Mvc;

namespace FP.DockerTraining.Microservice.Time.Containers
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
                Hostname = Environment.MachineName
            };
        }
    }

    public class TimeInfo
    {
        public string Hostname { get; set; }
        public DateTime Datetime { get; set; }
    }
}