namespace Dominio.Interfaces;

public interface IUnitOfWork : IDisposable
{
    ILivroRepositorio LivrosRepo { get; }
    Task Commit();
}