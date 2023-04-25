using Academia_de_Karate.Entities;

namespace Academia_de_Karate.Persistence.Repository
{
    public interface IAlunoRepository
    {
        void MatricularAluno(Aluno aluno);
        IEnumerable<Aluno> ObterAlunos();
    }
}