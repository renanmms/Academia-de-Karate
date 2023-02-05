using Academia_de_Karate.Models;
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

        [HttpPost]
        public IActionResult Index(AlunoInputModel model){
            if(ModelState.IsValid)
                return RedirectToAction("Index");
            return View(model);
        }
    }
}