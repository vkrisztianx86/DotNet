using System;

namespace A_very_big_sum
{
    internal class Program
    {
        private static long sum;

        static void Main(string[] args)
        {

            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT.NET"), true);

            int arCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<long> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt64(arTemp)).ToList();

            long result = aVeryBigSum(ar);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();


        }

        public static long aVeryBigSum(List<long> ar)
        {
            long sum = 0; // Initialize sum within the function scope
            foreach (long num in ar)
            {
                sum += num;
            }
            return sum; // Return the calculated sum

        }
    }
}
