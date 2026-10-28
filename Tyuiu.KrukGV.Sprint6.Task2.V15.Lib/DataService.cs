using tyuiu.cources.programming.interfaces.Sprint6;


namespace Tyuiu.KrukGV.Sprint6.Task2.V15.Lib
{
    public class DataService : ISprint6Task2V15
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
                    res[i] = 2*Math.Sin(x)/ (3 * x + 1.2) + Math.Cos(x) - 14*x;
                    res[i] = Math.Round(res[i], 2);
                }


            }

            return res;
        }
    }
}
