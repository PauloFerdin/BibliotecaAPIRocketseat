# BibliotecaAPIRocketseat
API RESTful em C# com ASP.NET Core para gerenciar uma livraria online. Permite criar, visualizar, editar e excluir livros, com respostas HTTP consistentes. Desenvolvida com foco em boas práticas, é ideal para estudo e aprendizado de APIs RESTful.

---

## 📋 Funcionalidades

A API oferece os seguintes recursos:

- **Criar Livro**: Adiciona um novo livro ao sistema.
- **Listar Livros**: Visualiza todos os livros cadastrados.
- **Detalhar Livro**: Visualiza informações de um livro específico.
- **Atualizar Livro**: Edita os dados de um livro existente.
- **Excluir Livro**: Remove um livro do sistema.

---

## 🛠️ Tecnologias Utilizadas

- **Linguagem**: C#
- **Framework**: ASP.NET Core
- **Banco de Dados**: Em memória (usando Entity Framework Core)
- **Ferramentas**:
  - Swagger para documentação e teste dos endpoints
  - Visual Studio como ambiente de desenvolvimento

---

## 🚀 Como Rodar o Projeto

1. Clone este repositório:
   ```bash
  git clone https://github.com/PauloFerdin/BibliotecaAPIRocketseat.git

2. Navegue até a pasta do projeto:

cd LivrariaAPI

4. Abra o projeto no Visual Studio.

5. Execute o projeto:

    Pressione F5 ou clique em "Executar".

6. Acesse o Swagger no navegador:

    URL padrão: https://localhost:{porta}/swagger
---
   
## 💡 Melhorias Futuras

Algumas ideias para expandir este projeto:

   - Integração com um banco de dados real (SQL Server ou MySQL).
   - Implementar autenticação e autorização.
   - Criar testes automatizados para validar os endpoints.
   - Adicionar filtros para busca de livros por título ou autor.

---

## 📖 Endpoints

1. Listar todos os livros

    GET /api/livros
    Descrição: Retorna todos os livros cadastrados.

2. Detalhar um livro

    GET /api/livros/{id}
    Descrição: Retorna os detalhes de um livro específico pelo id.

3. Criar um livro

    POST /api/livros
    Descrição: Adiciona um novo livro ao sistema.
    Body (exemplo):

    {
      "titulo": "O Senhor dos Anéis",
      "autor": "J.R.R. Tolkien",
      "genero": "Fantasia",
      "preco": 59.90,
      "quantidadeEmEstoque": 10
    }

4. Atualizar um livro

    PUT /api/livros/{id}
    Descrição: Atualiza os dados de um livro existente.
    Body (exemplo):

    {
      "id": 1,
      "titulo": "O Hobbit",
      "autor": "J.R.R. Tolkien",
      "genero": "Fantasia",
      "preco": 49.90,
      "quantidadeEmEstoque": 8
    }

5. Excluir um livro

    DELETE /api/livros/{id}
    Descrição: Remove um livro pelo id

---

## 📂 Estrutura do Projeto

   - Models: Contém as classes que representam os dados (ex.: Livro).
   - Data: Configurações do banco de dados em memória.
   - Controllers: Contém os endpoints da API.

---

## 📝 Autor

Desenvolvido por Paulo Cesar Maximiano Ferdin como parte do desafio prático da Rocketseat. 🚀
   
