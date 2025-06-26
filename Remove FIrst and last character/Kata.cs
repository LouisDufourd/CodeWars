using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Kata
{
    public static string Remove_char(string s)
    {
        string res = s.Remove(0, 1);
        res = res.Remove(res.Length - 1, 1);
        return res;
    }
}
