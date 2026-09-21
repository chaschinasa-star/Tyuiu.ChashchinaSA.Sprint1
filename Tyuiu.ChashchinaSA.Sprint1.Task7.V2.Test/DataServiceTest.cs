using Tyuiu.ChashchinaSA.Sprint1.Task7.V2.Lib;
namespace Tyuiu.ChashchinaSA.Sprint1.Task7.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.5;
            double y = 3;
            double wait = -0.494;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
