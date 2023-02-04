using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _appDbContext;

    public UnitOfWork(AppDbContext appDbContext, ILivroRepositorio livrosRepo)
    {
        _appDbContext = appDbContext;
        LivrosRepo = livrosRepo;
    }

    public ILivroRepositorio LivrosRepo { get; }

    public async Task Commit() => await _appDbContext.SaveChangesAsync();

    public void Dispose()
    {
        _appDbContext.Dispose();
        GC.SuppressFinalize(this);
    }
}