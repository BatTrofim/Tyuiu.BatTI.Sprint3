using Tyuiu.BatTI.Sprint3.Task2.V23.Lib;

namespace Tyuiu.BatTI.Sprint3.Task2.V23.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            double value = 1;
            int startValue = 1;
            int stopValue = 2;

            double wait = 2.188;
            double res = ds.GetSumSeries(value, startValue, stopValue);

            Assert.AreEqual(wait, res);
        }
    }
}
