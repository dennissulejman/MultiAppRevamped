using MultiAppRevamped.MiniApplications.Messages;
using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("MultiAppRevamped.Tests")]
namespace MultiAppRevamped.MiniApplications
{
    internal class DieRollGame : IMiniApplication
    {               
        private readonly DieRollGameMessages messages;

        public DieRollGame(DieRollGameMessages messages)
        {
            this.messages = messages;
        }

        public void StartApplication()
        {
            WriteWelcomeMessage();
            PlayNumbersGame();
        }

        public void ReturnToMainMenu() =>
            MainMenu.Show();

        public void WriteWelcomeMessage() => 
            messages.WelcomeMessage();

        private void PlayNumbersGame()
        {
            int numberOfTries = 0;
            int dieRoll = RollDie();

            VerifyDieRoll(dieRoll, numberOfTries);
        }

        private int RollDie()
        {
            Console.ReadLine();
            
            //Simulate die roll of a regular 1-6 die
            return new Random().Next(1, 7);
        }

        private void VerifyDieRoll(int dieRoll, int numberOfTries)
        {
            numberOfTries++;

            Action<int, int> continueAfterVerification = dieRoll switch
            {
                var x when x >= 5 => GameWon,
                _ => GameLost
            };

            continueAfterVerification.Invoke(dieRoll, numberOfTries);
        }

        private void GameWon(int dieRoll, int numberOfTries)
        {
            messages.GameWonMessage(dieRoll, numberOfTries);
            Console.ReadLine();
            PlayAgainPrompt();
        }

        private void GameLost(int dieRoll, int numberOfTries)
        {
            messages.GameLostMessage(dieRoll);
            VerifyDieRoll(RollDie(), numberOfTries);
        }

        private void PlayAgainPrompt()
        {
            messages.PlayAgainPromptMessage();

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
                        PlayAgainPrompt()
            };

            continueAfterUserInput.Invoke();
        }
    }
}
