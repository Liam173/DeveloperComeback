using DeveloperComeback.Models;
using System;

namespace DeveloperComeback
{
    public class Employee : Person
    {
        // A house blueprint is not a house.
        // A class is not an object.
        // It simply describes what an object will look like.

        public decimal Salary { get; private set; }

        public Employee(
            string name,
            int age,
            decimal salary)
            : base(name, age) // This tells you that it inherits from the Person class, and it will call the constructor of the Person class with the name and age parameters.
        {                     // "Before building the Employee, first build the Person part."
            if (salary <= 0)
            {
                throw new ArgumentOutOfRangeException("Salary must be a positive value", nameof(salary));
            }

            Salary = salary;
        }

        // Why not override ToString() instead of GetDescription()? Because ToString() is a method that is already defined in the base Object class, and it is not meant to be overridden for custom behavior. GetDescription() is a method that we define ourselves, and it is meant to be overridden for custom behavior.
        public override string GetDescription()
        {
            return $"{Name} - Emplyee - {Salary:C}";
        }

        /// <summary>
        /// Increases the employee's salary by the specified amount.
        /// </summary>
        /// <param name="amount">The raise amount.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when the amount is less than or equal to zero.
        /// </exception>
        public void GiveRaise(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException("Raise amount must be a positive value", nameof(amount));
            }

            Salary += amount;
        }

        /// <summary>
        /// Checks if the employee is a high earner.
        /// </summary>
        public bool IsHighEarner()
        {
            return Salary >= 50000m;
        }
    }
}
