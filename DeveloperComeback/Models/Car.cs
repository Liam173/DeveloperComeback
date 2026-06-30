using System;

namespace DeveloperComeback
{
    public class Car
    {
        public string Brand { get; }

        public string Model { get; }

        public int Year { get; }

        public string Colour { get; }

        public decimal Price { get; private set; }

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

            if (price <= 0)
                throw new ArgumentOutOfRangeException(nameof(price));

            if (year < 1886)
                throw new ArgumentOutOfRangeException(nameof(year));

            Brand = brand;
            Model = model;
            Year = year;
            Colour = colour;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Brand} {Model} ({Year}) - {Price:C}";
        }

        /// <summary>
        /// Checks if the car is a classic (manufactured before 1995).
        /// </summary>
        public bool IsClassic()
        {
            return Year < 1995;
        }

        /// <summary>
        /// Increases the car's price by the specified amount.
        /// </summary>
        /// <param name="amount">The price increase.</param>
        public void IncreasePrice(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentOutOfRangeException(nameof(amount));

            Price += amount;
        }
    }
}
