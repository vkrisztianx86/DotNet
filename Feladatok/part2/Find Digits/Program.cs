 static int findDigits(int n)
{
    string strn = n.ToString();
    int count = 0;
    for (int i = 0; i < strn.Length; i++)
    {
        int x = int.Parse(strn[i].ToString());              
        if (x != 0 && n % x == 0)
        {
            count++;
        }
    }
    return count;

}
int n = 27;
Console.WriteLine(findDigits(n));
