namespace SistemaAcademico.Servico;

public class AlunoServico : IAlunoServico
{
    private readonly IAlunoRepositorio

     public AlunoServico(IAlunoRepositorio alunoRepositorio)
        {
            _alunoRepositorio = alunoRepositorio;
        }

        public void Adicionar(AlunoDto alunoDto)
        {
            var aluno = new Aluno(alunoDto.Nome, alunoDto.Nota);
            _alunoRepositorio.Salvar(aluno);
        }

        public IEnumerable<AlunoDto> Listar()
        {
            return _alunoRepositorio.Listar().Select(aluno =>
                        new AlunoDto { Nome = aluno.Nome, Nota = aluno.Nota });
        }
}
