using System;

namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vehicle vehicle1 = new Vehicle("Audi", "A4", 2008, 8990);
            //Vehicle vehicle2 = new Vehicle("Ford", "Sierra", 1990, 1500);
            Vehicle vehicle3 = new Vehicle("Mercedes-Benz", "C", 2004, 4000);


            //Car car1 = new Car(1.8, "Henkilöauto", 5);
            //Car car2 = new Car(2.0, "Henkilöauto", 5);
            Car car3 = new Car(1.8, "Henkilöauto", 5);




            vehicle3.PrintVehicleInformation();
            car3.PrintCarInformation();


        }
    }
}
