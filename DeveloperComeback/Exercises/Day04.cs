using System;
using System.Collections.Generic;
using System.Linq;

namespace DeveloperComeback.Exercises
{
    public static class Day04Exercises
    {
        public static void Run()
        {
            EmployeeTesting();
            PrintCars();
        }

        public static void EmployeeTesting()
        {
            var employees = new List<Employee>
            {
                new Employee("John",25,10000m),
                new Employee("Jane",30,12000m),
                new Employee("Bob",35,5000m),
                new Employee("Alice",28,11000m)
            };

            Console.WriteLine($"Total Employees: {employees.Count}");

            foreach (Employee employee in employees)
            {
                Console.WriteLine($"Employee Name: {employee.Name}, Age: {employee.Age}, Salary: {employee.Salary}");
            }

            // Remove the second employee from the list
            employees.RemoveAt(1);

            // Find the employee using a lambda expression
            var john = employees.Find(e => e.Name == "John");

            // More common appraoch
            john = employees.FirstOrDefault(e => e.Name == "John");

            if (john != null)
            {
                Console.WriteLine(john.Name);
            }

            var exists = employees.Any(e => e.Name == "Alice");
            Console.WriteLine(exists);

            //High earners
            var highEarners = employees.Where(e => e.Salary > 10000m).ToList();
            foreach (Employee highEarner in highEarners)
            {
                Console.WriteLine($"High Earner: {highEarner.Name}, Salary: {highEarner.Salary:C}");
            }

            var averageSalary =
                employees.Average(e => e.Salary);

            Console.WriteLine($"Average Salary: {averageSalary:C}");

            var highestSalary = employees.Max(e => e.Salary);

            Console.WriteLine($"Highest Salary: {highestSalary:C}");

            var lowestSalary = employees.Min(e => e.Salary);

            Console.WriteLine($"Lowest Salary: {lowestSalary:C}");
        }

        public static void PrintCars()
        {
            var cars = new List<Car>
            {
                new Car("Toyota", "Camry", 2020, "Blue", 140000m),
                new Car("BMW", "M3", 2021, "White", 700000m),
                new Car("Ford", "Mustang", 2021, "White", 1000000m),
                new Car("Audi", "A4", 2008, "Black", 300000m),
                new Car("Mercedes", "C-Class", 2003, "Silver", 500000m)
            };

            foreach (Car car in cars)
            {
                Console.WriteLine($"Car Brand: {car.Brand}, Model: {car.Model}, Year: {car.Year}, Colour: {car.Colour}, Price: {car.Price}");
            }

            var whiteCarsByPrice = cars.Where(c => c.Colour == "White").OrderByDescending(c => c.Price).ToList();
            foreach (Car car in whiteCarsByPrice)
            {
                Console.WriteLine($"Car Brand: {car.Brand}, Model: {car.Model}, Year: {car.Year}, Colour: {car.Colour}, Price: {car.Price}");
            }

            var highestPricedCar = cars.Max(c => c.Price);
            Console.WriteLine($"Highest Priced Car: {highestPricedCar:C}");
        }
    }
}
