using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.NovikovDS.Sprint3.Task5.V13.Lib
{
    public class DataService : ISprint3Task5V13
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double sum = 0;
            for (int i = startValue1; i <= stopValue1; i++)
            {
                for (int j = startValue2; j < stopValue2; j++)
                {
                    sum += Math.Cos(x) + (j / 2);
                }
            }
            return Math.Round(sum, 3);
        }
    }

}
