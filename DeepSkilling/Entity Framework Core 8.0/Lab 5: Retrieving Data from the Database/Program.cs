using Lab3_Migrations.Data;
using Lab3_Migrations.Models;

using InventoryContext context = new InventoryContext();

List<Product> products = context.Products.ToList();

Console.WriteLine("Retail Inventory System");
Console.WriteLine();

foreach (Product product in products)
{
    Console.WriteLine("Product ID   : " + product.ProductId);
    Console.WriteLine("Product Name : " + product.ProductName);
    Console.WriteLine("Price        : " + product.Price);
    Console.WriteLine("Quantity     : " + product.Quantity);
    Console.WriteLine();
}