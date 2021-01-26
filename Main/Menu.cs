using MultiAppRevamped.MiniApplications;
using System;
using System.Collections.Generic;

namespace MultiAppRevamped.Main
{
    internal class Menu
    {
        private readonly ApplicationFactory applicationFactory;

        public Menu(ApplicationFactory applicationFactory)
        {
            this.applicationFactory = applicationFactory;
        }

        public void Display()
        {
            Messages.WelcomeMessage();
            HandleUserInput();
        }

        private void HandleUserInput()
        {
            try
            {
                var option = (ApplicationOption)int.Parse(Console.ReadLine());

                if (option.Equals(ApplicationOption.TerminateApplication))
                {
                    Environment.Exit(0);
                }

                var application = applicationFactory.CreateApplication(option);
                application.Start();
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
                Display();
            }
        }
    }
}
