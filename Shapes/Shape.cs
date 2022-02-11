using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    abstract class Shape
    {
        protected string colour;
        protected string type;

        public Shape()
        {
            this.colour = string.Empty;
            this.type = string.Empty;
        }

        public Shape(string colour, string type)
        {
            this.colour = colour;
            this.type = type;
        }

        abstract public double GetArea();

        public virtual string GetColour()
        {
            return this.colour;
        }

        public virtual string GetInfo()
        {
            return $"Colour: {this.colour}\nType: {this.type}";
        }
    }
}
