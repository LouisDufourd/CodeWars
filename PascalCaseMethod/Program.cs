using Kata;
using static System.Net.Mime.MediaTypeNames;

namespace PascalCaseMethod
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Problem.CamelCase(" camel case word"));
        }
    }
}