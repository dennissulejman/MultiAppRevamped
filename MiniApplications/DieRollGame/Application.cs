using MultiAppRevamped.MiniApplications.Abstractions;
using System;

namespace MultiAppRevamped.MiniApplications.DieRollGame
{
    internal class Application : IMiniApplication
    {
        public void WriteWelcomeMessage()
        {
            Messenger.WelcomeMessage();
        }

        public void Run()
        {
            int numberOfTries = 0;
            int dieRoll = RollDie();

            VerifyDieRoll(dieRoll, numberOfTries);
        }

        private static int RollDie()
        {
            Console.ReadLine();
            
            //Simulate die roll of a regular 1-6 die
            return new Random().Next(1, 7);
        }

        private void VerifyDieRoll(int dieRoll, int numberOfTries)
        {
            numberOfTries++;

            if (dieRoll >= 5)
            {
                GameWon(dieRoll, numberOfTries);
            }
            else
            {
                GameLost(dieRoll, numberOfTries);
            }
        }

        private static void GameWon(int dieRoll, int numberOfTries)
        {
            Messenger.GameWonMessage(dieRoll, numberOfTries);
            Console.ReadLine();
        }

        private void GameLost(int dieRoll, int numberOfTries)
        {
            Messenger.GameLostMessage(dieRoll);
            VerifyDieRoll(RollDie(), numberOfTries);
        }
    }
}
