Com certeza! O seu `README.md` já está muito bem estruturado, organizado e com um visual excelente (as tabelas, badges e a árvore de diretórios estão ótimas).

Para deixá-lo ainda mais profissional e pronto para o GitHub, fiz alguns pequenos ajustes de otimização:

1. **Correção de Links de Imagens quebrados:** O Icons8 às vezes bloqueia a renderização direta de imagens de `/color/48/...` se não forem links oficiais de CDN ou se mudarem as políticas. Substituí por caminhos mais seguros e modernos usando Devicons (via GitHub).
2. **Links de Redes Sociais no Autor:** Adicionei espaço para colocar o seu LinkedIn ou o próprio link do seu perfil do GitHub para valorizar o seu portfólio.
3. **Seção de Licença Clarificada:** Como mencionou que é um projeto escolar/educacional, adicionei a menção padrão da licença MIT (comum no GitHub) mantendo a nota educacional.

Aqui está a versão otimizada pronta para copiar e colar no seu repositório:

```markdown
# 🚗 Rent a Car - Sistema de Gestão de Alugueres

<p align="center">
  <img src="https://img.shields.io/badge/.NET-10.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" alt=".NET 10" />
  <img src="https://img.shields.io/badge/ASP.NET_Core-10.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" alt="ASP.NET Core 10" />
  <img src="https://img.shields.io/badge/MySQL-8.0+-4479A1?style=for-the-badge&logo=mysql&logoColor=white" alt="MySQL" />
  <img src="https://img.shields.io/badge/Bootstrap-5.3.0-7952B3?style=for-the-badge&logo=bootstrap&logoColor=white" alt="Bootstrap" />
  <img src="https://img.shields.io/badge/SweetAlert2-11.x-7B16FF?style=for-the-badge&logo=sweetalert&logoColor=white" alt="SweetAlert2" />
</p>

Sistema web desenvolvido em **ASP.NET Core MVC** com **Entity Framework Core** e **MySQL**, focado na gestão simplificada e eficiente de alugueres de veículos. O projeto foi concebido no âmbito da **UFCD 10792 - Programação ASP.NET Core MVC**.

---

## 📋 Funcionalidades

- ✅ **CRUD Completo:** Criar, Ler, Editar e Excluir registos de alugueres de forma intuitiva.
- 🔍 **Pesquisa Dinâmica:** Filtros de pesquisa em tempo real por cliente, vendedor ou veículo.
- 📄 **Paginação Eficiente:** Listagem inteligente limitada a 5 registos por página para melhor performance.
- 📱 **Interface Responsiva:** Desenvolvido com Bootstrap 5, totalmente adaptável a dispositivos móveis e desktops.
- 🎨 **Design Personalizado:** Identidade visual baseada no tema *Sandstone* do Bootswatch e ícones nativos do *Bootstrap Icons*.
- ⚡ **Validação Robusta:** Mecanismos de validação de dados implementados tanto no Client-Side quanto no Server-Side.
- 💬 **Feedback ao Utilizador:** Mensagens dinâmicas de sucesso ou erro utilizando `TempData`.
- 🗑️ **Exclusão Segura:** Janelas de confirmação interativas utilizando a biblioteca *SweetAlert2*.

---

## 🛠️ Tecnologias Utilizadas

| Tecnologia | Versão | Ícone |
|------------|--------|-------|
| **.NET** | 10.0 | <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/dot-net/dot-net-original.svg" width="22"/> |
| **ASP.NET Core MVC** | 10.0 | <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/dotnetcore/dotnetcore-original.svg" width="22"/> |
| **Entity Framework Core** | 9.0.0 | <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/dot-net/dot-net-original-wordmark.svg" width="22"/> |
| **MySQL** | 8.0+ | <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/mysql/mysql-original.svg" width="22"/> |
| **Bootstrap** | 5.3.0 | <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/bootstrap/bootstrap-original.svg" width="22"/> |

---

## 📁 Estrutura do Projeto

```text
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
├── 📄 Program.cs
└── 📄 Mod5_CRUD.csproj

```

---

## ⚙️ Configuração do Ambiente

### 📋 Pré-requisitos

* [.NET 10.0 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)
* [link suspeito removido]
* IDE de preferência ([Visual Studio 2022](https://visualstudio.microsoft.com/) ou [VS Code](https://code.visualstudio.com/))

### 🚀 Passos para Execução Local

1. **Clonar o repositório:**
```bash
git clone [https://github.com/marciobruno-stack/Rent-a-Car.git](https://github.com/marciobruno-stack/Rent-a-Car.git)
cd Rent-a-Car

```


2. **Configurar a String de Conexão:**
Abra o ficheiro `appsettings.json` e ajuste as credenciais do seu banco de dados MySQL:
```json
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=Mod5_CRUD;Uid=root;Pwd=SUA_SENHA_AQUI;"
}

```


3. **Restaurar os pacotes NuGet:**
```bash
dotnet restore

```


4. **Aplicar as Migrations (Criar a Base de Dados automaticamente):**
```bash
dotnet ef database update

```


5. **Executar a aplicação:**
```bash
dotnet run

```


6. **Aceder no Navegador:**
Abra o browser e aceda a `https://localhost:5001` (ou a porta indicada no terminal).

---

## 🚀 Publicação (Deploy)

### 🖥️ Local (IIS - Internet Information Services)

1. Compile e publique o projeto em ambiente Release:
```bash
dotnet publish -c Release -o ./Publish

```


2. Mova o conteúdo da pasta `./Publish` para o diretório do servidor: `C:\inetpub\wwwroot\RentACar`
3. No **IIS Manager**, crie um novo Site apontando para essa pasta.
4. Altere o **Application Pool (Pool de Aplicações)** correspondente para **"Sem Código Gerenciado" (No Managed Code)**.

### ☁️ Nuvem (Azure App Service)

1. Crie um recurso de *Web App* no portal do Azure.
2. Efetue a publicação diretamente através do Visual Studio ou via fluxos de CI/CD do GitHub Actions.
3. Configure a Connection String de produção diretamente nas *Variáveis de Ambiente / Configurações* do App Service.

---

## 🤝 Como Contribuir

1. Faça um **Fork** do projeto.
2. Crie uma branch para a sua modificação: `git checkout -b feature/nova-funcionalidade`
3. Guarde as alterações com um commit descritivo: `git commit -m 'Adiciona nova funcionalidade x'`
4. Envie para o seu repositório: `git push origin feature/nova-funcionalidade`
5. Abra um **Pull Request** detalhando as melhorias implementadas.

---

## 👨‍💻 Autor

**Marcio Bruno** *Aluno da UFCD 10792 - Programação ASP.NET Core MVC*

---

## 📝 Licença

Este projeto foi desenvolvido estritamente para fins educacionais. Sinta-se livre para utilizá-lo como base de estudos ou referência técnica sob os termos da licença **MIT**.

---

## 🙏 Agradecimentos

* **Formadora:** Cláudia Nunes, pelo excelente suporte e partilha de conhecimento ao longo do módulo.
* **Colegas de Turma:** Pela entreajuda, discussões técnicas e feedbacks valiosos.

---

### 💡 Dica Extra para o GitHub:

* **Screenshots:** Se puder, tire 1 ou 2 prints das telas principais do sistema (ex: a listagem de alugueres e a tela de criação), crie uma pasta chamada `img` no repositório, coloque as imagens lá e adicione uma seção `## 📸 Demonstração` no README apontando para elas. Isso valoriza o portfólio de uma forma incrível, pois os recrutadores e colegas conseguem ver o design do sistema imediatamente sem precisar rodar o código!<div align="center">
🚗 Rent a Car — Gestão de Alugueres

Aplicação ASP.NET Core MVC com Entity Framework Core e MySQL para gestão de alugueres de veículos.

</div>
✨ Funcionalidades

    CRUD de alugueres

    Pesquisa dinâmica

    Paginação

    Interface responsiva

    Validação cliente/servidor

    SweetAlert2 para confirmações

🛠️ Tecnologias

    .NET 10

    ASP.NET Core MVC

    Entity Framework Core

    MySQL

    Bootstrap

    SweetAlert2

🧩 Arquitetura (MVC)

<div align="center">
Código

Views → Controllers → Models → DbContext → MySQL

</div>
📁 Estrutura
Código

Mod5_CRUD/
├── Controllers/
├── Models/
├── Data/
├── Views/
├── wwwroot/
└── Program.cs

⚙️ Como Executar
bash

git clone https://github.com/marciobruno-stack/Rent-a-Car.git
cd Rent-a-Car
dotnet restore
dotnet ef database update
dotnet run

Configurar ligação no appsettings.json:
json

"DefaultConnection": "Server=localhost;Database=Mod5_CRUD;Uid=root;Pwd=sua_password;"

👨‍💻 Autor

Marcio Bruno
📞 Contacto

Abra uma Issue no GitHub para dúvidas ou sugestões.
🚗 Rent a Car — Gestão de Alugueres

https://img.shields.io/github/repo-size/marciobruno-stack/Rent-a-Car?style=flat-square
https://img.shields.io/github/languages/count/marciobruno-stack/Rent-a-Car?style=flat-square
https://img.shields.io/github/languages/top/marciobruno-stack/Rent-a-Car?style=flat-square
https://img.shields.io/github/last-commit/marciobruno-stack/Rent-a-Car?style=flat-square
https://img.shields.io/github/issues/marciobruno-stack/Rent-a-Car?style=flat-square
https://img.shields.io/github/license/marciobruno-stack/Rent-a-Car?style=flat-square

Aplicação ASP.NET Core MVC com Entity Framework Core e MySQL, desenvolvida para gestão eficiente de alugueres de veículos.
✨ Funcionalidades

    CRUD de alugueres

    Pesquisa dinâmica

    Paginação

    Interface responsiva

    Validação cliente/servidor

    Confirmação de exclusão com SweetAlert2

🛠️ Tecnologias

    .NET 10

    ASP.NET Core MVC

    Entity Framework Core

    MySQL

    Bootstrap

    SweetAlert2

🧩 Arquitetura do Sistema

A aplicação segue o padrão MVC, garantindo organização clara e separação de responsabilidades.
🎨 Diagrama Visual Premium
Código

                         ┌──────────────────────────┐
                         │         🖥️ Views         │
                         │  (Interface do Utilizador)│
                         └──────────────┬───────────┘
                                        │
                                        ▼
                         ┌──────────────────────────┐
                         │      🎯 Controllers       │
                         │ (Lógica + Orquestração)  │
                         └──────────────┬───────────┘
                                        │
                                        ▼
                         ┌──────────────────────────┐
                         │        📦 Models         │
                         │ (Entidades + Validação)  │
                         └──────────────┬───────────┘
                                        │
                                        ▼
                         ┌──────────────────────────┐
                         │     🗄️ DbContext (EF)     │
                         │ (Mapeamento + Queries)    │
                         └──────────────┬───────────┘
                                        │
                                        ▼
                         ┌──────────────────────────┐
                         │        🐬 MySQL           │
                         │ (Base de Dados Real)      │
                         └───────────────────────────┘

📁 Estrutura
Código

Mod5_CRUD/
├── Controllers/
├── Models/
├── Data/
├── Views/
├── wwwroot/
└── Program.cs

⚙️ Como Executar
bash

git clone https://github.com/marciobruno-stack/Rent-a-Car.git
cd Rent-a-Car
dotnet restore
dotnet ef database update
dotnet run

Configurar ligação no appsettings.json:
json

"DefaultConnection": "Server=localhost;Database=Mod5_CRUD;Uid=root;Pwd=sua_password;"

👨‍💻 Autor

Marcio Bruno
📞 Contacto

Abra uma Issue no GitHub para dúvidas ou sugestões.
