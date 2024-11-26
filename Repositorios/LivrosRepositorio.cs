using BibliotecaApi.Data;
using BibliotecaApi.Models;
using BibliotecaApi.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaApi.Repositorios;

public class LivrosRepositorio : ILivrosRepositorio
{
    private readonly BibliotecaDBContext _dbContext;
    public LivrosRepositorio(BibliotecaDBContext bibliotecaDBContext)
    {
        _dbContext = bibliotecaDBContext;
    }

    public async Task<LivrosModel> Adicionar(LivrosModel livro)
    {
        await _dbContext.Livros.AddAsync(livro);
        await _dbContext.SaveChangesAsync();

        return livro;
    }

    public async Task<bool> Apagar(int id)
    {
        LivrosModel livrosPorId = await BuscarPorId(id);

        if (livrosPorId == null)
        {
            throw new NotImplementedException($"Usuario para o ID: {id} não foi encontrado.");
        }

        _dbContext.Livros.Remove(livrosPorId);
        await _dbContext.SaveChangesAsync();
        return true;
    }

    public async Task<LivrosModel> Atualizar(LivrosModel livro, int id)
    {
        LivrosModel livrosPorId = await BuscarPorId(id);

        if (livrosPorId == null)
        {
            throw new NotImplementedException($"Usuario para o ID: {id} não foi encontrado.");
        }
        livrosPorId.Titulo = livro.Titulo;
        livrosPorId.Autor = livro.Autor;

        _dbContext.Livros.Update(livrosPorId);
        await _dbContext.SaveChangesAsync();

        return livrosPorId;
    }

    public async Task<LivrosModel> BuscarPorId(int id)
    {
        return await _dbContext.Livros.FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<List<LivrosModel>> BuscarTodosLivros()
    {
        return await _dbContext.Livros.ToListAsync();
    }
}
