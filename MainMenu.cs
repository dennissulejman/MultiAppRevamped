using Microsoft.Extensions.DependencyInjection;
using MultiAppRevamped.Extensions.DependencyInjection;
using MultiAppRevamped.MiniApplications;
using System;
using System.Collections.Generic;

namespace MultiAppRevamped
{
    internal static class MainMenu
    {
        private static readonly IServiceProvider serviceProvider =
            AppServiceProvider.GetServiceProvider();
        private static readonly ApplicationFactory applicationInitializer;
        private static readonly MainMenuMessages messages;

        static MainMenu()
        {
            applicationInitializer = serviceProvider.GetService<ApplicationFactory>();
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
                var option = (ApplicationOptions)int.Parse(Console.ReadLine());

                if (option.Equals(ApplicationOptions.TerminateApplcation))
                {
                    Environment.Exit(0);
                }

                applicationInitializer.GetApplicationFromUserInput(option).StartApplication();
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("Option not available, try again!");
                Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input format. The format needs to be an integer number, try again!");
                Console.ReadLine();
            }
            finally
            {
                Show();
            }
        }
    }
}
