using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.NikitinRYu.Sprint6.Task7.V8.Lib
{
    public class DataService : ISprint6Task7V8
    {
        public int[,] GetMatrix(string path)
        {
            // Читаем все строки файла
            string[] lines = File.ReadAllLines(path);

            // Определяем размеры матрицы
            int rows = lines.Length;

            // Важно: разделитель точка с запятой
            string[] firstLineValues = lines[0].Split(';');
            int cols = firstLineValues.Length;

            int[,] matrix = new int[rows, cols];

            // Заполняем матрицу
            for (int i = 0; i < rows; i++)
            {
                // Разделяем значения по точке с запятой
                string[] values = lines[i].Split(';');

                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = int.Parse(values[j].Trim()); // Trim на всякий случай
                }
            }

            return matrix;
        }

        public int[,] GetMatrixAndTransform(string path)
        {
            string[] lines = File.ReadAllLines(path);
            int rows = lines.Length;
            string[] firstLineValues = lines[0].Split(';');
            int cols = firstLineValues.Length;

            int[,] matrix = new int[rows, cols];
            int targetColumn = 7; // 8-й столбец (индекс 7)

            for (int i = 0; i < rows; i++)
            {
                string[] values = lines[i].Split(';');

                for (int j = 0; j < cols; j++)
                {
                    int value = int.Parse(values[j].Trim());

                    // Если это 8-й столбец и значение не равно 5
                    if (j == targetColumn && value != 5)
                    {
                        matrix[i, j] = -1;
                    }
                    else
                    {
                        matrix[i, j] = value;
                    }
                }
            }

            return matrix;
        }
    }
}
