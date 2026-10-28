
using Tyuiu.KrukGV.Sprint6.Task0.V24.Lib;

namespace Tyuiu.KrukGV.Sprint6.Task0.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            double x = 3;
            double res = ds.Calculate(3);
            double ans = 1024;
            Assert.AreEqual(ans, res);
        }
    }
}
