# OlaMundoWeb

Primeiro projecto ASP.NET Core da disciplina de **Programação Web Avançada** (USTM), criado como exercício introdutório de preparação do ambiente e de contacto inicial com Minimal APIs.

## Objectivo

Confirmar que o ambiente de desenvolvimento (.NET SDK, Visual Studio) está correctamente configurado e demonstrar a criação dos primeiros endpoints HTTP com ASP.NET Core.

## Tecnologia

- .NET 10.0 (`Microsoft.NET.Sdk.Web`)
- ASP.NET Core Minimal API

## Endpoints

| Método | Rota | Descrição |
| --- | --- | --- |
| `GET` | `/` | Mensagem de boas-vindas do autor |
| `GET` | `/disciplina` | Nome da disciplina |
| `GET` | `/universidade` | Nome da universidade |
| `GET` | `/data` | Data e hora actual do servidor |

## Como executar

```bash
dotnet run --project OlaMundoWeb
```

A aplicação fica disponível em `http://localhost:<porta>/` (porta definida em `Properties/launchSettings.json`).
