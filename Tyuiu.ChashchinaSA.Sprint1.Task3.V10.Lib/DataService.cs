using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.ChashchinaSA.Sprint1.Task3.V10.Lib
{
    public class DataService : ISprint1Task3V10
    {
        public string NumberToMoney(double number)
        {
            double rounded = Math.Round (number, 3);
            long rubles = (long)Math.Truncate(rounded);
            double fractionalPart = Math.Abs(rounded - rubles);
            int kopecks = (int)Math.Round(fractionalPart * 100);
            if (kopecks == 100)
            {
                rubles += (rounded >= 0) ? 1 : -1;
                kopecks = 0;
            }
            string originalNumberStr = number.ToString().Replace(',', '.');

            return $"{originalNumberStr} руб. - это {rubles} руб. {kopecks} коп.";

        }
    }
}
