using System.Collections.Generic;
using System;

public class WeightSort
{

    public static string orderWeight(string strng)
    {
        List<string> inputs = [.. strng.Split(' ')];
        try
        {
            inputs.Sort((a, b) =>
            {
                if (Sum(a) > Sum(b))
                {
                    return 1;
                }
                else if (Sum(a) < Sum(b))
                {
                    return -1;
                }

                if (a.Length > b.Length)
                {
                    for (int i = 0; i < b.Length; i++)
                    {
                        if (compareNumericChar(a[i], b[i]) != 0) return compareNumericChar(a[i], b[i]);
                    }
                    return 1;
                }
                else if (a.Length < b.Length)
                {
                    for (int i = 0; i < a.Length; i++)
                    {
                        if (compareNumericChar(a[i], b[i]) != 0) return compareNumericChar(a[i], b[i]);
                    }
                    return -1;
                }
                else
                {
                    for (int i = 0; i < b.Length; i++)
                    {
                        if (compareNumericChar(a[i], b[i]) != 0) return compareNumericChar(a[i], b[i]);
                    }
                    return 0;
                }
            });
        }
        catch (Exception e)
        {
            throw new Exception(strng);
        }

        return string.Join(' ', inputs);
    }

    public static int Sum(string number)
    {
        int sum = 0;
        foreach (var digit in number)
        {
            sum += (int)char.GetNumericValue(digit);
        }

        return sum;
    }

    public static int compareNumericChar(char a, char b)
    {
        int firstNumber = (int)char.GetNumericValue(a);
        int secondNumber = (int)char.GetNumericValue(b);

        if (firstNumber > secondNumber) return 1;
        else if (firstNumber < secondNumber) return -1;
        else return 0;
    }
}