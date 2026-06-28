namespace AlgorithmsDataStructures
{
    internal class SearchAlgorithms
    {
        // =============================================
        // LINEAR SEARCH
        // Checks every product one by one
        // Like searching your phone in every corner!
        // =============================================
        public Product LinearSearch(Product[] products, string searchName)
        {
            Console.WriteLine("\n Starting Linear Search...");
            int steps = 0;

            for (int i = 0; i < products.Length; i++)
            {
                steps++;
                Console.WriteLine($"  Checking: {products[i].ProductName}");

                if (products[i].ProductName.ToLower() == searchName.ToLower())
                {
                    Console.WriteLine($"   Found in {steps} steps!");
                    return products[i];
                }
            }

            Console.WriteLine($"   Not found after {steps} steps!");
            return null;
        }

        // =============================================
        // BINARY SEARCH
        // Cuts the list in half each time!
        // Like finding a page in a book!
        // IMPORTANT: Products must be SORTED first!
        // =============================================
        public Product BinarySearch(Product[] products, string searchName)
        {
            Console.WriteLine("\n Starting Binary Search...");
            int steps = 0;

            int left = 0;
            int right = products.Length - 1;

            while (left <= right)
            {
                steps++;

                // Find the middle
                int middle = (left + right) / 2;
                Console.WriteLine($"  Checking middle: {products[middle].ProductName}");

                int comparison = string.Compare(
                    products[middle].ProductName.ToLower(),
                    searchName.ToLower()
                );

                // Found it!
                if (comparison == 0)
                {
                    Console.WriteLine($"   Found in {steps} steps!");
                    return products[middle];
                }
                // Middle is too high - search LEFT half
                else if (comparison > 0)
                {
                    Console.WriteLine($"  Too high! Search left half...");
                    right = middle - 1;
                }
                // Middle is too low - search RIGHT half
                else
                {
                    Console.WriteLine($"  Too low! Search right half...");
                    left = middle + 1;
                }
            }

            Console.WriteLine($"   Not found after {steps} steps!");
            return null;
        }
    }
}