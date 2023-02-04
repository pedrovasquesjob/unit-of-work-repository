using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Repositories;

public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
{
    private readonly AppDbContext _context;

    protected GenericRepository(AppDbContext context) => _context = context;

    public async Task Add(T entity) => await _context.AddAsync(entity);

    public async Task<T> Get(int id) => await _context.Set<T>().FindAsync(id);

    public async Task<IEnumerable<T>> GetAll() => await _context.Set<T>().ToListAsync();
}