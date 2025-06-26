using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class Kata
{
    public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
    {
        if(iterable.Count() < 1) return new List<T>();
        T previous = iterable.ElementAt(0);
        List<T> result = new List<T>();

        for (int i = 1; i < iterable.Count(); i++)
        {
            var element = iterable.ElementAt(i);
            if (!previous.Equals(element))
            {
                result.Add(previous);
                previous = element;
            }
        }

        result.Add(previous);

        //your code here...
        return result;
    }
}
