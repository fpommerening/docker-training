using System;

namespace FP.DockerTraining.Microservice.PingMe.Controllers
{
    public interface IRepository
    {
        void Ping();

        DateTime Last { get; }

        string Kind { get; }
    }

    public class Repository : IRepository
    {
        public DateTime Last { get; private set; }
        public string Kind { get; private set; }

        public Repository()
        {
            Last = DateTime.UtcNow;
            Kind = "start";
        }

        public void Ping()
        {
            Last = DateTime.UtcNow;
            Kind = "ping";
        }

    }
}
