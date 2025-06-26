using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Kata
{
    public static string AbbrevName(string name)
    {
        var spaces = name.Split(' ');
        var res = "";
        foreach (var s in spaces)
        {
            res += char.ToUpper(s[0]) + ".";
        }

        res = res.Remove(res.Length - 1);
        return res;
    }
}