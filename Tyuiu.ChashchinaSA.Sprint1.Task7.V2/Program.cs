using System.Globalization;
using Tyuiu.ChashchinaSA.Sprint1.Task7.V2.Lib;
namespace Tyuiu.ChashchinaSA.Sprint1.Task7.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Чащина С. А. | АСОиУб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнила: Чащина Софья Алексеевна | АСОиУб-26-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение          *");
            Console.WriteLine("* по исходным значениям данных, вводимых пользователем. Ответ округлить   *");
            Console.WriteLine("* до 3 знаков после запятой.                                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("* Математическое выражение:                                               *");
            Console.WriteLine("*     sinX + cosY                                                         *");
            Console.WriteLine("* Z = ----------- tgXY                                                    *");
            Console.WriteLine("*     cosX - sinY                                                         *");
            Console.WriteLine("***************************************************************************");

            double x, y;
            Console.WriteLine("Введите значение X:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение Y:");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate(x, y));
            Console.ReadKey();
        }
    }
}
