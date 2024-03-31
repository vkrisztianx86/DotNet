
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Result
{
    public static List<int> serviceLane(int n, List<List<int>> cases, List<int> width)
    {
        List<int> maxWidths = new List<int>();

        foreach (var segment in cases)
        {
            int start = segment[0];
            int end = segment[1];

            // Find the minimum width within the segment
            int minWidth = width.GetRange(start, end - start + 1).Min();
            maxWidths.Add(minWidth);
        }

        return maxWidths;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);
        int t = Convert.ToInt32(firstMultipleInput[1]);

        List<int> width = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(widthTemp => Convert.ToInt32(widthTemp)).ToList();

        List<List<int>> cases = new List<List<int>>();

        for (int i = 0; i < t; i++)
        {
            cases.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(casesTemp => Convert.ToInt32(casesTemp)).ToList());
        }

        List<int> result = Result.serviceLane(n, cases, width);

        Console.WriteLine(String.Join("\n", result));
    }
}
