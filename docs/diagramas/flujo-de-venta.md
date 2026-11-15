# Flujo de registro de venta

El flujo muestra las validaciones que realiza el sistema antes de confirmar una venta.

```mermaid
flowchart TD
    A[Iniciar registro de venta] --> B[Mostrar productos]
    B --> C[Ingresar ID y cantidad]
    C --> D{¿Datos válidos?}
    D -- No --> X[Mostrar mensaje de error]
    D -- Sí --> E{¿Existe el producto?}
    E -- No --> X
    E -- Sí --> F{¿Cantidad disponible?}
    F -- No --> X
    F -- Sí --> G[Registrar venta]
    G --> H[Descontar stock]
    H --> I[Guardar datos JSON]
    I --> J[Confirmar operación]
    X --> K[Volver al menú]
    J --> K
```

## Reglas principales
1. El producto debe existir.
2. La cantidad debe ser mayor que cero.
3. El stock debe ser suficiente.
4. La venta se registra y el inventario se actualiza cuando todas las validaciones son correctas.
