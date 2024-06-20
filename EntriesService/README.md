# Test-Wallet

# Pré-Requisitos

Installed Frameworks and Packages
Docker
.Net Runtime 8.0
.Net SDK 8.0

1- Navigate to docker directory that contains docker-compose.yml
2- Run docker-compose up -d
3- Check if exists a Container named "docker" or "wallet-carrefour" in yout local docker


# Running Entries API

1- Open de the terminal
2- Navigate to WalletService Directory (/src)
3- Run dotnet restore
4- Run dotnet build
5- Run dotnet ef database update --context ApplicationDbContext
6- Run dotnet run

Access the swagger UI from http://localhost:PORT/swagger (port is yout output dotnet run listening on)

Endpoints:

POST /api/entry: Add new Entry
GET /api/entryType: Get Entry Types to use in POST Route


# Running Unit Tests

Open de the terminal

Navigate to UnitTests Directory (/Tests/UnitTests)

Run dotnet restore

Run dotnet build

Run dotnet test
