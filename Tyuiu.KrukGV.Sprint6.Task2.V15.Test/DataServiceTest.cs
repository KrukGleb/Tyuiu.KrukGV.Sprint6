
using Tyuiu.KrukGV.Sprint6.Task2.V15.Lib;

namespace Tyuiu.KrukGV.Sprint6.Task2.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            double[] res = ds.GetMassFunction(-5, 5);
            double[] ans = { 70.14, 55.21, 41.05, 27.96, 15.48, 1, -13.06, -28.16, -42.96, -56.77, -69.83 };

            CollectionAssert.AreEqual(ans, res);
        }
    }
}
