using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RESTClient.Models;
using System.Diagnostics;

namespace RESTClient.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [RouteAttribute("EntryPoint")]
        [RouteAttribute("Entry")]
        [HttpGet("Entry")]
        public IActionResult EntryPoint()
        {
            this.Response.StatusCode = 200;
            //Response.
            return Privacy();
            //Response.Body.Write("Entrypoint response".ToArray(byte[]));
        }
    }
}
