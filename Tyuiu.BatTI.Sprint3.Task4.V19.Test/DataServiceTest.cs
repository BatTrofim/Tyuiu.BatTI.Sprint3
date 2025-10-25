using Tyuiu.BatTI.Sprint3.Task4.V19.Lib;
    
namespace Tyuiu.BatTI.Sprint3.Task4.V19.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void DataServiceTest()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double res = ds.Calculate(startValue, stopValue);
            double wait = 9.432;

            Assert.AreEqual(wait, res);
        }
    }
}
