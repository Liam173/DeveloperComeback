using DeveloperComeback.Interfaces;
using System;

namespace DeveloperComeback.Notifications
{
    public class SmsNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"Message sent via SMS: \n{message}");
        }
    }
}
