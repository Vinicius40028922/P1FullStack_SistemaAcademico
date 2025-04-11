namespace SistemaAcademico.Repositorio;

public class AppDbContext DbContext
{
    public DbSet<Aluno> Alunos {get ; set;}
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
}
