# Demo API Gateway

## User Service

1. Create ASP.NET Core Empty Project

```bash
dotnet new web -n UserService
dotnet run
```

2. Test Endpoint

- http://localhost:5001/weather/{everything}

Add Health Check Endpoint (optional)

- http://localhost:5001/healthz

## Backend Gateway

1. Create ASP.NET Core Empty Project

```bash
dotnet new web -n BackendGateway
```

2. Install Ocelot (API Gateway)

```bash
dotnet add package Ocelot
```

3. Add `ocelot.json` to the project

4. Setup Routes to the `Program.cs`

## Setup Dockerfile and Docker Compose

Expose port 5001 for User Service
Expose port 5000 for Backend Gateway

- Create docker-compose.yml

```bash
docker-compose up -d --build
docker-compose down
```

## Test API Gateway

- http://localhost:5000/
- http://localhost:5000/api/weather/weatherforecast

```http
@BackendGateway_HostAddress = http://localhost:5000

GET {{BackendGateway_HostAddress}}/
Accept: application/json

###
GET {{BackendGateway_HostAddress}}/api/weather/weatherforecast
Accept: application/json
```
