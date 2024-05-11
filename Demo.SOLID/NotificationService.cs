using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.SOLID
{
    public class NotificationService
    {
        private readonly INotification _emailService;
        private readonly INotification _smsService;

        public NotificationService(INotification emailService, INotification smsService)
        {
            _emailService = emailService;
            _smsService = smsService;
        }

        public void Email(string message)
        {
            _emailService.Send(message);
        }

        public void SMS(string message) 
        { 
            _smsService.Send(message);
        }
    }
}
