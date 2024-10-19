using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.NovikovDS.Sprint3.Task7.V13.Lib
{
    public class DataService : ISprint3Task7V13
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int count = 0;
            for (int i = startValue; i <= stopValue; i++) count++;

            double[] mass = new double[count];
            int k = 0;

            for (int i = startValue; i <= stopValue; i++)
            {
                if (Math.Cos(i) + 1 == 0) 
                { 
                    mass[k] = 0; 
                    continue;
                } 
                
                mass[k] = Math.Round((3 * i + 2 - ((2 * i - i) / (Math.Cos(i) + 1))), 2); 
                k++;
            }
            return mass;
        }
    }
}
