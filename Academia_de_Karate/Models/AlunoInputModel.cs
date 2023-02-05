using System;
using System.ComponentModel.DataAnnotations;

namespace Academia_de_Karate.Models
{
    public class AlunoInputModel
    {
        [Required(ErrorMessage = "O nome é obrigatório!")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O email é obrigatório!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "O telefone é obrigatório!")]
        public string Telefone { get; set; }
    }
}