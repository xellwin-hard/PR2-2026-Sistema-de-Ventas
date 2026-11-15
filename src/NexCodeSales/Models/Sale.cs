namespace NexCodeSales.Models;

public class Sale
{
    public int Id { get; set; }
    public DateTime Date { get; set; } = DateTime.Now;
    public string ProductName { get; set; } = "";
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal Total => Quantity * UnitPrice;
}
