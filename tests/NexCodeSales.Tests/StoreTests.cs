using NexCodeSales.Models;
using NexCodeSales.Services;
using Xunit;

namespace NexCodeSales.Tests;

public class StoreTests
{
    [Fact]
    public void AddProduct_AssignsIdAndStoresProduct()
    {
        InTemporaryDirectory(() =>
        {
            var store = new Store();
            store.AddProduct(new Product { Name = "Teclado", Price = 120m, Stock = 5 });

            var product = Assert.Single(store.Products);
            Assert.Equal(1, product.Id);
            Assert.Equal("Teclado", product.Name);
            Assert.Equal(120m, product.Price);
            Assert.Equal(5, product.Stock);
        });
    }

    [Fact]
    public void RegisterSale_RecordsSaleAndDecreasesStock()
    {
        InTemporaryDirectory(() =>
        {
            var store = new Store();
            store.AddProduct(new Product { Name = "Mouse", Price = 50m, Stock = 8 });

            var result = store.RegisterSale(1, 3);

            Assert.True(result);
            Assert.Equal(5, store.Products[0].Stock);
            var sale = Assert.Single(store.Sales);
            Assert.Equal("Mouse", sale.ProductName);
            Assert.Equal(3, sale.Quantity);
            Assert.Equal(50m, sale.UnitPrice);
            Assert.Equal(150m, sale.Total);
        });
    }

    [Theory]
    [InlineData(99, 1)]
    [InlineData(1, 0)]
    [InlineData(1, -2)]
    [InlineData(1, 6)]
    public void RegisterSale_RejectsInvalidProductOrQuantity(int productId, int quantity)
    {
        InTemporaryDirectory(() =>
        {
            var store = new Store();
            store.AddProduct(new Product { Name = "Monitor", Price = 800m, Stock = 5 });

            var result = store.RegisterSale(productId, quantity);

            Assert.False(result);
            Assert.Equal(5, store.Products[0].Stock);
            Assert.Empty(store.Sales);
        });
    }

    private static void InTemporaryDirectory(Action action)
    {
        var originalDirectory = Directory.GetCurrentDirectory();
        var temporaryDirectory = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(temporaryDirectory);

        try
        {
            Directory.SetCurrentDirectory(temporaryDirectory);
            action();
        }
        finally
        {
            Directory.SetCurrentDirectory(originalDirectory);
            Directory.Delete(temporaryDirectory, recursive: true);
        }
    }
}
