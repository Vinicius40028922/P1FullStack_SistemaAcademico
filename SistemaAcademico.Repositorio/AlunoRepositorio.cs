using Dominio
namespace SistemaAcademico.Repositorio;

public class AlunoRepositorio : IAlunoRepositorio
{
    private readonly AppDbContext _context;

    public AlunoRepositorio(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

     public void Salvar(Aluno aluno)
        {
            _context.Alunos.Add(aluno);
            _context.SaveChanges();

        }

        public IEnumerable<Aluno> Listar()
        {
            return _context.Alunos.ToList();
        }
}
