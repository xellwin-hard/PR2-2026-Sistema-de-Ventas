# NexCode Sales

## Sistema de Gestión de Ventas e Inventario

NexCode Sales es un proyecto académico desarrollado en C# para apoyar la gestión básica de productos, inventario y ventas.

## Objetivo
Permitir registrar productos, consultar existencias, registrar ventas y revisar el historial de operaciones desde una aplicación de consola.

## Tecnologías
- C#
- .NET 8
- Visual Studio 2022 o .NET SDK 8
- Git y GitHub
- Archivos JSON locales para guardar los datos de demostración

## Funciones disponibles en la versión inicial
- Registrar productos con precio y cantidad inicial.
- Consultar el inventario.
- Registrar ventas.
- Validar que exista stock suficiente antes de vender.
- Descontar automáticamente el stock después de una venta.
- Consultar historial y total de ventas.

## Funciones todavía no implementadas
Inicio de sesión, roles, clientes, proveedores, promociones, preventas, reportes avanzados y conexión a una base de datos SQL. Se mantienen como posibles ampliaciones del proyecto y no deben presentarse como terminadas.

## Equipo
- Colque Mita German Wilfredo
- Pozo Teran Axel Erwin
- García Limachi Paola Andrea
- Andreia Jarjury

Ver [integrantes y roles](docs/equipo/integrantes-y-roles.md).

## Estructura
```text
.
├── .github/
├── database/
├── docs/
├── resources/
├── scripts/
├── src/
│   └── NexCodeSales/
│       ├── Models/
│       ├── Services/
│       ├── data/
│       ├── NexCodeSales.csproj
│       └── Program.cs
├── tests/
├── .editorconfig
├── .gitignore
├── CHANGELOG.md
├── CONTRIBUTING.md
├── README.md
└── SECURITY.md
```

## Requisitos para ejecutar
- .NET SDK 8.0 o superior.
- Windows, Linux o macOS compatible con .NET 8.

## Instalación y ejecución
1. Instalar .NET SDK 8.
2. Clonar o descargar el repositorio.
3. Abrir una terminal en `src/NexCodeSales/`.
4. Ejecutar:

```bash
dotnet restore
dotnet run
```

Los datos se guardan localmente en archivos JSON dentro de `src/NexCodeSales/data/`.

## Documentación
- [Visión y alcance](docs/vision-y-alcance.md)
- [Requisitos](docs/requisitos.md)
- [Arquitectura](docs/arquitectura.md)
- [Modelo de datos](docs/modelo-de-datos.md)
- [Planificación](docs/planificacion/planificacion.md)
- [Integrantes y roles](docs/equipo/integrantes-y-roles.md)
- [Acuerdos de trabajo](docs/equipo/acuerdos-de-trabajo.md)
- [Guía de contribución](CONTRIBUTING.md)
- [Historial de cambios](CHANGELOG.md)
- [Seguridad](SECURITY.md)

## Estado
**Versión inicial en desarrollo.** Se implementó una aplicación de consola básica. Las pruebas formales, diagramas, Gantt y módulos adicionales deben agregarse y validarse por el equipo.

## Licencia
Proyecto académico para fines educativos. La licencia formal queda pendiente de decisión del equipo.
