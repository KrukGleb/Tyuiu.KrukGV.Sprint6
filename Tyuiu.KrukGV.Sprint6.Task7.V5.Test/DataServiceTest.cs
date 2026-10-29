using Tyuiu.KrukGV.Sprint6.Task7.V5.Lib;

namespace Tyuiu.KrukGV.Sprint6.Task7.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestGetMatrix()
        {
            string path = Path.Combine(Path.GetTempPath(), "InPutFileTask7V5_test.csv");
            File.WriteAllText(path, "5;3;-1\r\n0;7;1\r\n9;2;2\r\n4;4;10\r\n");

            DataService ds = new DataService();
            int[,] res = ds.GetMatrix(path);

            int[,] wait = new int[,]
            {
                { 5, 3, 2 },
                { 0, 7, 2 },
                { 9, 2, 2 },
                { 4, 4, 10 }
            };

            CollectionAssert.AreEqual(wait, res);
            File.Delete(path);
        }

        [TestMethod]
        public void TestOtherColumnsNotChanged()
        {
            string path = Path.Combine(Path.GetTempPath(), "InPutFileTask7V5_test2.csv");
            File.WriteAllText(path, "-5;-3;1\r\n1;0;3\r\n");

            DataService ds = new DataService();
            int[,] res = ds.GetMatrix(path);

            int[,] wait = new int[,]
            {
                { -5, -3, 2 },
                { 1, 0, 3 }
            };

            CollectionAssert.AreEqual(wait, res);
            File.Delete(path);
        }
    }
}
