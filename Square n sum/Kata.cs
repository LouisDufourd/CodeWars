using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class Kata
{
    private static char[] chars = { 'a', 'e', 'i', 'o', 'u' };
    public static int SquareSum(int[] numbers) => (int) numbers.Sum(x => Math.Pow(x, 2));
}