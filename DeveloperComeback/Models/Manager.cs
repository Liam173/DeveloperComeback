using System;

namespace DeveloperComeback.Models
{
    public class Manager : Employee
    {
        public int TeamSize { get; }

        

        public Manager(
            string name,
            int age,
            decimal salary,
            int teamSize)
            : base(name, age, salary)
        {
            TeamSize = teamSize;
        }

        public override string GetDescription()
        {
            return $"{Name} - Manager ({TeamSize} staff)";
        }
    }
}
