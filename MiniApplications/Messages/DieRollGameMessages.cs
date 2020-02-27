using System;

namespace MultiAppRevamped.MiniApplications.Messages
{
    internal class DieRollGameMessages
    {
        public void WelcomeMessage()
        {
            Console.Clear();
            Console.WriteLine("To win, you will need either 5 or 6.");
            Console.WriteLine("Press enter to roll the die!");
        }

        public void GameWonMessage(int dieRoll, int numberOfTries) =>
            Console.WriteLine($"{dieRoll}! You won after {numberOfTries} die rolls.");

        public void GameLostMessage(int dieRoll) =>
            Console.WriteLine($"You rolled {dieRoll}, try again!");

        public void PlayAgainPromptMessage() =>
            Console.WriteLine("Would you like to play again? (y/n)");
    }
}
