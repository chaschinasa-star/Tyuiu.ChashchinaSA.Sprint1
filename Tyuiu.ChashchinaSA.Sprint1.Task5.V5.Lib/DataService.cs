using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.ChashchinaSA.Sprint1.Task5.V5.Lib
{
    public class DataService : ISprint1Task5V5
    {
        public int Calculate(double x)
        {
            if (x < 0)
            {
                return -1;
            }
            double a = Math.Truncate(x);
            double d = Math.Truncate((x - a) * 10);
            return Convert.ToInt32(d);
        }
    }
}
