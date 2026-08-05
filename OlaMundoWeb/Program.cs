var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Ola! Sou Emerson ,estudante de Licenciatura em Desenvolvimento de Software. Esta e a minha primeira Aplicacao ASP.NET Core."
);

app.MapGet("/disciplina",()=>
"Disciplina:Programacao Web Avancada"
);

app.MapGet("/universidade",()=>
"Universidade Sao Tomas de Moçambique"
);

app.MapGet("/data",()=>
$"Data actual {DateTime.Now:dd/MM/yyyy HH:mm:ss}"
);

app.Run();
