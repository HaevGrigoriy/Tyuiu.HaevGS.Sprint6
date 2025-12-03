using Tyuiu.HaevGS.Sprint6.Task3.V27.Lib;

namespace Tyuiu.HaevGS.Sprint6.Task3.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] inputMatrix = {
                {-17, -6, 10,  5,  3},
                {-10, -14, 10, -7, -3},
                {-19,   9,  8, -17, -9},
                {-19,  -5, -9, -18,  14},
                { 17,  12, 11,  12,   2}
            };

            int[,] expectedMatrix = {
                {-17, -6, 10,  5,  3},
                {  0,   0,  0, -7, -3},
                {-19,   9,  8, -17, -9},
                {-19,  -5, -9, -18,  14},
                { 17,  12, 11,  12,   2}
            };

            var result = ds.Calculate(inputMatrix);
            Assert.IsTrue(AreMatricesEqual(expectedMatrix, result), "The matrices are not equal.");
        }

        private bool AreMatricesEqual(int[,] expected, int[,] actual)
        {
            if (expected.GetLength(0) != actual.GetLength(0) || expected.GetLength(1) != actual.GetLength(1))
                return false;

            for (int i = 0; i < expected.GetLength(0); i++)
            {
                for (int j = 0; j < expected.GetLength(1); j++)
                {
                    if (expected[i, j] != actual[i, j])
                        return false;
                }
            }

            return true;
        }
    }
}
