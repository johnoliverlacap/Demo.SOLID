using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.SOLID
{
    public class EmailService : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine("Email sent");
        }
    }
}
