using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    interface IProduct
    {
        Product GetProduct(string name);
        double CalculateTotal();
    }
}
