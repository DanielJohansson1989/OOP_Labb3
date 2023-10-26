using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Labb3
{
    internal class Rectangle : Geometry
    {
        public Rectangle(double length = 2.5, double height = 5)
        {
            Length = length;
            Height = height;
        }
        public double Length { get; set; }
        public double Height { get; set; }

        public override double Area() 
        {
            return Length * Height;
        }
    }
}
