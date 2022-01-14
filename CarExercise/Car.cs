using System;
using System.Collections.Generic;
using System.Text;

namespace CarExercise
{
    class Car
    {
        public string brand;
        public int speed;

        public Car()
        {
        }

        public Car(string brand, int speed)
        {
            this.brand = string.Empty;
            this.speed = 0;
        }
        public void AskData()
        {
            Console.WriteLine("Wich brand is your car?");
            this.brand = Console.ReadLine();
            Console.WriteLine("What is your car's max speed?");
            if (int.TryParse(Console.ReadLine(), out this.speed))
            {
                this.speed = 0;                                 //jos syöttö epäonnistuu, ohjelma ei kaadu
            }
                                                                //this.speed = Convert.ToInt32(Console.ReadLine());
        }

        public void ShowCarInfo()
        {
            Console.WriteLine($"Auton merkki on {this.brand} ja huippunopeus on {this.speed}");
        }

        public void Accelerate(int value)
        {
            this.speed += value;
        }

        public void Brake()
        {
            this.speed /= 1;
        }
    }
}
