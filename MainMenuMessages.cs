using System;

namespace MultiAppRevamped
{
    internal class MainMenuMessages
    {
        public void WelcomeMessage()
        {
            Console.Clear();
            Console.WriteLine("Welcome! Type one of the options then press enter to open their corresponding mini-application:");
            Console.WriteLine("1: Try your luck, roll a die!");
            Console.WriteLine("2: Search for your favorite books, put them into lists and print them to a file.");
            Console.WriteLine("3: Check out version 2.0 of my calculator.");
            Console.WriteLine();
            Console.WriteLine("4: Close the application.");
        }
    }
}
