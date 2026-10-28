using Tyuiu.KrukGV.Sprint6.Task5.V22.Lib;

namespace Tyuiu.KrukGV.Sprint6.Task5.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string Dir = "C:\\DataSprint6";
            string path = Path.Combine(Dir, "InPutDataFileTask5V22.txt");

            double[] res = ds.LoadFromDataFile(path);
            double[] wait = { 12, 12.89, 35, 13.83, 12.76, 8.86 }; 

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
