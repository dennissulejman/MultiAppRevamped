using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MultiAppRevamped.Tests.DependencyInjection;
using MultiAppRevamped.MiniApplications;

namespace MultiAppRevamped.Tests
{
    [TestClass]
    public class DieRollGameTests
    {
        private readonly IApplication dieRollGame =
            TestServiceProvider.GetServiceProvider.GetService<DieRollGame>();
        [TestMethod]
        public void TestMethod1()
        {
            dieRollGame.StartApplication();
        }
    }
}
