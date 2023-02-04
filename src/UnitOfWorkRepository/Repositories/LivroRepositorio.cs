using Dominio.Entities;
using Dominio.Interfaces;

namespace Repositories;

public class LivroRepositorio : GenericRepository<Livro>, ILivroRepositorio
{
	public LivroRepositorio(AppDbContext context) : base(context) {}
}