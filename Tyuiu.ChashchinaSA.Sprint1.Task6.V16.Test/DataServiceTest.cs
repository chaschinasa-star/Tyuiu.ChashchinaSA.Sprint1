using Tyuiu.ChashchinaSA.Sprint1.Task6.V16.Lib;
namespace Tyuiu.ChashchinaSA.Sprint1.Task6.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestClass]
        public class DataServiceTests
        {
            [TestMethod]
            public void ValidString()
            {
                string strTest = "1 ! 2 ? 3";
                DataService ds = new DataService();

                bool res = ds.CheckSpecSymbols(strTest);

                Assert.IsTrue(res);
            }

            [TestMethod]
            public void ValidOnlyExclamation()
            {
                string strTest = "Только восклицание!";
                DataService ds = new DataService();

                bool res = ds.CheckSpecSymbols(strTest);

                Assert.IsFalse(res);
            }

            [TestMethod]
            public void ValidOnlyQuestion()
            {
                string strTest = "Только вопрос?";
                DataService ds = new DataService();

                bool res = ds.CheckSpecSymbols(strTest);

                Assert.IsFalse(res);
            }

            [TestMethod]
            public void ValidNoSymbols()
            {
                string strTest = "Простой текст без знаков";
                DataService ds = new DataService();

                bool res = ds.CheckSpecSymbols(strTest);

                Assert.IsFalse(res);
            }
        }
    }
}
