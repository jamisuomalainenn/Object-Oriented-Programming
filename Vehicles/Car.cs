using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    class Car : Vehicle // derived class (child)
    {
        protected double engine;
        protected string type;
        protected int doors;

       //konstruktori
       public Car()
        {
            Console.WriteLine("Lapsiluokan muodostin");
            this.engine = 0;
            this.type = string.Empty;
            this.doors = 0;
        }

        public Car(double engine, string type, int doors)
        {
            this.engine = engine;
            this.type = type;
            this.doors = doors;
        }

        //konstruktori, kutsuu kantaluokan muodostinta parametrilla
        public Car(string msg) : base(msg)
        {
            Console.WriteLine("Lapsiluokan muodostin: " + msg);
        }
    }
}
