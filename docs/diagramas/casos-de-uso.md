# Diagrama de casos de uso

El actor representa al usuario que opera la aplicación de consola. Los casos de uso corresponden a las funciones disponibles en la versión inicial.

```mermaid
flowchart LR
    U[Usuario]
    A((Registrar producto))
    B((Consultar inventario))
    C((Registrar venta))
    D((Consultar historial))
    E((Salir))
    U --- A
    U --- B
    U --- C
    U --- D
    U --- E
```

## Descripción
- Registrar producto: ingresar nombre, precio y stock inicial.
- Consultar inventario: revisar productos y existencias.
- Registrar venta: seleccionar un producto y una cantidad disponible.
- Consultar historial: revisar las ventas registradas y el total acumulado.
- Salir: cerrar la aplicación.
