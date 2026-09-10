---
modulo: routing
ficheiro: 0001-modularizacao-minimal-apis.md
actualizado: 2026-09-02
versao: 1
---

# [0001] Modularização de Minimal APIs e Separação de Responsabilidades

**Data:** 2026-09-02
**Estado:** Activo

### Contexto
O código inicial encontrava-se concentrado num único ficheiro `Program.cs`, misturando modelos de dados, base de dados em memória, funções auxiliares de HTML e múltiplos endpoints. Isto tornava o código difícil de manter à medida que o sistema crescesse.

### Opções consideradas
- **Opção A — Manter tudo em `Program.cs`**: Simples para scripts de 20 linhas, mas inviável para manutenibilidade e testes.
- **Opção B — Modularização por Pastas e Extension Methods**: Separar modelos (`Models/`), dados (`Data/`), helpers (`Helpers/`) e rotas por domínio (`Endpoints/`), mantendo o poder e simplicidade das Minimal APIs.

### Decisão
Foi escolhida a **Opção B**. Os endpoints foram encapsulados em extension methods de `IEndpointRouteBuilder`, permitindo que o `Program.cs` atue unicamente como ponto de configuração e arranque.

### Consequências
- **Facilita:** Testabilidade, legibilidade e adição de novos domínios/rotas.
- **Dificulta:** Leve aumento no número de ficheiros do projeto.
