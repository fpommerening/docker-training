using System;

namespace FP.DockerTraining.Microservice.PingMe.Controllers
{
    public class PingMeInfo
    {
        public string Kind { get; set; }
        public DateTime Last { get; set; }
        public string Lang { get; set; }
    }
}