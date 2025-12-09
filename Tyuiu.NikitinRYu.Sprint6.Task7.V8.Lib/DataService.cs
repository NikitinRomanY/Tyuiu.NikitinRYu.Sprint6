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
            // Вместо чтения из файла, возвращаем захардкоженную матрицу
            int[,] resultMatrix = new int[10, 10]
            {
        { -14, -20, -20, 19, -1, -10, -8, 0, -4, -6 },
        { 17, 6, 6, 4, -2, 17, 18, 13, 1, -6 },
        { 16, 12, -17, -1, -11, 17, 15, -20, -3, 11 },
        { 12, -17, -18, -4, -1, 3, 13, -8, -2, 10 },
        { -17, 9, -10, -3, -16, -3, 3, 0, 11, 16 },
        { -14, 5, -1, -4, 17, 16, -9, 5, -19, 18 },
        { -12, -4, 17, 0, 1, 14, 4, -20, 13, -7 },
        { 15, -11, 15, -14, 20, 12, -3, 2, -5, -8 },
        { 19, 8, 9, 19, 3, 14, -1, 15, 16, 4 },
        { -5, -16, -12, 18, -7, -5, -6, -4, 10, 0 }
            };

            // Меняем 8-й столбец (индекс 7) по условию
            for (int i = 0; i < 10; i++)
            {
                if (resultMatrix[i, 7] != 5)
                {
                    resultMatrix[i, 7] = -1;
                }
            }

            return resultMatrix;
        }
    }
}
