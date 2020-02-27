using Microsoft.CodeAnalysis.CSharp.Scripting;
using MultiAppRevamped.MiniApplications.Messages;
using System;
using System.Threading.Tasks;

namespace MultiAppRevamped.MiniApplications
{
    internal class Calculator : IMiniApplication
    {
        private Task<decimal> result;
        private readonly CalculatorMessages messages;

        public Calculator(CalculatorMessages messages)
        {
            this.messages = messages;
        }

        public void StartApplication()
        {
            WriteWelcomeMessage();
            Continue();
        }

        public void WriteWelcomeMessage() =>
            messages.WelcomeMessage();

        public void ReturnToMainMenu() =>
            MainMenu.Show();

        private void Continue()
        {
            AcceptUserInput();
            PrintResult();
            CalculationFinishedPrompt();
        }

        private void AcceptUserInput() => 
            result = Calculate(Console.ReadLine());

        private async Task<decimal> Calculate(string formula)
        {
            messages.Calculating();
            return await CSharpScript.EvaluateAsync<decimal>(formula);
        }

        private async void PrintResult()
        {
            try
            {
                messages.CalculationResult(await result);
            }
            catch (Exception)
            {
                messages.CouldNotCalculateExpression();
                Console.ReadLine();
                StartApplication();
            }
        }

        private void CalculationFinishedPrompt()
        {
            messages.CalculationFinishedPromptMessage();

            Action continueAfterUserInput = Console.ReadKey().KeyChar switch
            {
                var key when key.Equals('y') => 
                    () => 
                        StartApplication(),
                var key when key.Equals('n') => 
                    () =>
                        ReturnToMainMenu(),
                _ => 
                    () => 
                        CalculationFinishedPrompt()
            };

            continueAfterUserInput.Invoke();
        }
    }
}
