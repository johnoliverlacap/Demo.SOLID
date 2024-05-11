using Demo.SOLID.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.SOLID
{
    public class Program
    {
        static void Main(string[] args)
        {
            IPrinter printer = new Printer();
            IScanner scanner = new Scanner();
            IFax fax = new Fax();

            Client client = new Client(printer, scanner, fax);
            //client.PrintDocument();
            //client.ScanDocument();
            //client.FaxDocument();

            MultiFunctionPrinter multiPrinter = new MultiFunctionPrinter();
            //multiPrinter.Print();
            //multiPrinter.Scan();
            //multiPrinter.Fax();

            Shape circle = new Circle(10);
            //Console.WriteLine("Area of cirlce is {0}", circle.Area());

            Shape square = new Square(10);
            //Console.WriteLine("Area of square is {0}", square.Area());

            Shape rectangle = new Rectangle(10, 5);
            //Console.WriteLine("Area of rectangle is {0}", rectangle.Area());

            Car car = new Car();
            //car.Drive();

            INotification emailService = new EmailService();
            INotification smsService = new SmsService();

            NotificationService notificationService = new NotificationService(emailService, smsService);
            notificationService.Email("This is email");
            notificationService.SMS("This is SMS");

            Console.ReadLine();
        }
    }
}
