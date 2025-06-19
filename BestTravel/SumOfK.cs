using System;
using System.Collections.Generic;
public static class SumOfK
{
    /*
     * t => maxDistance
     * k => max number of town
     * ls => list of town and the distance
     */
    public static int? chooseBestSum(int t, int k, List<int> ls)
    {
        ls.Sort();

        var res = MaxSubarraySum(ls, k);

        int maxSum = 0;

        foreach (var item in res)
        {
            if(item.Count == t) {
                int currentSum = item.Sum();
                if (currentSum > maxSum) 
                {
                    maxSum = currentSum;
                }
            }
        }

        return maxSum;
    }

    public static List<List<int>> MaxSubarraySum(List<int> arr, int max)
    {
        List<List<int>> res = new();

        int startIndex = 0;

        int sum = 0;

        for (int i = startIndex; i < arr.Count; i++)
        {
            sum += arr[i];
            
            if(sum > max) {
                sum = 0;
                res.Add(arr.Slice(startIndex, i));
                startIndex = i;
            }
        }

        return res;
    }
}