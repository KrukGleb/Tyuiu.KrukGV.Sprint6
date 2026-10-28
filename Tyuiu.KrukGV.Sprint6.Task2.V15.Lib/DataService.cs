using tyuiu.cources.programming.interfaces.Sprint6;


namespace Tyuiu.KrukGV.Sprint6.Task0.V24.Lib
{
    public class DataService : ISprint6Task0V24
    {
        public double Calculate(int x)
        {
            return Math.Round(Math.Pow(x - 1, 3 * x + 1), 3);
        }
    }
}
