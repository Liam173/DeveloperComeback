using System;

namespace DeveloperComeback.Exercises
{
    public static class Day03Exercises
    {
        public static void Run()
        {
            Employee employee = new Employee(
                "John",
                25,
                10000m);

            Console.WriteLine($"Employee Name: {employee.Name}, Age: {employee.Age}, Salary: {employee.Salary}");
        }
    }
}
