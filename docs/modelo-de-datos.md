# Modelo de datos de la versión inicial

La aplicación inicial guarda dos colecciones en archivos JSON.

## Producto
- Id: identificador entero.
- Name: nombre del producto.
- Price: precio unitario decimal.
- Stock: cantidad disponible entera.

## Venta
- Id: identificador entero.
- Date: fecha y hora de la operación.
- ProductName: nombre del producto vendido.
- Quantity: cantidad vendida.
- UnitPrice: precio unitario aplicado.

El total de cada venta se calcula multiplicando cantidad por precio unitario.

## Archivos
- `data/products.json`
- `data/sales.json`

## Limitaciones y mejoras
En esta versión, la venta conserva el nombre del producto como texto y no utiliza todavía una relación mediante clave foránea. Para una futura base de datos relacional se recomienda diseñar tablas de productos, ventas y detalles de venta, con sus claves y restricciones.
