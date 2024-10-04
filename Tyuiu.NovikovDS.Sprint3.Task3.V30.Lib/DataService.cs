using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.NovikovDS.Sprint3.Task3.V30.Lib
{
    public class DataService : ISprint3Task3V30
    {
        public int GetMaxCharCount(string value, char item)
        {
            int max = 0, temp = 0;
            foreach (char chr in value)
            {
                if (chr == item)
                {
                    temp++;
                    if (temp > max) max = temp;
                } else temp = 0;
            }
            return max;
        }
    }

}
