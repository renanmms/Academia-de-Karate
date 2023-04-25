namespace Academia_de_Karate.Models
{
    public class AlunoViewModel
    {
        public AlunoViewModel(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public string Nome { get; set; }        
        public string Email { get; set; }
    }
}