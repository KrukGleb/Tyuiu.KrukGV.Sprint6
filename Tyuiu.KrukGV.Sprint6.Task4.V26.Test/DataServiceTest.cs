using Tyuiu.KrukGV.Sprint6.Task4.V26.Lib;

namespace Tyuiu.KrukGV.Sprint6.Task4.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            double[] res = ds.GetMassFunction(-5, 5);
            double[] ans = { 19.81, 16.79, 13.87, 10.98, 7.94, 3, 3.23, -0.45, -3.79, -6.97, -10 };

            CollectionAssert.AreEqual(ans, res);
        }
    }
}
