using Microsoft.AspNetCore.Mvc;

namespace Academia_de_Karate.Controllers {
    public class MatriculaController : Controller
    {

        public MatriculaController()
        {
            
        }

        public IActionResult Index(){
            return View();
        }
    }
}