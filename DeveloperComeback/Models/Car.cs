using System;

namespace DeveloperComeback
{
    public class Car
    {
        public string Brand { get; }

        public string Model { get; }

        public int Year { get; }

        public string Colour { get; }

        public decimal Price { get; }

        public Car(
            string brand,
            string model,
            int year,
            string colour,
            decimal price)
        {
            if (string.IsNullOrWhiteSpace(brand))
                throw new ArgumentException("Brand cannot be empty.");

            if (string.IsNullOrWhiteSpace(model))
                throw new ArgumentException("Model cannot be empty.");

            if (price < 0)
                throw new ArgumentOutOfRangeException(nameof(price));

            if (year < 1886)
                throw new ArgumentOutOfRangeException(nameof(year));

            Brand = brand;
            Model = model;
            Year = year;
            Colour = colour;
            Price = price;
        }
    }
}