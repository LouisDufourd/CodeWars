using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class TimeFormat
{
    public static string GetReadableTime(int seconds)
    {
        int s = seconds % 60;
        seconds /= 60;
        int m = seconds % 60;
        seconds /= seconds / 60;
        int h = seconds % 100;

        return $"{h:D2}:{m:D2}:{s:D2}";
    }
}
