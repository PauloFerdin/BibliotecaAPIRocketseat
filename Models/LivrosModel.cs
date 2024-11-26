using BibliotecaApi.Enums;

namespace BibliotecaApi.Models;

public class LivrosModel
{
    public int Id { get; set; }

    public string Titulo { get; set; }

    public string Autor { get; set; }

    //o ? é por que ele pode vir com ou sem genero
    public GeneroTipo Genero { get; set; }

    public int Preco { get; set; }

    public int QuantidadeEstoque { get; set; }
}
