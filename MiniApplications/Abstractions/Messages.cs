using System;

namespace MultiAppRevamped.MiniApplications.Abstractions
{
    internal static class Messages
    {
        public static void ReturnToMainMenuPromptMessage()
        {
            Console.WriteLine("Would you like to return to the main menu? (y/n)");
        }
    }
}
