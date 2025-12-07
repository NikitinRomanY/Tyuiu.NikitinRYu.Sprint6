using System;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.NikitinRYu.Sprint6.Task4.V2.Lib
{
    public class DataService : ISprint6Task4V2
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] valueArray = new double[len];

            int index = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (Math.Abs(x - 0.7) < 0.0001)
                {
                    valueArray[index] = 0;
                }
                else
                {
                    double numerator = Math.Cos(x);          
                    double denominator = x - 0.7;             
                    double term1 = numerator / denominator;   

                    double term2 = Math.Sin(x) * 12 * x;      

                    double result = term1 - term2 + 2;        

                    valueArray[index] = Math.Round(result, 2);
                }
                index++;
            }

            return valueArray;
        }
    }
}
