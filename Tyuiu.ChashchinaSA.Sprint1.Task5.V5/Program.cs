using System.Globalization;
using Tyuiu.ChashchinaSA.Sprint1.Task5.V5.Lib;
namespace Tyuiu.ChashchinaSA.Sprint1.Task5.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Чащина С. А. | АСОиУб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Преобразование типов и класс Convert                              *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнила: Чащина Софья Алексеевна | АСОиУб-26-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая решает следующую задачу:                    *");
            Console.WriteLine("* Присвоить целой переменной d первую цифру из дробной части              *");
            Console.WriteLine("* положительного вещественного числа x.                                   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("***************************************************************************");

            double x;

            IFormatProvider formatter = new NumberFormatInfo { NumberDecimalSeparator = "." };
            Console.WriteLine("Введите число x: ");
            string input = Console.ReadLine();
            input = input.Replace(',', '.');
            x = double.Parse(input, formatter);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int result = ds.Calculate(x);
            if (result == -1)
            {
                Console.WriteLine("Ошибка: Число должно быть положительным.");
            }
            else
            {
                Console.WriteLine($"Первая цифра дробной части: {result}");
            }

            Console.ReadLine();
        }
    }
}
