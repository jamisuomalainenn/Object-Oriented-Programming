using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    class Vehicle
    {
        protected string brand;
        protected string model;
        protected int modelYear;
        protected double price;

       public Vehicle()
        {
            Console.WriteLine("Kantaluokan muodostin");
            this.brand = string.Empty;
            this.model = string.Empty;
            this.modelYear = 0;
            this.price = 0;
        }

        public Vehicle(string brand, string model, int modelYear, double price)
        {
            this.brand = brand;
            this.model = model;
            this.modelYear = modelYear;
            this.price = price;
        }

        //konstruktori
        public Vehicle(string msg)
        {
            Console.WriteLine("Kantaluokan muodostin: " + msg);
        }

    }
       
}
    
    

