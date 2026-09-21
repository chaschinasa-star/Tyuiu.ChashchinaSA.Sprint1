using Tyuiu.ChashchinaSA.Sprint1.Task5.V5.Lib;
namespace Tyuiu.ChashchinaSA.Sprint1.Task5.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double x = 32.597;
            DataService ds = new DataService();
            double res = ds.Calculate(x);
            int wait = 5;
            Assert.AreEqual(wait, res);
        }
    }
}
