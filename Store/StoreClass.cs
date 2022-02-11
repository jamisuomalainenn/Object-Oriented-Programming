using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    class StoreClass : IProducts, ICustomer
    {
        private string name;
        private List<Product> allProducts = new List<Product>();
        private double sales;
        private List<Customer> allCustomers = new List<Customer>();


        public StoreClass(string name)
        {
            this.name = name;
        }

        public void AddCustomer(Customer customer)
        {
            this.allCustomers.Add(customer);
        }

        public void AddProduct(Product product)
        {
            this.allProducts.Add(product);
        }

        public double GetBonus()
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomer(string name)
        {
            throw new NotImplementedException();
        }

        public void PrintCustomers()
        {
            foreach (Customer c in allCustomers)
            {
                Console.WriteLine(c.ToString());
            }
        }

        public void PrintProducts()
        {
            foreach (Product p in allProducts)
            {
                Console.WriteLine(p.ToString());
            }
        }

        public override string ToString()
        {
            return $"Name: {this.name}, Sales: {this.sales} Number of customers: {this.allCustomers}, Number of products: {this.allProducts}";
        }

        internal void AddCustomer()
        {
            throw new NotImplementedException();
        }
    }
}
