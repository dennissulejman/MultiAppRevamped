using Microsoft.Extensions.DependencyInjection;
using MultiAppRevamped.MiniApplications;
using System;

namespace MultiAppRevamped.Startup
{
    internal static class Services
    {
        public static IServiceProvider Provider { get; }

        static Services()
        {
            Provider = new ServiceCollection()
                .AddSingleton<ApplicationFactory>()
                .AddSingleton<Main.Menu>()
                .AddTransient<MiniApplications.DieRollGame.Application>()
                .AddTransient<MiniApplications.BookListCreator.Application>()
                .AddTransient<MiniApplications.Calculator.Application>()

                .BuildServiceProvider();
        }

        public static T Get<T>()
        {
            return Provider.GetRequiredService<T>();
        }
    }
}
