using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    class Customer : ICustomer
    {
        string name;
        double purchases;

        public Customer(string name, double purchases)
        {
            this.name = name;
            this.purchases = purchases;
        }

        public double GetBonus()
        {
            if (this.purchases < 1000)
            {
                return 2;
            }
            else if (this.purchases > 1000 && this.purchases < 2000)
            {
                return 3;
            }
            else if (this.purchases > 2000)
            {
                return 5;
            } 
            else
            {
                return 0;
            }
        }

        public Customer GetCustomer(string name)
        { return null; }

        public override string ToString()
        {
            return $"{this.name}, {this.purchases}";
        }
    }
}
