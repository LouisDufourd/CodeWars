using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Text.Json.Serialization;
using System.Text.Json;

public class StripCommentsSolution
{
    public static string StripComments(string text, string[] commentSymbols)
    {
        string res = "";
        List<string> symbols = [.. commentSymbols];
        bool isInComment = false;

        try
        {
            foreach (var character in text)
            {
                if (character == '\n')
                {
                    if (res != "" && res[res.Length - 1] == ' ') res = res.Remove(res.Length - 1);
                    isInComment = false;
                }
                if (symbols.Contains($"{character}"))
                {
                    if (res[res.Length - 1] == ' ') res = res.Remove(res.Length - 1);
                    isInComment = true;
                }
                if (!isInComment) res += character;
            }
            while (res[res.Length - 1] == ' ') res = res.Remove(res.Length - 1);
        } catch (Exception e)
        {
            Console.WriteLine(text.Replace("\n", "\\n"));
            Console.WriteLine(JsonSerializer.Serialize(commentSymbols));
            Console.Error.WriteLine(e.StackTrace);
        }

        return res;
    }
}
