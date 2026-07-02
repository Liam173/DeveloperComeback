using DeveloperComeback.Interfaces;
using System;

namespace DeveloperComeback.Notifications
{
    public class NotificationService
    {
        public void SendNotification(INotification notificationMethod, string message)
        {
            notificationMethod.Send(message);
        }
    }
}
