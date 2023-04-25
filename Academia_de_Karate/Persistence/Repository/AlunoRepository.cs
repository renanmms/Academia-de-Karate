using Academia_de_Karate.Entities;

namespace Academia_de_Karate.Persistence.Repository
{
    public class AlunoRepository : IAlunoRepository
    {
        private readonly AcademiaDeKarateDbContext _dbContext;
        public AlunoRepository(AcademiaDeKarateDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void MatricularAluno(Aluno aluno)
        {
            _dbContext.Alunos.Add(aluno);
            _dbContext.SaveChanges();
        }

        public IEnumerable<Aluno> ObterAlunos()
        {
            var alunos = _dbContext.Alunos.ToList();
            return alunos;
        }
    }
}