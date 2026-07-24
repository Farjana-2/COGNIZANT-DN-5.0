using Microsoft.EntityFrameworkCore;
using Lab3_Migrations.Models;

namespace Lab3_Migrations.Data
{
    public class InventoryContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
               @"Server=localhost;Database=RetailInventoryDB_Lab3;Integrated Security=True;TrustServerCertificate=True");
        }
    }
}