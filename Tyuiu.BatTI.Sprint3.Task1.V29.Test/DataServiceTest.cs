using Tyuiu.BatTI.Sprint3.Task1.V29.Lib;

namespace Tyuiu.BatTI.Sprint3.Task1.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            double value = 1;
            int startValue = 1;
            int stopValue = 2;

            double wait = 12;
            double res = ds.GetMultiplySeries(value, startValue, stopValue);

            Assert.AreEqual(wait, res);
        }
    }
}
