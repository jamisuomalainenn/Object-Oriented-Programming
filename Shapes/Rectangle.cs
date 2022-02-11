using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Rectangle : Shape
    {
        private double lenght;
        private double width;

        public Rectangle()
        {
            this.lenght = 0;
            this.width = 0;
        }

        public Rectangle(string colour, double lenght, double width)
        {
            this.lenght = lenght;
            this.width = width;
            this.colour = colour;
            this.type = "RECTANGLE";
        }

        public override double GetArea()
        {
            return this.lenght * this.width;
        }
    }
}
