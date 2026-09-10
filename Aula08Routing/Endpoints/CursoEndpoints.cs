using Microsoft.AspNetCore.Http;
using Aula08Routing.Data;
using Aula08Routing.Helpers;

namespace Aula08Routing.Endpoints;

public static class CursoEndpoints
{
    public static void MapCursoEndpoints(this IEndpointRouteBuilder routes)
    {
        routes.MapGet("/cursos/{id:int}", (int id) =>
        {
            if (!AppData.Cursos.TryGetValue(id, out var curso))
            {
                var erro = $"""
                    <section class="card erro">
                        <h2>Curso não encontrado</h2>
                        <p>Não existe curso com o identificador <strong>{id}</strong>.</p>
                    </section>
                    """;
                return Results.Content(HtmlHelper.CriarPagina("Curso não encontrado", erro),
                    "text/html; charset=utf-8", statusCode: StatusCodes.Status404NotFound);
            }

            var conteudo = $"""
                <section class="card">
                    <h2>Dados do curso</h2>
                    <p><strong>Id:</strong> {curso.Id}</p>
                    <p><strong>Nome:</strong> {curso.Nome}</p>
                    <p><strong>Duração:</strong> {curso.DuracaoAnos} anos</p>
                </section>
                """;
            return Results.Content(HtmlHelper.CriarPagina($"Curso {curso.Id}", conteudo),
                "text/html; charset=utf-8");
        });
    }
}
