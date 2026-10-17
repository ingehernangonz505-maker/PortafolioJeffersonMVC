# Portafolio Jefferson Hernández - ASP.NET Core MVC

Portafolio personal en ASP.NET Core MVC con diseño negro y verde esmeralda.

## Requisitos
- .NET SDK 10.0
- Visual Studio Code (opcional)
- Extensión C# Dev Kit (opcional)

## Ejecutar el proyecto
1. Extrae el archivo ZIP.
2. Abre la carpeta `PortafolioJeffersonMVC` en Visual Studio Code.
3. Abre una terminal en la carpeta donde está `PortafolioJeffersonMVC.csproj`.
4. Ejecuta:

```bash
dotnet restore
dotnet run
```

5. Abre en el navegador la URL local que aparezca en la terminal, por ejemplo `http://localhost:5000` o la URL indicada por ASP.NET Core.

## Estructura
- `Controllers/HomeController.cs`: controlador principal.
- `Models/PortfolioViewModel.cs`: modelo de datos del portafolio.
- `Views/Home/Index.cshtml`: vista principal.
- `Views/Shared/_Layout.cshtml`: diseño común.
- `wwwroot/css/site.css`: estilos.
- `wwwroot/js/site.js`: menú móvil.
- `Program.cs`: configuración de la aplicación.

## Personalización
- Edita el nombre, profesión, ubicación, habilidades y proyectos en `Controllers/HomeController.cs`.
- Cambia el enlace de GitHub en `Views/Home/Index.cshtml`.
- Puedes añadir una foto real reemplazando el círculo con las iniciales JH.
- Las fuentes se cargan desde Google Fonts; para utilizarlas hace falta conexión a internet.

Este proyecto es una plantilla de portafolio. Revisa y adapta la información para que coincida con tu experiencia real.
