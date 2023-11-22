# GustavoSeguros

## Modelo de Ambiente

O projeto foi implantado utilizando Docker Compose.

## Preview do projeto

[Seguro Preview](https://gustavocaldas.net/services/seguro)

## Serviços

### 1. Angular App

- **Porta Exposta:** 80

### 2. ASP.NET Core API

- **Porta Exposta:** 88

### 3. SQL Server Database

### Requisitos para rodar localmente

- Docker

### Como rodar localmente

CMD/BASH
`docker compose up --build -d && docker compose down && docker compose up -d`
