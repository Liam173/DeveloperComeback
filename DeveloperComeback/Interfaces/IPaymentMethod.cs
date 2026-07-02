using System;

namespace DeveloperComeback.Interfaces
{
    public interface IPaymentMethod
    {
        void Pay(decimal amount);
    }
}
