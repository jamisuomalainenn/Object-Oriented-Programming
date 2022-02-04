using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    class Product : IProduct
    {
        private string name;
        private double price;
        private int amount;

        public Product(string name, double price, int amount)
        {
            this.name = name;
            this.price = price;
            this.amount = amount;
        }

        public double CalculateTotal()
        {
            return this.price * this.amount;
        }

        public Product GetProduct(string name)
        {
            if (name.ToLower() == this.name.ToLower())
            {
                return this;
            }
            
            return null;
        }

        public override string ToString()
        {
            return $"\nNimi: {this.name} \nHinta: {this.price} \nVarastosaldo: {this.amount}";
        }
    }
}
