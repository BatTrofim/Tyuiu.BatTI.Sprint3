using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.BatTI.Sprint3.Task3.V30.Lib
{
    public class DataService : ISprint3Task3V30
    {
        public int GetMaxCharCount(string value, char item)
        {
            int count = 0;
            int max_count = 999;
            foreach(char chr in value)
            {
                if (chr == item)
                {
                    count++;
                }
                if (chr != item)
                {
                    max_count = count;
                    count = 0;
                }
            }
            return max_count;
        }
    }
}
