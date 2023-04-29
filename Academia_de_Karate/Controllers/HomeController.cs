using Academia_de_Karate.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Academia_de_Karate.Controllers
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

        public IActionResult Sobre()
        {
            return View();
        }

        [Route("admin")]
        public IActionResult LoginAdm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginInputModel model)
        {
            if(ModelState.IsValid){
                return RedirectToAction(nameof(Index), "Home");
            }

            return View("LoginAdm", model);
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