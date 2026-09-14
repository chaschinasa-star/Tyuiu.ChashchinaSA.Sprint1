using Tyuiu.ChashchinaSA.Sprint1.Task1.V2.Lib;
namespace Tyuiu.ChashchinaSA.Sprint1.Task1.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 5.0;
            double y = 2.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(1, res);
        }
    }
}
