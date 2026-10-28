using tyuiu.cources.programming.interfaces.Sprint6;


namespace Tyuiu.KrukGV.Sprint6.Task4.V26.Lib
{
    public class DataService : ISprint6Task4V26
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = Math.Abs(stopValue - startValue) + 1;
            double[] res = new double[len];

            for (int i = 0; i < len; i++)
            {
                var x = i + startValue;
                if (3 * x + 1.2 == 0)
                    res[i] = 0;
                else
                {
                    res[i] = 5-3*x + (1+Math.Sin(x)) / (2 * x - 0.5);
                    res[i] = Math.Round(res[i], 2);
                }
            }

            return res;
        }
    }
}
