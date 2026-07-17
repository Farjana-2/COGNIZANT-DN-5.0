using Microsoft.EntityFrameworkCore;

using (var context = new RetailContext())
{
    context.Database.EnsureCreated();

    var category = new Category { Name = "Electronics" };
    var product = new Product { Name = "Wireless Mouse", Price = 19.99m, QuantityInStock = 50, Category = category };

    context.Categories.Add(category);
    context.Products.Add(product);
    context.SaveChanges();

    var products = context.Products.Include(p => p.Category).ToList();
    foreach (var p in products)
    {
        Console.WriteLine($"{p.Name} - {p.Price:C} - Category: {p.Category.Name}");
    }
}