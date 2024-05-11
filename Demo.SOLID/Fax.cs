using Demo.SOLID.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.SOLID
{
    public class Fax : IFax
    {
        void IFax.Fax()
        {
            Console.WriteLine("Faxing...");
        }
    }
}
