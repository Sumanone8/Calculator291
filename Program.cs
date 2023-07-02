using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Fellow Learner!");
            Console.WriteLine("Enter your Name");
            String name = Console.ReadLine();
            Console.WriteLine("Welcome " + name + ",");

            Console.WriteLine("Enter the first number:");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int sum = number1 + number2;
            int difference = number1 - number2;
            int multiplication = number1 * number2;
            double division = (double)number1 / number2;

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Difference: " + difference);
            Console.WriteLine("Multiplication: " + multiplication);
            Console.WriteLine("Division: " + division);

            Console.ReadLine();
        }
    }
}
