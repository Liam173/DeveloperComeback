using DeveloperComeback.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace DeveloperComeback.Exercises
{
    public class Day06Exercises
    {
        public static void Run()
        {
            /*
             * Day 6 - Inheritance, Polymorphism & Composition
             * Goal
             * Understand:
             * Inheritance (:)
             * Base classes
             * Derived classes
             * virtual
             * override
             * base
             * protected
             * Why inheritance can be dangerous
             * When composition is better than inheritance
            */

            //The following code is polymorphism. Where even though the list is of type Person, each object behaves differently.

            var people = new List<Person>
            {
                new Employee("Alice", 30, 40000m),
                new Employee("Eve", 28, 60000m),
                new Contractor("Bob", 25, 500m, DateTime.Today.AddMonths(6)),
                new Contractor("Jim", 34, 700m, DateTime.Today.AddMonths(3)),
                new Manager("Charlie", 40, 80000m, 40),
                new Manager("Donald", 45, 90000m, 50)
            };

            foreach (var person in people)
            {
                Console.WriteLine(person.GetDescription());

                if (person is Employee employee)
                {
                    employee.GiveRaise(5000m);
                }
            }

            var contractor = people.Find(p => p is Contractor) as Contractor;

            Console.WriteLine(
                contractor.IsContractExpired()
                    ? "Expired"
                    : "Active");
        }
    }
}
