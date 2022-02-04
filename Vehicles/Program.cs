using System;

namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kommenteissa on tehtävän ''Osa 1'' Vehicle-luokan luodut oliot.
            //Vehicle vehicle1 = new Vehicle("Audi", "A4", 2008, 8990);
            //Vehicle vehicle2 = new Vehicle("Ford", "Sierra", 1990, 1500);               
            //Vehicle vehicle3 = new Vehicle("Mercedes-Benz", "C", 2004, 4000);


            
            Car car1 = new Car("Audi", "A4", 2008, 8990, 1.8, "Henkilöauto", 5);
            Car car2 = new Car("Ford", "Focus", 1990, 1500, 2.0, "Henkilöauto", 5);
            Car car3 = new Car("Mercedes-Benz", "C", 2004, 4000, 1.8, "Henkilöauto", 5);

            
            
            
            //seuraava kommentti on tehtävän ''Osa1'' Vehicle-luokan kutsuttu metodi.
            //vehicle1.PrintVehicleInformation();
            car1.PrintInformation();

            //vehicle2.PrintVehicleInformation();
            car2.PrintInformation();

            //vehicle3.PrintVehicleInformation();
            car3.PrintInformation();

            
            
            
            Console.WriteLine(car3.ToString());

            
            
            
            if (car1.Equals(car2))
            {
                Console.WriteLine($"{car1.GetBrand()} ja {car2.GetBrand()} ovat samoja");
                
            }
            else
            {
                Console.WriteLine($"{car1.GetBrand()} ja {car2.GetBrand()} eivät ole samoja autoja");
            }

            
            
            
            //Osa 4, kuorma-auto-olio sekä kulutus-metodin kutsu:
            Truck truck1 = new Truck("Daf", "F30", 2019, 200000, 6.8, "Kuorma-auto", 2, 2500, 30);
            truck1.PrintInformation();

            truck1.CalculateConsumption();  //järjetön kulutus!!

            
            
            //Osa 4, tyyppimuunnokset:
            
            Console.WriteLine("____________________________________________________");
            Truck truckA = new Truck("Scania", "Koukku", 1990, 19000, 5.0, "Kuorma-auto", 2, 3000, 13);
            Car carA = truckA as Car;

            if (carA != null)
            {
                Console.WriteLine("\nKuorma-autosta muutettu henkilöauto.");
                Console.WriteLine("Truck --> Car: " + carA.ToString());
            }
            else
            {
                Console.WriteLine("\nTruck --> Car: Tyyppimuunnos ei onnistu... :(");
            }
            Console.WriteLine("____________________________________________________");


            Car carB = new Car("Volvo", "S60", 2005, 2950, 2.5, "Henkilöauto", 5);
            Truck truckB = carB as Truck;

            if (carB != null)
            {
                Console.WriteLine("\nHenkilöautosta muutettu kuorma-auto.");
                Console.WriteLine("Car ---> Truck: " + carB.ToString());
            }
            else
            {
                Console.WriteLine("\nCar ---> Truck: Tyyppimuunnos ei onnistu... :(");
            }
            Console.WriteLine("____________________________________________________");


        }
    }
}
