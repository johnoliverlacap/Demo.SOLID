using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.SOLID
{
    public class Square : Shape
    {
        private double Width { get; set; }

        public Square(double width)
        {
            Width = width;
        }

        public override double Area()
        {
            return Width * Width;
        }
    }
}
