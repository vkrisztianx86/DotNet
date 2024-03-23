using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    public static List<int> compareTriplets(List<int> a, List<int> b)
    {
        int aa = 0;
        int bb = 0;
        List<int> res = new List<int>();
        for (int i = 0; i < a.Count; i++)
        {
            if (a[i] > b[i])
            {
                aa = aa + 1;
                //res.Add(aa);

            }
            if (a[i] < b[i])
            {
                bb = bb + 1;
                //res.Add(bb);

            }
            if (a[i] == b[i])
            {
                continue;
            }
        }
        res.Add(aa);
        res.Add(bb);
        return res;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter("OUTPUT.NET", true);
            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            List<int> result = Result.compareTriplets(a, b);

            textWriter.WriteLine(String.Join(" ", result));

            textWriter.Flush();
            textWriter.Close();                          
    }
}

