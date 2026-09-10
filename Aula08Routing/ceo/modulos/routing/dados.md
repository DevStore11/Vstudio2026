---
modulo: routing
ficheiro: dados.md
actualizado: 2026-09-02
versao: 1
---

# Dados — Routing

## Entidades

### Estudante
**Responsabilidade:** Representa um estudante matriculado.

| Campo | Tipo | Obrigatório | Descrição |
|---|---|---|---|
| Id | int | sim | Identificador único do estudante |
| Nome | string | sim | Nome completo do estudante |
| Curso | string | sim | Nome do curso frequentado |

### Curso
**Responsabilidade:** Representa um curso académico.

| Campo | Tipo | Obrigatório | Descrição |
|---|---|---|---|
| Id | int | sim | Identificador único do curso |
| Nome | string | sim | Nome do curso |
| DuracaoAnos | int | sim | Duração do curso em anos |

### Disciplina
**Responsabilidade:** Representa uma disciplina lecionada.

| Campo | Tipo | Obrigatório | Descrição |
|---|---|---|---|
| Id | int | sim | Identificador único da disciplina |
| Nome | string | sim | Nome da disciplina |
| Descricao | string | sim | Descrição ou sumário da disciplina |

## Armazenamento
- Dicionários em memória (`Dictionary<int, T>`) estáticos na classe `AppData`.
