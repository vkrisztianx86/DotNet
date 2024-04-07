namespace Pangrams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(pangrams(Console.ReadLine()));
        }

        public static String pangrams(String s)
        {         
                // Convert input string to lowercase
                s = s.ToLower();

                // Create a set to store remaining letters
                var remainingLetters = new HashSet<char>("abcdefghijklmnopqrstuvwxyz");

                foreach (char c in s)
                {
                    if (char.IsLetter(c))
                    {
                        remainingLetters.Remove(c);
                    }
                }

                // If the set is empty, it's a pangram
                if (remainingLetters.Count == 0)
                {
                    return "pangram";
                }
                else
                {
                    return "not pangram";
                }
            

        }

    }

}
