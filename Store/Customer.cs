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

        public Customer AddCustomer(Customer customer)
        {
            throw new NotImplementedException();
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
        {
            if (this.name == name)
            {
                return this;
            }
            return null; 
        }

        public Customer PrintCustomers()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{this.name}, {this.purchases}";
        }

        void ICustomer.AddCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        void ICustomer.PrintCustomers()
        {
            throw new NotImplementedException();
        }
    }
}
