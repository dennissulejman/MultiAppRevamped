using MultiAppRevamped.MiniApplications;
using System;

namespace MultiAppRevamped
{
    internal static class MainMenu
    {
        private static readonly ApplicationInitializer applicationInitializer = new ApplicationInitializer();

        internal static void Display()
        {
            Console.Clear();
            Console.WriteLine("Welcome! Type one of the options then press enter to open their corresponding mini-application:");
            Console.WriteLine("1: Try your luck, roll a die!");
            Console.WriteLine("2: Write lists of your things and print them.");
            Console.WriteLine("3: Check out version 2.0 of my calculator.");
            Console.WriteLine();
            Console.WriteLine("4: Close the application.");
            HandleUserInput();
        }

        private static void HandleUserInput()
        {
            var option = int.Parse(Console.ReadLine());
            applicationInitializer.Initialize(option);
        }
    }
}
