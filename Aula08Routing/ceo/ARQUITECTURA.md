---
modulo: raiz
ficheiro: ARQUITECTURA.md
actualizado: 2026-09-02
versao: 1
---

# Arquitetura — Aula08Routing

## Visão de Componentes

```mermaid
graph LR
    subgraph Cliente
        Browser[Browser / Cliente HTTP]
    end

    subgraph Servidor ASP.NET Core
        Static[Static Files Middleware]
        Routing[Endpoint Routing Table]
        Endpoints[Módulo Routing / Endpoints]
        Data[AppData / Memória]
        Helpers[HtmlHelper]
    end

    Browser -->|GET /| Static
    Browser -->|GET /estudantes/{id}| Routing
    Browser -->|GET /cursos/{id}| Routing
    Browser -->|GET /disciplinas/{id}| Routing
    Routing --> Endpoints
    Endpoints --> Data
    Endpoints --> Helpers
    Static -->|wwwroot/index.html| Browser
    Helpers -->|HTML Response| Browser
```

## Princípios Arquiteturais
1. **Separação de Responsabilidades**: O arranque (`Program.cs`) delega o mapeamento para Extension Methods em `Endpoints/`.
2. **Contratos Modulares**: Entidades isoladas em `Models/`, acesso a dados centralizado em `Data/`, e formatação visual em `Helpers/`.
3. **Sem Estado (Stateless Routing)**: Os endpoints processam pedidos HTTP de forma síncrona utilizando coleções em memória para fins educacionais.
