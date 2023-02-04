using Dominio.Entities;
using Microsoft.EntityFrameworkCore;

namespace Repositories;

public class AppDbContext : DbContext
{
	public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt) {}
    public DbSet<Livro> Livros { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Livro>().HasKey(x => x.Id);
        base.OnModelCreating(modelBuilder);
    }
}
