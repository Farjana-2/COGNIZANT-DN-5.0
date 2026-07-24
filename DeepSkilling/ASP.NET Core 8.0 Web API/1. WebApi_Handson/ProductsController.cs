using Microsoft.AspNetCore.Mvc;

namespace WebApi_Handson.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private static List<Product> products = new List<Product>
        {
            new Product { ProductId = 1, ProductName = "Laptop", Category = "Electronics", Price = 55000, StockQuantity = 10 },
            new Product { ProductId = 2, ProductName = "Mouse", Category = "Electronics", Price = 500, StockQuantity = 50 },
            new Product { ProductId = 3, ProductName = "Desk Chair", Category = "Furniture", Price = 3500, StockQuantity = 20 }
        };

        [HttpGet]
        public ActionResult<List<Product>> GetAllProducts()
        {
            return Ok(products);
        }

        [HttpGet("{id}")]
        public ActionResult<Product> GetProductById(int id)
        {
            var product = products.FirstOrDefault(p => p.ProductId == id);
            if (product == null)
            {
                return NotFound($"Product with ID {id} not found.");
            }
            return Ok(product);
        }

        [HttpPost]
        public ActionResult<Product> AddProduct(Product newProduct)
        {
            newProduct.ProductId = products.Count > 0 ? products.Max(p => p.ProductId) + 1 : 1;
            products.Add(newProduct);
            return CreatedAtAction(nameof(GetProductById), new { id = newProduct.ProductId }, newProduct);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, Product updatedProduct)
        {
            var product = products.FirstOrDefault(p => p.ProductId == id);
            if (product == null)
            {
                return NotFound($"Product with ID {id} not found.");
            }

            product.ProductName = updatedProduct.ProductName;
            product.Category = updatedProduct.Category;
            product.Price = updatedProduct.Price;
            product.StockQuantity = updatedProduct.StockQuantity;

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var product = products.FirstOrDefault(p => p.ProductId == id);
            if (product == null)
            {
                return NotFound($"Product with ID {id} not found.");
            }

            products.Remove(product);
            return NoContent();
        }
    }
}