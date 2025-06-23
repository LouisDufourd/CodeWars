using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

public class PowerSumDig
{
    public static long PowerSumDigTerm(int n)
    {
        List<long> longs = new();

        for (long i = 11; n > longs.Count; i++)
        {
            var power = getPower(i, Sum(i));
            var roundPower = Math.Round(power);
            var difference = Math.Abs(power - roundPower);

            if(power % 1 == 0 || difference <= 0.0000001)
            {
                longs.Add(i);
            }
        }

        return longs[n - 1];
    }

    public static int Sum(long i)
    {
        string number = $"{i}";
        int sum = 0;

        foreach (var digit in number)
        {
            sum += (int) char.GetNumericValue(digit);
        }

        return sum;
    }

    public static double getPower(double number, double sum) {
        if (sum == 1) return 1.1;
        return Math.Log(number) / Math.Log(sum);
    }
}
