using System;

namespace CarExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car exercise:");
            
            Car car1 = new Car();
            car1.AskData();
            car1.Accelerate(60);
            Console.WriteLine($"Nopeutta muutettu {car1.speed}");
            car1.Brake();
            Console.WriteLine($"Jarrutettu, nopeus on nyt {car1.speed}");
            car1.ShowCarInfo();

            Car car2 = new Car();
            car2.AskData();
            car2.Accelerate(15);
            Console.WriteLine($"Nopeutta muutettu {car2.speed}");
            car2.Brake();
            Console.WriteLine($"Jarrutettu, nopeus on nyt {car2.speed}");
            car2.ShowCarInfo();
            
        }
    }
}
