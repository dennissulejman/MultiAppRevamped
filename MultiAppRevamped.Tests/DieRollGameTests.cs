using Microsoft.VisualStudio.TestTools.UnitTesting;
using MultiAppRevamped.MiniApplications;

namespace MultiAppRevamped.Tests
{
    [TestClass]
    public class DieRollGameTests
    {
        private readonly IApplication dieRollGame = new DieRollGame();
        [TestMethod]
        public void TestMethod1()
        {
            dieRollGame.StartApplication();
        }
    }
}
