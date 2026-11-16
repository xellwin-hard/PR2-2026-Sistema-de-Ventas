# NexCode Sales

## Sistema de Gestión de Ventas e Inventario

NexCode Sales es un proyecto académico desarrollado en C# con .NET 8. Su propósito es apoyar el registro de productos, el control de existencias y la gestión básica de ventas mediante una aplicación de consola.

## Problema y usuarios objetivo

El registro manual de productos, existencias y ventas puede dificultar el seguimiento de las operaciones. El sistema está dirigido principalmente al personal que administra productos, consulta inventario y registra ventas en un pequeño negocio. Estos usuarios y necesidades deben ser validados por el equipo.

## Funcionalidades de la versión inicial

- Registrar productos con precio y cantidad inicial.
- Consultar productos y existencias.
- Registrar ventas.
- Validar que exista stock suficiente antes de vender.
- Descontar automáticamente del inventario la cantidad vendida.
- Consultar el historial y el total de ventas.

Las funciones de inicio de sesión, roles, clientes, proveedores, promociones, preventas, reportes avanzados y conexión a una base de datos SQL no forman parte de la versión inicial implementada.

## Equipo

- Colque Mita German Wilfredo
- Pozo Teran Axel Erwin
- García Limachi Paola Andrea
- Andreia Jarjury

Las responsabilidades individuales están en [Integrantes y roles](docs/equipo/integrantes-y-roles.md). Los roles que todavía no han sido confirmados se identifican allí como pendientes.

## Tecnologías y requisitos

- C#.
- .NET 8.
- .NET SDK 8.0.
- Git y GitHub.
- Persistencia local mediante archivos JSON.

Se requiere un sistema operativo compatible con .NET 8.

## Estructura del repositorio

```text
.
├── .github/
│   ├── ISSUE_TEMPLATE/
│   └── workflows/
├── docs/
│   ├── diagramas/
│   ├── equipo/
│   ├── manuales/
│   └── planificacion/
├── src/
│   └── NexCodeSales/
├── tests/
│   └── NexCodeSales.Tests/
├── .editorconfig
├── .gitignore
├── CHANGELOG.md
├── CONTRIBUTING.md
├── README.md
└── SECURITY.md
```

## Instalación y ejecución

1. Instalar el .NET SDK 8.
2. Clonar el repositorio:

```bash
git clone https://github.com/xellwin-hard/PR2-2026-Sistema-de-Ventas.git
```

3. Entrar en la carpeta de la aplicación:

```bash
cd PR2-2026-Sistema-de-Ventas/src/NexCodeSales
```

4. Restaurar dependencias y ejecutar:

```bash
dotnet restore
dotnet run
```

Los datos de la aplicación se guardan localmente en archivos JSON dentro de la carpeta de datos del proyecto.

## Pruebas y calidad

El proyecto incluye pruebas automatizadas con xUnit en `tests/NexCodeSales.Tests/`. Para ejecutarlas desde la raíz del repositorio:

```bash
dotnet test ./tests/NexCodeSales.Tests/NexCodeSales.Tests.csproj
```

GitHub Actions ejecuta la restauración, compilación y pruebas automatizadas al realizar cambios en la rama principal o mediante pull requests. Consulta el [historial de ejecuciones](https://github.com/xellwin-hard/PR2-2026-Sistema-de-Ventas/actions).

## Documentación

Consulta el [índice de documentación](docs/README.md). Documentos principales:

- [Visión y alcance](docs/vision-y-alcance.md).
- [Requisitos funcionales y no funcionales](docs/requisitos.md).
- [Arquitectura](docs/arquitectura.md).
- [Modelo de datos](docs/modelo-de-datos.md).
- [Planificación](docs/planificacion/planificacion.md).
- [Cronograma Gantt](docs/planificacion/gantt.md).
- [Seguimiento del proyecto](docs/planificacion/seguimiento.md).
- [Diagramas](docs/diagramas/README.md).
- [Manual de ejecución](docs/manuales/ejecucion.md).
- [Integrantes y roles](docs/equipo/integrantes-y-roles.md).
- [Acuerdos de trabajo](docs/equipo/acuerdos-de-trabajo.md).

## Gestión y colaboración

Las tareas y problemas se gestionan mediante [GitHub Issues](https://github.com/xellwin-hard/PR2-2026-Sistema-de-Ventas/issues) y el tablero de [GitHub Projects](https://github.com/users/xellwin-hard/projects). Antes de contribuir, consulta [CONTRIBUTING.md](CONTRIBUTING.md).

## Estado del proyecto

**Versión inicial en desarrollo.** La aplicación de consola y su conjunto inicial de pruebas están incluidos en el repositorio. La documentación describe el alcance implementado y distingue las ampliaciones todavía no desarrolladas. El cronograma Gantt, los responsables definitivos y la licencia del proyecto deben ser confirmados por el equipo antes de la entrega final.

## Licencia

Consulta el archivo [LICENSE](LICENSE). El equipo debe confirmar esta condición de uso antes de distribuir el proyecto fuera del contexto académico.
