using System;
using System.Collections.Generic;
using System.Linq;

namespace MultiAppRevamped.MiniApplications
{
    internal class ApplicationInitializer
    {
        private readonly DieRollGame dieRollGame;
        private readonly BookListCreator bookListCreator;
        private readonly Calculator calculator;
        private readonly IEnumerable<(int Option, IApplication Application)> applications;

        public ApplicationInitializer(DieRollGame dieRollGame,
                                      BookListCreator bookListCreator,
                                      Calculator calculator)
        {
            this.dieRollGame = dieRollGame;
            this.bookListCreator = bookListCreator;
            this.calculator = calculator;
            applications = SetApplications();
        }

        private IEnumerable<(int, IApplication)> SetApplications()
        {
            yield return (1, dieRollGame);
            yield return (2, bookListCreator);
            yield return (3, calculator);
        }

        public IApplication GetApplication(int option) => 
            applications.Where(application => 
                application.Option.Equals(option))
                    .FirstOrDefault().Application
                        ?? throw new InvalidOperationException("Option not available! Try a different option");
    }
}
