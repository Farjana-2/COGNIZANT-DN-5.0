using RetailInventoryLab1.Models;

Product product = new Product();

product.ProductId = 1;
product.ProductName = "Laptop";
product.Price = 50000;
product.Quantity = 5;

Console.WriteLine("Retail Inventory System");
Console.WriteLine("-----------------------");
Console.WriteLine($"Product ID : {product.ProductId}");
Console.WriteLine($"Product Name : {product.ProductName}");
Console.WriteLine($"Price : {product.Price}");
Console.WriteLine($"Quantity : {product.Quantity}");

Console.WriteLine();
Console.WriteLine("Product object created successfully.");