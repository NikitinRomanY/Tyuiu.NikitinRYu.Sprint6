using System;
using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.NikitinRYu.Sprint6.Task6.V3.Lib
{
    public class DataService : ISprint6Task6V3
    {
        public string CollectTextFromFile(string path)
        {
            StringBuilder result = new StringBuilder();

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Разбиваем строку на слова по пробелам
                    string[] words = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                    foreach (string word in words)
                    {
                        // Проверяем, содержит ли слово строчную букву 'r'
                        if (word.Contains('r'))
                        {
                            // Добавляем слово в результат через пробел
                            if (result.Length > 0)
                            {
                                result.Append(" ");
                            }
                            result.Append(word);
                        }
                    }
                }
            }

            return result.ToString();
        }
    }
}
