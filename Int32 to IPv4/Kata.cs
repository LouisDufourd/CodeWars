using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

public class Kata
{
    public static string UInt32ToIP(uint ip)
    {
        string binary = Convert.ToString(ip, 2).ToString();
        while (binary.Length < 32) binary = "0" + binary;

        var output = binary.SplitInParts(8);

        Console.WriteLine(output.Count());

        string result = "";

        for (int i = 0; i < output.Count(); i++)
        {
            result += Convert.ToString(Convert.ToInt32(output.ElementAt(i), 2), 10);
            if (i != output.Count() - 1) result += ".";
        }

        return result;
    }
}


static class StringExtensions
{

    public static IEnumerable<String> SplitInParts(this String s, Int32 partLength)
    {
        if (s == null)
            throw new ArgumentNullException(nameof(s));
        if (partLength <= 0)
            throw new ArgumentException("Part length has to be positive.", nameof(partLength));

        for (var i = 0; i < s.Length; i += partLength)
            yield return s.Substring(i, Math.Min(partLength, s.Length - i));
    }

}
