using Tyuiu.HaevGS.Sprint6.Task5.V12.Lib;

namespace Tyuiu.HaevGS.Sprint6.Task5.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string filePath = @"C:\\Users\\ananas\\source\\repos\\tyuiu.cources.programming.files-main\\Sprint6Task5\\InPutDataFileTask5V25.txt";

            var res = ds.LoadFromDataFile(filePath);
            int wait = 3;
            Assert.Equals(wait, res);
        }
    }
}
