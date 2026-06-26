using System;

namespace DeveloperComeback
{
    public static class Day02Exercises
    {
        public static void Run()
        {
            Car car1 = CreateCar(
                "Toyota",
                "Corolla",
                2020,
                "Blue",
                250000m);

            PrintCar(car1);
        }

        #region "Models and Objects - Day 2"

        private static Car CreateCar(
            string brand,
            string model,
            int year,
            string colour,
            decimal price)
        {
            return new Car
            {
                Brand = brand,
                Model = model,
                Year = year,
                Colour = colour,
                Price = price
            };
        }

        private static void PrintCar(Car car)
        {
            Console.WriteLine(
                $"{car.Brand} {car.Model}");
        }

        #endregion
    }
}