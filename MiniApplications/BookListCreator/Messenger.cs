using System;

namespace MultiAppRevamped.MiniApplications.BookListCreator
{
    internal static class Messenger
    {
        public static void WelcomeMessage()
        {
            Console.Clear();
            Console.WriteLine("Press one of the following buttons to handle your collection of books:");
            Console.WriteLine("1: Search for books.");
            Console.WriteLine("2: Show my favorite books.");
            Console.WriteLine("3: Print my favorite books to a testfile.");
            Console.WriteLine("4: Return to main menu.");
        }
    }
}
