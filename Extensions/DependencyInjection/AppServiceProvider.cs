using Microsoft.Extensions.DependencyInjection;
using MultiAppRevamped.MiniApplications;
using MultiAppRevamped.MiniApplications.Messages;
using System;

namespace MultiAppRevamped.Extensions.DependencyInjection
{
    internal static class AppServiceProvider
    {
        public static IServiceProvider GetServiceProvider()
        {
            return new ServiceCollection()
                .AddSingleton<Program>()
                .AddSingleton<ApplicationInitializer>()
                //.AddSingleton<MainMenu>()
                .AddSingleton<MainMenuMessages>()
                .AddTransient<DieRollGame>()
                .AddSingleton<DieRollGameMessages>()
                .AddTransient<BookListCreator>()
                .AddTransient<Calculator>()
                .AddSingleton<CalculatorMessages>()

                .BuildServiceProvider();
        }
    }
}
