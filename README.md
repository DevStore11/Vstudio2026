# Emerson Ibraimo — Projetos em C# / ASP.NET Core

Este repositório reúne os meus projetos de desenvolvimento em **C#** com **ASP.NET Core**, criados e mantidos por **Emerson Ibraimo**.

## Objetivo

Organizar e versionar o meu portfólio de projetos em C#, abrangendo desde aplicações web com ASP.NET Core até práticas de APIs, Razor Pages e outras tecnologias do ecossistema .NET.

## Tecnologias

- **C#** — linguagem principal
- **ASP.NET Core** — framework para aplicações web e APIs
- **.NET** — runtime e ferramentas de build
- **HTML / CSS / JavaScript** — front-end dos projetos web

## Estrutura

Cada projeto fica na raiz do repositório, na sua própria pasta:

| Projeto | Descrição |
| --- | --- |
| [`OlaMundoWeb`](./OlaMundoWeb/README.md) | Primeiro projeto ASP.NET Core — aplicação web inicial de boas-vindas |
| [`Aula04Http`](./Aula04Http/README.md) | Laboratório HTTP/Postman — calculadora web com Minimal APIs |
| [`Aula06Middleware`](./Aula06Middleware/README.md) | Introdução ao pipeline de middleware do ASP.NET Core |
| [`Aula06MiddlewareLab`](./Aula06MiddlewareLab/README.md) | Middlewares customizados: logging, medição de tempo e validação de cabeçalho |
| [`Aula08Routing`](./Aula08Routing/README.md) | Routing dinâmico, endpoints por domínio e ficheiros estáticos em `wwwroot` |

## Como executar

```bash
dotnet restore
dotnet run --project <NomeDoProjeto>
```

Substitua `<NomeDoProjeto>` por um dos projetos listados acima (ex.: `Aula08Routing`). Consulte o README de cada projeto para detalhes específicos (endpoints, cabeçalhos exigidos, etc.).

## Autor

**Emerson Ibraimo** — desenvolvedor focado em C# e ASP.NET Core.
