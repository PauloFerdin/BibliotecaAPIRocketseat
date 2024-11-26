using BibliotecaApi.Models;

namespace BibliotecaApi.Repositorios.Interfaces;

public interface ILivrosRepositorio
{
    Task<List<LivrosModel>> BuscarTodosLivros();
    Task<LivrosModel> BuscarPorId(int id);
    Task<LivrosModel> Adicionar(LivrosModel livro);
    Task<LivrosModel> Atualizar(LivrosModel livro, int id);
    Task<bool> Apagar(int id);
}
