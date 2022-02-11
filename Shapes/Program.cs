using System;
using System.Collections.Generic;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shapes- tehtävä!");
            List<Shape> allShapes = new List<Shape>
            {
                new Circle("red", 6),
                new Circle("blue", 2),
                new Triangle("blue", 2, 2),
                new Triangle("yellow", 10, 3),
                new Rectangle("brown", 3, 17),      //tässä taulukko, jossa erilaisia monikulmioita
                new Rectangle("black", 4, 4)
            };

            Console.WriteLine();

            foreach (Shape s in allShapes)
            {
                Console.WriteLine($"A = {s.GetArea()}");        //tämä tulostaa koodiin kolmioiden muutkin tiedot
                if (s is Triangle)                              //muista kuin kolmioista tulee vain pinta-ala
                {
                    Console.WriteLine(s.GetInfo());
                }
            }

            Console.WriteLine();

            allShapes.Sort();
            foreach (Shape s in allShapes)
            {
                    Console.WriteLine(s.GetInfo());     //tässä tulostetaan monikulmiot värin mukaisessa järjestyksessä
            }



        }
    }
}
