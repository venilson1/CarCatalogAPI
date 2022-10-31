# CarCatalogAPI

Projeto vitrine de carros.

# Configuração

você terá duas opçoes para configurar o projeto

- 1º opção

Baixar uma imagem docker com a congiguração do banco setadas igual ao do projeto

```
docker run -v ~/docker --name sqlserver -e "ACCEPT_EULA=Y" -e "MSSQL_USER=sa" -e "MSSQL_SA_PASSWORD=Root@2022" -p 1433:1433 -d mcr.microsoft.com/mssql/server
```

- 2º opção

Abrir o appsettigns do projeto e configurar a ConnectionString de acordo com as configurações do seu banco sql server local.

### Configuração Padrão do AppSettings

```
server=localhost;database=car_catalog;user=sa;password=Root@2022
```

# Rodando os contextos

```
 Update-Database -Context CarCatalogDbContext
```

```
 Update-Database -Context UserDbContext
```


# Criar um usuário para acesso do admin

na rota `http://localhost:5103/auth/create` crie um usuario com os seguintes parametros

{
  "username": "user",
  "email": "user@verzel.com",
  "password": "Verzel123@"
}

- collection postman: `https://www.getpostman.com/collections/34b77ff83db610f8061f`


### rodar o projeto

`dotnet run`
