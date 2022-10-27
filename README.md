# CarCatalogAPI

Projeto de vitrine carros.

# Configuração

Você pode rodar este comando Docker para instanciar um banco SqlServer.

```
docker run -v ~/docker --name sqlserver -e "ACCEPT_EULA=Y" -e "MSSQL_USER=sa" -e "MSSQL_SA_PASSWORD=Root@2022" -p 1433:1433 -d mcr.microsoft.com/mssql/server
```
# Rodando Contexto

```
 Update-Database -Context CarCatalogDbContext
```

```
 Update-Database -Context UserDbContext
```
