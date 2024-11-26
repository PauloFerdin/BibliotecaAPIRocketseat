using System.ComponentModel;

namespace BibliotecaApi.Enums;

public enum GeneroTipo
{
    [Description("Romance")]
    Romance = 1,
    [Description("Ficção")]
    Ficção = 2,
    [Description("Mistério")]
    Misterio = 3,
    [Description("Terror")]
    Terror = 4,
    [Description("Aventura")]
    Aventura = 5,
    [Description("História")]
    História = 6,
    [Description("Biografias")]
    Biografias = 7
}
