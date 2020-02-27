using MultiAppRevamped.Extensions.DependencyInjection;
using System;

namespace MultiAppRevamped.Tests.DependencyInjection
{
    public static class TestServiceProvider
    {
        public static IServiceProvider GetServiceProvider = GetAppServiceProvider();

        private static IServiceProvider GetAppServiceProvider()
        {
            return AppServiceProvider.GetServiceProvider();
        }
    }
}
