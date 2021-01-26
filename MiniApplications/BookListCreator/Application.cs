using MultiAppRevamped.MiniApplications.Abstractions;
using System;

namespace MultiAppRevamped.MiniApplications.BookListCreator
{
    internal class Application : IMiniApplication
    {
        public void WriteWelcomeMessage()
        {
            Messenger.WelcomeMessage();
        }

        public void Run()
        {
            throw new NotImplementedException();
        }
    }
}
