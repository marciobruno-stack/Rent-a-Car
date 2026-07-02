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
