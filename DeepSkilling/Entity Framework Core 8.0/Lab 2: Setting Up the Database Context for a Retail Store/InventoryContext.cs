using Microsoft.EntityFrameworkCore;
using Lab2_DatabaseContext.Models;

namespace Lab2_DatabaseContext.Data
{
    public class InventoryContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=localhost;Database=RetailInventoryDB;Integrated Security=True;TrustServerCertificate=True");
        }
    }
}