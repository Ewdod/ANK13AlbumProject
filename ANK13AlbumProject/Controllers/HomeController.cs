using ANK13AlbumProject.Controllers;
using ANK13AlbumProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ANK13AlbumProject.Controllers
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
    }
}





//Aşağıdakiler teker teker yazınız. Çalışmıyorsa hatanın sebebini, çalışıyorsa da yine çalışma sebebini comment olarak yazınız.

//herhangi bir controller a yazabilirsiniz.

