using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Triangle : Shape
    {
        private double lenght;
        private double width;

        public Triangle()
        {
            this.lenght = 0;
            this.width = 0;
        }

        public Triangle(string colour, double lenght, double width)
        {
            this.lenght = lenght;
            this.width = width;
            this.colour = colour;
            this.type = "TRIANGLE";
        }

        public override double GetArea()
        {
            throw new NotImplementedException();
        }
    }
}
