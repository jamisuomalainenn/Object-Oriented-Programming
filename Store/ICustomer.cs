using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    interface ICustomer
    {
        Customer GetCustomer(string name);
        double GetBonus();
        void AddCustomer(Customer customer);

        void PrintCustomers();

    }
}
