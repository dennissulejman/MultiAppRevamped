using MultiAppRevamped.Abstractions;
using System;

namespace MultiAppRevamped.MiniApplications.Abstractions
{
    internal interface IMiniApplication : IApplication
    {
        void WriteWelcomeMessage();
        void Run();

        void IApplication.Start()
        {
            WriteWelcomeMessage();
            Run();
            ReturnToMainMenuPrompt();
        }

        void ReturnToMainMenuPrompt()
        {
            Messages.ReturnToMainMenuPromptMessage();

            var userInputKey = Console.ReadKey().KeyChar;

            switch (userInputKey)
            {
                case 'y': break;
                case 'n': Start(); break;
                default: ReturnToMainMenuPrompt(); break;
            }
        }
    }
}
