using System.Net.Http;
using System.Threading.Tasks;
using FP.DockerTraining.Microservice.UI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace FP.DockerTraining.Microservice.UI.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var model = new Dashboard();
            var pingMeUrl = EnvironmentVariable.GetValueOrDefault("PingMeUrl", string.Empty);
            if (!string.IsNullOrEmpty(pingMeUrl))
            {
                model.PingMeInfo = await GetObject<PingMeInfo>(pingMeUrl);
            }
            var timeUrl = EnvironmentVariable.GetValueOrDefault("TimeUrl", string.Empty);
            if (!string.IsNullOrEmpty(timeUrl))
            {
                model.TimeInfo = await GetObject<TimeInfo>(timeUrl);
            }
            return View(model);
        }

        private async Task<T> GetObject<T>(string url)
        {
            using (var client = new HttpClient())
            {
                var result = await client.GetAsync(url);
                result.EnsureSuccessStatusCode();
                var resultAsString = await result.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T>(resultAsString);
            }
        }
    }
}
