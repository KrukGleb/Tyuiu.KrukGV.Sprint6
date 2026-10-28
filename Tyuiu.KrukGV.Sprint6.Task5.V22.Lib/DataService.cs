using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint6;


namespace Tyuiu.KrukGV.Sprint6.Task5.V22.Lib
{
    public class DataService : ISprint6Task5V22
    {

        public double[] LoadFromDataFile(string path)
        {

            string text = File.ReadAllText(path);
            text = text.Replace(",", ".");
            string[] parts = text.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            double[] result = parts
                .Select(p => double.Parse(p, CultureInfo.InvariantCulture))
                .Where(num => num > 5)
                .Select(num => Math.Round(num, 3))
                .ToArray();

            return result;
        }
    }
}
