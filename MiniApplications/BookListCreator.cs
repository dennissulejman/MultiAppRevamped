using System;

namespace MultiAppRevamped.MiniApplications
{
    internal class BookListCreator : IMiniApplication
    {

        public void StartApplication()
        {
            WriteWelcomeMessage();
            //AcceptUserInput();
        }

        public void WriteWelcomeMessage()
        {
            Console.Clear();
            Console.WriteLine("You are free to handle your collection of books.");
            Console.WriteLine("Press one of the following buttons to continue:");
            Console.WriteLine("1: Search for books.");
            Console.WriteLine("2: Show my favorite books.");
            Console.WriteLine("3: Print my favorite books to a testfile.");
            Console.WriteLine("4: Return to main menu.");
        }

        public void ReturnToMainMenu() =>
            MainMenu.Show();

        //private void AcceptUserInput(int options)
        //{
        //    Action continueAfterUserInput = options switch
        //    {
        //        _ => null
        //    }
        //}
    }
}
