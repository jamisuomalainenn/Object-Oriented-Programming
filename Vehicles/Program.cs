using System;

namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            // luodaan luokasta Car olio
            Car myCar = new Car();
            // kutsutaan honk() metodia, joka on Vehicle-luokassa
            myCar.honk();
            // tulostetaan konsoliin brand (määritelty Vehicle-luokassa)
            // ja modelName (määritelty Car-luokassa)
            Console.WriteLine(myCar.brand + " " + myCar.modelName);

        }
    }
}
