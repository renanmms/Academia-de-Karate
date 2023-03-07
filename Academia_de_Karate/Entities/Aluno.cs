namespace Academia_de_Karate.Entities
{
    public class Aluno
    {
        public Aluno(string nome, string email, string telefone)
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
        }

        public int Id { get; set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Telefone { get; private set; }
    }
}