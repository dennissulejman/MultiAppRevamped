using System;

namespace MultiAppRevamped.MiniApplications
{
    internal class ApplicationInitializer
    {
        public IApplication Initialize(int option)
        {
            return option switch
            {
                1 => new DieRollGame(),
                2 => new ListCreator(),
                3 => new Calculator(),
                _ => throw new InvalidOperationException("No such option available!")
            };
        }
    }
}
