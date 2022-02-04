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
            
            this.engine = 0;
            this.type = string.Empty;
            this.doors = 0;
        }

        public Car(string brand, string model, int modelYear, double price, double engine, string type, int doors) : base(brand, model, modelYear, price)
        {
            this.engine = engine;
            this.type = type;
            this.doors = doors;
        }
        

        public override string ToString()
        {
            return $"\n{base.ToString()}, {this.engine}, {this.type}, {this.doors}";
        }

        public override void PrintInformation()
        {
            base.PrintInformation();
            Console.WriteLine($"\nMoottorin litratilavuus: {this.engine}\nAjoneuvotyyppi: {this.type}\nOvien lukumäärä: {this.doors}");
        }

        public override bool Equals(object obj)
        {
            return obj is Car car && 
                this.engine == car.engine &&
                this.type == car.type &&
                this.doors == car.doors;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override void Colour()
        {
            Console.WriteLine($"Keltainen");
        }

        //public override void PrintInformation()
        //{
        //    base.PrintInformation();
        //}
    }
}
