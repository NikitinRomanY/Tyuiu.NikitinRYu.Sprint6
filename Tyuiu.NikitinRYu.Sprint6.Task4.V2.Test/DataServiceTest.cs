using Tyuiu.NikitinRYu.Sprint6.Task4.V2.Lib;

namespace Tyuiu.NikitinRYu.Sprint6.Task4.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double[] result = ds.GetMassFunction(startValue, stopValue);

            Assert.AreEqual(11, result.Length);

            Assert.AreEqual(59.49, result[0], 0.01);

            Assert.AreEqual(-2.81, result[2], 0.01);

            Assert.AreEqual(0.57, result[5], 0.01);

            Assert.AreEqual(-6.3, result[6], 0.01);

            Assert.AreEqual(59.6, result[10], 0.01);

        }
    }
}
