# BaseAPI

API REST en ASP.NET Core con autenticacion JWT, Identity y MySQL.

🧩 .NET 10 • C# • ASP.NET Core Web API • MySQL (Docker) • MIT License

## Requisitos

- ✅ .NET SDK 10
- ✅ Docker Desktop (para levantar MySQL)
- ✅ Extension ".NET Install Tool" (VS Code)
- ✅ Herramienta de Entity Framework CLI (`dotnet-ef`)

Instalar `dotnet-ef`:

```bash
dotnet tool install --global dotnet-ef
```

Si ya la tienes instalada y quieres actualizarla:

```bash
dotnet tool update --global dotnet-ef
```

## 🐳 Levantar base de datos con Docker

Desde la raiz del repositorio:

```bash
docker compose up -d
```

Esto levanta MySQL con la configuracion de `docker-compose.yml`:

- Host: `localhost`
- Puerto: `3306`
- Database: `BaseApiDb`
- User: `baseapi_user`
- Password: `BaseApi2026@`

## ▶️ Ejecutar el proyecto

Desde la raiz del repositorio:

```bash
dotnet run --project BaseAPI/BaseAPI.csproj
```

Swagger quedara disponible en:

- `http://localhost:5108/swagger`
- `https://localhost:7004/swagger`

## 🧱 Migraciones y base de datos

Crear una nueva migracion:

```bash
dotnet ef migrations add NombreMigracion --project BaseAPI/BaseAPI.csproj --startup-project BaseAPI/BaseAPI.csproj
```

Aplicar migraciones a la base de datos:

```bash
dotnet ef database update --project BaseAPI/BaseAPI.csproj --startup-project BaseAPI/BaseAPI.csproj
```

## 🔐 Endpoint de login

- Metodo: `POST`
- URL: `api/Auth/Login`

Ejemplo de body:

```json
{
  "email": "admin@locahost.com",
  "password": "BaseAPI2026$"
}
```

Credenciales de prueba (seed):

- Email: `admin@locahost.com`
- Password: `BaseAPI2026$`

Respuesta esperada (ejemplo):

```json
{
  "id": "f284b3fd-f2cf-476e-a9b6-6560689cc48c",
  "username": "admin",
  "email": "admin@locahost.com",
  "token": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9..."
}
```

## 🗂️ Estructura del proyecto

La API se organiza por modulos dentro de `BaseAPI/Modules`.  
Toma `Auth` como plantilla para crear nuevos modulos (por ejemplo `Country`).

```text
BaseAPI/
└─ 📁 BaseAPI/
   ├─ 📄 Program.cs
   ├─ 📄 ApplicationDbContext.cs
   ├─ 📁 Modules/
   │  ├─ 📁 Auth/                       # Modulo actual de autenticacion
   │  │  ├─ 📄 AuthController.cs        # Endpoints del modulo
   │  │  ├─ 📁 Dtos/                    # Request/Response del modulo
   │  │  ├─ 📁 Entities/                # Entidades del modulo
   │  │  ├─ 📁 Interfaces/              # Contratos (ej: IAuthService)
   │  │  ├─ 📁 Services/                # Logica de negocio
   │  │  └─ 📁 Configurations/          # Configuracion EF Core + seed
   │  │
   │  └─ 📁 Country/                    # Ejemplo de nuevo modulo
   │     ├─ 📄 CountryController.cs     # Endpoints de Country
   │     ├─ 📁 Dtos/                    # CountryRequest, CountryResponse
   │     ├─ 📁 Entities/                # Entidad Country
   │     ├─ 📁 Interfaces/              # ICountryService
   │     ├─ 📁 Services/                # Reglas de negocio de Country
   │     └─ 📁 Configurations/          # Mapping/configuracion de tablas
   │
   ├─ 📁 ServiceRegistration/           # Registro global de servicios
   ├─ 📁 Settings/                      # Config tipada (JwtSettings, etc.)
   ├─ 📁 Migrations/                    # Historial de migraciones
   ├─ 📄 appsettings.json
   └─ 📄 appsettings.Development.json
```

### 📌 Regla para nuevos modulos

Si vas a agregar otro modulo (`Country`, `City`, etc.), repite la misma estructura de `Auth` para mantener orden y escalabilidad.

## 🛡️ Seguridad de passwords

Los passwords no se guardan en texto plano. Se almacenan como `PasswordHash` usando ASP.NET Core Identity (`PasswordHasher`), lo que agrega seguridad para proteger credenciales en base de datos.
