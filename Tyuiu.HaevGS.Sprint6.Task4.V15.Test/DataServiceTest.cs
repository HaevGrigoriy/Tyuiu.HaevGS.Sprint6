using Tyuiu.HaevGS.Sprint6.Task4.V15.Lib;

namespace Tyuiu.HaevGS.Sprint6.Task4.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            var results = ds.GetMassFunction(startValue, stopValue);

            Assert.AreEqual(11, results.Length);
            Assert.AreEqual(15.19, results[0]);
        }
    }
}
