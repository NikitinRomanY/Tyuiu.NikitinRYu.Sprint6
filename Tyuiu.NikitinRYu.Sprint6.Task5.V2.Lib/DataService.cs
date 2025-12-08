using System;
using System.IO;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.NikitinRYu.Sprint6.Task5.V2.Lib
{
    public class DataService : ISprint6Task5V2
    {
        public double[] LoadFromDataFile(string path)
        {
            // Первый проход: подсчет количества строк
            int len = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Пропускаем пустые строки
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        len++;
                    }
                }
            }

            // Второй проход: чтение и преобразование данных
            double[] numsArray = new double[len];
            int index = 0;

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Пропускаем пустые строки
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    // Преобразуем строку в число
                    double number = Convert.ToDouble(line);

                    // Округляем до 3 знаков после запятой
                    numsArray[index] = Math.Round(number, 3);
                    index++;
                }
            }

            // Фильтруем отрицательные числа (по условию задания)
            double[] negativeNumbers = numsArray.Where(val => val < 0).ToArray();

            return negativeNumbers;
        }
    }
}
