using System;
using System.Collections.Generic;

public class SumDigPower
{

    public static long[] SumDigPow(long a, long b)
    {
        List<long> longs = new();
        for (long i = a; i < b; i++)
        {
            string str = $"{i}";
            long sum = 0;
            for (int j = 0; j < str.Length; j++)
            {
                sum += (long) Math.Pow(long.Parse($"{str[j]}"), j + 1);
            }

            if(sum == i) 
            {
                longs.Add(i);
            }
        }

        return longs.ToArray();
    }
}