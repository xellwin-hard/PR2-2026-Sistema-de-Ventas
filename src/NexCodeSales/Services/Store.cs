using System.Text.Json;
using NexCodeSales.Models;

namespace NexCodeSales.Services;

public class Store
{
    private const string DataDirectory = "data";
    private const string ProductsFile = "data/products.json";
    private const string SalesFile = "data/sales.json";

    public List<Product> Products { get; private set; } = [];
    public List<Sale> Sales { get; private set; } = [];

    public Store()
    {
        Directory.CreateDirectory(DataDirectory);
        Products = Load<List<Product>>(ProductsFile) ?? [];
        Sales = Load<List<Sale>>(SalesFile) ?? [];
    }

    private static T? Load<T>(string path)
    {
        if (!File.Exists(path)) return default;
        try
        {
            return JsonSerializer.Deserialize<T>(File.ReadAllText(path));
        }
        catch (JsonException)
        {
            Console.WriteLine($"Aviso: no se pudo leer {path}. Se iniciará una lista vacía.");
            return default;
        }
    }

    private static void Save<T>(string path, T value) =>
        File.WriteAllText(path, JsonSerializer.Serialize(value,
            new JsonSerializerOptions { WriteIndented = true }));

    public void AddProduct(Product product)
    {
        product.Id = Products.Count == 0 ? 1 : Products.Max(p => p.Id) + 1;
        Products.Add(product);
        Save(ProductsFile, Products);
    }

    public bool RegisterSale(int productId, int quantity)
    {
        var product = Products.FirstOrDefault(p => p.Id == productId);
        if (product is null || quantity <= 0 || product.Stock < quantity) return false;

        Sales.Add(new Sale
        {
            Id = Sales.Count == 0 ? 1 : Sales.Max(s => s.Id) + 1,
            ProductName = product.Name,
            Quantity = quantity,
            UnitPrice = product.Price
        });
        product.Stock -= quantity;
        Save(ProductsFile, Products);
        Save(SalesFile, Sales);
        return true;
    }
}
