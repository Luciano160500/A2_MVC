using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using A2_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace A2_MVC.Controllers
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

        public IActionResult Biografia()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult CV(int id)
        {
            var FilePath = "";
            
            switch (id)
            {
                case 0:
                   FilePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/CV", "Luca.txt");
                   ViewBag.CV1 = System.IO.File.ReadAllText(FilePath);
                    FilePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/CV", "Luciano.txt");
                    ViewBag.CV2 = System.IO.File.ReadAllText(FilePath);
                    FilePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/CV", "Daniele.txt");
                    ViewBag.CV3 = System.IO.File.ReadAllText(FilePath);
                    FilePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/CV", "Matteo.txt");
                    ViewBag.CV4 = System.IO.File.ReadAllText(FilePath);
                    break;
                case 1:
                    FilePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/CV", "Luca.txt");
                    ViewBag.CV = System.IO.File.ReadAllText(FilePath);
                    break;
                case 2:
                    FilePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/CV", "Luciano.txt");
                    ViewBag.CV = System.IO.File.ReadAllText(FilePath);
                    break;
                case 3:
                    FilePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/CV", "Daniele.txt");
                    ViewBag.CV = System.IO.File.ReadAllText(FilePath);
                    break;
                case 4:
                    FilePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/CV", "Matteo.txt");
                    ViewBag.CV = System.IO.File.ReadAllText(FilePath);
                    break;
            }
            return View();
        }


        public IActionResult Chi_Siamo()
        {
            return View();
        }

        public IActionResult AssistenzaClienti()
        {
            return View();
        }
    }
}
