using DeveloperComeback.Interfaces;
using System;

namespace DeveloperComeback.Notification_Methods
{
    public class PushNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending push notification: {message}");
        }
    }
}
