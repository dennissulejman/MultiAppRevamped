using System;

namespace MultiAppRevamped.MiniApplications.Calculator
{
    internal static class Messenger
    {
        public static void WelcomeMessage()
        {
            Console.Clear();
            Console.WriteLine("Write a mathematical formula that you would like to calculate ");
        }

        public static void Calculating()
        {
            Console.WriteLine("Calculating...");
        }

        public static void CouldNotCalculateExpression()
        {
            Console.WriteLine("Could not calculate the given expression, try again!");
        }

        public static void CalculationResult(decimal result)
        {
            Console.WriteLine($"The result of the calculation is {result}");
        }

        public static void CalculationFinishedPromptMessage()
        {
            Console.WriteLine("Would you like to calculate a new problem? (y/n)");
        }
    }
}
