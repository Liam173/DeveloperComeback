using DeveloperComeback.Interfaces;
using System;

namespace DeveloperComeback.Payments
{
    public class PaymentService
    {
        public void ProcessPayment(IPaymentMethod paymentMethod, decimal amount)
        {
            paymentMethod.Pay(amount);
        }
    }
}
