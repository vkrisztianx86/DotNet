using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank
{
    class Result
    {

        /*
         * Complete the 'plusMinus' function below.
         *
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        public static void plusMinus(List<int> arr)
        {
            double pos = 0.0;
            double neg = 0.0;
            double zero = 0.0;
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] > 0)
                {
                    pos++;
                }
                else if (arr[i] < 0)
                {
                    neg++;
                }
                else
                {
                    zero++;
                }
            }
            pos = pos/arr.Count;
            neg = neg/arr.Count;
            zero = zero/arr.Count;
            Console.WriteLine($"{pos:F6} {neg} {zero}");
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            Result.plusMinus(arr);
        }
    }
}
