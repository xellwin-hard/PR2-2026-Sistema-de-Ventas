# Manual de instalación y ejecución

## Requisitos
- .NET SDK 8.0.
- Git (opcional, si se clona el repositorio).
- Windows, Linux o macOS compatible con .NET 8.

## Obtener el proyecto
Se puede descargar el repositorio desde GitHub o clonarlo:

```bash
git clone https://github.com/xellwin-hard/PR2-2026-Sistema-de-Ventas.git
```

## Ejecutar la aplicación
Abrir una terminal en la carpeta del proyecto y ejecutar:

```bash
cd src/NexCodeSales
dotnet restore
dotnet run
```

## Ejecutar las pruebas
Desde la carpeta raíz del repositorio:

```bash
dotnet test ./tests/NexCodeSales.Tests/NexCodeSales.Tests.csproj
```

## Almacenamiento de datos
La aplicación crea una carpeta local `data` para guardar productos y ventas en archivos JSON. Estos archivos son datos de ejecución y no sustituyen una base de datos centralizada.

## Solución de problemas
- Si el comando `dotnet` no se reconoce, instalar el .NET SDK 8 y reiniciar la terminal.
- Si hay errores de compilación, revisar la salida de `dotnet build`.
- Si una prueba falla, revisar el mensaje de xUnit antes de modificar el código.
