# Test-Wallet

# Estrutura das APIs Envolvidas

Domain:
Contém as entidades, DTOs e interfaces da API.

Application:
Contém os Handlers utilizados na API via Imediator.

Migrations:
Contém o controle de migrações do EF Core.

Infrastructure:
Implementações de repositórios e contexto de banco de dados.

Tests:
Testes Unitários da API.


# Pré-Requisitos

Instalar o .Net Runtime 8.0 e o .Net SDK 8.0
Docker

1- Abrir o terminal e navegar até a pasta Docker
2- Run docker-compose up -d
3- Confirmar se foi criado o container com o nome docker ou wallet-carrefour

Os passos acima são obrigatórios para que seja criado o container do banco de dados.

# Executando Entries API

1- Abrir o Terminal
2- Navegar até o diretório da api Entries (EntriesService/src)
3- Run dotnet restore
4- Run dotnet build
5- Run dotnet ef database update --context ApplicationDbContext
6- Run dotnet run

Acessar o Swagger UI pela URL http://localhost:5001/swagger (ou a porta especificada no output do comando dotnet run)

Endpoints:

POST /api/entry: Adicionar Lançamento
GET /api/entryType: Listar Tipos de Lançamentos

# Executando Balance API

1- Abrir o Terminal
2- Navegar até o diretório da api BValance (BalanceService/src)
3- Run dotnet restore
4- Run dotnet build
5- Run dotnet run

Acessar o Swagger UI pela URL http://localhost:5002/swagger (ou a porta especificada no output do comando dotnet run)

GET /api/balance: Lista o extrato consolidado pela data de referência informando: TotalBalance, TotalDebit, TotalCredito, ReferenceDate

Endpoints:

POST /api/entry: Adicionar Lançamento
GET /api/entryType: Listar Tipos de Lançamentos



# Executando Testes Unitários das APIs

Abrir o Terminal

Navegar para UnitTests do respectivo projeto (/Tests/UnitTests)

Run dotnet restore

Run dotnet build

Run dotnet test

![image](https://github.com/bvmdev/Test-Wallet/assets/33611537/3d53b629-171d-47a7-8d45-c202740a6e9a)

