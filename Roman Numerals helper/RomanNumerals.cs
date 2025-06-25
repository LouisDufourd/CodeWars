using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

public class RomanNumerals
{
    public static string ToRoman(int n)
    {
        var result = "";
        try
        {
            var longArray = intToLongArray(n);
            for (int i = 0; i < longArray.Length; i++)
            {
                result += intToRomanChar((int)longArray[i]);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(n);
            Console.Error.WriteLine(e.StackTrace);
        }

        return result;
    }

    public static int FromRoman(string romanNumeral)
    {
        var res = 0;
        try
        {
            for (int i = 0; i < romanNumeral.Length; i++)
            {
                var romanChar = romanNumeral[i];

                if (i == romanNumeral.Length - 1)
                    res += romanCharToInt(romanChar);

                else if (romanCharToInt(romanChar) < romanCharToInt(romanNumeral[i + 1]))
                    res -= romanCharToInt(romanChar);

                else
                    res += romanCharToInt(romanChar);
            }
        }
        catch (Exception e)
        {
            Console.Error.WriteLine(e.StackTrace);
        }
        
        return res;
    }

    private static long[] intToLongArray(int integer)
    {
        string str = integer.ToString();
        long[] longs = new long[str.Length];

        for (int i = longs.Length - 1; i >= 0; i--)
        {
            var power = Math.Pow(10, longs.Length - i - 1);
            var digit = char.GetNumericValue(str[i]);
            longs[i] = (long)Math.Round(digit * power);
        }

        return longs;
    }

    private static String intToRomanChar(int i)
    {
        switch(i)
        {
            case 4: return "IV";
            case 9: return "IX";
            case 40: return "XL";
            case 90: return "XC";
            case 400: return "CD";
            case 900: return "CM";
            default:
                if (i < 5) return new string('I', i);
                else if (i < 10) return "V" + new string('I', i - 5);
                else if (i < 50) return new string('X', i / 10);
                else if (i < 100) return "L" + new string('X', i / 10 - 5);
                else if (i < 500) return new string('C', i / 100);
                else if (i < 1000) return "D" + new string('C', i / 100 - 5);
                else return new string('M', i / 1000);
        }
    }

    private static int romanCharToInt(char c)
    {
        switch(c)
        {
            case 'I': return 1;
            case 'V': return 5;
            case 'X': return 10;
            case 'L': return 50;
            case 'C': return 100;
            case 'D': return 500;
            case 'M': return 1000;
            default: return 0;
        }
    }

}