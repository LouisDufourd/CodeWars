using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class Kata
{
    public static string getIssuer(long number)
    {
        string num = $"{number}";

        Console.WriteLine(num.Length);

        if (num.StartsWith("4") && (num.Length == 13 || num.Length == 16)) return "VISA";
        else if (num.StartsWith("6011") && num.Length == 16) return "Discover";
        else if ((num.StartsWith("34") || num.StartsWith("37")) && num.Length == 15) return "AMEX";
        else if (
            (num.StartsWith("51") ||
            num.StartsWith("52") ||
            num.StartsWith("53") ||
            num.StartsWith("54") ||
            num.StartsWith("55")) && num.Length == 16) return "Mastercard";
        else
        {
            Console.WriteLine(num);
            return "Unknown";
        }
    }
}
