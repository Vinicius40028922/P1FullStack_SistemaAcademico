namespace SistemaAcademico.Repositorio;

public interface IAlunoRepositorio
{
    void Adicionar(Aluno, aluno);
    IEnumerable<Aluno> ObterTodos();

}
