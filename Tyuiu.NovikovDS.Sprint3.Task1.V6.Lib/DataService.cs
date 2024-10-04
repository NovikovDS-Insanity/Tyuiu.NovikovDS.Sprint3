using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.NovikovDS.Sprint3.Task1.V6.Lib
{
    public class DataService : ISprint3Task1V6
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double S = 0;
            int i = startValue - 1;
            while (i != stopValue)
            {
                S += (Math.Pow(value, i) + 1) * Math.Sin(i);
                i++;
            }
            return Math.Round(S, 3);
        }
    }

}
