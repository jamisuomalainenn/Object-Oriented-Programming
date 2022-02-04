using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    interface IProducts
    {
        void AddProduct(Product product);
        void PrintProducts();
    }
}
