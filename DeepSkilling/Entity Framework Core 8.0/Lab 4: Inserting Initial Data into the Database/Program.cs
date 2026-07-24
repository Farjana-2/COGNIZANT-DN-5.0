using Lab3_Migrations.Data;
using Lab3_Migrations.Models;

using InventoryContext context = new InventoryContext();

Product product1 = new Product();
product1.ProductName = "Laptop";
product1.Price = 50000;
product1.Quantity = 5;

Product product2 = new Product();
product2.ProductName = "Mouse";
product2.Price = 800;
product2.Quantity = 20;

Product product3 = new Product();
product3.ProductName = "Keyboard";
product3.Price = 1500;
product3.Quantity = 10;

context.Products.Add(product1);
context.Products.Add(product2);
context.Products.Add(product3);


context.SaveChanges();

Console.WriteLine("Products inserted successfully!");