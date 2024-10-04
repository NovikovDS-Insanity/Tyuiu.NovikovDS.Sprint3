using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.NovikovDS.Sprint3.Task0.V3.Lib
{
    public class DataService : ISprint3Task0V3
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double S = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                S += Math.Sin(i) * Math.Pow(0.5, 2);
            }
            return Math.Round(S, 3);
        }
    }

}
