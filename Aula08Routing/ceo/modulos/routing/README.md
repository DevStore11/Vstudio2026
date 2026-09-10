---
modulo: routing
ficheiro: README.md
actualizado: 2026-09-02
versao: 1
---

# Módulo — Routing

## Responsabilidade
Gerir o encaminhamento de rotas HTTP e apresentação de dados académicos (Estudantes, Cursos e Disciplinas) em ASP.NET Core Minimal APIs.

## Fronteiras
**Consome:** Nenhum serviço externo (dados em memória).
**Expõe:** Endpoints HTTP GET para `/estudantes/{id}`, `/cursos/{id}` e `/disciplinas/{id}`.
**Não faz:** Persistência em base de dados relacional ou autenticação/autorização (escopo laboratorial).

## Diagrama de contexto
```mermaid
graph TD
    title Contexto do Módulo Routing
    Client[Cliente HTTP] -->|GET /estudantes/{id}| RE[EstudanteEndpoints]
    Client -->|GET /cursos/{id}| CE[CursoEndpoints]
    Client -->|GET /disciplinas/{id}| DE[DisciplinaEndpoints]
    RE --> AppData
    CE --> AppData
    DE --> AppData
    RE --> HtmlHelper
    CE --> HtmlHelper
    DE --> HtmlHelper
```

## Estado actual
Implementado e Refatorado.

## Ficheiros deste módulo
- `dados.md` — Estrutura de dados em memória e entidades.
- `contratos.md` — Contratos de endpoints HTTP.
- `riscos.md` — Riscos e dívida técnica consciente.
- `decisoes.md` — Decisões arquiteturais tomadas.

## Registo de alterações
| Data | O que mudou |
|---|---|
| 2026-09-02 | Refatoração inicial separando Program.cs em Models, Data, Helpers e Endpoints. |
