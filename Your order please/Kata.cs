using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class Kata
{
    public static string Order(string words)
    {
        string[] wordList = words.Split(' ');
        string[] correctOrder = new string[wordList.Length];
        
        for (int i = 0; i < wordList.Length; i++)
        {
            foreach(var character in wordList[i])
            {
                if(char.IsDigit(character)) correctOrder[(int) char.GetNumericValue(character)] = wordList[i];
            }
        }

        return string.Join(" ", correctOrder);
    }
}
