using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.BatTI.Sprint3.Task2.V23.Lib
{
    public class DataService : ISprint3Task2V23
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sum = 0;
            do
            {
                sum = sum + ((Math.Pow(value, startValue) + 0.25) * Math.Sin(startValue));
                startValue++;
            } while (startValue <= stopValue);
            return Math.Round(sum, 3);
        }
    }
}
