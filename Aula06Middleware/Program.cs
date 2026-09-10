var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => Results.Ok(new {
    mensangem="Laboratorio Middleware.",
    estado="Aplicacao Activa"

}));

app.MapGet("/lento",async()=>
{
    await Task.Delay(500);
    return Results.Ok(new{

        mensangem="Operacao concluida",
        atrasoSimuladoMs=500
    });
});

app.Run();
