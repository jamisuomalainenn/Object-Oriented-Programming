using System;
using System.Collections.Generic;
using System.Text;

namespace CarExercise
{
    class Car
    {
        public string brand;
        public double speed;

        public Car()
        {
        }

        public Car(string brand, double speed)
        {
            this.brand = string.Empty;
            this.speed = 0;
        }
        public void AskData()
        {
            Console.WriteLine("Wich brand is your car?");
            this.brand = Console.ReadLine();
            Console.WriteLine("What is your car's max speed?");         //tässä käyttäjältä kysytään tiedot
            if (double.TryParse(Console.ReadLine(), out this.speed))
            {
                Console.WriteLine(this.speed);                                 //jos syöttö epäonnistuu, ohjelma ei kaadu
            }
            else
            {
                this.speed = 0;
            }
                                                                
        }

        public void ShowCarInfo()    //käyttäjän ilmoittamat tiedot
        {
            Console.WriteLine($"Auton merkki on {this.brand} ja nopeus on {this.speed}");
        }

        public void Accelerate(double value)    //program.cs puolella ilmoitetut arvot lisätään lukuun
        {
            this.speed += value;
        }

        public void Brake() //nopeus vähenee 10%, alla oleva kaava vähentää ilmoitetusta luvusta 10%
        {
            this.speed *= 0.9;
        }
    }
}
