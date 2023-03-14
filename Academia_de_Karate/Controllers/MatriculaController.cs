using Academia_de_Karate.Entities;
using Academia_de_Karate.Models;
using Academia_de_Karate.Persistence.Repository;
using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace Academia_de_Karate.Controllers {
    public class MatriculaController : Controller
    {
        private readonly IAlunoRepository _alunoRepository;
        private readonly INotyfService _notfyService;
        public MatriculaController(IAlunoRepository alunoRepository, INotyfService notyfService)
        {
            _alunoRepository = alunoRepository;
            _notfyService = notyfService;
        }

        public IActionResult Index(){
            return View();
        }

        [HttpPost]
        public IActionResult Index(AlunoInputModel model){
            var aluno = new Aluno(model.Nome, model.Email, model.Telefone);
            if(ModelState.IsValid){
                _notfyService.Success("Aluno matriculado com sucesso");
                _alunoRepository.MatricularAluno(aluno);
                return RedirectToAction("Index","Home");
            }

            return View(model);
        }


        public IActionResult Teste(){
            return Json(new {name = "Renan", age = 23});
        }
    }
}