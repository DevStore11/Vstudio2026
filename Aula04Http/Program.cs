var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () =>
{
    return Results.Ok(new
    {
        mensagem = "Laboratório HTTP e Postman",
        estado = "Aplicação em funcionamento"
    });
});

app.MapGet("/saudacao", (string? nome) =>
{
    if (string.IsNullOrWhiteSpace(nome))
    {
        return Results.BadRequest(new
        {
            erro = "O parâmetro nome é obrigatório."
        });
    }
    return Results.Ok(new
    {
        mensagem = $"Olá, {nome}!"
    });
});

app.MapPost("/eco", (Mensagem entrada) =>
{
    if (string.IsNullOrWhiteSpace(entrada.Texto))
    {
        return Results.BadRequest(new
        {
            erro = "O campo texto é obrigatório."
        });
    }
    return Results.Created("/eco", new
    {
        recebido = entrada.Texto,
        tamanho = entrada.Texto.Length,
        maiusculas = entrada.Texto.ToUpper()
    });
});

app.MapGet("/calcular", (double a, double b, string op) =>
{
    if (string.IsNullOrWhiteSpace(op))
    {
        return Results.BadRequest(new
        {
            erro = "O parâmetro op é obrigatório e não pode ser vazio."
        });
    }

    var operacao = op.Trim().ToLower();

    if (operacao == "somar")
    {
        var resultado = a + b;
        return Results.Ok(new { a, b, operacao, resultado, descricao = $"{a} + {b} = {resultado}" });
    }

    if (operacao == "subtrair")
    {
        var resultado = a - b;
        return Results.Ok(new { a, b, operacao, resultado, descricao = $"{a} - {b} = {resultado}" });
    }

    if (operacao == "multiplicar")
    {
        var resultado = a * b;
        return Results.Ok(new { a, b, operacao, resultado, descricao = $"{a} * {b} = {resultado}" });
    }

    if (operacao == "dividir")
    {
        if (b == 0)
        {
            return Results.BadRequest(new { erro = "Não é possível dividir por zero." });
        }
        var resultado = a / b;
        return Results.Ok(new { a, b, operacao, resultado, descricao = $"{a} / {b} = {resultado}" });
    }

    if (operacao == "resto")
    {
        if (b == 0)
        {
            return Results.BadRequest(new { erro = "Não é possível calcular o resto com divisor zero." });
        }
        var resultado = a % b;
        return Results.Ok(new { a, b, operacao, resultado, descricao = $"{a} % {b} = {resultado}" });
    }

    if (operacao == "potencia")
    {
        var resultado = Math.Pow(a, b);
        return Results.Ok(new { a, b, operacao, resultado, descricao = $"{a} ^ {b} = {resultado}" });
    }

    return Results.BadRequest(new
    {
        erro = "Operação inválida.",
        operacoesPermitidas = new[] { "somar", "subtrair", "multiplicar", "dividir", "resto", "potencia" }
    });
});

app.Run();

public record Mensagem(string Texto);