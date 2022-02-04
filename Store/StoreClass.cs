using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    class StoreClass
    {
        private string name;
        private List<Product> allProducts = new List<Product>();

        public StoreClass(string name)
        {
            this.name = name;
        }


        public void AddProduct(Product product)
        {
            this.allProducts.Add(product);
        }
        public void PrintProducts()
        {
            foreach (Product p in allProducts)
            {
                Console.WriteLine(p.ToString());
            }
        }
    }
}
