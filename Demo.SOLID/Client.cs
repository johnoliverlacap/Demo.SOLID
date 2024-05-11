using Demo.SOLID.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.SOLID
{
    public class Client
    {
        IPrinter _printer;
        IScanner _scanner;
        IFax _fax;

        public Client(IPrinter printer, IScanner scanner, IFax fax)
        {
            _printer = printer;
            _scanner = scanner;
            _fax = fax;
        }

        public void PrintDocument()
        {
            _printer.Print();
        }

        public void ScanDocument()
        {
            _scanner.Scan();
        }

        public void FaxDocument()
        {
            _fax.Fax();
        }
    }
}
