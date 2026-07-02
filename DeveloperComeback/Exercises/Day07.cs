using DeveloperComeback.Payments;
using DeveloperComeback.Logging;
using DeveloperComeback.Notifications;
using System;

namespace DeveloperComeback.Exercises
{
    public static class Day07Exercises
    {
        public static void Run()
        {
            RunPaymentExample();
            RunNotificationExample();
            RunLoggingExample();
        }

        public static void RunPaymentExample()
        {
            var paymentService = new PaymentService();
            paymentService.ProcessPayment(new CreditCardPayment(), 500m);
            paymentService.ProcessPayment(new PayPalPayment(), 700m);
            paymentService.ProcessPayment(new BankTransferPayment(), 1500m);
        }

        public static void RunNotificationExample()
        {
            var notificationService = new NotificationService();
            notificationService.SendNotification(new EmailNotification(), "Your payment was successful.");
            notificationService.SendNotification(new SmsNotification(), "Your payment was successful.");
        }

        public static void RunLoggingExample()
        {
            var reportService = new ReportService();
            reportService.LogMessage(new ConsoleLogger(), "This is a log message.");
            reportService.LogMessage(new FileLogger(), "This is a log message.");
        } 
    }
}
