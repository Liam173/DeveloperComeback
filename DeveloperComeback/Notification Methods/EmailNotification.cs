using DeveloperComeback.Interfaces;
using System;

namespace DeveloperComeback.Notifications
{
    public class EmailNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"Message sent via Email: \n{message}");
        }
    }
}
