using System;

namespace EcommerceSearch
{
    public class SearchOperations
    {

        // Linear Search
        public static Product LinearSearch(Product[] products, int productId)
        {
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].ProductId == productId)
                {
                    return products[i];
                }
            }

            return null;
        }


        // Binary Search
        public static Product BinarySearch(Product[] products, int productId)
        {
            int left = 0;
            int right = products.Length - 1;


            while (left <= right)
            {
                int middle = (left + right) / 2;


                if (products[middle].ProductId == productId)
                {
                    return products[middle];
                }


                if (products[middle].ProductId < productId)
                {
                    left = middle + 1;
                }

                else
                {
                    right = middle - 1;
                }
            }


            return null;
        }
    }
}