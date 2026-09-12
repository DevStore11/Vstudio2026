# Aula06MiddlewareLab

Laboratório prático da Aula 6 da disciplina de **Programação Web Avançada** (USTM), com implementação de middlewares customizados no pipeline do ASP.NET Core.

## Objectivo

Construir e encadear três middlewares próprios, demonstrando logging de pedidos, medição de tempo de resposta e validação de um cabeçalho de segurança.

## Tecnologia

- .NET 10.0 (`Microsoft.NET.Sdk.Web`)
- ASP.NET Core Minimal API

## Middlewares

1. **Registo de pedidos** — regista no `Console` o método, o caminho e o código de estado de cada pedido (entrada e saída).
2. **Medição do tempo** — usa `Stopwatch` para calcular a duração do pedido e devolve-a no cabeçalho `X-Response-Time-ms`.
3. **Cabeçalho obrigatório** — exige o cabeçalho `X-Lab-Key`; devolve `400` se estiver ausente e `403` se o valor for diferente de `USTM2026`.

## Endpoints

| Método | Rota | Descrição |
| --- | --- | --- |
| `GET` | `/` | Estado da aplicação |
| `GET` | `/lento` | Simula uma operação demorada com `Task.Delay(500)` |

## Como executar

```bash
dotnet run --project Aula06MiddlewareLab
```

Para testar os endpoints é necessário incluir o cabeçalho `X-Lab-Key: USTM2026` no pedido (por exemplo, no Postman).
