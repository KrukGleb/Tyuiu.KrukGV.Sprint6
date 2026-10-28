using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KrukGV.Sprint6.Task3.V19.Lib
{
    public class DataService : ISprint6Task3V19
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rowsCount = matrix.GetLength(0);
            int colsCount = matrix.GetLength(1);
            int[] row = new int[rowsCount];

            for (int i = 0; i < rowsCount; i++)
                row[i] = matrix[i, colsCount-1];

            Array.Sort(row);

            for (int i = 0; i < rowsCount; i++)
                matrix[i, colsCount - 1] = row[i];

            return matrix;
        }
    }
}
