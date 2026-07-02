------


```markdown
# 🚗 Rent a Car - Sistema de Gestão de Alugueres

![.NET](https://img.shields.io/badge/.NET-10.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![ASP.NET Core](https://img.shields.io/badge/ASP.NET_Core-10.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![MySQL](https://img.shields.io/badge/MySQL-8.0+-4479A1?style=for-the-badge&logo=mysql&logoColor=white)
![Bootstrap](https://img.shields.io/badge/Bootstrap-5.3.0-7952B3?style=for-the-badge&logo=bootstrap&logoColor=white)
![SweetAlert2](https://img.shields.io/badge/SweetAlert2-11.x-7B16FF?style=for-the-badge&logo=sweetalert&logoColor=white)
![Entity Framework](https://img.shields.io/badge/Entity_Framework-9.0.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Pomelo](https://img.shields.io/badge/Pomelo-9.0.0-4479A1?style=for-the-badge&logo=mysql&logoColor=white)
![Visual Studio](https://img.shields.io/badge/Visual_Studio-2022-5C2D91?style=for-the-badge&logo=visualstudio&logoColor=white)
![GitHub](https://img.shields.io/badge/GitHub-Repository-181717?style=for-the-badge&logo=github&logoColor=white)

Sistema web desenvolvido em **ASP.NET Core MVC** com **Entity Framework Core** e **MySQL**, que permite gerir alugueres de veículos. O projeto foi desenvolvido no âmbito da **UFCD 10792 - Programação ASP.NET Core MVC**.

---

## 📋 Funcionalidades

| Funcionalidade | Descrição |
|----------------|-----------|
| ✅ **CRUD completo** | Criar, Ler, Editar e Excluir alugueres |
| 🔍 **Pesquisa dinâmica** | Filtrar por cliente, vendedor ou veículo |
| 📄 **Paginação** | 5 registos por página para melhor organização |
| 📱 **Interface responsiva** | Adaptada a todos os dispositivos com Bootstrap 5 |
| 🎨 **Tema personalizado** | Bootswatch - Sandstone |
| 🏷️ **Ícones** | Bootstrap Icons para melhor experiência visual |
| ⚡ **Validação de dados** | No lado do servidor e do cliente |
| 💬 **Mensagens de sucesso/erro** | Utilização de TempData |
| 🗑️ **Confirmação de exclusão** | Com SweetAlert2 |

---

## 🛠️ Tecnologias Utilizadas

| Tecnologia | Versão | Ícone |
|------------|--------|-------|
| .NET | 10.0 | <img src="https://img.icons8.com/color/48/000000/net-framework.png" width="30"/> |
| ASP.NET Core MVC | 10.0 | <img src="https://img.icons8.com/color/48/000000/asp.png" width="30"/> |
| Entity Framework Core | 9.0.0 | <img src="https://img.icons8.com/color/48/000000/entity-framework.png" width="30"/> |
| MySQL | 8.0+ | <img src="https://img.icons8.com/color/48/000000/mysql-logo.png" width="30"/> |
| Pomelo.EntityFrameworkCore.MySql | 9.0.0 | <img src="https://img.icons8.com/color/48/000000/mysql.png" width="30"/> |
| Bootstrap | 5.3.0 | <img src="https://img.icons8.com/color/48/000000/bootstrap.png" width="30"/> |
| SweetAlert2 | 11.x | <img src="https://img.icons8.com/color/48/000000/alert.png" width="30"/> |
| Visual Studio | 2022 | <img src="https://img.icons8.com/color/48/000000/visual-studio.png" width="30"/> |
| Git | Latest | <img src="https://img.icons8.com/color/48/000000/git.png" width="30"/> |

---

## 📁 Estrutura do Projeto

```
📁 Mod5_CRUD/
├── 📁 Controllers/
│   ├── 📄 AlugueresController.cs
│   └── 📄 HomeController.cs
├── 📁 Models/
│   ├── 📄 AlugueresModel.cs
│   └── 📄 ErrorViewModel.cs
├── 📁 Data/
│   └── 📄 ApplicationDbContext.cs
├── 📁 Views/
│   ├── 📁 Alugueres/
│   │   ├── 📄 Index.cshtml
│   │   ├── 📄 Cadastrar.cshtml
│   │   ├── 📄 Editar.cshtml
│   │   └── 📄 Excluir.cshtml
│   ├── 📁 Home/
│   │   └── 📄 Index.cshtml
│   └── 📁 Shared/
│       └── 📄 _Layout.cshtml
├── 📁 wwwroot/
│   ├── 📁 css/
│   ├── 📁 Docs/
│   │   ├── 🖼️ screenshot-index.png
│   │   ├── 🖼️ screenshot-cadastro.png
│   │   ├── 🖼️ screenshot-editar.png
│   │   └── 🖼️ screenshot-excluir.png
│   ├── 📁 img/
│   ├── 📁 js/
│   └── 📁 lib/
├── 📁 Migrations/
├── 📄 appsettings.json
├── 📄 appsettings.Development.json
├── 📄 Program.cs
└── 📄 Mod5_CRUD.csproj
```

---

## ⚙️ Configuração do Ambiente

### 📋 Pré-requisitos

| Recurso | Descrição |
|---------|-----------|
| [.NET 10.0 SDK](https://dotnet.microsoft.com/download/dotnet/10.0) | Framework principal |
| [MySQL Server 8.0+](https://dev.mysql.com/downloads/mysql/) | Base de dados |
| [MySQL Workbench](https://dev.mysql.com/downloads/workbench/) | Gestão do MySQL (opcional) |
| [Visual Studio 2022](https://visualstudio.microsoft.com/) | IDE principal |
| [VS Code](https://code.visualstudio.com/) | Editor alternativo |
| [Git](https://git-scm.com/) | Controlo de versões |

---

### 🚀 Passos para executar localmente

#### 1. Clonar o repositório
```bash
git clone https://github.com/marciobruno-stack/Rent-a-Car.git
cd Rent-a-Car
```

#### 2. Configurar a string de conexão no `appsettings.json`
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=RentACar;Uid=root;Pwd=sua_password;"
  }
}
```

#### 3. Restaurar os pacotes NuGet
```bash
dotnet restore
```

#### 4. Aplicar as migrações (criar a base de dados)
```bash
dotnet ef database update
```

#### 5. Executar o projeto
```bash
dotnet run
```

#### 6. Aceder no browser
```
https://localhost:5001
```

---

## 🚀 Publicação (Deploy)

### 🖥️ Local (IIS)

| Passo | Ação |
|-------|------|
| 1 | Publicar o projeto: `dotnet publish -c Release -o ./Publish` |
| 2 | Copiar a pasta `Publish` para `C:\inetpub\wwwroot\RentACar` |
| 3 | Criar um novo Site no **IIS Manager** |
| 4 | Configurar o **Application Pool** para **"Sem Código Gerenciado"** |
| 5 | Testar em `http://localhost:8080` |

### ☁️ Azure App Service

| Passo | Ação |
|-------|------|
| 1 | Criar uma Web App no Azure |
| 2 | Publicar diretamente pelo Visual Studio ou VS Code |
| 3 | Configurar a string de conexão nas definições da App Service |

---

## 📸 Screenshots

### Página de Listagem (Index)
![Listagem de Alugueres](wwwroot/Docs/screenshot-index.png)

### Página de Cadastro
![Cadastro de Aluguer](wwwroot/Docs/screenshot-cadastro.png)

### Página de Edição
![Edição de Aluguer](wwwroot/Docs/screenshot-editar.png)

### Página de Exclusão com SweetAlert2
![Exclusão com SweetAlert2](wwwroot/Docs/screenshot-excluir.png)

---

## 🤝 Contribuição

| Passo | Ação |
|-------|------|
| 1 | 🍴 Fazer um **Fork** do projeto |
| 2 | 🌿 Criar uma **Branch**: `git checkout -b feature/nova-funcionalidade` |
| 3 | ✏️ Fazer **Commit**: `git commit -m 'Adiciona nova funcionalidade'` |
| 4 | 📤 Fazer **Push**: `git push origin feature/nova-funcionalidade` |
| 5 | 🔄 Abrir um **Pull Request** |

---

## 📝 Licença

Este projeto foi desenvolvido para fins educacionais no âmbito da **UFCD 10792 - Programação ASP.NET Core MVC**.

---

## 👨‍💻 Autor

**Marcio Bruno**  
👨‍🎓 Aluno da UFCD 10792 - Programação ASP.NET Core MVC  
📍 Portugal  
🔗 [GitHub](https://github.com/marciobruno-stack)

---

## 🙏 Agradecimentos

- 👩‍🏫 **Formadora:** Cláudia Nunes
- 🤝 **Colegas:** Todos os que contribuíram com feedback e sugestões
- 📚 **Recursos:** Documentação oficial da Microsoft, Bootswatch, Bootstrap Icons

---

## 📞 Contacto

Para dúvidas ou sugestões, pode abrir uma **Issue** no GitHub ou contactar diretamente.

---

## 📊 Status do Projeto

![Status](https://img.shields.io/badge/Status-Concluído-success?style=for-the-badge)
![Versão](https://img.shields.io/badge/Versão-1.0.0-blue?style=for-the-badge)
![Licença](https://img.shields.io/badge/Licença-Educacional-orange?style=for-the-badge)

---

**© 2026 - Rent a Car | Todos os direitos reservados** 🚗
```


````````

