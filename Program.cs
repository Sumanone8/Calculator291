using System;

namespace Calulator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello Fellow Learner!");
            Console.WriteLine("Enter your Name");
            String name = Console.ReadLine();

            Calculator.AdditionOfTwoNumbers();
            Calculator.DifferenceOfTwoNumbers();

            Console.ReadLine();
        }
    }

    public class Calculator
    {
        public static void AdditionOfTwoNumbers()
        {
            Console.WriteLine("Enter 1st number");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sum: " + (firstNumber + secondNumber));
        }

        public static void DifferenceOfTwoNumbers()
        {
            Console.WriteLine("Enter 1st number");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Difference: " + Math.Abs(firstNumber - secondNumber));
        }
    }
}
