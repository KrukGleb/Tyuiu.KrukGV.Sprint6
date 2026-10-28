using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint6;


namespace Tyuiu.KrukGV.Sprint6.Task6.V11.Lib
{
    public class DataService : ISprint6Task6V11
    {
        public string CollectTextFromFile(string path)
        {
            string text = File.ReadAllText(path);
            string[] lines = File.ReadAllLines(path);
            string result = "";

            foreach (string line in lines)
            {
                string[] words = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (words.Length >= 2)
                {
                    string secondToLast = words[words.Length - 2];
                    result += secondToLast + Environment.NewLine;
                }
            }

            result = result.Trim();

            return result;
        }
        
    }
}
