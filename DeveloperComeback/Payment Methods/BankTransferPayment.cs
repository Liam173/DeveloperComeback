using DeveloperComeback.Interfaces;
using System;

namespace DeveloperComeback.Payments
{
    public class BankTransferPayment : IPaymentMethod
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount:C} via a Bank Transfer.");
        }
    }
}
