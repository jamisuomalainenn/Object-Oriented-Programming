using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyExercise
{
    class Building
    {
        public string address;
        public int buildingYear;

        //tyhjä constructor.
        public Building()
        {
            this.address = string.Empty;
            this.buildingYear = 0;
        }

        public Building(string address, int buildingYear)
        {
            this.address = address;
            this.buildingYear = buildingYear;
        }

        //copy conturctor
        public Building(Building building)
        {
            this.address = building.address;
            this.buildingYear = building.buildingYear;
        }

        public void printInfo()
        {
            Console.WriteLine($"Rakennuksen osoite: {this.address}, rakennusvuosi: {this.buildingYear}");
        }

        //printinfo ja toString toimivat molemmat tietojen tulostukseen

       /* public override string ToString()
        {
            return $"Luokka: {base.ToString()}, osoite: {this.address}, rakennusvuosi: {this.buildingYear}";
        }

        public void CalculateAge()
        {
            int age = 2022 - this.buildingYear;
            Console.WriteLine($"Rakennuksen ikä: {age}");
        }*/
    }
}
