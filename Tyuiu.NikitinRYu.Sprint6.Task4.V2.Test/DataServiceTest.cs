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

            double[] res = ds.GetMassFunction(startValue, stopValue);

            Assert.AreEqual(11, res.Length);
        }
    }
}
