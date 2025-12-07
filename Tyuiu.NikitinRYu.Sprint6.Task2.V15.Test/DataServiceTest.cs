using Tyuiu.NikitinRYu.Sprint6.Task2.V15.Lib;

namespace Tyuiu.NikitinRYu.Sprint6.Task2.V15.Test
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

            Assert.AreEqual(70.14, result[0], 0.01);

            Assert.AreEqual(1.00, result[5], 0.01);
        }
    }
}
