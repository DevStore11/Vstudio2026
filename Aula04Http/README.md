# Aula04Http

Laboratório da Aula 4 da disciplina de **Programação Web Avançada** (USTM), focado no protocolo HTTP, no Postman e na construção de uma pequena calculadora web com Minimal APIs.

## Objectivo

Praticar pedidos `GET` e `POST`, query strings, corpo de pedido em JSON (`record`), validação de dados e devolução de respostas estruturadas (`Results.Ok`, `Results.BadRequest`, `Results.Created`).

## Tecnologia

- .NET 10.0 (`Microsoft.NET.Sdk.Web`)
- ASP.NET Core Minimal API
- Swashbuckle.AspNetCore (Swagger/OpenAPI)

## Endpoints

| Método | Rota | Descrição |
| --- | --- | --- |
| `GET` | `/` | Estado da aplicação |
| `GET` | `/saudacao?nome=...` | Saudação personalizada; `400` se `nome` não for indicado |
| `POST` | `/eco` | Recebe `{ "texto": "..." }` e devolve o texto, o tamanho e a versão em maiúsculas |
| `GET` | `/calcular?a=...&b=...&op=...` | Calculadora com as operações `somar`, `subtrair`, `multiplicar`, `dividir`, `resto` e `potencia` |

## Como executar

```bash
dotnet run --project Aula04Http
```

Testar os endpoints com o Postman ou com o Swagger UI disponibilizado pelo projecto.
