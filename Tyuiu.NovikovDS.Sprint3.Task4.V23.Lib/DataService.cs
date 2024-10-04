using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.NovikovDS.Sprint3.Task4.V23.Lib
{
    public class DataService : ISprint3Task4V23
    {
        public double Calculate(int startValue, int stopValue)
        {
            int x;
            double mult = 1;

            for (x = startValue; x <= stopValue; x++)
            {
                if (x == 0) break;
                mult *= (Math.Cos(x) / x) + 3;
            }
            return Math.Round(mult, 3);
        }
    }

}
