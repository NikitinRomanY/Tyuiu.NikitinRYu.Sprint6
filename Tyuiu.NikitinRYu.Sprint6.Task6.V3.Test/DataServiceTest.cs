using Tyuiu.NikitinRYu.Sprint6.Task6.V3.Lib;

namespace Tyuiu.NikitinRYu.Sprint6.Task6.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CollectTextFromFile()
        {
            DataService ds = new DataService();

            // Путь к существующему файлу
            string path = @"C:\DataSprint6\InPutDataFileTask6V3.txt";

            // Проверяем, что файл существует
            if (!File.Exists(path))
            {
                Assert.Inconclusive("Файл не найден. Создайте файл с тестовыми данными.");
                return;
            }

            string result = ds.CollectTextFromFile(path);

            // Ожидаемый результат для ваших данных
            string expected = "rdRibhX swrfhvUjC raHsMtQF jiUFMDjMsEervIz";
            Assert.AreEqual(expected, result);
        }
    }
}
