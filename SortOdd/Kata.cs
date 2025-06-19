using System;
using System.Collections.Generic;

public class Kata
{
    public static int[] SortArray(int[] array)
    {
        Dictionary<int, int> odds = new();
        List<int> evens = new();
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0) odds[i] = array[i];
            if (array[i] % 2 == 1) evens.Add(array[i]);
        }

        evens.Sort();

        foreach(var keyValuePair in odds) 
        {
            evens.Insert(keyValuePair.Key, keyValuePair.Value);
        }

        return evens.ToArray();
    }
}