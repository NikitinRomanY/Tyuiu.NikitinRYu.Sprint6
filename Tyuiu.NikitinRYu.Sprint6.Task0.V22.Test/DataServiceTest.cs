using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.NikitinRYu.Sprint6.Task0.V22.Lib;

namespace Tyuiu.NikitinRYu.Sprint6.Task0.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int x = 2;

            // 0.7*8 + 1.52*4 = 5.6 + 6.08 = 11.68
            double wait = 11.68;
            double res = ds.Calculate(x);

            Assert.AreEqual(wait, res);
        }
    }
}
