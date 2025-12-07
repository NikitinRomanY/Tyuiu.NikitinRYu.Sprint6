using Tyuiu.NikitinRYu.Sprint6.Task3.V9.Lib;

namespace Tyuiu.NikitinRYu.Sprint6.Task3.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[5, 5]
            {
                {-14, 25, 26, 18, 17},
                {28, 10, 6, -2, 4},
                {30, 25, -3, 11, -10},
                {11, 32, -5, -20, 25},
                {2, -18, 11, 8, -20}
            };

            int[,] result = ds.Calculate(matrix);

            int[] sortedFifthColumn = { -20, -10, 4, 17, 25 };

            for (int i = 0; i < 5; i++)
            {
                Assert.AreEqual(sortedFifthColumn[i], result[i, 4]);
            }

            Assert.AreEqual(-14, result[0, 0]);
            Assert.AreEqual(25, result[0, 1]);
            Assert.AreEqual(25, result[4, 4]);
        }
    }
}
