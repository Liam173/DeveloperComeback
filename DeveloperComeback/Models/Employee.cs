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

        public decimal Salary { get; }

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
    }
}
