using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    class Car : Vehicle // derived class (child)
    {
       //konstruktori
       public Car()
        {
            Console.WriteLine("Lapsiluokan muodostin");
        }

        //konstruktori, kutsuu kantaluokan muodostinta parametrilla
        public Car(string msg) : base(msg)
        {
            Console.WriteLine("Lapsiluokan muodostin: " + msg);
        }
    }
}
