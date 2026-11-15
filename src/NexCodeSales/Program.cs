using System.Globalization;
using NexCodeSales.Models;
using NexCodeSales.Services;

namespace NexCodeSales;

internal class Program
{
    private static readonly Store Store = new();
    private static readonly CultureInfo Culture = CultureInfo.InvariantCulture;

    private static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("==================================");
            Console.WriteLine("          NEXCODE SALES");
            Console.WriteLine(" Sistema de ventas e inventario");
            Console.WriteLine("==================================");
            Console.WriteLine("1. Registrar producto");
            Console.WriteLine("2. Ver inventario");
            Console.WriteLine("3. Registrar venta");
            Console.WriteLine("4. Historial de ventas");
            Console.WriteLine("0. Salir");
            Console.Write("\nSeleccione una opción: ");

            switch (Console.ReadLine())
            {
                case "1": AddProduct(); break;
                case "2": ShowInventory(); break;
                case "3": RegisterSale(); break;
                case "4": ShowSales(); break;
                case "0": return;
                default: Pause("Opción no válida."); break;
            }
        }
    }

    private static void AddProduct()
    {
        Console.Write("Nombre del producto: ");
        var name = Console.ReadLine()?.Trim() ?? "";
        if (string.IsNullOrWhiteSpace(name)) { Pause("El nombre es obligatorio."); return; }

        if (!ReadDecimal("Precio: ", out var price) || price <= 0)
        { Pause("Ingrese un precio válido mayor que cero."); return; }

        if (!ReadInt("Cantidad inicial: ", out var stock) || stock < 0)
        { Pause("Ingrese una cantidad válida (cero o mayor)."); return; }

        Store.AddProduct(new Product { Name = name, Price = price, Stock = stock });
        Pause("Producto registrado correctamente.");
    }

    private static void ShowInventory()
    {
        Console.WriteLine("\n--- INVENTARIO ---");
        if (Store.Products.Count == 0) Console.WriteLine("No hay productos registrados.");
        foreach (var p in Store.Products)
            Console.WriteLine($"ID: {p.Id} | {p.Name} | Precio: {p.Price:F2} | Stock: {p.Stock}");
        Pause();
    }

    private static void RegisterSale()
    {
        ShowProducts();
        if (!ReadInt("\nID del producto: ", out var id) ||
            !ReadInt("Cantidad a vender: ", out var quantity))
        { Pause("Datos no válidos."); return; }

        Pause(Store.RegisterSale(id, quantity)
            ? "Venta registrada y stock actualizado."
            : "No se pudo registrar. Verifique el producto y el stock disponible.");
    }

    private static void ShowProducts()
    {
        Console.WriteLine("\n--- PRODUCTOS ---");
        foreach (var p in Store.Products)
            Console.WriteLine($"ID: {p.Id} | {p.Name} | Precio: {p.Price:F2} | Stock: {p.Stock}");
        if (Store.Products.Count == 0) Console.WriteLine("No hay productos registrados.");
    }

    private static void ShowSales()
    {
        Console.WriteLine("\n--- HISTORIAL DE VENTAS ---");
        if (Store.Sales.Count == 0) Console.WriteLine("Todavía no hay ventas.");
        foreach (var s in Store.Sales)
            Console.WriteLine($"Venta #{s.Id} | {s.Date:g} | {s.ProductName} | " +
                              $"{s.Quantity} x {s.UnitPrice:F2} = {s.Total:F2}");
        Console.WriteLine($"Total vendido: {Store.Sales.Sum(s => s.Total):F2}");
        Pause();
    }

    private static bool ReadInt(string prompt, out int value)
    {
        Console.Write(prompt);
        return int.TryParse(Console.ReadLine(), out value);
    }

    private static bool ReadDecimal(string prompt, out decimal value)
    {
        Console.Write(prompt);
        return decimal.TryParse(Console.ReadLine(), NumberStyles.Number, Culture, out value);
    }

    private static void Pause(string message = "Presione ENTER para continuar.")
    {
        Console.WriteLine("\n" + message);
        Console.ReadLine();
    }
}
