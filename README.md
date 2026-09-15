# ML_PROY_BACKEND

API ASP.NET Core 8 para autenticacion de usuarios.

## Configuracion local

1. Copia `appsettings.example.json` como `appsettings.json`.
2. Reemplaza `YOUR_USERNAME` y `YOUR_PASSWORD` con las credenciales de tu base de datos local o de tu entorno autorizado.
3. No subas `appsettings.json` al repositorio: contiene credenciales y esta excluido por `.gitignore`.

## Ejecutar

```powershell
dotnet restore
dotnet run --launch-profile http
```

La API queda disponible en `http://localhost:5180`.

Swagger:

```text
http://localhost:5180/swagger
```

## Frontend Vite

El frontend debe ejecutarse en `http://localhost:5173`. CORS esta configurado para permitir ese origen.

Endpoint de login:

```text
POST http://localhost:5180/api/usuario/login
```

Cuerpo:

```json
{
  "logUsu": "Admin",
  "pasUsu": "tu-contrasena"
}
```
