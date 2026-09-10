---
modulo: routing
ficheiro: 2026-09-02-auditoria-inicial.md
actualizado: 2026-09-02
versao: 1
---

# Auditoria — Routing — 2026-09-02

## Âmbito
Auditoria ao projeto `Aula08Routing` após refatoração da estrutura monolítica (`Program.cs`) para arquitetura modular orientada a Minimal APIs.

## Crítico — resolve antes de ir para produção
- Nenhum em ambiente de laboratório/protótipo. Se transitar para produção, requer persistência em base de dados e camadas de segurança/autenticação.

## Importante — resolve na próxima iteração
- [ ] Adicionar testes unitários e de integração (xUnit) para validar o routing e o comportamento de 404.
- [ ] Validar inputs e sanitizar strings caso sejam introduzidos inputs de utilizador.

## Menor — dívida técnica conhecida
- Dados estáticos em memória sem repositório de dados abstraído.

## O que foi testado
- Compilação limpa do projeto (.NET 10.0).
- Verificação de rotas e mapeamento por extension methods.

## Decisões necessárias
- Nenhuma no estágio atual.
