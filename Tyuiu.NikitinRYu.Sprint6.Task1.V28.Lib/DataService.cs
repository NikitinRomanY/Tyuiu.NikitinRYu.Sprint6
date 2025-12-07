using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.NikitinRYu.Sprint6.Task1.V28.Lib
{
    public class DataService : ISprint6Task1V28
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] valueArray = new double[len];

            int index = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                // F(x) = cos(x) + (4x/2) - sin(x) * 3x
                // Упрощаем: cos(x) + 2x - 3x*sin(x)
                double result = Math.Cos(x) + (2 * x) - (3 * x * Math.Sin(x));
                valueArray[index] = Math.Round(result, 2);
                index++;
            }

            return valueArray;
        }
    }
}
