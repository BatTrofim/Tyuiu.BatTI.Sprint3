using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.BatTI.Sprint3.Task6.V21.Lib
{
    public class DataService : ISprint3Task6V21
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            startValue = 19;
            stopValue = 30;
            int count = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count = count + j;
                    }
                }
            }
            return count;
        }
    }
}
