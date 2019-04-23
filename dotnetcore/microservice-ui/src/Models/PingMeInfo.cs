using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FP.DockerTraining.Microservice.UI.Models
{
    public class PingMeInfo
    {
        public string Kind { get; set; }
        public DateTime Last { get; set; }
        public string Lang { get; set; }
    }
}
