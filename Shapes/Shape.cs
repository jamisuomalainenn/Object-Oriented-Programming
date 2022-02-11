using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Shapes
{
    abstract class Shape : IComparable<Shape>
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
            return $"Colour: {this.colour}, Type: {this.type} Area: {GetArea():F2}";
        }


        public int CompareTo([AllowNull] Shape other)
        {
            //return this.GetArea().CompareTo(other.GetArea());         //kommentoitu rivi tulostaa monikulmiot pinta-alan mukaan
            return this.colour.CompareTo(other.colour);                 //alempi rivi tulostaa monikulmiot värin mukaan.
        }
    }
}
