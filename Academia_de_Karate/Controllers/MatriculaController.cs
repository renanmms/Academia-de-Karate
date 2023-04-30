using Academia_de_Karate.Entities;
using Academia_de_Karate.Models;
using Academia_de_Karate.Persistence.Repository;
using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace Academia_de_Karate.Controllers {
    public class MatriculaController : Controller
    {
        private readonly ILogger<MatriculaController> _logger;
        private readonly IAlunoRepository _alunoRepository;
        private readonly INotyfService _notfyService;
        public MatriculaController(ILogger<MatriculaController> logger, IAlunoRepository alunoRepository, INotyfService notyfService)
        {
            _alunoRepository = alunoRepository;
            _notfyService = notyfService;
            _logger = logger;
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

        public IActionResult Alunos(){
            try{
                var alunos = _alunoRepository.ObterAlunos();
                var alunosVM = alunos.Select(a => Aluno.ToEntity(a)).ToList();
                return View(alunosVM);

            } catch(Exception ex) {
                _logger.LogInformation(ex.Message);
                throw;
            }
        }

        public IActionResult Teste(){
            return Json(new {name = "Renan", age = 23});
        }
    }
}