using Microsoft.Extensions.DependencyInjection;
using MultiAppRevamped.Extensions.DependencyInjection;
using MultiAppRevamped.MiniApplications;
using System;

namespace MultiAppRevamped
{
    internal static class MainMenu
    {
        private static readonly IServiceProvider serviceProvider =
            AppServiceProvider.GetServiceProvider();
        private static readonly ApplicationInitializer applicationInitializer;
        private static readonly MainMenuMessages messages;

        static MainMenu()
        {
            applicationInitializer = serviceProvider.GetService<ApplicationInitializer>();
            messages = serviceProvider.GetService<MainMenuMessages>();
        }

        public static void Show()
        {
            messages.WelcomeMessage();
            HandleUserInput();
        }

        private static void HandleUserInput()
        {
            try
            {
                applicationInitializer.GetApplication(int.Parse(Console.ReadLine())).StartApplication();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
            Show();
        }
    }
}
