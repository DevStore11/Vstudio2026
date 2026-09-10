---
modulo: routing
data: 2026-09-02
tipo: refactor
---

# Refatoração e Modularização do Sistema de Routing

## O que foi feito
Separação do código contido em `Program.cs` numa arquitetura limpa e modular:
- Criação da pasta `Models/` com `Estudante.cs`, `Curso.cs` e `Disciplina.cs`.
- Criação da pasta `Data/` com `AppData.cs` (dados em memória).
- Criação da pasta `Helpers/` com `HtmlHelper.cs`.
- Criação da pasta `Endpoints/` com `EstudanteEndpoints.cs`, `CursoEndpoints.cs` e `DisciplinaEndpoints.cs` utilizando Extension Methods.
- Limpeza do `Program.cs` para conter apenas o bootstrapping da aplicação.

## Decisão que motivou
- `decisoes/routing/0001-modularizacao-minimal-apis.md`

## Ficheiros do módulo actualizados
- `README.md` — Criado com visão geral, fronteiras e diagrama.
- `dados.md` — Documentadas entidades e armazenamento.
- `contratos.md` — Documentados endpoints HTTP e responses.
- `riscos.md` — Registado risco de dados voláteis em memória.

## Ficheiros de código tocados
- `Program.cs`
- `Models/Estudante.cs`
- `Models/Curso.cs`
- `Models/Disciplina.cs`
- `Data/AppData.cs`
- `Helpers/HtmlHelper.cs`
- `Endpoints/EstudanteEndpoints.cs`
- `Endpoints/CursoEndpoints.cs`
- `Endpoints/DisciplinaEndpoints.cs`

## O que ficou por fazer
- Testes unitários (xUnit).

## Riscos introduzidos
- Nenhum.
