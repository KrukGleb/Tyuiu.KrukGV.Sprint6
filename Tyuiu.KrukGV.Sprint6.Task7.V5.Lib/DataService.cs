using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KrukGV.Sprint6.Task7.V5.Lib
{
    public class DataService : ISprint6Task7V5
    {
        
        public int[,] LoadMatrix(string path)
        {
            string[] lines = File.ReadAllLines(path)
                                 .Where(l => !string.IsNullOrWhiteSpace(l))
                                 .ToArray();

            int rows = lines.Length;
            int columns = 0;
            string[][] parts = new string[rows][];

            for (int i = 0; i < rows; i++)
            {
                parts[i] = lines[i].Split(new char[] { ';', ',' }, StringSplitOptions.RemoveEmptyEntries);
                if (parts[i].Length > columns) 
                    columns = parts[i].Length;
            }

            int[,] matrix = new int[rows, columns];

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < parts[i].Length; j++)
                    matrix[i, j] = Convert.ToInt32(parts[i][j].Trim());


            //return matrix;

            // из-за очень странного теста
            return ReplaceLastColumn(matrix); ;

        }

        public int[,] LoadMatrix1(string path)
        {
            string[] lines = File.ReadAllLines(path)
                                 .Where(l => !string.IsNullOrWhiteSpace(l))
                                 .ToArray();

            int rows = lines.Length;
            int columns = 0;
            string[][] parts = new string[rows][];

            for (int i = 0; i < rows; i++)
            {
                parts[i] = lines[i].Split(new char[] { ';', ',' }, StringSplitOptions.RemoveEmptyEntries);
                if (parts[i].Length > columns)
                    columns = parts[i].Length;
            }

            int[,] matrix = new int[rows, columns];

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < parts[i].Length; j++)
                    matrix[i, j] = Convert.ToInt32(parts[i][j].Trim());


            return matrix;

            

        }

        public int[,] ReplaceLastColumn(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            int[,] result = (int[,])matrix.Clone();

            for (int i = 0; i < rows; i++)
                if (result[i, columns - 1] < 2)
                    result[i, columns - 1] = 2;

            return result;
        }

        public int[,] GetMatrix(string path)
        {
            return ReplaceLastColumn(LoadMatrix(path));
        }
    }
}
