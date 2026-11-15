# Requisitos del sistema

## Requisitos funcionales implementados
- RF-01: Registrar productos con nombre, precio y stock inicial.
- RF-02: Consultar la lista de productos y sus existencias.
- RF-03: Registrar una venta indicando producto y cantidad.
- RF-04: Rechazar ventas si el producto no existe, la cantidad no es válida o no hay stock suficiente.
- RF-05: Descontar del inventario la cantidad vendida.
- RF-06: Consultar el historial de ventas.
- RF-07: Mostrar el total acumulado de ventas.

## Requisitos no funcionales
- RNF-01: La aplicación está desarrollada en C# sobre .NET 8.
- RNF-02: Los datos se guardan localmente en archivos JSON.
- RNF-03: El código se organiza en modelos y un servicio de almacenamiento.
- RNF-04: No se deben incluir credenciales ni datos personales reales.

## Funciones pendientes
Inicio de sesión, roles, clientes, proveedores, promociones, preventas, reportes avanzados y persistencia en una base de datos SQL quedan fuera de esta primera versión.
