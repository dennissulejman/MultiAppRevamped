using Microsoft.CodeAnalysis.CSharp.Scripting;
using System;
using System.Threading.Tasks;

namespace MultiAppRevamped.MiniApplications
{
    internal class Calculator : IMiniApplication
    {
        private Task<decimal> result;

        public Calculator()
        {
            StartApplication();
        }

        public void ReturnToMainMenu()
        {
            MainMenu.Display();
        }

        public void StartApplication()
        {
            WriteWelcomeMessage();
            Continue();
        }

        public void WriteWelcomeMessage()
        {
            Console.Clear();
            Console.WriteLine("Write any mathematic formula using +, -, /, or * between the numbers");
        }

        private void Continue()
        {
            AcceptUserInput();
            PrintResult();
            CalculationFinishedPrompt();
        }

        private void AcceptUserInput()
        {
            result = Calculate(Console.ReadLine());
        }

        private async Task<decimal> Calculate(string formula)
        {
            return await CSharpScript.EvaluateAsync<decimal>(formula);
        }

        private async void PrintResult()
        {
            try
            {
                Console.WriteLine($"The result of the calculation is {await result}");
            }
            catch (Exception)
            {
                Console.WriteLine("Could not calculate the given expression, try again!");
                Console.ReadLine();
                StartApplication();
            }
        }

        private void CalculationFinishedPrompt()
        {
            Console.WriteLine("Would you like to calculate a new problem? (y/n)");

            switch (Console.ReadKey().KeyChar)
            {
                case 'y': StartApplication(); break;
                case 'n': ReturnToMainMenu(); break;
                default: CalculationFinishedPrompt(); break;
            }
        }
    }
}
