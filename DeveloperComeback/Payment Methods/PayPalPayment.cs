using DeveloperComeback.Interfaces;
using System;

namespace DeveloperComeback.Payments
{
    public class PayPalPayment : IPaymentMethod
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount:C} using PayPal.");
        }
    }
}
