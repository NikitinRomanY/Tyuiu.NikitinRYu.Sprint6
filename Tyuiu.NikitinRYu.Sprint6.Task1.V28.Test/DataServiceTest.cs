using Tyuiu.NikitinRYu.Sprint6.Task1.V28.Lib;

namespace Tyuiu.NikitinRYu.Sprint6.Task1.V28.Test
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

            double[] expected =
            {
                4.67,   // x=-5
                0.43,  // x=-4
                -8.26,  // x=-3
                -9.87,  // x=-2
                -3.98,  // x=-1
                1.00,   // x=0
                0.02,   // x=1
                -1.87,  // x=2
                3.74,  // x=3
                16.43,  // x=4
                24.67   // x=5
            };

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i], 0.01, $"Ошибка при x={startValue + i}");
            }
        }
    }
}
