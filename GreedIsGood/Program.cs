using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreedIsGood
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dices = { 1, 1, 1, 1, 2 };
            Console.WriteLine(Kata.Score(dices));
        }
    }
}
