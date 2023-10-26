using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Labb3
{
    internal class Circle : Geometry
    {
        private float _pi = 3.141f;
        public Circle(double radius = 4)
        {
            Radius = radius;
        }

        public double Radius { get; set; }

        public override double Area()
        {
            return Radius * Radius * _pi;
        }
    }
}
