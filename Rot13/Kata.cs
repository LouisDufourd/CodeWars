using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Kata
{
    public static string Rot13(string message)
    {
        var builder = new StringBuilder(message);

        for (int i = 0; i < builder.Length; i++)
        {
            if (builder[i] == 'z') builder[i] = 'm';
            else if (builder[i] == 'y') builder[i] = 'l';
            else if (builder[i] == 'x') builder[i] = 'k';
            else if (builder[i] == 'w') builder[i] = 'j';
            else if (builder[i] == 'v') builder[i] = 'i';
            else if (builder[i] == 'u') builder[i] = 'h';
            else if (builder[i] == 't') builder[i] = 'g';
            else if (builder[i] == 's') builder[i] = 'f';
            else if (builder[i] == 'r') builder[i] = 'e';
            else if (builder[i] == 'q') builder[i] = 'd';
            else if (builder[i] == 'p') builder[i] = 'c';
            else if (builder[i] == 'o') builder[i] = 'b';
            else if (builder[i] == 'n') builder[i] = 'a';
            else if (builder[i] == 'Z') builder[i] = 'M';
            else if (builder[i] == 'Y') builder[i] = 'L';
            else if (builder[i] == 'X') builder[i] = 'K';
            else if (builder[i] == 'W') builder[i] = 'J';
            else if (builder[i] == 'V') builder[i] = 'I';
            else if (builder[i] == 'U') builder[i] = 'H';
            else if (builder[i] == 'T') builder[i] = 'G';
            else if (builder[i] == 'S') builder[i] = 'F';
            else if (builder[i] == 'R') builder[i] = 'E';
            else if (builder[i] == 'Q') builder[i] = 'D';
            else if (builder[i] == 'P') builder[i] = 'C';
            else if (builder[i] == 'O') builder[i] = 'B';
            else if (builder[i] == 'N') builder[i] = 'A';
            else if ((builder[i] >= 'a' && builder[i] <= 'n') || (builder[i] >= 'A' && builder[i] <= 'M')) builder[i] += (char)13;
        }

        return builder.ToString();

    }
}
