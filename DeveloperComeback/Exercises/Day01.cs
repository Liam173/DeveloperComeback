using System;

namespace DeveloperComeback.Exercises
{
    public static class Day01Exercises
    {
        public static void Run()
        {
            CreateMyData();
            PrintMessage("John", 45, 50000.00m, 1.80d, 75.5f, true);

            Console.WriteLine($"50 + 20 = {Addition(50, 20)}");
            Console.WriteLine($"50 - 20 = {Subtraction(50, 20)}");
            Console.WriteLine($"50 * 20 = {Multiplication(50, 20)}");
            Console.WriteLine($"50 / 20 = {Division(50, 20)}");
        }


        #region "Mathematical Operations - Day 1"

        public static int Addition(int firstNumber, int secondNumber)
        {
            int sum = firstNumber + secondNumber;
            return sum;
        }

        public static int Subtraction(int firstNumber, int secondNumber)
        {
            int difference = firstNumber - secondNumber;
            return difference;
        }

        public static int Multiplication(int firstNumber, int secondNumber)
        {
            int product = firstNumber * secondNumber;
            return product;
        }

        public static double Division(int firstNumber, int secondNumber)
        {
            if (secondNumber != 0)
            {
                double quotient = (double)firstNumber / secondNumber;
                return quotient;
            }
            else
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
            return 0; // Return a default value in case of division by zero
        }

        #endregion

        #region "Data Creation and Printing - Day 1"

        public static void CreateMyData()
        {
            // String is used for text and character data
            string name = "Liam";
            // Integer is used for whole numbers and counting
            int age = 30;
            // Decimal is used for financial and monetary calculations where precision is important
            decimal salary = 30000.50m;
            // Double is used for scientific calculations and measurements where precision is less critical
            double height = 1.75d;
            // Float is used for graphics and game development where performance is more important than precision
            float weight = 70.5f;
            // Boolean is used for logical operations and decision-making
            bool employed = true;
            PrintMessage(name, age, salary, height, weight, employed);
        }

        public static void PrintMessage(string name, int age, decimal salary, double height, float weight, bool employed)
        {
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine($"Hello {name}!");
            // Output the values to the console using string interpolation
            Console.WriteLine($"I am {age} years old");
            Console.WriteLine($"My salary is {salary:C}");
            Console.WriteLine($"My height is {height} meters");
            Console.WriteLine($"My weight is {weight} kg");
            Console.WriteLine($"I am employed: {employed}");
        }

        #endregion
    }
}
