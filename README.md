# 🚗 Rent a Car - Sistema de Gestão de Alugueres

Sistema web desenvolvido em **ASP.NET Core MVC** com **Entity Framework Core** e **MySQL**, que permite gerir alugueres de veículos. O projeto foi desenvolvido no âmbito da UFCD 10792 - Programação ASP.NET Core MVC.

---

## 📋 Funcionalidades

- ✅ **CRUD completo** (Criar, Ler, Editar, Excluir) de alugueres
- 🔍 **Pesquisa dinâmica** por cliente, vendedor ou veículo
- 📄 **Paginação** (5 registos por página)
- 📱 **Interface responsiva** com Bootstrap 5
- 🎨 **Tema personalizado** (Bootswatch - Sandstone)
- 🏷️ **Ícones** Bootstrap Icons
- ⚡ **Validação de dados** no lado do servidor e cliente
- 💬 **Mensagens de sucesso/erro** (TempData)
- 🗑️ **Confirmação de exclusão** com SweetAlert2

---

## 🛠️ Tecnologias Utilizadas

| Tecnologia | Versão |
|------------|--------|
| .NET | 10.0 |
| ASP.NET Core MVC | 10.0 |
| Entity Framework Core | 9.0.0 |
| MySQL | 8.0+ |
| Pomelo.EntityFrameworkCore.MySql | 9.0.0 |
| Bootstrap | 5.3.0 |
| SweetAlert2 | 11.x |

---

## 📁 Estrutura do Projeto
Mod5_CRUD/
├── Controllers/
│ ├── AlugueresController.cs
│ └── HomeController.cs
├── Models/
│ ├── AlugueresModel.cs
│ └── ErrorViewModel.cs
├── Data/
│ └── ApplicationDbContext.cs
├── Views/
│ ├── Alugueres/
│ │ ├── Index.cshtml
│ │ ├── Cadastrar.cshtml
│ │ ├── Editar.cshtml
│ │ └── Excluir.cshtml
│ ├── Home/
│ │ └── Index.cshtml
│ └── Shared/
│ └── _Layout.cshtml
├── wwwroot/
│ ├── css/
│ ├── img/
│ ├── js/
│ └── lib/
├── Migrations/
├── appsettings.json
├── appsettings.Development.json
├── Program.cs
└── Mod5_CRUD.csproj
text


---

## ⚙️ Configuração do Ambiente

### Pré-requisitos

- [.NET 10.0 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)
- [MySQL Server 8.0+](https://dev.mysql.com/downloads/mysql/)
- [MySQL Workbench](https://dev.mysql.com/downloads/workbench/) (opcional)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) ou [VS Code](https://code.visualstudio.com/)

### Passos para executar localmente

1. **Clonar o repositório**
   ```bash
   git clone https://github.com/SEU_USUARIO/Mod5_CRUD.git
   cd Mod5_CRUD

    Configurar a string de conexão no appsettings.json
    json

    "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Database=Mod5_CRUD;Uid=root;Pwd=sua_password;"
    }

    Restaurar os pacotes NuGet
    bash

    dotnet restore

    Aplicar as migrações (criar a base de dados)
    bash

    dotnet ef database update

    Executar o projeto
    bash

    dotnet run

    Aceder no browser
    text

    https://localhost:5001


