using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    class Truck : Car
    {
        protected double load;
        protected double consumption;

        public Truck()
        {
            this.load = 0;
            this.consumption = 0;
        }

        public Truck(string brand, string model, int modelYear, double price, double engine, string type, int doors, double load, double consumption) : base(brand, model, modelYear, price, engine, type, doors)
        {
            this.load = load;
            this.consumption = consumption;
        }

        public override void PrintInformation()
        {
            base.PrintInformation();
            Console.WriteLine($"\nKuorma: {this.load}\nKulutus: {this.consumption}");
        }

        public void CalculateConsumption()
        {
            double perKG = this.load * this.consumption;
            Console.WriteLine("Kuorma-auton kulutus on: " + perKG + " litraa / kg");
        }
    }
    
}
