using System;
using Module2HW6.Interfaces;

namespace Module2HW6.Services
{
    public class NotificationService : INotificationService
    {
        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
