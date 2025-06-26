using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Kata
{
    public static bool BetterThanAverage(int[] ClassPoints, int YourPoints) => (ClassPoints.Sum() + YourPoints) / (ClassPoints.Length + 1) < YourPoints;
}
