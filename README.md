Aqui está o `README.md` com **emojis** e **badges (gifs/ícones)** para as tecnologias utilizadas:

---

```markdown
# 🚗 Rent a Car - Sistema de Gestão de Alugueres

![.NET](https://img.shields.io/badge/.NET-10.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![ASP.NET Core](https://img.shields.io/badge/ASP.NET_Core-10.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![MySQL](https://img.shields.io/badge/MySQL-8.0+-4479A1?style=for-the-badge&logo=mysql&logoColor=white)
![Bootstrap](https://img.shields.io/badge/Bootstrap-5.3.0-7952B3?style=for-the-badge&logo=bootstrap&logoColor=white)
![SweetAlert2](https://img.shields.io/badge/SweetAlert2-11.x-7B16FF?style=for-the-badge&logo=sweetalert&logoColor=white)

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

| Tecnologia | Versão | Ícone |
|------------|--------|-------|
| .NET | 10.0 | <img src="https://img.icons8.com/color/48/000000/net-framework.png" width="24"/> |
| ASP.NET Core MVC | 10.0 | <img src="https://img.icons8.com/color/48/000000/asp.png" width="24"/> |
| Entity Framework Core | 9.0.0 | <img src="https://img.icons8.com/color/48/000000/entity-framework.png" width="24"/> |
| MySQL | 8.0+ | <img src="https://img.icons8.com/color/48/000000/mysql-logo.png" width="24"/> |
| Pomelo.EntityFrameworkCore.MySql | 9.0.0 | <img src="https://img.icons8.com/color/48/000000/mysql.png" width="24"/> |
| Bootstrap | 5.3.0 | <img src="https://img.icons8.com/color/48/000000/bootstrap.png" width="24"/> |
| SweetAlert2 | 11.x | <img src="https://img.icons8.com/color/48/000000/alert.png" width="24"/> |

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

- [.NET 10.0 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)
- [MySQL Server 8.0+](https://dev.mysql.com/downloads/mysql/)
- [MySQL Workbench](https://dev.mysql.com/downloads/workbench/) (opcional)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) ou [VS Code](https://code.visualstudio.com/)

### 🚀 Passos para executar localmente

1. **Clonar o repositório**
   ```bash
   git clone https://github.com/marciobruno-stack/Rent-a-Car.git
   cd Rent-a-Car
   ```

2. **Configurar a string de conexão no `appsettings.json`**
   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=localhost;Database=Mod5_CRUD;Uid=root;Pwd=sua_password;"
   }
   ```

3. **Restaurar os pacotes NuGet**
   ```bash
   dotnet restore
   ```

4. **Aplicar as migrações (criar a base de dados)**
   ```bash
   dotnet ef database update
   ```

5. **Executar o projeto**
   ```bash
   dotnet run
   ```

6. **Aceder no browser**
   ```
   https://localhost:5001
   ```

---

## 🚀 Publicação (Deploy)

### 🖥️ Local (IIS)

1. Publicar o projeto:
   ```bash
   dotnet publish -c Release -o ./Publish
   ```
2. Copiar a pasta `Publish` para `C:\inetpub\wwwroot\RentACar`
3. Criar um novo Site no **IIS Manager**
4. Configurar o **Application Pool** para **"Sem Código Gerenciado"**
5. Testar em `http://localhost:8080`

### ☁️ Azure App Service

1. Criar uma Web App no Azure
2. Publicar diretamente pelo Visual Studio ou VS Code
3. Configurar a string de conexão nas definições da App Service

---

## 🤝 Contribuição

1. 🍴 Fazer um **Fork** do projeto
2. 🌿 Criar uma **Branch** para a sua funcionalidade (`git checkout -b feature/nova-funcionalidade`)
3. ✏️ Fazer **Commit** das alterações (`git commit -m 'Adiciona nova funcionalidade'`)
4. 📤 Fazer **Push** para a Branch (`git push origin feature/nova-funcionalidade`)
5. 🔄 Abrir um **Pull Request**

---

## 📝 Licença

Este projeto foi desenvolvido para fins educacionais no âmbito da UFCD 10792 - Programação ASP.NET Core MVC.

---

## 👨‍💻 Autor

**Marcio Bruno**  
👨‍🎓 Aluno da UFCD 10792 - Programação ASP.NET Core MVC

---

## 🙏 Agradecimentos

- 👩‍🏫 Formadora: Cláudia Nunes
- 🤝 Todos os colegas que contribuíram com feedback e sugestões

---

## 📞 Contacto

Para dúvidas ou sugestões, pode abrir uma **Issue** no GitHub ou contactar diretamente.

---

**© 2026 - Rent a Car | Todos os direitos reservados** 🚗
```

---

## 📸 Exemplo visual no GitHub

### Badges (no topo)
![.NET](https://img.shields.io/badge/.NET-10.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![ASP.NET Core](https://img.shields.io/badge/ASP.NET_Core-10.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![MySQL](https://img.shields.io/badge/MySQL-8.0+-4479A1?style=for-the-badge&logo=mysql&logoColor=white)

### Estrutura com ícones
```
📁 Mod5_CRUD/
├── 📁 Controllers/
│   ├── 📄 AlugueresController.cs
│   └── 📄 HomeController.cs
```



