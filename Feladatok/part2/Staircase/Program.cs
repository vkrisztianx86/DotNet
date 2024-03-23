namespace Staircase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

           staircase(n);
        }

        public static void staircase(int n)
        {
            if (n > 0 && n <= 100)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int k = n - 1; i < k; k--)
                    {
                        Console.Write(' ');
                    }
                    for (int k = 0; k < i + 1; k++)
                    {
                        Console.Write('*');
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Anyád!");
            }
                
            
        }
    }
}
