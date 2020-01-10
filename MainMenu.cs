using MultiAppRevamped.MiniApplications;
using System;

namespace MultiAppRevamped
{
    internal class MainMenu
    {
        private readonly MiniApplicationInitializer miniApplicationInitializer = new MiniApplicationInitializer();

        internal void Display()
        {
            Console.Clear();
            Console.WriteLine("Welcome! Type one of the options then press enter to open their corresponding mini-application:");
            Console.WriteLine("1: Try your luck, roll the die!");
            Console.WriteLine("2: Write lists of your things and print them.");
            Console.WriteLine("3: Check out version 2.0 of my calculator.");
            Console.WriteLine();
            Console.WriteLine("4: Close the application.");
            var option = int.Parse(Console.ReadLine());
            miniApplicationInitializer.Initialize(option);
        }
    }
}
