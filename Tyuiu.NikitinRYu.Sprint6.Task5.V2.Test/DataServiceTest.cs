using Tyuiu.NikitinRYu.Sprint6.Task5.V2.Lib;

namespace Tyuiu.NikitinRYu.Sprint6.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();

            // Путь к тестовому файлу
            string path = @"C:\DataSprint6\InPutDataFileTask5V2.txt";

            // Проверяем, существует ли файл
            Assert.IsTrue(File.Exists(path), $"Файл не существует по пути: {path}");

            // Вызываем тестируемый метод
            double[] result = ds.LoadFromDataFile(path);

            // Проверка 1: Массив не null
            Assert.IsNotNull(result);

            // Проверка 2: Правильное количество отрицательных чисел (9 чисел)
            Assert.AreEqual(9, result.Length, "Количество отрицательных чисел неверное");

            // Проверка 3: Все числа отрицательные
            for (int i = 0; i < result.Length; i++)
            {
                Assert.IsTrue(result[i] < 0, $"Число {result[i]} (индекс {i}) должно быть отрицательным");
            }

            // Проверка 4: Конкретные значения (отсортированы как в файле)
            double[] expected = { -1, -2, -3, -5, -6, -7, -8, -9, -10 };

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i], 0.001, $"Ожидалось {expected[i]}, получено {result[i]} (индекс {i})");
            }
        }
    }
}
