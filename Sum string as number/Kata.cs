using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public static class Kata
{
    public static string sumStrings(string a, string b)
    {
        var numberOne = stringToIntArray(a);
        var numberTwo = stringToIntArray(b);

        var resultAdder = new List<string>();
        var carryIn = 0;
        var index = 0;

        while (true)
        {
            if (numberOne.Length >= numberTwo.Length && numberOne.Length <= index)
            {
                resultAdder.Add($"{carryIn}");
                break;
            }
            else if (numberOne.Length <= numberTwo.Length && numberTwo.Length <= index)
            {
                resultAdder.Add($"{carryIn}");
                break;
            }

            if (numberOne.Length <= index && numberTwo.Length > index)
            {
                var result = numberTwo[index] + carryIn;
                resultAdder.Add($"{result % 10}");
                carryIn = (int) Math.Floor((double) (result / 10));
                index++;
                continue;
            }
            else if (numberOne.Length > index && numberTwo.Length <= index)
            {
                var result = numberOne[index] + carryIn;
                resultAdder.Add($"{result % 10}");
                carryIn = (int) Math.Floor((double) (result / 10));
                index++;
                continue;
            }

            var res = numberOne[index] + numberTwo[index] + carryIn;

            carryIn = (int) Math.Floor((double) (res / 10));
            resultAdder.Add($"{res % 10}");

            index++;
        }

        var finalString = new StringBuilder();
        for (int i = resultAdder.Count - 1; i >= 0; i--)
        {
            finalString.Append(resultAdder[i]);
        }

        if (finalString.ToString() == "" || Count(finalString.ToString(), '0') == finalString.Length) {
            return "0";
        }

        while (finalString[0] == '0')
        {
            finalString.Remove(0, 1);
        }

        return finalString.ToString();
    }

    private static int[] stringToIntArray(string a)
    {
        var list = new List<int>();
        for (int i = a.Length - 1; i >= 0; i--)
        {
            list.Add((int)char.GetNumericValue(a[i]));
        }

        return list.ToArray();
    }

    private static int Count(string a, char c)
    {
        int count = 0;
        for (int i = 0; i < a.Length; i++)
        {
            if(c == a[i]) count++;
        }

        return count;
    }
}