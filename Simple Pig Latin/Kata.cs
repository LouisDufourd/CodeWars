using System;
using System.Text.RegularExpressions;

public class Kata
{

    public static Regex regex = new Regex("\\p{P}");

    public static string PigIt(string str)
    {
        var inputs = str.Split(' ');

        try
        {
            for (int i = 0; i < inputs.Length; i++)
            {
                var item = inputs[i];
                if (regex.Match($"{item[item.Length - 1]}").Success) continue;
                var character = item[0];
                item = item[1..];
                inputs[i] = item + character + "ay";
            }
        } catch (Exception e)
        {
            throw new Exception(str);
        }

        return String.Join(' ', inputs);
    }
}