---
modulo: routing
ficheiro: riscos.md
actualizado: 2026-09-02
versao: 1
---

# Riscos — Routing

## Risco — Dados voláteis em memória
**Severidade:** Baixa
**Probabilidade:** Alta
**Estado:** Aceite (Contexto Laboratorial)

### Descrição
Como os dados estão armazenados em dicionários estáticos (`Dictionary<int, T>`), qualquer reinício da aplicação limpa alterações e repõe o estado inicial.

### Impacto
Perda de dados em caso de restart do processo.

### Mitigação actual
Nenhuma necessária para fins educacionais de routing.

### O que falta
Introdução de Entity Framework Core e base de dados persistente (ex: SQLite ou PostgreSQL) se a aplicação evoluir para produção.
