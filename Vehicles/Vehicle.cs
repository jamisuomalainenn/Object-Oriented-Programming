using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    class Vehicle
    {
       public Vehicle()
        {
            Console.WriteLine("Kantaluokan muodostin");
        }

        //konstruktori
        public Vehicle(string msg)
        {
            Console.WriteLine("Kantaluokan muodostin: " + msg);
        }

    }
       
}
    
    

