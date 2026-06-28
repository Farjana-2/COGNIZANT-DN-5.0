using System.Linq;
namespace AlgorithmsDataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("E-COMMERCE PLATFORM SEARCH FUNCTION");
            Console.WriteLine("=======================================\n");

            // Creating our product catalog
            Product[] products = new Product[]
            {
        new Product(1, "Laptop", 45000),
        new Product(2, "Mobile", 15000),
        new Product(3, "Headphones", 2000),
        new Product(4, "Keyboard", 1500),
        new Product(5, "Monitor", 12000),
        new Product(6, "Mouse", 800),
        new Product(7, "Tablet", 25000),
        new Product(8, "Webcam", 3000)
            };

            Console.WriteLine(" Our Product Catalog:");
            Console.WriteLine("------------------------");
            foreach (Product p in products)
            {
                Console.WriteLine(p);
            }

            SearchAlgorithms search = new SearchAlgorithms();

            // ---- LINEAR SEARCH ----
            Console.WriteLine("\n\n LINEAR SEARCH DEMO");
            Console.WriteLine("Searching for: Tablet");
            Product result1 = search.LinearSearch(products, "Tablet");
            if (result1 != null)
                Console.WriteLine($"\n  🎉 Product Found: {result1}");

            // ---- BINARY SEARCH ----
            // First we need to SORT the products alphabetically!
            Console.WriteLine("\n\n BINARY SEARCH DEMO");
            Console.WriteLine("Sorting products alphabetically first...");
            Product[] sortedProducts = products.OrderBy(p => p.ProductName).ToArray();

            Console.WriteLine("\n Sorted Catalog:");
            foreach (Product p in sortedProducts)
                Console.WriteLine($"  {p}");

            Console.WriteLine("\nSearching for: Tablet");
            Product result2 = search.BinarySearch(sortedProducts, "Tablet");
            if (result2 != null)
                Console.WriteLine($"\n  Product Found: {result2}");

            // ---- COMPARISON ----
            Console.WriteLine("\n\nSEARCH COMPARISON");
            Console.WriteLine("====================");
            Console.WriteLine("Linear Search - checks every item one by one 🐢");
            Console.WriteLine("Binary Search - cuts list in half each time ⚡");
            Console.WriteLine("Binary Search is MUCH faster for large data!");

            Console.ReadKey();
        }
    }
}
