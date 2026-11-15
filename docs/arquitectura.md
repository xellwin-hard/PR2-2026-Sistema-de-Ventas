# Arquitectura del sistema

## Tecnologías
La versión inicial utiliza C# y .NET 8 en una aplicación de consola.

## Organización
- `Program.cs`: menú e interacción con el usuario.
- `Models/Product.cs`: datos de productos.
- `Models/Sale.cs`: datos de ventas.
- `Services/Store.cs`: operaciones de inventario, registro de ventas y persistencia.
- `data/`: archivos JSON locales generados durante la ejecución.

## Flujo básico
1. El usuario selecciona una opción del menú.
2. La aplicación valida los datos ingresados.
3. El servicio actualiza productos o ventas.
4. Los cambios se guardan en archivos JSON locales.

## Persistencia
La versión inicial utiliza archivos JSON y no una base de datos SQL. Los archivos se crean en la carpeta `data/` al ejecutar el programa.

## Limitaciones
No hay autenticación, control de roles, interfaz gráfica ni conexión a una base de datos servidor. La arquitectura podrá ampliarse cuando el equipo defina los siguientes módulos.
