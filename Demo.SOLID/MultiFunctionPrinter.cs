using Demo.SOLID.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.SOLID
{
    public class MultiFunctionPrinter : IPrinter, IScanner, IFax
    {
        public void Fax()
        {
            Console.WriteLine("Faxing...");
        }

        public void Print()
        {
            Console.WriteLine("Printing...");
        }

        public void Scan()
        {
            Console.WriteLine("Scanning...");
        }
    }
}
