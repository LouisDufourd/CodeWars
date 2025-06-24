using System.Text.RegularExpressions;
using System;

public class Kata
{
    public static bool Alphanumeric(string str)
    {
        var matches = new Regex("^[a-zA-Z0-9]+$").Matches(str);

        return matches.Count == 1;
    }
}
