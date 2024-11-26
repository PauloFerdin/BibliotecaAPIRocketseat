using BibliotecaApi.Models;
using BibliotecaApi.Repositorios.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BibliotecaApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class LivrosController : ControllerBase
{
    private readonly ILivrosRepositorio _livrosRepositorio;
    public LivrosController(ILivrosRepositorio livrosRepositorio)
    {
        _livrosRepositorio = livrosRepositorio;
    }

    [HttpGet]
    public async Task <ActionResult<List<LivrosModel>>> BuscarTodosLivros()
    {
        List<LivrosModel> livros = await _livrosRepositorio.BuscarTodosLivros();
        return Ok(livros);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<LivrosModel>> BuscarPorId(int id)
    {
        LivrosModel livro = await _livrosRepositorio.BuscarPorId(id);
        return Ok(livro);
    }

    [HttpPost]
    public async Task<ActionResult<LivrosModel>> Cadastrar([FromBody] LivrosModel livroModel)
    {
        LivrosModel livro = await _livrosRepositorio.Adicionar(livroModel);

        return Ok(livro);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<LivrosModel>> Atualizar([FromBody] LivrosModel livroModel, int id)
    {
        livroModel.Id = id;
        LivrosModel livro = await _livrosRepositorio.Atualizar(livroModel, id);

        return Ok(livro);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<LivrosModel>> Apagar(int id)
    {
        bool apagado = await _livrosRepositorio.Apagar(id);

        return Ok(apagado);
    }

}
