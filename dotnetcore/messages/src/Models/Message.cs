using System;
using System.ComponentModel;

namespace FP.DockerTraining.Messages.Models
{
    public class Message
    {
        [DisplayName("User")]
        public string UserName { get; set; }

        [DisplayName("Message")]
        public string Content { get; set; }

        [DisplayName("Create at")]
        public DateTime Timestamp { get; set; }
    }
}
