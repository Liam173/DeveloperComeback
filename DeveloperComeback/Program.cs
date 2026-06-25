using System;

namespace DeveloperComeback
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Keeping this for practice puposes, but it is not needed for the current functionality of the program.
            //CreateMyData();
            //PrintMessage("John", 45, 50000.00m, 1.80d, 75.5f, true);

            Console.WriteLine("Please enter the first number:");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number:");
            int secondNumber = int.Parse(Console.ReadLine());
            int sum = Addition(firstNumber, secondNumber);
            Console.WriteLine($"The sum of {firstNumber} and {secondNumber} is: {sum}");
            int difference = Subtraction(firstNumber, secondNumber);
            Console.WriteLine($"The difference of {firstNumber} and {secondNumber} is: {difference}");
            int product = Multiplication(firstNumber, secondNumber);
            Console.WriteLine($"The product of {firstNumber} and {secondNumber} is: {product}");
            double quotient = Division(firstNumber, secondNumber);
            Console.WriteLine($"The quotient of {firstNumber} and {secondNumber} is: {quotient}");
        }

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
    }
}
