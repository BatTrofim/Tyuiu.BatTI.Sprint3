using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.BatTI.Sprint3.Task4.V19.Lib
{
    public class DataService : ISprint3Task4V19
    {
        public double Calculate(int startValue, int stopValue)
        {
            int x;
            double y = 1;
            for (x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                {
                    break;
                }
            }
            {
                y = y * (x * (Math.Pow(Math.Cos(x) + x, -1)) + 0.5);
            }
            return y;
        }
    }
}
