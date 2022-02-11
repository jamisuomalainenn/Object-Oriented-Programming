using System;
using System.Collections.Generic;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<Shape> allShapes = new List<Shape>
            {
                new Circle("red", 6),
                new Circle("blue", 2)
                //new Triangle("blue", 2, 2)
            };

            foreach (Shape s in allShapes)
            {
                Console.WriteLine($"A= {s.GetArea()}");
            }
        }
    }
}
