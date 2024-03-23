namespace Kihívás_1._nap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year = 2024;
            int month = 2;
            int day = 19;
            int age = 37;

            static int Challenge1(int year, int month, int day, int age)
            {
                int result = (year + month + day) % age;
                return result;
            }

            Console.WriteLine(Challenge1(year, month, day, age));
        }
    }
}
