using DeveloperComeback.Logging;
using DeveloperComeback.Notification_Methods;
using DeveloperComeback.Notifications;
using DeveloperComeback.Services;
using System;

namespace DeveloperComeback.Exercises
{
    public static class Day08Exercises
    {
        public static void Run()
        {
            RunNotificationExample();

            RunEmployeeExample();
        }

        public static void RunNotificationExample()
        {
            var notificationService = new NotificationService();
            notificationService.SendNotification(new PushNotification(), "Your payment was successful.");
        }

        public static void RunEmployeeExample()
        {
            //var employee = new Employee(
            //    "John",
            //    30,
            //    25000m);

            //var employeeService =
            //    new EmployeeService(
            //        new EmployeeValidator(),
            //        new EmployeeRepository(),
            //        new EmployeeLogger(),
            //        new EmployeeReportExporter());

            //employeeService.RegisterEmployee(employee);
        }
    }
}
