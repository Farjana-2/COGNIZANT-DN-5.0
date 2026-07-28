using System;

namespace EcommerceSearch
{
    class Program
    {
        static void Main(string[] args)
        {

            // Sorted array for Binary Search
            Product[] products =
            {
                new Product(101,"Laptop","Electronics"),
                new Product(102,"Mobile","Electronics"),
                new Product(103,"Shoes","Fashion"),
                new Product(104,"Watch","Accessories"),
                new Product(105,"Camera","Electronics")
            };


            Console.WriteLine("Linear Search Result:");

            Product result1 = SearchOperations.LinearSearch(products, 103);

            if (result1 != null)
            {
                result1.Display();
            }
            else
            {
                Console.WriteLine("Product not found");
            }



            Console.WriteLine("\nBinary Search Result:");

            Product result2 = SearchOperations.BinarySearch(products, 104);

            if (result2 != null)
            {
                result2.Display();
            }
            else
            {
                Console.WriteLine("Product not found");
            }


            Console.ReadLine();
        }
    }
}