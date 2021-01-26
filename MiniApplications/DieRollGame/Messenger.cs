using System;

namespace MultiAppRevamped.MiniApplications.DieRollGame
{
    internal static class Messenger
    {
        public static void WelcomeMessage()
        {
            Console.Clear();
            Console.WriteLine("To win, you will need either 5 or 6.");
            Console.WriteLine("Press enter to roll the die!");
        }

        public static void GameWonMessage(int dieRoll, int numberOfTries)
        {
            Console.WriteLine($"{dieRoll}! You won after {numberOfTries} die rolls.");
        }

        public static void GameLostMessage(int dieRoll)
        {
            Console.WriteLine($"You rolled {dieRoll}, try again!");
        }

        public static void PlayAgainPromptMessage()
        {
            Console.WriteLine("Would you like to play again? (y/n)");
        }
    }
}
