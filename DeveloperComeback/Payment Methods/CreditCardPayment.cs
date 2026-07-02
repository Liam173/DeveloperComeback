using DeveloperComeback.Interfaces;
using System;

namespace DeveloperComeback.Payments
{
    public class CreditCardPayment : IPaymentMethod
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount:C} by credit card.");
        }
    }
}
