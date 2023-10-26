using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Labb3
{
    internal class Square : Geometry
    {
        public Square(double side = 15)
        {
            Side = side;
        }

        public double Side { get; set; }

        public override double Area()
        {
            return Side * Side;
        }
    }
}
