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

            if (!File.Exists(path))
            {
                Assert.Inconclusive($"Файл не найден по пути: {path}");
                return;
            }

            // Получаем преобразованную матрицу
            int[,] matrix = ds.GetMatrixAndTransform(path);

            // Проверяем размеры
            Assert.AreEqual(10, matrix.GetLength(0));
            Assert.AreEqual(10, matrix.GetLength(1));

            // Проверяем преобразование 8-го столбца (индекс 7)
            // Только значение 5 должно остаться, остальные → -1

            // Значения из вашего файла в 8-м столбце (индекс 7):
            // [0, 13, -20, -8, 0, 5, -20, 2, 15, -4]

            Assert.AreEqual(-1, matrix[0, 7]);  // 0 → -1
            Assert.AreEqual(-1, matrix[1, 7]);  // 13 → -1
            Assert.AreEqual(-1, matrix[2, 7]);  // -20 → -1
            Assert.AreEqual(-1, matrix[3, 7]);  // -8 → -1
            Assert.AreEqual(-1, matrix[4, 7]);  // 0 → -1
            Assert.AreEqual(5, matrix[5, 7]);   // 5 остается 5 ✓
            Assert.AreEqual(-1, matrix[6, 7]);  // -20 → -1
            Assert.AreEqual(-1, matrix[7, 7]);  // 2 → -1
            Assert.AreEqual(-1, matrix[8, 7]);  // 15 → -1
            Assert.AreEqual(-1, matrix[9, 7]);  // -4 → -1

            // Проверяем, что другие столбцы не изменились
            Assert.AreEqual(-14, matrix[0, 0]);
            Assert.AreEqual(0, matrix[9, 9]);
        }
    }
}
