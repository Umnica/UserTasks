using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Globalization;
using UserTasks.Web.Models;


namespace UserTasks.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index() => View();

        public IActionResult Privacy() => View(new TimeStampViewModel
        {
            TimeStamp = DateTime.Now.ToString("dd.MM.yyyy", new CultureInfo("en-US"))
        });

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() =>
            View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });

    }
}
