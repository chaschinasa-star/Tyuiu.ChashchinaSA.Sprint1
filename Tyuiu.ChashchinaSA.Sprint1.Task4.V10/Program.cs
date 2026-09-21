using System.Globalization;
using Tyuiu.ChashchinaSA.Sprint1.Task4.V10.Lib;
namespace Tyuiu.ChashchinaSA.Sprint1.Task4.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Чащина С. А. | АСОиУб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Class Math                                                        *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнила: Чащина Софья Алексеевна | АСОиУб-26-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* вычисляет результат по формуле и печатает его на экране                 *");
            Console.WriteLine("* ФОРМУЛА:                                                                *");
            Console.WriteLine("* 1 + cosa                                                                *");
            Console.WriteLine("* --------                                                                *");
            Console.WriteLine("*  sina^2                                                                 *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("***************************************************************************");

            double x;
            IFormatProvider formatter = new NumberFormatInfo { NumberDecimalSeparator = "." };
            Console.WriteLine("Введите значение в радианах: ");
            string input = Console.ReadLine();
            input = input.Replace(',', '.');
            x = double.Parse(input, formatter);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("(1 + cosa) / sina ^ 2 = " + ds.Calculate(x));

            Console.ReadLine();
        }
    }
}
