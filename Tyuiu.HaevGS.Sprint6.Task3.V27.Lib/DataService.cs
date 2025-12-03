using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.HaevGS.Sprint6.Task3.V27.Lib
{
    public class DataService : ISprint6Task3V27
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int col = matrix.Length / rows;

            int[] kal = new int[matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                kal[i] = matrix[i, 3];
            }
            Array.Sort(kal);

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                matrix[i, 3] = kal[i];
            }
            return matrix;
        }
    }
}