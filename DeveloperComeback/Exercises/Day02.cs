using System;

namespace DeveloperComeback
{
    public static class Day02Exercises
    {
        public static void Run()
        {
            Car car1 = new Car(
                "Toyota",
                "Corolla",
                2020,
                "Blue",
                250000m);

            PrintCar(car1);
        }

        #region "Models and Objects - Day 2"

        // Constructor handles this now.
        //private static Car CreateCar(
        //    string brand,
        //    string model,
        //    int year,
        //    string colour,
        //    decimal price)
        //{
        //    return new Car
        //    {
        //        brand,
        //        model,
        //        year,
        //        colour,
        //        price
        //    };
        //}

        private static void PrintCar(Car car)
        {
            Console.WriteLine("==============================");
            Console.WriteLine("Car Information");
            Console.WriteLine("==============================");
            Console.WriteLine($"Brand  : {car.Brand}");
            Console.WriteLine($"Model  : {car.Model}");
            Console.WriteLine($"Year   : {car.Year}");
            Console.WriteLine($"Colour : {car.Colour}");
            Console.WriteLine($"Price  : {car.Price:C}");
            Console.WriteLine("==============================");
        }

        #endregion
    }
}