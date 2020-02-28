using System;
using System.Collections.Generic;
using System.Linq;

namespace MultiAppRevamped.MiniApplications
{
    internal class ApplicationFactory
    {
        private readonly DieRollGame dieRollGame;
        private readonly BookListCreator bookListCreator;
        private readonly Calculator calculator;
        private readonly Dictionary<ApplicationOptions, IApplication> applications;

        public ApplicationFactory(DieRollGame dieRollGame,
                                      BookListCreator bookListCreator,
                                      Calculator calculator)
        {
            this.dieRollGame = dieRollGame;
            this.bookListCreator = bookListCreator;
            this.calculator = calculator;
            applications = SetApplications();
        }

        private Dictionary<ApplicationOptions, IApplication> SetApplications() => 
            new Dictionary<ApplicationOptions, IApplication>
            {
                { ApplicationOptions.DieRollGame, dieRollGame },
                { ApplicationOptions.BookListCreator, bookListCreator },
                { ApplicationOptions.Calculator, calculator }
            };

        public IApplication GetApplication(ApplicationOptions option)
        {
            if (option.Equals(ApplicationOptions.Terminate))
            {
                Environment.Exit(0);
            }
            return applications[option];
        }
    }
}
