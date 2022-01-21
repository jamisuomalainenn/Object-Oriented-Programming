using System;

namespace CompanyExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Company exercise!");
            /*
            Console.WriteLine("Example: Building");
            Console.WriteLine("\n\nSchool:");
            Building school = new Building();
            school.buildingYear = 1990;
            school.address = "Skinnarilankatu 36, 53850 Lappeenranta";
            school.printInfo();
            Console.WriteLine("school-olio: " + school.ToString());
            school.CalculateAge();

            Console.WriteLine("\n\nOffice:");
            Building office = new Building("Marssitie 50, 53800 Lappeenranta", 2000);
            office.printInfo();
            Console.WriteLine("office-olio: " + school.ToString());
            office.CalculateAge();

            //create object using copy constuctor
            Console.WriteLine("\n\nPostOffice:");
            Building postOffice = new Building(office);
            postOffice.printInfo();
            Console.WriteLine("postOffice-olio: " + school.ToString());
            postOffice.CalculateAge();*/

            Console.WriteLine("\n\nGigantti");
            Company gigantti = new Company();
            gigantti.title = "Gigantti";
            gigantti.address = "Myllymäki 50, 53850 Lappeenranta";
            gigantti.phone = "045 8529632";
            gigantti.outcome = 105000;
            gigantti.expense = 300000;
            gigantti.printInfo();
            //Console.WriteLine("Gigantti-olio: " + gigantti.ToString());
            gigantti.Voitot();

            Console.WriteLine("\n\nMotonet");
            Company motonet = new Company($"Motonet", "Hiessillankatu 4, 53700 Lappeenranta", "0404561236", 15000, 6200);
            motonet.printInfo();
            //Console.WriteLine("Motonet-olio: " + motonet.ToString());
            motonet.Voitot();

        }
    }
}
