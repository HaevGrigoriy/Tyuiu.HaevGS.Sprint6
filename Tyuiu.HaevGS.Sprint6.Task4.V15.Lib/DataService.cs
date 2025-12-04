using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.HaevGS.Sprint6.Task4.V15.Lib
{
    public class DataService : ISprint6Task4V15
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (x + 2 == 0)
                {
                    y = 0;
                }
                else
                {
                    y = Math.Round(Math.Sin(x) + (2 * x / 3) - Math.Cos(x) * (4 * x), 2);
                }

                if (double.IsNaN(y) || double.IsInfinity(y))
                {
                    y = 0;
                }

                valueArray[count] = y;
                count++;
            }
            return valueArray;
        }
    }
}
