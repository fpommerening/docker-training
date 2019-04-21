using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace FP.DockerTraining.Configs.Controllers
{
    public class HomeController : ControllerBase
    {
        private readonly IConfiguration _cfg;

        public HomeController(IConfiguration cfg)
        {
            _cfg = cfg;
        }

        [HttpGet]
        public ActionResult<string> Index()
        {
            return $" Config-Sample {DateTime.Now:G} \n {_cfg["greeting"]}";
        }

      
    }
}
