using System;

namespace FP.DockerTraining.Microservice.UI.Models
{
    public class Dashboard
    {
        public Dashboard()
        {
            UiNow = DateTime.UtcNow;   
        }

        public DateTime UiNow { get; set; }

        public PingMeInfo PingMeInfo { get; set; }

        public TimeInfo TimeInfo { get; set; }
    }
}
