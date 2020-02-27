using System;

namespace MultiAppRevamped.MiniApplications.Messages
{
    internal class CalculatorMessages
    {
        public void WelcomeMessage()
        {
            Console.Clear();
            Console.WriteLine("Write a mathematical formula that you would like to calculate ");
        }

        public void Calculating() => 
            Console.WriteLine("Calculating...");

        public void CouldNotCalculateExpression() => 
            Console.WriteLine("Could not calculate the given expression, try again!");

        public void CalculationResult(decimal result) => 
            Console.WriteLine($"The result of the calculation is {result}");

        internal void CalculationFinishedPromptMessage() =>
            Console.WriteLine("Would you like to calculate a new problem? (y/n)");
    }
}
