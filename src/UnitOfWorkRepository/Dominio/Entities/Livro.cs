namespace Dominio.Entities;

public class Livro
{
    public Livro()
    {
            
    }
    public Livro(int id, string? nome)
    {
        Id = id;
        Nome = nome;
    }

    public int Id { get; }
    public string? Nome { get; }
}