using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.NovikovDS.Sprint3.Task6.V7.Lib
{
    public class DataService : ISprint3Task6V7
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int sum = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                if (i < 0)
                {
                    for (int j = -1; j >= i; j--)
                    {
                        if (i % j == 0) sum -= j;
                    }
                }
                else
                {
                    for (int j = 1; j <= i; j++)
                    {
                        if (i % j == 0) sum += j;
                    }
                }
            }
            return sum;
        }
    }

}
