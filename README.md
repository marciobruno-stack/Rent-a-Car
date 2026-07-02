# Mod5_CRUD

Projeto ASP.NET Core MVC — CRUD de aluguéis.

## Requisitos
- .NET 10 SDK
- SQL Server (ou usar SQLite/EF Core InMemory para testes)

## Como executar (desenvolvimento)
1. Abra o terminal na pasta do projeto (Mod5_CRUD).
2. Restaurar pacotes:

```bash
dotnet restore
```

3. Atualizar a base de dados (usar EF Core Tools):

```bash
dotnet ef database update
```

4. Executar a aplicação:

```bash
dotnet run
```

5. Acesse a URL informada no console (ex.: http://localhost:5000).

## Solução de problemas: bloqueio por política do Windows
Se ocorrer erro ao carregar assemblies com mensagem indicando que uma política de controle de aplicação bloqueou o arquivo (ex.: Smart App Control / Code Integrity), siga estas etapas seguras:

1. Verifique se o arquivo tem marca "Zone.Identifier" (Mark of the Web):

```powershell
Get-Item -Path "<caminho-completo>\\Mod5_CRUD.dll" -Stream *
```

2. Se houver Mark-of-the-Web, desbloqueie o arquivo (teste):

```powershell
Unblock-File -Path "<caminho-completo>\\Mod5_CRUD.dll"
```

3. Se o bloqueio for por Smart App Control / Code Integrity, verifique o histórico do Windows Security:

- Abra Segurança do Windows → Proteção contra vírus e ameaças → Histórico de proteção → procure o bloqueio e permita se apropriado.

4. Para desenvolvimento local, pode-se adicionar exceção ao Microsoft Defender (executar PowerShell como Administrador):

```powershell
Add-MpPreference -ExclusionPath "<pasta-do-projeto>"
```

5. Alternativa rápida: mover o projeto para um caminho simples (ex.: C:\\Dev\\Mod5_CRUD), reconstruir e executar.

Avisos:
- Em máquinas gerenciadas por TI, consulte o administrador antes de alterar políticas ou adicionar exclusões.
- Não desative permanentemente o Smart App Control em sistemas de produção.

## Contribuição
Pull requests são bem-vindos. Para problemas, abra uma issue descrevendo o ambiente e o erro completo.

