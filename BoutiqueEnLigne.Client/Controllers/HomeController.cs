using BoutiqueEnLigne.Client.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BoutiqueEnLigne.Client.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //private readonly IExempleService _exempleService;

        public HomeController(ILogger<HomeController> logger/*, IExempleService exempleService */)
        {
            _logger = logger;
            // _exempleService = exempleService;
        }

        public /* async Task */ IActionResult Index()
        {
            //await _exempleService.Ajouter();
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
    }
}