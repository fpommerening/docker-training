using System;

namespace FP.DockerTraining.Messages.Modells
{
    public class Message
    {
        public string UserName { get; set; }

        public string Content { get; set; }

        public DateTime Timestamp { get; set; }
    }
}
