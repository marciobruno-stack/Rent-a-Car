# Rent a Car - Sistema de Gestao de Alugueres

Sistema web desenvolvido em **ASP.NET Core MVC** com **Entity Framework Core** e **MySQL**, que permite gerir alugueres de veiculos. O projeto foi desenvolvido no ambito da UFCD 10792 - Programacao ASP.NET Core MVC.

---

## Funcionalidades

- CRUD completo (Criar, Ler, Editar, Excluir) de alugueres
- Pesquisa dinamica por cliente, vendedor ou veiculo
- Paginacao (5 registos por pagina)
- Interface responsiva com Bootstrap 5
- Tema personalizado (Bootswatch - Sandstone)
- Icones Bootstrap Icons
- Validacao de dados no lado do servidor e cliente
- Mensagens de sucesso/erro (TempData)
- Confirmacao de exclusao com SweetAlert2

---

## Tecnologias Utilizadas

| Tecnologia | Versao |
|------------|--------|
| .NET | 10.0 |
| ASP.NET Core MVC | 10.0 |
| Entity Framework Core | 9.0.0 |
| MySQL | 8.0+ |
| Pomelo.EntityFrameworkCore.MySql | 9.0.0 |
| Bootstrap | 5.3.0 |
| SweetAlert2 | 11.x |

---

## Estrutura do Projeto

```
Mod5_CRUD/
├── Controllers/
│   ├── AlugueresController.cs
│   └── HomeController.cs
├── Models/
│   ├── AlugueresModel.cs
│   └── ErrorViewModel.cs
├── Data/
│   └── ApplicationDbContext.cs
├── Views/
│   ├── Alugueres/
│   │   ├── Index.cshtml
│   │   ├── Cadastrar.cshtml
│   │   ├── Editar.cshtml
│   │   └── Excluir.cshtml
│   ├── Home/
│   │   └── Index.cshtml
│   └── Shared/
│       └── _Layout.cshtml
├── wwwroot/
│   ├── css/
│   ├── img/
│   ├── js/
│   └── lib/
├── Migrations/
├── appsettings.json
├── appsettings.Development.json
├── Program.cs
└── Mod5_CRUD.csproj
```

---

## Configuracao do Ambiente

### Pre-requisitos

- [.NET 10.0 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)
- [MySQL Server 8.0+](https://dev.mysql.com/downloads/mysql/)
- [MySQL Workbench](https://dev.mysql.com/downloads/workbench/) (opcional)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) ou [VS Code](https://code.visualstudio.com/)

### Passos para executar localmente

1. Clonar o repositorio
   ```
   git clone https://github.com/marciobruno-stack/Rent-a-Car.git
   cd Rent-a-Car
   ```

2. Configurar a string de conexao no appsettings.json
   ```
   "ConnectionStrings": {
     "DefaultConnection": "Server=localhost;Database=Mod5_CRUD;Uid=root;Pwd=sua_password;"
   }
   ```

3. Restaurar os pacotes NuGet
   ```
   dotnet restore
   ```

4. Aplicar as migracoes (criar a base de dados)
   ```
   dotnet ef database update
   ```

5. Executar o projeto
   ```
   dotnet run
   ```

6. Aceder no browser
   ```
   https://localhost:5001
   ```

---

## Publicacao (Deploy)

### Local (IIS)

1. Publicar o projeto:
   ```
   dotnet publish -c Release -o ./Publish
   ```
2. Copiar a pasta Publish para C:\inetpub\wwwroot\RentACar
3. Criar um novo Site no IIS Manager
4. Configurar o Application Pool para "Sem Codigo Gerenciado"
5. Testar em http://localhost:8080

### Azure App Service

1. Criar uma Web App no Azure
2. Publicar diretamente pelo Visual Studio ou VS Code
3. Configurar a string de conexao nas definicoes da App Service

---

## Contribuicao

1. Fazer um Fork do projeto
2. Criar uma Branch para a sua funcionalidade
3. Fazer Commit das alteracoes
4. Fazer Push para a Branch
5. Abrir um Pull Request

---

## Licenca

Este projeto foi desenvolvido para fins educacionais no ambito da UFCD 10792 - Programacao ASP.NET Core MVC.

---

## Autor

**Marcio Bruno**
Aluno da UFCD 10792 - Programacao ASP.NET Core MVC

---

## Agradecimentos

- Formadora: Claudia Nunes
- Todos os colegas que contribuiram com feedback e sugestoes

---

## Contacto

Para duvidas ou sugestoes, pode abrir uma Issue no GitHub ou contactar diretamente.

---

© 2026 - Rent a Car | Todos os direitos reservados
```

