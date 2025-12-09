using Tyuiu.NikitinRYu.Sprint6.Task7.V8.Lib;

namespace Tyuiu.NikitinRYu.Sprint6.Task7.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();

            string path = @"C:\DataSprint6\InPutDataFileTask7V8.csv";

            if (!File.Exists(path))
            {
                Assert.Inconclusive($"Файл не найден по пути: {path}");
                return;
            }

            // Получаем матрицу
            int[,] matrix = ds.GetMatrix(path);

            // Проверяем размеры (10x10)
            Assert.AreEqual(10, matrix.GetLength(0)); // строки
            Assert.AreEqual(10, matrix.GetLength(1)); // столбцы

            // Проверяем несколько значений
            Assert.AreEqual(-14, matrix[0, 0]);
            Assert.AreEqual(5, matrix[5, 7]);   // Это значение 5 должно остаться
            Assert.AreEqual(0, matrix[9, 9]);
        }

        [TestMethod]
        public void ValidGetMatrixAndTransform()
        {
            DataService ds = new DataService();

            string path = @"C:\DataSprint6\InPutDataFileTask7V8.csv";

            // Вызываем метод GetMatrix (который проверяется)
            int[,] result = ds.GetMatrix(path);

            // Ожидаемый результат
            int[,] expected = new int[10, 10]
            {
        { -14, -20, -20, 19, -1, -10, -8, -1, -4, -6 },
        { 17, 6, 6, 4, -2, 17, 18, -1, 1, -6 },
        { 16, 12, -17, -1, -11, 17, 15, -1, -3, 11 },
        { 12, -17, -18, -4, -1, 3, 13, -1, -2, 10 },
        { -17, 9, -10, -3, -16, -3, 3, -1, 11, 16 },
        { -14, 5, -1, -4, 17, 16, -9, 5, -19, 18 },
        { -12, -4, 17, 0, 1, 14, 4, -1, 13, -7 },
        { 15, -11, 15, -14, 20, 12, -3, -1, -5, -8 },
        { 19, 8, 9, 19, 3, 14, -1, -1, 16, 4 },
        { -5, -16, -12, 18, -7, -5, -6, -1, 10, 0 }
            };

            // Проверяем размеры
            Assert.AreEqual(10, result.GetLength(0));
            Assert.AreEqual(10, result.GetLength(1));

            // Проверяем все значения
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Assert.AreEqual(expected[i, j], result[i, j],
                        $"Несовпадение в ячейке [{i},{j}]. Ожидалось: {expected[i, j]}, Получено: {result[i, j]}");
                }
            }
        }
    }
}
