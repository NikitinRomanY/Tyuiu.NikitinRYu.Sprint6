using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.NikitinRYu.Sprint6.Task2.V15.Lib
{
    public class DataService : ISprint6Task2V15
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] valueArray = new double[len];

            int index = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (Math.Abs(3 * x + 1.2) < 0.0001)
                {
                    valueArray[index] = 0;
                }
                else
                {
                    double numerator = 2 * Math.Sin(x);
                    double denominator = 3 * x + 1.2;
                    double term1 = numerator / denominator;
                    double term2 = Math.Cos(x);
                    double term3 = 7 * x * 2;

                    valueArray[index] = Math.Round(term1 + term2 - term3, 2);
                }
                index++;
            }

            return valueArray;
        }
    }
}
