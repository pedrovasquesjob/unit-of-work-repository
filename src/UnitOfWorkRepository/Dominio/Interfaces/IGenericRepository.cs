namespace Dominio.Interfaces;

public interface IGenericRepository<T> where T : class
{
    Task<T> Get(int id);
    Task<IEnumerable<T>> GetAll();
    Task Add(T entity);
}