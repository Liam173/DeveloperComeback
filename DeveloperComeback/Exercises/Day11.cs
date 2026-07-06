using DeveloperComeback.Repositories;
using System;

namespace DeveloperComeback.Exercises
{
    public static class Day11Exercises
    {
        public static void Run()
        {
            var employeeRepo = new Repository<Employee>();

            employeeRepo.Save(
                new Employee("John", 30, 50000m));

            var carRepo = new Repository<Car>();

            carRepo.Save(
                new Car(
                    "BMW",
                    "M3",
                    2023,
                    "Blue",
                    900000m));
        }
    }
}
