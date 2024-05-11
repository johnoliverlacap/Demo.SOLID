using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.SOLID
{
    public class Bicycle : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Bike is pedalling");
        }
    }
}
