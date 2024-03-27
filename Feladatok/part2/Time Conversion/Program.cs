namespace Time_Conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            //string s = Console.ReadLine();
            string s = "12:01:00AM";
            string result = timeConversion(s);

            Console.WriteLine(result);      
        }

        public static string timeConversion(string s)
        {          
            DateTime parsedTime = DateTime.ParseExact(s, "hh:mm:sstt", null);
            return parsedTime.ToString("HH:mm:ss");
            
        }
    }
}
