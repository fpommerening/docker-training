using System;
using System.Text;
using FP.DockerTraining.Secrets.Business;
using Microsoft.AspNetCore.Mvc;

namespace FP.DockerTraining.Secrets.Controllers
{
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Index()
        {
                var sb = new StringBuilder();
                sb.AppendLine($"Secret-Sample {DateTime.Now:G}");
                var databaseconfig = SecretHelper.GetSecret("databaseconfig.cfg");
                if (string.IsNullOrEmpty(databaseconfig))
                {
                    sb.AppendLine("Es wurde keine databaseconfig gefunden");
                }
                else
                {
                    sb.AppendLine($"databaseconfig:{databaseconfig}");
                }
                return sb.ToString();

        }
    }
}
