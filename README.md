Aqui está o `README.md` corrigido e formatado corretamente:

---

## `README.md` corrigido

```markdown
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

## ⚙️ Configuração do Ambiente

### Pré-requisitos

- [.NET 10.0 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)
- [MySQL Server 8.0+](https://dev.mysql.com/downloads/mysql/)
- [MySQL Workbench](https://dev.mysql.com/downloads/workbench/) (opcional)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) ou [VS Code](https://code.visualstudio.com/)

### Passos para executar localmente

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

### Local (IIS)

1. Publicar o projeto:
   ```bash
   dotnet publish -c Release -o ./Publish
   ```
2. Copiar a pasta `Publish` para `C:\inetpub\wwwroot\RentACar`
3. Criar um novo Site no **IIS Manager**
4. Configurar o **Application Pool** para **"Sem Código Gerenciado"**
5. Testar em `http://localhost:8080`

### Azure App Service

1. Criar uma Web App no Azure
2. Publicar diretamente pelo Visual Studio ou VS Code
3. Configurar a string de conexão nas definições da App Service

---

## 📸 Screenshots

### Página de Listagem (Index)
![Listagem de Alugueres](docs/screenshot-index.png)

### Página de Cadastro
![Cadastro de Aluguer](docs/screenshot-cadastro.png)

### Página de Edição
![Edição de Aluguer](docs/screenshot-editar.png)

---

## 🤝 Contribuição

1. Fazer um **Fork** do projeto
2. Criar uma **Branch** para a sua funcionalidade (`git checkout -b feature/nova-funcionalidade`)
3. Fazer **Commit** das alterações (`git commit -m 'Adiciona nova funcionalidade'`)
4. Fazer **Push** para a Branch (`git push origin feature/nova-funcionalidade`)
5. Abrir um **Pull Request**

---

## 📝 Licença

Este projeto foi desenvolvido para fins educacionais no âmbito da UFCD 10792 - Programação ASP.NET Core MVC.

---

## 👨‍💻 Autor

**Marcio Bruno**  
Aluno da UFCD 10792 - Programação ASP.NET Core MVC

---

## 🙏 Agradecimentos

- Formadora: Cláudia Nunes

---

## 📞 Contacto

Para dúvidas ou sugestões, podes abrir uma **Issue** no GitHub ou contactar diretamente.

---

**© 2026 - Rent a Car | Todos os direitos reservados**
```

---

## Alterações feitas

| Problema | Correção |
|----------|----------|
| Estrutura do projeto mal formatada | Adicionadas ` ``` ` para código e indentação correta |
| URL do repositório incorreta | Atualizada para `https://github.com/marciobruno-stack/Rent-a-Car.git` |
| Falta de separação entre passos | Adicionados números e espaçamento |
| Texto solto sem formatação | Corrigida a sintaxe Markdown |
| Nome do projeto inconsistente | Uniformizado para "Rent a Car" |

---

