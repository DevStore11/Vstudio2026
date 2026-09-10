using Microsoft.AspNetCore.Http;
using Aula08Routing.Data;
using Aula08Routing.Helpers;

namespace Aula08Routing.Endpoints;

public static class EstudanteEndpoints
{
    public static void MapEstudanteEndpoints(this IEndpointRouteBuilder routes)
    {
        routes.MapGet("/estudantes/{id:int}", (int id) =>
        {
            if (!AppData.Estudantes.TryGetValue(id, out var estudante))
            {
                var erro = $"""
                    <section class="card erro">
                        <h2>Estudante não encontrado</h2>
                        <p>Não existe estudante com o identificador <strong>{id}</strong>.</p>
                    </section>
                    """;
                return Results.Content(HtmlHelper.CriarPagina("Estudante não encontrado", erro),
                    "text/html; charset=utf-8", statusCode: StatusCodes.Status404NotFound);
            }

            var conteudo = $"""
                <section class="card">
                    <h2>Dados do estudante</h2>
                    <p><strong>Id:</strong> {estudante.Id}</p>
                    <p><strong>Nome:</strong> {estudante.Nome}</p>
                    <p><strong>Curso:</strong> {estudante.Curso}</p>
                </section>
                """;
            return Results.Content(HtmlHelper.CriarPagina($"Estudante {estudante.Id}", conteudo),
                "text/html; charset=utf-8");
        });
    }
}
