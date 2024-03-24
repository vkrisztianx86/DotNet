namespace Birthday_Cake_Candles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            int candlesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();

            int result = birthdayCakeCandles(candles);

            Console.WriteLine(result);

            
        }
        public static int birthdayCakeCandles(List<int> candles)
        {
            int count = 0;
            int max = int.MinValue;
            foreach (int num in candles)
            {
                if (num > max)
                {
                    max = num;
                    count = 1; // Reset count for a new max height
                }
                else if (num == max)
                {
                    count++; // Increment count if current candle has the same height as max
                }
            }
            return count;
        }


    }
}





