using tyuiu.cources.programming.interfaces.Sprint1;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Tyuiu.ChashchinaSA.Sprint1.Task4.V10.Lib
{
    public class DataService : ISprint1Task4V10
    {
        public double Calculate(double a)
        {
            var res = (1 + Math.Cos(a)) / Math.Pow(Math.Sin(a), 2);
            double result = Math.Round(res, 3);
            return result;
        }
    }
}
