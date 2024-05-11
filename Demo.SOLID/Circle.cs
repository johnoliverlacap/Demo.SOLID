using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.SOLID
{
    public class Circle : Shape
    {
        private double Radius { get; set; }

        public Circle(double radius) 
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius; 
        }
    }
}
