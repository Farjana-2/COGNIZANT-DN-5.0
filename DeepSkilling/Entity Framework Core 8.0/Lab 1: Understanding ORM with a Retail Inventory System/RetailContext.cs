using Microsoft.EntityFrameworkCore;

public class RetailContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=RetailInventoryDb;Trusted_Connection=True;");
    }
}