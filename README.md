# CarCatalogAPI

Projeto de vitrine carros.

# Configuração

Você pode rodar este comando Docker para instanciar um banco SqlServer.

```
docker run -v ~/docker --name sqlserver -e "ACCEPT_EULA=Y" -e "MSSQL_USER=sa" -e "MSSQL_SA_PASSWORD=Root@2022" -p 1433:1433 -d mcr.microsoft.com/mssql/server
```

ou abrir o appsettigns do projeto e configurar a ConnectionString de acordo com as configurações do seu banco sql server.

### Configuração Padrão do AppSettings

```
server=localhost;database=car_catalog;user=sa;password=Root@2022
```

# Rodando contexto

```
 Update-Database -Context CarCatalogDbContext
```

```
 Update-Database -Context UserDbContext
```

# Criar um user dentro postman ou insomnia

na rota `http://localhost:5103/auth/create` crie um usuario com os seguintes parametros

{
  "username": "user",
  "email": "user@verzel.com",
  "password": "verzel123@"
}
