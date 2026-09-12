# Aula08Routing

Laboratório da Aula 8 da disciplina de **Programação Web Avançada** (USTM), sobre *routing* dinâmico no ASP.NET Core, organização de endpoints por domínio e ficheiros estáticos em `wwwroot`.

## Objectivo

Praticar rotas com parâmetros e restrições de tipo (`{id:int}`), consultar entidades em memória e devolver páginas HTML geradas a partir de um *helper* comum, além de servir uma página inicial estática.

## Tecnologia

- .NET 10.0 (`Microsoft.NET.Sdk.Web`)
- ASP.NET Core Minimal API
- `UseDefaultFiles` / `UseStaticFiles` para servir conteúdo de `wwwroot`

## Estrutura do projecto

```
Aula08Routing/
├── Program.cs                  # composição da aplicação e registo dos endpoints
├── Endpoints/                  # extensões de mapeamento de rotas, por domínio
│   ├── EstudanteEndpoints.cs   # GET /estudantes/{id:int}
│   ├── CursoEndpoints.cs       # GET /cursos/{id:int}
│   └── DisciplinaEndpoints.cs  # GET /disciplinas/{id:int}
├── Models/                     # records: Estudante, Curso, Disciplina
├── Data/
│   └── AppData.cs              # dados em memória (Dictionary<int, T>)
├── Helpers/
│   └── HtmlHelper.cs           # geração da página HTML comum (layout + cabeçalho)
└── wwwroot/                    # página inicial estática (index.html, css, js, img)
```

## Endpoints

| Método | Rota | Descrição |
| --- | --- | --- |
| `GET` | `/` | Página inicial estática (`wwwroot/index.html`) |
| `GET` | `/estudantes/{id:int}` | Dados do estudante; `404` (HTML) se o id não existir |
| `GET` | `/cursos/{id:int}` | Dados do curso; `404` (HTML) se o id não existir |
| `GET` | `/disciplinas/{id:int}` | Dados da disciplina; `404` (HTML) se o id não existir |

## Como executar

```bash
dotnet run --project Aula08Routing
```
