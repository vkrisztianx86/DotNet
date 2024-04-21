namespace StatStrHlp
{
    public static class StrHelper
    {
        public static string Hullamos(string s)
        {
            string eredmeny = string.Empty;
            for (int i = 0; i < s.Length; i++)
            {
                if (i%2==0)
                {
                    eredmeny += s[i];
                }
                else
                {
                    eredmeny += char.ToUpper(s[i]);
                }
            }
            return eredmeny;
        }
    }
}
