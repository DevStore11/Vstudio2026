# Aula06Middleware

Projecto de apoio à Aula 6 (teoria) da disciplina de **Programação Web Avançada** (USTM), com um exemplo mínimo do pipeline de middleware do ASP.NET Core.

## Objectivo

Servir de base introdutória ao conceito de *request pipeline*, antes da prática mais elaborada feita em `Aula06MiddlewareLab`.

## Tecnologia

- .NET 10.0 (`Microsoft.NET.Sdk.Web`)
- ASP.NET Core Minimal API

## Endpoints

| Método | Rota | Descrição |
| --- | --- | --- |
| `GET` | `/` | Estado da aplicação |
| `GET` | `/lento` | Simula uma operação demorada com `Task.Delay(500)` |

## Como executar

```bash
dotnet run --project Aula06Middleware
```
