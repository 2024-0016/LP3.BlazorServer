using LP3.BlazorServer.Domain.Entities;

namespace LP3.BlazorServer.Data.Repositories;

public class CursoRepository(ApplicationDbContext context) : Repository<Curso>(context), ICursoRepository
{
}
