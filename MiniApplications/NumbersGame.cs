using System;

namespace MultiAppRevamped.MiniApplications
{
    internal class NumbersGame : IMiniApplication
    {
        public NumbersGame()
        {
            StartApplication();
        }

        public MainMenu ReturnToMainMenu()
        {
            return new MainMenu();
        }

        public void StartApplication()
        {
            WriteWelcomeMessage();
            StartNumbersGame();
        }

        public void WriteWelcomeMessage()
        {
            Console.Clear();
            Console.WriteLine("To win, you will need either 5 or 6.");
            Console.WriteLine("Press enter to roll the die!");
        }

        private void StartNumbersGame()
        {

        }
    }
}
