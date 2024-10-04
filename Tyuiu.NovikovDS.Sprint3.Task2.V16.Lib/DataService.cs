using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.NovikovDS.Sprint3.Task2.V16.Lib
{
    public class DataService : ISprint3Task2V16
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double S = 1;
            int i = startValue;
            do
            {
                S *= Math.Pow((1 / Math.Pow(i, value)), -1);
                i++;
            } while (i != (stopValue + 1));
            return Math.Round(S, 3);
        }
    }

}
