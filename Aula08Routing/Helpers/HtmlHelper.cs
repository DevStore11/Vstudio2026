namespace Aula08Routing.Helpers;

public static class HtmlHelper
{
    public static string CriarPagina(string titulo, string conteudo)
    {
        return $"""
            <!DOCTYPE html>
            <html lang="pt">
            <head>
                <meta charset="utf-8">
                <meta name="viewport" content="width=device-width, initial-scale=1">
                <title>{titulo}</title>
                <link rel="stylesheet" href="/css/site.css">
            </head>
            <body>
                <header>
                    <div class="marca container">
                        <img src="/img/ustm.jpg" alt="Logótipo USTM">
                        <div>
                            <h1>{titulo}</h1>
                            <p>Laboratório de Routing</p>
                        </div>
                    </div>
                </header>
                <main class="container">
                    {conteudo}
                    <p><a href="/">Voltar à página inicial</a></p>
                </main>
                <footer>Aula 8 — Routing no ASP.NET Core</footer>
            </body>
            </html>
            """;
    }
}
