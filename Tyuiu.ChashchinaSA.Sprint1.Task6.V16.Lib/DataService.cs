using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.ChashchinaSA.Sprint1.Task6.V16.Lib
{
    public class DataService : ISprint1Task6V16
    {
        public bool CheckSpecSymbols(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return false;
            }

            bool hasExclamation = value.Contains("!");
            bool hasQuestion = value.Contains("?");

            return hasExclamation && hasQuestion;
        }
    }
}
