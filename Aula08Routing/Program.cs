using Aula08Routing.Endpoints;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// ============================================================
// FICHEIROS ESTÁTICOS
// ============================================================
app.UseDefaultFiles(); // reescreve "/" para "/index.html"
app.UseStaticFiles();  // serve ficheiros dentro de wwwroot

// ============================================================
// MAPEAMENTO DE ENDPOINTS POR DOMÍNIO
// ============================================================
app.MapEstudanteEndpoints();
app.MapCursoEndpoints();
app.MapDisciplinaEndpoints();

app.Run();
5r