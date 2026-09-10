---
modulo: routing
ficheiro: contratos.md
actualizado: 2026-09-02
versao: 1
---

# Contratos — Routing

## GET /estudantes/{id}
**Autenticação:** Não requerida
**Autorização:** Pública

### Request
- Path parameter: `id` (int)

### Response — Sucesso (200 OK)
- Content-Type: `text/html; charset=utf-8`
- Body: Página HTML formatada com os dados do estudante.

### Response — Erros
| Código | Condição | Mensagem |
|---|---|---|
| 404 | Estudante não encontrado | Página HTML indicando que o estudante não existe |

---

## GET /cursos/{id}
**Autenticação:** Não requerida
**Autorização:** Pública

### Request
- Path parameter: `id` (int)

### Response — Sucesso (200 OK)
- Content-Type: `text/html; charset=utf-8`
- Body: Página HTML formatada com os dados do curso.

### Response — Erros
| Código | Condição | Mensagem |
|---|---|---|
| 404 | Curso não encontrado | Página HTML indicando que o curso não existe |

---

## GET /disciplinas/{id}
**Autenticação:** Não requerida
**Autorização:** Pública

### Request
- Path parameter: `id` (int)

### Response — Sucesso (200 OK)
- Content-Type: `text/html; charset=utf-8`
- Body: Página HTML formatada com os dados da disciplina.

### Response — Erros
| Código | Condição | Mensagem |
|---|---|---|
| 404 | Disciplina não encontrada | Página HTML indicando que a disciplina não existe |
