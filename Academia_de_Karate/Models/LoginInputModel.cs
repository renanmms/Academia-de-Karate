using System.ComponentModel.DataAnnotations;

namespace Academia_de_Karate.Models
{
    public class LoginInputModel
    {
        [Required(ErrorMessage = "Login é Obrigatório!")]
        public string? Login { get; set; }

        [Required(ErrorMessage = "Senha é Obrigatória!")]
        public string? Senha { get; set; }
    }
}