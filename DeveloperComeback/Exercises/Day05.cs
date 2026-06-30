using System;
using System.Collections.Generic;

namespace DeveloperComeback.Exercises
{
    public static class Day05Exercises
    {
        public static void Run()
        {
            RunEmployeeExercise();
            RunCarExercise();
        }

        public static void RunEmployeeExercise()
        {
            var employees = new List<Employee>
            {
                new Employee("Alice", 30, 45000m),
                new Employee("Bob", 25, 45000m),
                new Employee("Charlie", 35, 55000m)
            };

            var alice = employees.Find(e => e.Name == "Alice");
            var raiseAmount = 5000m;

            if (alice == null)
            {
                Console.WriteLine("Employee not found.");
                return;
            }

            Console.WriteLine(alice);
            Console.WriteLine($"Before Raise: {alice}");

            alice.GiveRaise(raiseAmount);

            Console.WriteLine($"After Raise: {alice}");
            Console.WriteLine($"Congratulations, {alice.Name}! You received a raise of {raiseAmount:C}!");
            Console.WriteLine("High Earners:");

            foreach (var employee in employees)
            {
                if (employee.IsHighEarner())
                {
                    Console.WriteLine(employee);
                }
            }
        }

        public static void RunCarExercise()
        {
            var car = new Car("Toyota", "Camry", 1990, "Red", 5000m);
            Console.WriteLine(car);
            Console.WriteLine($"Is the car a classic? {car.IsClassic()}");

            car.IncreasePrice(2000m);
            Console.WriteLine($"New price: {car.Price:C}");
        }
    }
}
