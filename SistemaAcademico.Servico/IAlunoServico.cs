namespace SistemaAcademico.Servico;

public interface IAlunoServico
{
    void Adicionar(AlunoDto alunodto);
    IEnumerable<AlunoDto> ObterTodos();
}
