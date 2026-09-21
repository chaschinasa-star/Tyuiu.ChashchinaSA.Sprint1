using System.Globalization;
using Tyuiu.ChashchinaSA.Sprint1.Task6.V16.Lib;
namespace Tyuiu.ChashchinaSA.Sprint1.Task6.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Чащина С. А. | АСОиУб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Работа со строками класс String                                   *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнила: Чащина Софья Алексеевна | АСОиУб-26-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу: пользователь вводит текст.                          *");
            Console.WriteLine("* Проверить, что в строке есть восклицание (!) и вопрос (?).              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите текст для проверки: ");
            string strTest = Console.ReadLine();
            bool res = ds.CheckSpecSymbols(strTest);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"{res}");
            
            if (res)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Проверка успешна: в тексте найдены и '!', и '?'.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Проверка провалена: отсутствует знак '!' или '?' (или оба).");
            }
            Console.ResetColor();

            Console.ReadLine();
        }
    }
}
