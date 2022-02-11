using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Circle : Shape
    {
        private double radius;

        public Circle()
        {
            this.radius = 0;
        }

        public Circle(string colour, double radius) //: base(colour, "CIRCLE")
        {
            this.radius = radius;
            this.colour = colour;
            this.type = "CIRCLE";

        }

        public override double GetArea()
        {
            return Math.PI * this.radius * this.radius;
        }
    }
}
