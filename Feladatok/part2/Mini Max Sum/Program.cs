using System.ComponentModel;

namespace Mini_Max_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            miniMaxSum(arr);
        }
        public static void miniMaxSum(List<int> arr)
        {
            int counter = arr.Count;
            if (counter >= 1 && counter <= Math.Pow(10, 9))
            {
                long sum = 0;
                int min = int.MaxValue;
                int max = int.MinValue;

                foreach (int num in arr)
                {
                    sum += num;
                    min = Math.Min(min, num);
                    max = Math.Max(max, num);
                }

                Console.WriteLine($"{sum - max} {sum - min}");
            }
            
        }
    }
}
