using System;

namespace DeveloperComeback.Models
{
    public class Contractor : Person
    {
        public decimal HourlyRate { get; }
        public DateTime ContractEndDate { get; }

        public Contractor(
            string name,
            int age,
            decimal hourlyRate,
            DateTime contractEndDate)
            : base(name, age)
        {
            HourlyRate = hourlyRate;
            ContractEndDate = contractEndDate;
        }

        public bool IsContractExpired()
        {
            return DateTime.Today > ContractEndDate;
        }

        public override string GetDescription()
        {
            return $"{Name} - Contractor - {HourlyRate:C}/hr";
        }
    }
}
