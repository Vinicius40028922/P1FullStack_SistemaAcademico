namespace SistemaAcademico.WebAPI;

public class AlunoController : ControllerBase
    {
        private readonly IAlunoServico _servico;

        public AlunoController(IAlunoServico servico)
        {
            _servico = servico;
        }

        [HttpPost]
        public IActionResult Post([Frombody]AlunoDto dto)
        {
            _servico.Cadastrar(dto);
            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_servico.ListarTodos());
        }
    }
