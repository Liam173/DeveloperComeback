using System;

namespace DeveloperComeback
{
    public class Employee
    {
        // A house blueprint is not a house.
        // A class is not an object.
        // It simply describes what an object will look like.

        public string Name { get; }

        public int Age { get; }

        public decimal Salary { get; private set; }

        public Employee(
            string name,
            int age,
            decimal salary)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name cannot be null or empty", nameof(name));
            }

            if (age < 18)
            {
                throw new ArgumentOutOfRangeException("Age must be at least 18", nameof(age));
            }

            if (salary <= 0)
            {
                throw new ArgumentOutOfRangeException("Salary must be a positive value", nameof(salary));
            }

            Name = name;
            Age = age;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"{Name} ({Age}) - {Salary:C}";
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
