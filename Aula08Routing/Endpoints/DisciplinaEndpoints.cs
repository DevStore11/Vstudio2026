using Microsoft.AspNetCore.Http;
using Aula08Routing.Data;
using Aula08Routing.Helpers;

namespace Aula08Routing.Endpoints;

public static class DisciplinaEndpoints
{
    public static void MapDisciplinaEndpoints(this IEndpointRouteBuilder routes)
    {
        routes.MapGet("/disciplinas/{id:int}", (int id) =>
        {
            if (!AppData.Disciplinas.TryGetValue(id, out var disciplina))
            {
                var erro = $"""
                    <section class="card erro">
                        <h2>Disciplina não encontrada</h2>
                        <p>Não existe disciplina com o identificador <strong>{id}</strong>.</p>
                    </section>
                    """;
                return Results.Content(HtmlHelper.CriarPagina("Disciplina não encontrada", erro),
                    "text/html; charset=utf-8", statusCode: StatusCodes.Status404NotFound);
            }

            var conteudo = $"""
                <section class="card">
                    <h2>Dados da disciplina</h2>
                    <p><strong>Id:</strong> {disciplina.Id}</p>
                    <p><strong>Nome:</strong> {disciplina.Nome}</p>
                    <p><strong>Descrição:</strong> {disciplina.Descricao}</p>
                </section>
                """;
            return Results.Content(HtmlHelper.CriarPagina($"Disciplina {disciplina.Id}", conteudo),
                "text/html; charset=utf-8");
        });
    }
}
