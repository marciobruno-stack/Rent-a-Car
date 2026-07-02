# 🚗 Rent a Car - Sistema de Gestão de Alugueres

<p align="center">
  <img src="https://img.shields.io/github/repo-size/marciobruno-stack/Rent-a-Car?style=flat-square&color=512BD4" alt="Repo Size" />
  <img src="https://img.shields.io/github/languages/count/marciobruno-stack/Rent-a-Car?style=flat-square&color=512BD4" alt="Languages" />
  <img src="https://img.shields.io/github/languages/top/marciobruno-stack/Rent-a-Car?style=flat-square&color=4479A1" alt="Top Language" />
  <img src="https://img.shields.io/github/last-commit/marciobruno-stack/Rent-a-Car?style=flat-square&color=7952B3" alt="Last Commit" />
  <img src="https://img.shields.io/github/license/marciobruno-stack/Rent-a-Car?style=flat-square&color=7B16FF" alt="License" />
</p>

<p align="center">
  <b>Aplicação ASP.NET Core MVC com Entity Framework Core e MySQL para gestão eficiente de alugueres de veículos.</b>
  <br />
  <i>Desenvolvido no âmbito da UFCD 10792 - Programação ASP.NET Core MVC.</i>
</p>

---

## ✨ Funcionalidades

* **CRUD Completo:** Registo, consulta, edição e eliminação de alugueres de veículos.
* **Pesquisa Dinâmica:** Filtros inteligentes por cliente, vendedor ou veículo.
* **Paginação:** Listagem organizada com limite de 5 registos por página.
* **Interface Responsiva:** Desenvolvido com Bootstrap 5 (Tema Sandstone do Bootswatch).
* **Validação de Dados:** Segurança garantida com validações no cliente e no servidor.
* **Exclusão Segura:** Alertas de confirmação interativos via SweetAlert2.

---

## 🛠️ Tecnologias Utilizadas

* **Backend:** .NET 10 & ASP.NET Core MVC
* **ORM:** Entity Framework Core
* **Base de Dados:** MySQL 8.0+
* **Frontend:** Bootstrap 5 & SweetAlert2

---

## 🧩 Arquitetura do Sistema

A aplicação segue o padrão de arquitetura **MVC (Model-View-Controller)**, garantindo uma separação clara de responsabilidades:

```text
       ┌──────────────────────────┐
       │         🖥️ Views         │
       │  (Interface do Utilizador)│
       └──────────────┬───────────┘
                      │
                      ▼
       ┌──────────────────────────┐
       │       🎯 Controllers     │
       │ (Lógica + Orquestração)  │
       └──────────────┬───────────┘
                      │
                      ▼
       ┌──────────────────────────┐
       │         📦 Models        │
       │ (Entidades + Validação)  │
       └──────────────┬───────────┘
                      │
                      ▼
       ┌──────────────────────────┐
       │     🗄️ DbContext (EF)     │
       │ (Mapeamento + Queries)   │
       └──────────────┬───────────┘
                      │
                      ▼
       ┌──────────────────────────┐
       │         🐬 MySQL         │
       │   (Base de Dados Real)   │
       └──────────────────────────┘

📁 Estrutura do Projeto

Mod5_CRUD/
├── 📁 Controllers/
├── 📁 Models/
├── 📁 Data/
├── 📁 Views/
├── 📁 wwwroot/
├── 📄 appsettings.json
└── 📄 Program.cs

⚙️ Como Executar Localmente
1. Clonar o repositório

git clone [https://github.com/marciobruno-stack/Rent-a-Car.git](https://github.com/marciobruno-stack/Rent-a-Car.git)
cd Rent-a-Car

2. Configurar a Base de Dados

Abra o ficheiro appsettings.json e configure a sua ligação ao MySQL:
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=Mod5_CRUD;Uid=root;Pwd=sua_password;"
}

3. Executar os Comandos

No terminal, execute os seguintes passos para restaurar as dependências, criar a base de dados e iniciar a aplicação:
Bash

dotnet restore
dotnet ef database update
dotnet run

👨‍💻 Autor

    Marcio Bruno — Aluno da UFCD 10792

📞 Contacto

Caso tenha alguma dúvida ou sugestão para melhorar o projeto, sinta-se à vontade para abrir uma Issue no repositório!
