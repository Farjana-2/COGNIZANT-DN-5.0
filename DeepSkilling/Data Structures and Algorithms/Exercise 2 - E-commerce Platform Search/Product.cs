namespace AlgorithmsDataStructures
{
    // This represents a single product on our e-commerce platform
    internal class Product
    {
        // Each product has an ID, Name and Price
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }

        // Constructor - creates a product with all details
        public Product(int productId, string productName, double price)
        {
            ProductId = productId;
            ProductName = productName;
            Price = price;
        }

        // This prints product details nicely
        public override string ToString()
        {
            return $"ID: {ProductId} | Name: {ProductName} | Price: ₹{Price}";
        }
    }
}