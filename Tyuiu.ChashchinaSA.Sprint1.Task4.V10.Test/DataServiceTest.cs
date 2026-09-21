using Tyuiu.ChashchinaSA.Sprint1.Task4.V10.Lib;
namespace Tyuiu.ChashchinaSA.Sprint1.Task4.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 1.047;
            double wait = 2.001;
            var res = ds.Calculate(a);
            Assert.AreEqual(wait, res);
        }
    }
}
