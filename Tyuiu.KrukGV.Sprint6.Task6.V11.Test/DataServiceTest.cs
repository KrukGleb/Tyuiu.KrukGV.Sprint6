using Tyuiu.KrukGV.Sprint6.Task6.V11.Lib;

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
            string path = Path.Combine(Dir, "InPutDataFileTask6V11.txt");

            string res = ds.CollectTextFromFile(path);
            string ans = "btwMCZUcB\nPADUsjhlu\nJmjQKHd\nTMRyztkPxzEVkcarVMlQ\nEUWCvEgL";

            Assert.AreEqual(ans, res);
        }
    }
}
