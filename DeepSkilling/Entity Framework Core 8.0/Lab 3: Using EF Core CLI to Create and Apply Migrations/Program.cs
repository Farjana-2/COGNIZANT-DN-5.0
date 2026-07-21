using Lab3_Migrations.Data;

Console.WriteLine("Retail Inventory System");
Console.WriteLine();

using InventoryContext context = new InventoryContext();

Console.WriteLine("Inventory Context Created Successfully!");
Console.WriteLine("Ready to create migrations.");