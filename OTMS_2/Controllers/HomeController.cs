using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OTMS_2.Models;
using OTMS_2.Models.Home;
using System.Diagnostics;

namespace OTMS_2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IActionResult Index(InputDataModel input)
        {
            var viewModel = new IndexViewModel(input);
            viewModel.CalculateTemps();

            return View(viewModel);
        }

        public IActionResult Index()
        {
            var viewModel = new IndexViewModel()/*.GetDefault();*/;

            return View(viewModel);
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
    }
}
