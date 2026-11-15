# NexCode Sales – aplicación inicial

Aplicación de consola en C# para registrar productos, consultar inventario, registrar ventas y consultar el historial.

## Requisitos
- .NET SDK 8.0 o superior.
- Visual Studio 2022 con carga de trabajo de desarrollo de .NET, o terminal con .NET SDK.

## Ejecutar
Desde esta carpeta:

```bash
dotnet restore
dotnet run
```

Los datos se guardan localmente en archivos JSON dentro de la carpeta `data/`, que se crea al ejecutar el programa por primera vez.

## Funciones implementadas
- Registro de productos con nombre, precio y stock inicial.
- Consulta de inventario.
- Registro de ventas con validación de stock.
- Descuento automático de existencias al vender.
- Historial de ventas y cálculo del total vendido.

## Alcance
Esta es una versión inicial reconstruida desde cero. Todavía no incluye inicio de sesión, clientes, proveedores, promociones, preventas, reportes avanzados ni base de datos SQL. Los datos JSON son locales para demostración académica.
