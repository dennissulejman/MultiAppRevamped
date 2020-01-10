using System;

namespace MultiAppRevamped.MiniApplications
{
    internal class MiniApplicationInitializer
    {
        public IMiniApplication Initialize(int option)
        {
            return option switch
            {
                1 => new NumbersGame(),
                2 => new ListCreator(),
                3 => new Calculator(),
                _ => throw new InvalidOperationException("No such option available!")
            };
        }
    }
}
