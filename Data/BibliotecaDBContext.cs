using BibliotecaApi.Data.Map;
using BibliotecaApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaApi.Data;

public class BibliotecaDBContext : DbContext
{
    public BibliotecaDBContext(DbContextOptions<BibliotecaDBContext> options)
        : base(options)
    {
    }

    public DbSet<LivrosModel> Livros { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new LivrosMap());

        base.OnModelCreating(modelBuilder);
    }
}
