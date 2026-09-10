using Aula08Routing.Models;

namespace Aula08Routing.Data;

public static class AppData
{
    public static readonly Dictionary<int, Estudante> Estudantes = new()
    {
        [1] = new(1, "Ana João", "Engenharia Informática"),
        [2] = new(2, "Paulo José", "Engenharia de Telecomunicações"),
        [3] = new(3, "Marta Carlos", "Informática")
    };

    public static readonly Dictionary<int, Curso> Cursos = new()
    {
        [1] = new(1, "Engenharia Informática", 4),
        [2] = new(2, "Engenharia de Telecomunicações", 4)
    };

    public static readonly Dictionary<int, Disciplina> Disciplinas = new()
    {
        [1] = new(1, "Programação Web Avançada", "ASP.NET Core"),
        [2] = new(2, "Segurança de Redes", "Fundamentos de segurança")
    };
}
