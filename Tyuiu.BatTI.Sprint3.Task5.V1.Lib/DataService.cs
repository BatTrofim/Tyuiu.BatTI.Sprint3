using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.BatTI.Sprint3.Task5.V1.Lib
{
    public class DataService : ISprint3Task5V1
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            x = 5;
            double y = 0;
            for (int i = startValue1; i <= stopValue1; i++)
            {
                for (int k = startValue2; k <= stopValue2; k++)
                {
                    y = y + (1 * (Math.Pow((Math.Cos(k) + x), -1)));
                }
            }
            return Math.Round(y, 3);
        }
    }
}
