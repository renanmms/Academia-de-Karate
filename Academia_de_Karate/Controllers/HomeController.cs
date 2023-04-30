using Academia_de_Karate.Models;
using Academia_de_Karate.Services;
using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Academia_de_Karate.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAuthService _authService;
        private readonly INotyfService _notyfService;

        public HomeController(ILogger<HomeController> logger, IAuthService authService, INotyfService notyfService)
        {
            _logger = logger;
            _authService = authService;
            _notyfService = notyfService;
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
            if(ModelState.IsValid && _authService.Authenticate(model)){
                _notyfService.Success("Login realizado com sucesso!");
                return RedirectToAction("Alunos", "Matricula");
            }

            _notyfService.Error("Erro na autenticação favor tente novamente!");
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