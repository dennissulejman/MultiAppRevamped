using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("MultiAppRevamped.Tests")]
namespace MultiAppRevamped.MiniApplications
{
    internal class DieRollGame : IMiniApplication
    {
        private readonly Func<int> getRandomNumberFromOneToSix = () => new Random().Next(1, 7);

        public DieRollGame()
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
            PlayNumbersGame();
        }

        public void WriteWelcomeMessage()
        {
            Console.Clear();
            Console.WriteLine("To win, you will need either 5 or 6.");
            Console.WriteLine("Press enter to roll the die!");
        }

        private void PlayNumbersGame()
        {
            int numberOfTries = 0;
            int dieRoll = RollDie();

            VerifyDieRoll(dieRoll, numberOfTries);
        }

        private int RollDie()
        {
            Console.ReadLine();
            return getRandomNumberFromOneToSix.Invoke();
        }

        private void VerifyDieRoll(int dieRoll, int numberOfTries)
        {
            numberOfTries++;

            switch (dieRoll >= 5)
            {
                case true: GameWon(dieRoll, numberOfTries); break;
                default: GameLost(dieRoll, numberOfTries); break;
            }
        }

        private void GameWon(int dieRoll, int numberOfTries)
        {
            Console.WriteLine($"{dieRoll}! You won after {numberOfTries} die rolls.");
            Console.ReadLine();

            PlayAgainPrompt();
        }

        private void GameLost(int dieRoll, int numberOfTries)
        {
            Console.WriteLine($"You rolled {dieRoll}, try again!");
            VerifyDieRoll(RollDie(), numberOfTries);
        }

        private void PlayAgainPrompt()
        {
            Console.WriteLine("Would you like to play again? (y/n)");

            switch (Console.ReadKey().KeyChar)
            {
                case 'y': StartApplication(); break;
                case 'n': ReturnToMainMenu(); break;
                default: PlayAgainPrompt(); break;
            }
        }
    }
}
