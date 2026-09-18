using System.Data;
using Tyuiu.ChashchinaSA.Sprint1.Task3.V10.Lib;
namespace Tyuiu.ChashchinaSA.Sprint1.Task3.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 23.6;
            var res = ds.NumberToMoney(x);
            Assert.AreEqual("23.6 руб. — это 23 руб. 60 коп.", res);
        }
    }
}
