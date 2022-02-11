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
            myStore.AddCustomer();


            Customer customer1 = new Customer("Roope Borg", 1400.55);
            Customer customer2 = new Customer("Reppe Eli", 2401.05);
            Customer customer3 = new Customer("Mika Hokkanen", 500);

            Console.WriteLine($"Asiakas 1 saa bonusta: {customer1.GetBonus()} prosenttia loppuhinnasta");
            Console.WriteLine($"Asuakas 2 nimi on: {customer2.GetCustomer("Reppe Eli")}");

        }
    }
}
