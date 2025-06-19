using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static IEnumerable<string> OpenOrSenior(int[][] data)
    {
        List<string> category = new();
        foreach(var member in data) category.Add(member[0] >= 55 && member[1] > 7 ? "Senior" : "Open");
        return category;
    }
}