using Microsoft.CodeAnalysis.CSharp.Scripting;
using MultiAppRevamped.MiniApplications.Abstractions;
using System;
using System.Threading.Tasks;

namespace MultiAppRevamped.MiniApplications.Calculator
{
    internal class Application : IMiniApplication
    {
        private Task<decimal> result;

        public void WriteWelcomeMessage()
        {
            Messenger.WelcomeMessage();
        }

        public void Run()
        {
            AcceptUserInput();
            PrintResult();
        }

        private void AcceptUserInput()
        {
            result = Calculate(Console.ReadLine());
        }

        private static async Task<decimal> Calculate(string formula)
        {
            Messenger.Calculating();
            return await CSharpScript.EvaluateAsync<decimal>(formula);
        }

        private async void PrintResult()
        {
            try
            {
                Messenger.CalculationResult(await result);
            }
            catch (Exception)
            {
                Messenger.CouldNotCalculateExpression();
                Console.ReadLine();
                Run();
            }
        }
    }
}
