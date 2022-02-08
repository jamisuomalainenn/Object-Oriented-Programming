using System;
using System.Collections.Generic;

namespace Store
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Product> productsList = new List<Product>();
            productsList.Add(new Product("Huppari", 59.99, 36));
            productsList.Add(new Product("Kengät", 109.99, 77));
            productsList.Add(new Product("T-Paita", 19.99, 304));

            foreach (Product currentProduct in productsList)
            {
                if(currentProduct.GetProduct("T-Paita") != null)
                {
                    Console.WriteLine("--------  ");
                    Console.WriteLine("T-Paita löytyi");
                    Console.WriteLine($"Varaston arvo: {currentProduct.CalculateTotal()}");
                    Console.WriteLine("--------  ");
                }
                //Console.WriteLine(currentProduct.ToString());
            }

            Console.WriteLine("-------STORE-------");

            StoreClass myStore = new StoreClass("Jamin Marketti");
            myStore.AddProduct(new Product("Huppari", 59.99, 36));
            myStore.AddProduct(new Product("Kengät", 109.99, 77));
            myStore.AddProduct(new Product("T-Paita", 19.99, 304));
            myStore.PrintProducts();
        }
    }
}
