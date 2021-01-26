using MultiAppRevamped.Abstractions;
using System.Collections.Generic;

namespace MultiAppRevamped.MiniApplications
{
    internal class ApplicationFactory
    {
        private readonly DieRollGame.Application dieRollGame;
        private readonly BookListCreator.Application bookListCreator;
        private readonly Calculator.Application calculator;

        public ApplicationFactory(DieRollGame.Application dieRollGame,
                                      BookListCreator.Application bookListCreator,
                                      Calculator.Application calculator)
        {
            this.dieRollGame = dieRollGame;
            this.bookListCreator = bookListCreator;
            this.calculator = calculator;
        }

        private Dictionary<ApplicationOption, IApplication> Applications =>
            new Dictionary<ApplicationOption, IApplication>
            {
                { ApplicationOption.DieRollGame, dieRollGame },
                { ApplicationOption.BookListCreator, bookListCreator },
                { ApplicationOption.Calculator, calculator }
            };

        public IApplication CreateApplication(ApplicationOption option)
        {
            return Applications[option];
        }
    }
}
